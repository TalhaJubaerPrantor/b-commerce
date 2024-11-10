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
    }
}
