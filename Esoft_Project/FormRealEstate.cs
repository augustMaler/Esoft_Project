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
    public partial class FormRealEstate : Form
    {
        public FormRealEstate()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowRealEstatesSet();
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                //изменение видимости нужной таблицы
                listViewApartament.Visible = true;
                listViewHouse.Visible = false;
                listViewLand.Visible = false;

                //Изменение видимости текстовых полей и их описания
                labelAddress_City.Visible = true;
                textBoxAdress_City.Visible = true;

                labelAdress_Street.Visible = true;
                textBoxAddress_Street.Visible = true;

                labelHouse.Visible = true;
                textBoxAddress_House.Visible = true;

                labelAddress_Number.Visible = true;
                textBoxAddress_Number.Visible = true;

                labelRooms.Visible = true;
                textBoxRooms.Visible = true;

                labelFloors_Number.Visible = true;
                textBoxFloors_Number.Visible = true;

                labelFloor.Visible = true;
                textBoxFloor.Visible = true;
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                //изменение видимости нужной таблицы
                listViewApartament.Visible = false;
                listViewHouse.Visible = true;
                listViewLand.Visible = false;

                //Изменение видимости текстовых полей и их описания
                labelAddress_City.Visible = true;
                textBoxAdress_City.Visible = true;

                labelAdress_Street.Visible = true;
                textBoxAddress_Street.Visible = true;

                labelHouse.Visible = true;
                textBoxAddress_House.Visible = true;

                labelAddress_Number.Visible = false;
                textBoxAddress_Number.Visible = false;

                labelRooms.Visible = true;
                textBoxRooms.Visible = true;

                labelFloors_Number.Visible = true;
                textBoxFloors_Number.Visible = true;

                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                //изменение видимости нужной таблицы
                listViewApartament.Visible = false;
                listViewHouse.Visible = false;
                listViewLand.Visible = true;

                //Изменение видимости текстовых полей и их описания
                labelAddress_City.Visible = true;
                textBoxAdress_City.Visible = true;

                labelAdress_Street.Visible = true;
                textBoxAddress_Street.Visible = true;

                labelHouse.Visible = false;
                textBoxAddress_House.Visible = false;

                labelAddress_Number.Visible = false;
                textBoxAddress_Number.Visible = false;

                labelRooms.Visible = false;
                textBoxRooms.Visible = false;

                labelFloors_Number.Visible = false;
                textBoxFloors_Number.Visible = false;

                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
            }

        }
        void ShowRealEstatesSet()
        {
            listViewApartament.Items.Clear();
            listViewHouse.Items.Clear();
            listViewLand.Items.Clear();
            foreach (RealEstateSet realEstateSet in Program.wftDb.RealEstateSet)
            {
                if (realEstateSet.Type == 0)
                {

                    ListViewItem item = new ListViewItem(new string[]{
                realEstateSet.Adress_City, realEstateSet.Adress_Street, realEstateSet.Adress_House,
                realEstateSet.Adress_Number, realEstateSet.Coordinate_latitude.ToString(), realEstateSet.Coordinate_longitude.ToString(),
                realEstateSet.TotalArea.ToString(), realEstateSet.Rooms.ToString(), realEstateSet.TotalFloors.ToString(),
                realEstateSet.Floor.ToString()
                });
                    item.Tag = realEstateSet;
                    listViewApartament.Items.Add(item);
                }
                else if (realEstateSet.Type == 1)
                {

                    ListViewItem item = new ListViewItem(new string[]{
                realEstateSet.Adress_City, realEstateSet.Adress_Street, realEstateSet.Adress_House,
                realEstateSet.Coordinate_latitude.ToString(), realEstateSet.Coordinate_longitude.ToString(),
                realEstateSet.TotalArea.ToString(), realEstateSet.Rooms.ToString(), realEstateSet.TotalFloors.ToString()
                });
                    item.Tag = realEstateSet;
                    listViewHouse.Items.Add(item);
                }
                else
                {

                    ListViewItem item = new ListViewItem(new string[]{
                realEstateSet.Adress_City, realEstateSet.Adress_Street,
                realEstateSet.Coordinate_latitude.ToString(), realEstateSet.Coordinate_longitude.ToString(),
                realEstateSet.TotalArea.ToString()
                });
                    item.Tag = realEstateSet;
                    listViewLand.Items.Add(item);
                }
            }
            listViewApartament.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewLand.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void buttonAdd_Click(object sender, EventArgs e)
        {
            RealEstateSet realEstateSet = new RealEstateSet();
            realEstateSet.Type = comboBoxType.SelectedIndex;
            realEstateSet.Adress_City = textBoxAdress_City.Text;
            realEstateSet.Adress_Street = textBoxAddress_Street.Text;
            if (textBoxLongtitude.Text != "") { realEstateSet.Coordinate_longitude = Convert.ToDouble(textBoxLongtitude.Text); }
            if (textBoxLatitude.Text != "") { realEstateSet.Coordinate_latitude = Convert.ToDouble(textBoxLatitude.Text); }
            if (textBoxTotalArea.Text != "") { realEstateSet.TotalArea = Convert.ToDouble(textBoxTotalArea.Text); }
            if (comboBoxType.SelectedIndex == 0)
            {
                realEstateSet.Adress_House = textBoxAddress_House.Text;
                realEstateSet.Adress_Number = textBoxAddress_Number.Text;
                if (textBoxFloors_Number.Text != "") { realEstateSet.TotalFloors = Convert.ToInt32(textBoxFloors_Number.Text); }
                if (textBoxFloor.Text != "") { realEstateSet.Floor = Convert.ToInt32(textBoxFloor.Text); }
                if (textBoxRooms.Text != "") { realEstateSet.Rooms = Convert.ToInt32(textBoxRooms.Text); }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                realEstateSet.Adress_House = textBoxAddress_House.Text;
                realEstateSet.Adress_Number = textBoxAddress_Number.Text;
                if (textBoxRooms.Text != "") { realEstateSet.Rooms = Convert.ToInt32(textBoxRooms.Text); }
            }
            Program.wftDb.RealEstateSet.Add(realEstateSet);
            Program.wftDb.SaveChanges();
            ShowRealEstatesSet();
        }

        void textBoxFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 || number == 127)
            {
                e.Handled = true;

            }
        }

        void textBoxRooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 || number == 127)
            {
                e.Handled = true;

            }
        }

        void textBoxFloors_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 || number == 127)
            {
                e.Handled = true;

            }
        }

        void textBoxLongtitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничение на заполнение значений в долготу
            char number = e.KeyChar;
            if (textBoxLongtitude.Text == "")
            {
                if (!Char.IsDigit(number) && number != 8 || number == 127)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!textBoxLongtitude.Text.Contains(","))
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

        void textBoxTotalArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничение на заполнение значений в Площаде
            char number = e.KeyChar;
            if (textBoxTotalArea.Text == "")
            {
                if (!Char.IsDigit(number) && number != 8 || number == 127)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!textBoxTotalArea.Text.Contains(","))
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

        void textBoxLatitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничение на заполнение значений в широте
            char number = e.KeyChar;
            if (textBoxLatitude.Text == "")
            {
                if (!Char.IsDigit(number) && number != 8 || number == 127)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!textBoxLatitude.Text.Contains(","))
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

        void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                RealEstateSet realEstateSet = listViewApartament.SelectedItems[0].Tag as RealEstateSet;
                if (listViewApartament.SelectedItems.Count == 1)
                {
                    realEstateSet.Adress_City = textBoxAdress_City.Text;
                    realEstateSet.Adress_House = textBoxAddress_House.Text;
                    realEstateSet.Adress_Street = textBoxAddress_Street.Text;
                    realEstateSet.Adress_Number = textBoxAddress_Number.Text;
                    if (textBoxLongtitude.Text != "") { realEstateSet.Coordinate_longitude = Convert.ToDouble(textBoxLongtitude.Text); }
                    if (textBoxLatitude.Text != "") { realEstateSet.Coordinate_latitude = Convert.ToDouble(textBoxLatitude.Text); }
                    if (textBoxFloors_Number.Text != "") { realEstateSet.TotalFloors = Convert.ToInt32(textBoxFloors_Number.Text); }
                    if (textBoxFloor.Text != "") { realEstateSet.Floor = Convert.ToInt32(textBoxFloor.Text); }
                    if (textBoxRooms.Text != "") { realEstateSet.Rooms = Convert.ToInt32(textBoxRooms.Text); }
                    if (textBoxTotalArea.Text != "") { realEstateSet.TotalArea = Convert.ToDouble(textBoxTotalArea.Text); }
                    realEstateSet.Type = comboBoxType.SelectedIndex;
                    Program.wftDb.SaveChanges();
                    ShowRealEstatesSet();
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                RealEstateSet realEstateSet = listViewHouse.SelectedItems[0].Tag as RealEstateSet;
                if (listViewHouse.SelectedItems.Count == 1)
                {
                    realEstateSet.Adress_City = textBoxAdress_City.Text;
                    realEstateSet.Adress_House = textBoxAddress_House.Text;
                    realEstateSet.Adress_Street = textBoxAddress_Street.Text;
                    if (textBoxLongtitude.Text != "") { realEstateSet.Coordinate_longitude = Convert.ToDouble(textBoxLongtitude.Text); }
                    if (textBoxLatitude.Text != "") { realEstateSet.Coordinate_latitude = Convert.ToDouble(textBoxLatitude.Text); }
                    if (textBoxFloors_Number.Text != "") { realEstateSet.TotalFloors = Convert.ToInt32(textBoxFloors_Number.Text); }
                    if (textBoxRooms.Text != "") { realEstateSet.Rooms = Convert.ToInt32(textBoxRooms.Text); }
                    if (textBoxTotalArea.Text != "") { realEstateSet.TotalArea = Convert.ToDouble(textBoxTotalArea.Text); }
                    realEstateSet.Type = comboBoxType.SelectedIndex;
                    Program.wftDb.SaveChanges();
                    ShowRealEstatesSet();
                }
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                if (listViewLand.SelectedItems.Count == 1)
                {
                    RealEstateSet realEstateSet = listViewLand.SelectedItems[0].Tag as RealEstateSet;
                    realEstateSet.Adress_City = textBoxAdress_City.Text;
                    realEstateSet.Adress_Street = textBoxAddress_Street.Text;
                    if (textBoxLongtitude.Text != "") { realEstateSet.Coordinate_longitude = Convert.ToDouble(textBoxLongtitude.Text); }
                    if (textBoxLatitude.Text != "") { realEstateSet.Coordinate_latitude = Convert.ToDouble(textBoxLatitude.Text); }
                    if (textBoxTotalArea.Text != "") { realEstateSet.TotalArea = Convert.ToDouble(textBoxTotalArea.Text); }
                    realEstateSet.Type = comboBoxType.SelectedIndex;
                    Program.wftDb.SaveChanges();
                    ShowRealEstatesSet();
                }
            }
        }

        void listViewApartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApartament.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewApartament.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_House.Text = realEstate.Adress_House;
                textBoxAdress_City.Text = realEstate.Adress_City;
                textBoxAddress_Number.Text = realEstate.Adress_Number;
                textBoxAddress_Street.Text = realEstate.Adress_Street;
                textBoxFloor.Text = realEstate.Floor.ToString();
                textBoxFloors_Number.Text = realEstate.TotalFloors.ToString();
                textBoxLatitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxLongtitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxRooms.Text = realEstate.Rooms.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
            }
        }

        void listViewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHouse.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewHouse.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_House.Text = realEstate.Adress_House;
                textBoxAdress_City.Text = realEstate.Adress_City;
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxAddress_Street.Text = realEstate.Adress_Street;
                textBoxFloors_Number.Text = realEstate.TotalFloors.ToString();
                textBoxLatitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxLongtitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxRooms.Text = realEstate.Rooms.ToString();
                comboBoxType.Text = realEstate.Type.ToString();
            }
        }

        void listViewLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLand.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewLand.SelectedItems[0].Tag as RealEstateSet;
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxAdress_City.Text = realEstate.Adress_City;
                textBoxAddress_Street.Text = realEstate.Adress_Street;
                textBoxLatitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxLongtitude.Text = realEstate.Coordinate_longitude.ToString();
            }
        }

        void buttonDel_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewApartament.SelectedItems.Count == 1)
                {
                    RealEstateSet realEstateSet = listViewApartament.SelectedItems[0].Tag as RealEstateSet;
                    Program.wftDb.RealEstateSet.Remove(realEstateSet);
                    Program.wftDb.SaveChanges();
                    ShowRealEstatesSet();
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewHouse.SelectedItems.Count == 1)
                {
                    RealEstateSet realEstateSet = listViewHouse.SelectedItems[0].Tag as RealEstateSet;
                    Program.wftDb.RealEstateSet.Remove(realEstateSet);
                    Program.wftDb.SaveChanges();
                    ShowRealEstatesSet();
                }
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                if (listViewLand.SelectedItems.Count == 1)
                {
                    RealEstateSet realEstateSet = listViewLand.SelectedItems[0].Tag as RealEstateSet;
                    Program.wftDb.RealEstateSet.Remove(realEstateSet);
                    Program.wftDb.SaveChanges();
                    ShowRealEstatesSet();
                }
            }
        }

        void ComboBoxPressFalse(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (num == e.KeyChar)
            {
                e.Handled = true;
            }
        }
    }
}
