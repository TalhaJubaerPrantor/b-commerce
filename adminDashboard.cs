using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pts
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void switchToUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f=new firstPage();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f = new firstPage();
            f.Show();
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void deliveryLoaction1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryLocation d = new DeliveryLocation();
            d.Show();
        }

        private void deliveryLoaction2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryLocation d = new DeliveryLocation();
            d.Show();
        }

        private void deliveryLoaction3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryLocation d = new DeliveryLocation();
            d.Show();
        }

        private void deliveryLoaction4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryLocation d = new DeliveryLocation();
            d.Show();
        }
    }
}
