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
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
            ShowAgents();
        }
        void ShowAgents()
        {
            listViewEmployees.Items.Clear();
            foreach (Employees employees in Program.TrappaDB.Employees)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        employees.Id.ToString(), employees.Name, employees.Surname,
                        employees.Patronymic, employees.Position
                    });
                item.Tag = employees;
                listViewEmployees.Items.Add(item);
            }
            //listViewEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void buttonAdd_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Name = textBoxName.Text;
            employees.Surname = textBoxPatronymic.Text;
            employees.Patronymic = textBoxSurname.Text;
            employees.Position = textBoxPosition.Text;
            Program.TrappaDB.Employees.Add(employees);
            Program.TrappaDB.SaveChanges();
            ShowAgents();
        }
        void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count == 1)
            {

                Employees employees = listViewEmployees.SelectedItems[0].Tag as Employees;
                employees.Name = textBoxName.Text;
                employees.Surname = textBoxPatronymic.Text;
                employees.Patronymic = textBoxSurname.Text;
                employees.Position = textBoxPosition.Text;
                Program.TrappaDB.SaveChanges();
                ShowAgents();
            }
        }
        void listViewAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count == 1)
            {
                Employees employees = listViewEmployees.SelectedItems[0].Tag as Employees;
                employees.Name = textBoxName.Text;
                employees.Surname = textBoxPatronymic.Text;
                employees.Patronymic = textBoxSurname.Text;
                employees.Position = textBoxPosition.Text;
            }
            else
            {
                textBoxName.Text = "";
                textBoxPatronymic.Text = "";
                textBoxSurname.Text = "";
                textBoxPosition.Text = "";
            }
        }
        void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEmployees.SelectedItems.Count == 1)
                {
                    Employees employees = listViewEmployees.SelectedItems[0].Tag as Employees;
                    Program.TrappaDB.Employees.Remove(employees);
                    Program.TrappaDB.SaveChanges();
                    ShowAgents();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
