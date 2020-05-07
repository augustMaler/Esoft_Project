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
            FormAgents formAgents = new FormAgents();
            formAgents.Show();
        }

        void buttonOpenRealEstates_Click_1(object sender, EventArgs e)
        {
            FormRealEstate realEstate = new FormRealEstate();
            realEstate.Show();
        }

        void buttonOpenDemands_Click_1(object sender, EventArgs e)
        {
            FormDemandSet formDemand = new FormDemandSet();
            formDemand.Show();
        }

        void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            FormSupply formSupply = new FormSupply();
            formSupply.Show();
        }

        void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            FormDeal formDeal = new FormDeal();
            formDeal.Show();
        }
    }
}
