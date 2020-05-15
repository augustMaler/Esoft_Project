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
    public partial class FormGoods : Form
    {
        public FormGoods()
        {
            InitializeComponent();
            ShowGoods();
        }
        void ShowGoods()
        {
            listViewGoods.Items.Clear();
            foreach (Goods goods in Program.TrappaDB.Goods)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        goods.Id.ToString(), goods.Name, goods.Type,
                        goods.VendorCode.ToString(), goods.Price.ToString()
                    });
                item.Tag = goods;
                listViewGoods.Items.Add(item);
            }
            listViewGoods.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void buttonAdd_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            goods.Name = textBoxName.Text;
            goods.Type = textBoxType.Text;
            goods.VendorCode = Convert.ToInt32(textBoxVendorCode.Text);
            goods.Price = Convert.ToInt32(textBoxPrice.Text);
            Program.TrappaDB.Goods.Add(goods);
            Program.TrappaDB.SaveChanges();
            ShowGoods();
        }

        void textBoxVendorCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 || number == 127)
            {
                e.Handled = true;

            }
        }

        void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 || number == 127)
            {
                e.Handled = true;

            }
        }
        void buttonEdit_Click(object sender, EventArgs e)
        {
            Goods goods = listViewGoods.SelectedItems[0].Tag as Goods;
            goods.Name = textBoxName.Text;
            goods.Type = textBoxType.Text;
            goods.VendorCode = Convert.ToInt32(textBoxVendorCode.Text);
            goods.Price = Convert.ToInt32(textBoxPrice.Text);
            Program.TrappaDB.Goods.Add(goods);
            Program.TrappaDB.SaveChanges();
            ShowGoods();
        }
        void buttonDel_Click(object sender, EventArgs e)
        {
            Goods goods = listViewGoods.SelectedItems[0].Tag as Goods;
            Program.TrappaDB.Goods.Remove(goods);
            Program.TrappaDB.SaveChanges();
            ShowGoods();
        }
    }
}
