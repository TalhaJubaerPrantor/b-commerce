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
    public partial class Tracker : Form
    {
        public Tracker()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard u=new UserDashboard();
            u.Show();
        }

        private void seeLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapTrack m = new MapTrack();
            m.Show();
        }
    }
}
