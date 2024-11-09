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
    }
}
