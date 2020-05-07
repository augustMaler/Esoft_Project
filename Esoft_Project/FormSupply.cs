using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }
        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet agentsSet in Program.wftDb.AgentsSet)
            {
                string[] item = { agentsSet.Id.ToString() + ":", agentsSet.LastName, agentsSet.FirstName[0] + ".", agentsSet.MiddleName[0] + "." };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ":", clientsSet.LastName, clientsSet.FirstName[0] + ".", clientsSet.MiddleName[0] + "." };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowRealEstate()
        {
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstate in Program.wftDb.RealEstateSet)
            {
                string[] item = { realEstate.Id.ToString() + ":", realEstate.Adress_City+",", realEstate.Adress_Street+",", "д. "+realEstate.Adress_House+",",
                "кв. "+realEstate.Adress_Number};
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSupplySet()
        {
            string type;
            listViewSupplySet.Items.Clear();
            foreach (SupplySet supply in Program.wftDb.SupplySet)
            {
                if (supply.RealEstateSet.Type == 0)
                { type = "Квартира"; }
                else if (supply.RealEstateSet.Type == 1)
                { type = "Дом"; }
                else { type = "Земля"; }
                if (supply.RealEstateSet.Adress_House != null && supply.RealEstateSet.Adress_Number != null)
                {
                    ListViewItem item = new ListViewItem(new string[]
                {
                        supply.AgentsSet.LastName.ToString() + " " + supply.AgentsSet.FirstName[0] + ". " + supply.AgentsSet.MiddleName[0] + ".",
                        supply.ClientsSet.LastName + " " + supply.ClientsSet.FirstName[0] + ". " + supply.ClientsSet.MiddleName[0] + ".",
                        type,
                    supply.RealEstateSet.Adress_City + " ул." + supply.RealEstateSet.Adress_Street + " " + supply.RealEstateSet.Adress_House + " кв. №" + supply.RealEstateSet.Adress_Number,
                        supply.Price.ToString()
                });
                    item.Tag = supply;
                    listViewSupplySet.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                  {
                        supply.AgentsSet.LastName.ToString() + " " + supply.AgentsSet.FirstName[0] + ". " + supply.AgentsSet.MiddleName[0] + ".",
                        supply.ClientsSet.LastName + " " + supply.ClientsSet.FirstName[0] + ". " + supply.ClientsSet.MiddleName[0] + ".",
                        type,
                      supply.RealEstateSet.Adress_City + " ул." + supply.RealEstateSet.Adress_Street,
                        supply.Price.ToString()
                  });
                    item.Tag = supply;
                    listViewSupplySet.Items.Add(item);
                }
            }
            listViewSupplySet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxRealEstate.SelectedItem != null && textBoxPrice.Text != "")
            {
                SupplySet supply = new SupplySet();
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split(':')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split(':')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split(':')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wftDb.SupplySet.Add(supply);
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }

        void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supply.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.IdRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }

        void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    Program.wftDb.SupplySet.Remove(supply);
                    Program.wftDb.SaveChanges();
                    ShowSupplySet();
                }
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split(':')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split(':')[0]); ;
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split(':')[0]);
                supply.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
        }
        void comboBoxKeyPressFalse(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (num == e.KeyChar)
            {
                e.Handled = true;
            }
        }
    }
}
