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
    public partial class firstPage : Form
    {
        public firstPage()
        {
            InitializeComponent();
            
        }


        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin a=new AdminLogin();
            a.Show();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin u=new UserLogin();
            u.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
