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
    public partial class Dress : Form
    {
        public Dress()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f = new firstPage();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard u = new UserDashboard();
            u.Show();
        }



        private void buyDress(string name, int price)
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



        

        private void abaya_Click(object sender, EventArgs e)
        {
            buyDress("Abaya",999);
        }

        private void hijab_Click(object sender, EventArgs e)
        {
            buyDress("Hijab", 850);

        }

        private void frock_Click(object sender, EventArgs e)
        {
            buyDress("Frock", 1200);

        }

        private void tshirt_Click(object sender, EventArgs e)
        {
            buyDress("T-shirt", 600);

        }

        private void jeans_Click(object sender, EventArgs e)
        {
            buyDress("Jeans", 999);

        }

        private void shirt_Click(object sender, EventArgs e)
        {
            buyDress("Shirt", 1100);

        }
    }
}
