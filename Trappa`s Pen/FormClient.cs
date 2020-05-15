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
    public partial class FormClient : Form
    {
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (Clients clients in Program.TrappaDB.Clients)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        clients.Id.ToString(), clients.Name, clients.Surname, clients.Patronymic,
                        clients.Phone, clients.Email
                    });
                item.Tag = clients;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        void buttonAdd_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.Name = textBoxName.Text;
            client.Surname = textBoxSurname.Text;
            client.Patronymic = textBoxPatronymic.Text;
            client.Phone = textBoxPhone.Text;
            client.Email = textBoxEmail.Text;
            Program.TrappaDB.Clients.Add(client);
            Program.TrappaDB.SaveChanges();
            ShowClient();
        }

        void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Clients client = listViewClient.SelectedItems[0].Tag as Clients;
                client.Name = textBoxName.Text;
                client.Surname = textBoxSurname.Text;
                client.Patronymic = textBoxPatronymic.Text;
                client.Phone = textBoxPhone.Text;
                client.Email = textBoxEmail.Text;
                Program.TrappaDB.SaveChanges();
                ShowClient();
            }
        }

        void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Clients client = listViewClient.SelectedItems[0].Tag as Clients;
                textBoxName.Text = client.Name;
                textBoxSurname.Text = client.Surname;
                textBoxPatronymic.Text = client.Patronymic;
                textBoxPhone.Text = client.Phone;
                textBoxEmail.Text = client.Email;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronymic.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }
        void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }

        void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    Clients client = listViewClient.SelectedItems[0].Tag as Clients;
                    Program.TrappaDB.Clients.Remove(client);
                    Program.TrappaDB.SaveChanges();
                    ShowClient();
                }
                else
                {
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxPatronymic.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEmail.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
