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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        void buttonOpenClients_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.Show();
        }
        void buttonOpenAgents_Click_1(object sender, EventArgs e)
        {
            FormEmployees formAgents = new FormEmployees();
            formAgents.Show();
        }

        void buttonOpenRealEstates_Click_1(object sender, EventArgs e)
        {
            FormGoods goods = new FormGoods();
            goods.Show();
        }
    }
}
