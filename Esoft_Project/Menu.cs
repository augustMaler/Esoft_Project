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

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            FormAgents formAgents = new FormAgents();
            formAgents.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            FormRealEstate realEstate = new FormRealEstate();
            realEstate.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            FormSupply formSupply = new FormSupply();
            formSupply.Show();
        }

        private void buttonOpenAgents_Click_1(object sender, EventArgs e)
        {
            FormAgents formAgents = new FormAgents();
            formAgents.Show();
        }

        private void buttonOpenRealEstates_Click_1(object sender, EventArgs e)
        {
            FormRealEstate realEstate = new FormRealEstate();
            realEstate.Show();
        }

        private void buttonOpenDemands_Click_1(object sender, EventArgs e)
        {
            FormDemandSet formDemand = new FormDemandSet();
            formDemand.Show();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            FormSupply formSupply = new FormSupply();
            formSupply.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            FormDeal formDeal = new FormDeal();
            formDeal.Show();
        }
    }
}
