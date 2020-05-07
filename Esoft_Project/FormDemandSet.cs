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
    public partial class FormDemandSet : Form
    {
        public FormDemandSet()
        {
            InitializeComponent();
            comboBoxType.SelectedItem = "Квартира";
            ShowAgents();
            ShowClients();
            ShowListViewApartament();
            ShowListViewHouse();
            ShowListViewLand();
        }
        void ShowListViewApartament()
        {
            DemandSet demandSet1 = new DemandSet();
            listViewApartament.Items.Clear();
            foreach (DemandSet demandSet in Program.wftDb.DemandSet)
            {
                if (demandSet.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                demandSet.AgentsSet.LastName+" "+ demandSet.AgentsSet.FirstName[0]+". "+demandSet.AgentsSet.MiddleName[0]+".",
                demandSet.ClientsSet.LastName+" "+ demandSet.ClientsSet.FirstName[0]+". "+demandSet.ClientsSet.MiddleName[0]+".",
                "Квартира", demandSet.MinPrice.ToString(), demandSet.MaxPrice.ToString(), demandSet.MinArea.ToString(), demandSet.MaxArea.ToString(),
                demandSet.MinRooms.ToString(), demandSet.MaxRooms.ToString(), demandSet.MinFloors.ToString(), demandSet.MaxFloors.ToString(),
                demandSet.MinFloor.ToString(), demandSet.MaxFloor.ToString()
                });
                    item.Tag = demandSet;
                    listViewApartament.Items.Add(item);
                }
            }
        }
        void ShowListViewHouse()
        {
            listViewHouse.Items.Clear();
            foreach (DemandSet demandSet in Program.wftDb.DemandSet)
            {
                if (demandSet.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                demandSet.AgentsSet.LastName+" "+ demandSet.AgentsSet.FirstName[0]+". "+demandSet.AgentsSet.MiddleName[0]+".",
                demandSet.ClientsSet.LastName+" "+ demandSet.ClientsSet.FirstName[0]+". "+demandSet.ClientsSet.MiddleName[0]+".",
                "Дом", demandSet.MinPrice.ToString(), demandSet.MaxPrice.ToString(), demandSet.MinArea.ToString(), demandSet.MaxArea.ToString(),
                demandSet.MinRooms.ToString(), demandSet.MaxRooms.ToString(), demandSet.MinFloors.ToString(), demandSet.MaxFloors.ToString()
                });
                    item.Tag = demandSet;
                    listViewHouse.Items.Add(item);
                }
            }
        }
        void ShowListViewLand()
        {
            listViewLand.Items.Clear();
            foreach (DemandSet demandSet in Program.wftDb.DemandSet)
            {
                if (demandSet.Type == 2)
                {
                    ListViewItem item = new ListViewItem(new string[] {
                demandSet.AgentsSet.LastName+" "+ demandSet.AgentsSet.FirstName[0]+". "+demandSet.AgentsSet.MiddleName[0]+".",
                demandSet.ClientsSet.LastName+" "+ demandSet.ClientsSet.FirstName[0]+". "+demandSet.ClientsSet.MiddleName[0]+".",
                "Земля", demandSet.MinPrice.ToString(), demandSet.MaxPrice.ToString(), demandSet.MinArea.ToString(), demandSet.MaxArea.ToString()
                });
                    item.Tag = demandSet;
                    listViewLand.Items.Add(item);
                }
            }
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

        private void ComboBoxPressFalse(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (num == e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem.ToString() == "Квартира")
            {
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;

                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;

                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;

                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;

                labelMinFloor.Visible = true;
                textBoxMinFloor.Visible = true;

                labelMaxFloor.Visible = true;
                textBoxMaxFloor.Visible = true;

                listViewApartament.Visible = true;
                listViewHouse.Visible = false;
                listViewLand.Visible = false;
            }
            else if (comboBoxType.SelectedItem.ToString() == "Дом")
            {
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;

                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;

                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;

                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;

                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;

                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                listViewApartament.Visible = false;
                listViewHouse.Visible = true;
                listViewLand.Visible = false;
            }
            else if (comboBoxType.SelectedItem.ToString() == "Земля")
            {
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;

                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;

                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;

                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;

                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                listViewApartament.Visible = false;
                listViewHouse.Visible = false;
                listViewLand.Visible = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.Text != "" && comboBoxClients.Text != "")
            {
                DemandSet demandSet = new DemandSet();
                demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split(':')[0]);
                demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split(':')[0]);
                if (textBoxMinArea.Text != "") { demandSet.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                if (textBoxMaxArea.Text != "") { demandSet.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                if (textBoxMinPrice.Text != "") { demandSet.MinPrice = Convert.ToInt64(textBoxMinArea.Text); }
                if (textBoxMaxPrice.Text != "") { demandSet.MaxPrice = Convert.ToInt64(textBoxMaxArea.Text); }
                demandSet.Type = comboBoxType.SelectedIndex;
                if (comboBoxType.SelectedItem.ToString() == "Квартира")
                {
                    if (textBoxMinRooms.Text != "") { demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text); }
                    if (textBoxMaxRooms.Text != "") { demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text); }
                    if (textBoxMinFloors.Text != "") { demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text); }
                    if (textBoxMaxFloors.Text != "") { demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text); }
                    if (textBoxMinFloor.Text != "") { demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text); }
                    if (textBoxMaxFloor.Text != "") { demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text); }
                }
                else if (comboBoxType.SelectedItem.ToString() == "Дом")
                {
                    if (textBoxMinRooms.Text != "") { demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text); }
                    if (textBoxMaxRooms.Text != "") { demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text); }
                    if (textBoxMinFloors.Text != "") { demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text); }
                    if (textBoxMaxFloors.Text != "") { demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text); }
                }
                Program.wftDb.DemandSet.Add(demandSet);
                Program.wftDb.SaveChanges();
                ShowListViewLand();
                ShowListViewApartament();
                ShowListViewHouse();
            }
            else
            {
                MessageBox.Show("Не заполнены либо агенты либо клиенты!");
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem.ToString() == "Квартира")
            {
                if (listViewApartament.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = listViewApartament.SelectedItems[0].Tag as DemandSet;
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split(':')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split(':')[0]);
                    if (textBoxMinArea.Text != "") { demandSet.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                    if (textBoxMaxArea.Text != "") { demandSet.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                    if (textBoxMinPrice.Text != "") { demandSet.MinPrice = Convert.ToInt64(textBoxMinArea.Text); }
                    if (textBoxMaxPrice.Text != "") { demandSet.MaxPrice = Convert.ToInt64(textBoxMaxArea.Text); }
                    if (textBoxMinRooms.Text != "") { demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text); }
                    if (textBoxMaxRooms.Text != "") { demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text); }
                    if (textBoxMinFloors.Text != "") { demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text); }
                    if (textBoxMaxFloors.Text != "") { demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text); }
                    if (textBoxMinFloor.Text != "") { demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text); }
                    if (textBoxMaxFloor.Text != "") { demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text); }
                }
            }
            else if (comboBoxType.SelectedItem.ToString() == "Дом")
            {
                if (listViewHouse.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split(':')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split(':')[0]);
                    if (textBoxMinArea.Text != "") { demandSet.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                    if (textBoxMaxArea.Text != "") { demandSet.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                    if (textBoxMinPrice.Text != "") { demandSet.MinPrice = Convert.ToInt64(textBoxMinArea.Text); }
                    if (textBoxMaxPrice.Text != "") { demandSet.MaxPrice = Convert.ToInt64(textBoxMaxArea.Text); }
                    demandSet.Type = comboBoxType.SelectedIndex;
                    if (textBoxMinRooms.Text != "") { demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text); }
                    if (textBoxMaxRooms.Text != "") { demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text); }
                    if (textBoxMinFloors.Text != "") { demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text); }
                    if (textBoxMaxFloors.Text != "") { demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text); }
                }
            }
            else if (comboBoxType.SelectedItem.ToString() == "Земля")
            {
                if (listViewLand.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split(':')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split(':')[0]);
                    if (textBoxMinArea.Text != "") { demandSet.MinArea = Convert.ToDouble(textBoxMinArea.Text); }
                    if (textBoxMaxArea.Text != "") { demandSet.MaxArea = Convert.ToDouble(textBoxMaxArea.Text); }
                    if (textBoxMinPrice.Text != "") { demandSet.MinPrice = Convert.ToInt64(textBoxMinArea.Text); }
                    if (textBoxMaxPrice.Text != "") { demandSet.MaxPrice = Convert.ToInt64(textBoxMaxArea.Text); }
                }
            }
            Program.wftDb.SaveChanges();
            ShowListViewLand();
            ShowListViewApartament();
            ShowListViewHouse();
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem.ToString() == "Квартира")
            {
                if (listViewApartament.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = listViewApartament.SelectedItems[0].Tag as DemandSet;
                    Program.wftDb.DemandSet.Remove(demandSet);
                    Program.wftDb.SaveChanges();
                }
            }
            else if (comboBoxType.SelectedItem.ToString() == "Дом")
            {
                if (listViewHouse.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                    Program.wftDb.DemandSet.Remove(demandSet);
                    Program.wftDb.SaveChanges();
                }
            }
            else if (comboBoxType.SelectedItem.ToString() == "Земля")
            {
                if (listViewLand.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                    Program.wftDb.DemandSet.Remove(demandSet);
                    Program.wftDb.SaveChanges();
                }
            }
            ShowListViewLand();
            ShowListViewApartament();
            ShowListViewHouse();
        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }

        private void MinAreaFloatNumbers(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxMinArea.Text == "")
            {
                if (!Char.IsDigit(number) && number != 8 || number == 127)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!textBoxMinArea.Text.Contains(","))
                {
                    if (!Char.IsDigit(number) && number != 8 && number != 44 || number == 127)
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

        private void MaxAreaFloatNumbers(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (textBoxMaxArea.Text == "")
            {
                if (!Char.IsDigit(number) && number != 8 || number == 127)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!textBoxMaxArea.Text.Contains(","))
                {
                    if (!Char.IsDigit(number) && number != 8 && number != 44 || number == 127)
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

        private void listViewLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLand.SelectedItems.Count == 1)
            {
                DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demandSet.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(demandSet.IdClient.ToString());
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
            }
        }

        private void listViewApartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApartament.SelectedItems.Count == 1)
            {
                DemandSet demandSet = listViewApartament.SelectedItems[0].Tag as DemandSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demandSet.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(demandSet.IdClient.ToString());
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinFloors.Text = demandSet.MinFloors.ToString();
                textBoxMaxFloors.Text = demandSet.MaxFloors.ToString();
                textBoxMinFloor.Text = demandSet.MinFloor.ToString();
                textBoxMaxFloor.Text = demandSet.MaxFloor.ToString();
                textBoxMinRooms.Text = demandSet.MinRooms.ToString();
                textBoxMaxRooms.Text = demandSet.MaxRooms.ToString();
            }
        }

        private void listViewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHouse.SelectedItems.Count == 1)
            {
                DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demandSet.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(demandSet.IdClient.ToString());
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinFloors.Text = demandSet.MinFloors.ToString();
                textBoxMaxFloors.Text = demandSet.MaxFloors.ToString();
                textBoxMinRooms.Text = demandSet.MinRooms.ToString();
                textBoxMaxRooms.Text = demandSet.MaxRooms.ToString();
            }
        }
    }
}
