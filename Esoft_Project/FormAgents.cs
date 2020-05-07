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
    public partial class FormAgents : Form
    {
        public FormAgents()
        {
            InitializeComponent();
            ShowAgents();
        }
        void ShowAgents()
        {
            //очистка listView
            listViewAgents.Items.Clear();
            //проход о коллекции клиентов, в базе данных
            foreach (AgentsSet agentSet in Program.wftDb.AgentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        agentSet.Id.ToString(), agentSet.FirstName, agentSet.LastName,
                        agentSet.MiddleName, agentSet.DealShare.ToString()
                    });
                item.Tag = agentSet;
                listViewAgents.Items.Add(item);
            }
            listViewAgents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNameAgent.Text != "" && textBoxLastNameAgent.Text != "" && textBoxMiddleNameAgent.Text != "")
            {
                AgentsSet agentSet = new AgentsSet();
                agentSet.FirstName = textBoxNameAgent.Text;
                agentSet.MiddleName = textBoxMiddleNameAgent.Text;
                agentSet.LastName = textBoxLastNameAgent.Text;
                int dealShare;
                Int32.TryParse(textBoxDealShare.Text, out dealShare);
                agentSet.DealShare = dealShare;
                if (dealShare < 0 || dealShare > 100)
                {
                    labelDealShare.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    labelDealShare.ForeColor = Color.Black;
                }

                Program.wftDb.AgentsSet.Add(agentSet);
                //Сохраняем измаенения в модели
                Program.wftDb.SaveChanges();
                ShowAgents();
            }
        }

        private void textBoxDealShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 || number == 127)
            {
                e.Handled = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxNameAgent.Text != "" && textBoxLastNameAgent.Text != "" && textBoxMiddleNameAgent.Text != "")
            {
                AgentsSet agentSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                agentSet.FirstName = textBoxNameAgent.Text;
                agentSet.MiddleName = textBoxMiddleNameAgent.Text;
                agentSet.LastName = textBoxLastNameAgent.Text;
                //Сохраняем изменения в модели wftDb
                int dealShare;
                Int32.TryParse(textBoxDealShare.Text, out dealShare);
                agentSet.DealShare = dealShare;
                Program.wftDb.SaveChanges();
                ShowAgents();
            }
        }

        private void listViewAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1)
            {
                AgentsSet agentSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                textBoxNameAgent.Text = agentSet.FirstName;
                textBoxLastNameAgent.Text = agentSet.LastName;
                textBoxMiddleNameAgent.Text = agentSet.MiddleName;
                textBoxDealShare.Text = agentSet.DealShare.ToString();
            }
            else
            {
                textBoxNameAgent.Text = "";
                textBoxMiddleNameAgent.Text = "";
                textBoxLastNameAgent.Text = "";
                textBoxDealShare.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgents.SelectedItems.Count == 1)
                {
                    AgentsSet agentSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                    Program.wftDb.AgentsSet.Remove(agentSet);
                    Program.wftDb.SaveChanges();
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
