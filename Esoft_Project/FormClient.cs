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
            //очистка listView
            listViewClient.Items.Clear();
            //проход о коллекции клиентов, в базе данных
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        clientsSet.Id.ToString(), clientsSet.FirstName, clientsSet.LastName,
                        clientsSet.MiddleName, clientsSet.Phone, clientsSet.Email
                    });
                item.Tag = clientsSet;
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
            //обЪект таблицы
            ClientsSet clientSet = new ClientsSet();
            //ссылки на объект
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.Phone = textBoxPhone.Text;
            //Нахождение подстроки в почте
            if (textBoxEmail.Text.Contains("@") == true && textBoxEmail.Text.Contains(".") == true)
            {
                clientSet.Email = textBoxEmail.Text;
            }
            else
            {
                textBoxEmail.Text = "Вы не правильно указали почту";
            }
            //Добавляем нового клиента в таблицу клиентов
            Program.wftDb.ClientsSet.Add(clientSet);
            //Сохраняем измаенения в модели
            Program.wftDb.SaveChanges();
            ShowClient();
        }

        void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                //ищем элемент по тегу
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                //указыываеам изменения
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmail.Text;
                //Сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
                //Отображаем в listView
                ShowClient();
            }
        }

        void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmail.Text = clientSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
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
                    ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    Program.wftDb.ClientsSet.Remove(clientSet);
                    Program.wftDb.SaveChanges();
                    ShowClient();
                }
                else
                {
                    textBoxFirstName.Text = "";
                    textBoxMiddleName.Text = "";
                    textBoxLastName.Text = "";
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
