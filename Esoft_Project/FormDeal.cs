using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
            ShowSupply();
            ShowDemand();
            ShowDealSet();
        }
        void ShowSupply()
        {
            comboBoxSupply.Items.Clear();
            foreach (SupplySet supply in Program.wftDb.SupplySet)
            {
                string[] item = { supply.Id.ToString()+": ", "Риелтор: "+supply.AgentsSet.LastName+" "+supply.AgentsSet.FirstName[0]+". "+ supply.AgentsSet.MiddleName[0] + ".",
                " Клиент: "+supply.ClientsSet.LastName+" "+supply.ClientsSet.FirstName[0]+". "+ supply.ClientsSet.MiddleName[0] + "."};
                comboBoxSupply.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemand()
        {
            comboBoxDemand.Items.Clear();
            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                string[] item = { demand.Id.ToString()+": ", "Риелтор: "+demand.AgentsSet.LastName+" "+demand.AgentsSet.FirstName[0]+". "+ demand.AgentsSet.MiddleName[0] + ".",
                " Клиент: "+demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName[0]+". "+ demand.ClientsSet.MiddleName[0] + "."};
                comboBoxDemand.Items.Add(string.Join(" ", item));
            }
        }

        void comboBoxSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        void comboBoxDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }
        void Deductions()
        {
            if (comboBoxSupply.SelectedItem != null && comboBoxDemand.SelectedItem != null)
            {
                SupplySet supplySet = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split(':')[0]));
                DemandSet demandSet = Program.wftDb.DemandSet.Find(Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split(':')[0]));
                double customerCompanyDeductions = supplySet.Price * 0.03;
                textBoxCustomerDeductions.Text = customerCompanyDeductions.ToString("0.00");
                if (demandSet.AgentsSet.DealShare != 0)
                {
                    double agentCustomerDeductions = customerCompanyDeductions * Convert.ToDouble(demandSet.AgentsSet.DealShare) / 100;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
                else if (demandSet.AgentsSet.DealShare == 0)
                {
                    double agentCustomerDeductions = customerCompanyDeductions * 0.45;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxCustomerDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }
            if (comboBoxSupply.SelectedItem != null)
            {
                SupplySet supplySet = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split(':')[0]));
                double sellerCompanyDeductions;
                if (supplySet.RealEstateSet.Type == 0)
                {
                    sellerCompanyDeductions = 36000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else if (supplySet.RealEstateSet.Type == 1)
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.02;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                if (supplySet.AgentsSet.DealShare != 0)
                {
                    double agentSellerDeductions = sellerCompanyDeductions * Convert.ToDouble(supplySet.AgentsSet.DealShare) / 100;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
                else if (supplySet.AgentsSet.DealShare == 0)
                {
                    double agentSellerDeductions = sellerCompanyDeductions * 0.45;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxAgentCustomerDeductions.Text = "";
                textBoxAgentSellerDeductions.Text = "";
                textBoxCustomerDeductions.Text = "";
                textBoxSellerCompanyDeductions.Text = "";
            }
        }
        void ShowDealSet()
        {
            listViewDealSet.Items.Clear();
            foreach (DealSet deal in Program.wftDb.DealSet)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    deal.SupplySet.ClientsSet.LastName + " "+  deal.SupplySet.ClientsSet.FirstName[0]+". "+ deal.SupplySet.ClientsSet.MiddleName[0]+".",
                    deal.SupplySet.AgentsSet.LastName + " "+  deal.SupplySet.AgentsSet.FirstName[0]+". "+ deal.SupplySet.AgentsSet.MiddleName[0]+".",
                    deal.DemandSet.ClientsSet.LastName + " "+  deal.DemandSet.ClientsSet.FirstName[0]+". "+ deal.DemandSet.ClientsSet.MiddleName[0]+".",
                    deal.DemandSet.AgentsSet.LastName + " "+  deal.DemandSet.AgentsSet.FirstName[0]+". "+ deal.DemandSet.AgentsSet.MiddleName[0]+".",
                    "г "+deal.SupplySet.RealEstateSet.Adress_City+", ул. "+deal.SupplySet.RealEstateSet.Adress_Street+", д. "+deal.SupplySet.RealEstateSet.Adress_House+" кв. "+deal.SupplySet.RealEstateSet.Adress_Number,
                    deal.SupplySet.Price.ToString()
                    });
                item.Tag = deal;
                listViewDealSet.Items.Add(item);
            }
            listViewDealSet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void comboBoxPressFalse(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (num == e.KeyChar)
            {
                e.Handled = true;
            }
        }

        void onlyNumberSellerClient(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxSellerCompanyDeductions.Text == "")
            {
                if (!Char.IsDigit(number) && number != 8 || number == 127)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!textBoxSellerCompanyDeductions.Text.Contains("."))
                {
                    if (!Char.IsDigit(number) && number != 8 && number != 46 || number == 127)
                    {
                        e.Handled = true;

                    }
                }
                else
                {
                    if (!Char.IsDigit(number) && number != 8 || number == 127)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void onlyNumberAgentSellerClient(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxAgentSellerDeductions.Text == "")
            {
                if (!Char.IsDigit(number) && number != 8 || number == 127)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!textBoxAgentSellerDeductions.Text.Contains("."))
                {
                    if (!Char.IsDigit(number) && number != 8 && number != 46 || number == 127)
                    {
                        e.Handled = true;

                    }
                }
                else
                {
                    if (!Char.IsDigit(number) && number != 8 || number == 127)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void onlyNumberClientBuyer(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxCustomerDeductions.Text == "")
            {
                if (!Char.IsDigit(number) && number != 8 || number == 127)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!textBoxCustomerDeductions.Text.Contains("."))
                {
                    if (!Char.IsDigit(number) && number != 8 && number != 46 || number == 127)
                    {
                        e.Handled = true;

                    }
                }
                else
                {
                    if (!Char.IsDigit(number) && number != 8 || number == 127)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void onlyBuyerAgentClientBuyer(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxAgentCustomerDeductions.Text == "")
            {
                if (!Char.IsDigit(number) && number != 8 || number == 127)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!textBoxAgentCustomerDeductions.Text.Contains("."))
                {
                    if (!Char.IsDigit(number) && number != 8 && number != 46 || number == 127)
                    {
                        e.Handled = true;

                    }
                }
                else
                {
                    if (!Char.IsDigit(number) && number != 8 || number == 127)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDemand.SelectedItem != null && comboBoxSupply.SelectedItem != null)
            {
                DealSet deal = new DealSet();
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split(':')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split(':')[0]);
                Program.wftDb.DealSet.Add(deal);
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split(':')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split(':')[0]);
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
            else
            {
                comboBoxDemand.Text = null;
                comboBoxSupply.Text = null;
            }
        }

        void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDealSet.SelectedItems.Count == 1)
                {
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split(':')[0]);
                    deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split(':')[0]);
                    Program.wftDb.DealSet.Remove(deal);
                    Program.wftDb.SaveChanges();
                    ShowDealSet();
                }
                else
                {
                    comboBoxDemand.Text = null;
                    comboBoxSupply.Text = null;
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void listViewDealSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                comboBoxSupply.SelectedItem = deal.SupplySet.Id + ":  Риелтор: " + deal.SupplySet.AgentsSet.LastName + " " + deal.SupplySet.AgentsSet.FirstName[0] + ". " + deal.SupplySet.AgentsSet.MiddleName[0] + ". " + " Клиент: " +
                     deal.SupplySet.ClientsSet.LastName + " " + deal.SupplySet.ClientsSet.FirstName[0] + ". " + deal.SupplySet.ClientsSet.MiddleName[0] + ".";

                comboBoxDemand.SelectedItem = deal.DemandSet.Id + ":  Риелтор: " + deal.DemandSet.AgentsSet.LastName + " " + deal.DemandSet.AgentsSet.FirstName[0] + ". " + deal.DemandSet.AgentsSet.MiddleName[0] + ". " + " Клиент: " +
                     deal.DemandSet.ClientsSet.LastName + " " + deal.DemandSet.ClientsSet.FirstName[0] + ". " + deal.DemandSet.ClientsSet.MiddleName[0] + ".";
            }
            Deductions();
        }
    }
}
