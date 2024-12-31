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
    public partial class UserDashboard : Form
    {

        public UserDashboard()
        {
            InitializeComponent();
            orderNumber.Text = Convert.ToString(Tracker.totalOrder);
            totalValue.Text =Convert.ToString( Tracker.totalValue);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tracker t = new Tracker();
            t.Show();
        }


        private void switchToAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f=new firstPage();
            f.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f = new firstPage();
            f.Show();
        }


        private void viewShoe_Click(object sender, EventArgs e)
        {
            this.Hide();
            shoe s = new shoe();
            s.Show();
        }


        private void viewDress_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dress d = new Dress();
            d.Show();
        }

        private void viewBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books b = new Books();
            b.Show();
        }

        private void viewGrocery_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grocery g = new Grocery();
            g.Show();
        }

        private void viewElectronics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Electronics el = new Electronics();
            el.Show();
        }
    }
}
