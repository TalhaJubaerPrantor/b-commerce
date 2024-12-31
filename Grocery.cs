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
    public partial class Grocery : Form
    {
        public Grocery()
        {
            InitializeComponent();
        }

        private void Shoes_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

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


        private void buyGrocery(string name, int price)
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


        private void rice_Click(object sender, EventArgs e)
        {
            buyGrocery("Rice", 70);
        }

        private void potato_Click(object sender, EventArgs e)
        {
            buyGrocery("Potato", 50);

        }

        private void eggs_Click(object sender, EventArgs e)
        {
            buyGrocery("Eggs", 140);

        }

        private void milk_Click(object sender, EventArgs e)
        {
            buyGrocery("Milk", 70);

        }

        private void tomato_Click(object sender, EventArgs e)
        {
            buyGrocery("Tomato", 160);

        }

        private void meat_Click(object sender, EventArgs e)
        {
            buyGrocery("Meat", 700);

        }
    }
}
