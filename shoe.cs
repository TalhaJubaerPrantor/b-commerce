using MySql.Data.MySqlClient;
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
    public partial class shoe : Form
    {
        public shoe()
        {
            InitializeComponent();
        }

       
        private void shoe_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard u = new UserDashboard();
            u.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f = new firstPage();
            f.Show();
        }



        private void buyShoes(string name, int price)
        {
            string email = UserLogin.email;

            string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
            MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
            mySqlConn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into orders values(@p_name,@p_price,@payment,@confirmation,@proccessing,@packaging,@deliverying,@delivired,@google_map,@email,@time)", mySqlConn);
            cmd.Parameters.AddWithValue("p_name", name);
            cmd.Parameters.AddWithValue("p_price", price);
            cmd.Parameters.AddWithValue("payment", 0);
            cmd.Parameters.AddWithValue("confirmation", 0);
            cmd.Parameters.AddWithValue("proccessing", 0);
            cmd.Parameters.AddWithValue("packaging", 0);
            cmd.Parameters.AddWithValue("deliverying", 0);
            cmd.Parameters.AddWithValue("delivired", 0);
            cmd.Parameters.AddWithValue("google_map", "");
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("time", DateTime.Now.ToString());
            cmd.ExecuteNonQuery();
            mySqlConn.Close();
            MessageBox.Show("Product buy successfull");
        }



        private void nike_Click(object sender, EventArgs e)
        {
            buyShoes("Nike",1199);
        }

        private void rebook_Click(object sender, EventArgs e)
        {
            buyShoes("Nike", 999);

        }

        private void adidas_Click(object sender, EventArgs e)
        {
            buyShoes("Nike", 1999);

        }

        private void bata_Click(object sender, EventArgs e)
        {
            buyShoes("Nike", 1150);

        }

        private void woodland_Click(object sender, EventArgs e)
        {
            buyShoes("Nike", 1800);

        }

        private void sketchers_Click(object sender, EventArgs e)
        {
            buyShoes("Nike", 1199);

        }
    }
}
