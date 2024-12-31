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
using System.Xml.Linq;

namespace Pts
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f = new firstPage();
            f.Show();
        }

        private void buyBooks(string name,int price)
        {
            string email= UserLogin.email;

            string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
            MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
            mySqlConn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into orders values(@p_name,@p_price,@payment,@confirmation,@proccessing,@packaging,@deliverying,@delivired,@google_map,@email,@time)", mySqlConn);
            cmd.Parameters.AddWithValue("p_name", name);
            cmd.Parameters.AddWithValue("p_price",price);
            cmd.Parameters.AddWithValue("payment", 0);
            cmd.Parameters.AddWithValue("confirmation",0);
            cmd.Parameters.AddWithValue("proccessing",0);
            cmd.Parameters.AddWithValue("packaging",0);
            cmd.Parameters.AddWithValue("deliverying",0);
            cmd.Parameters.AddWithValue("delivired",0);
            cmd.Parameters.AddWithValue("google_map","");
            cmd.Parameters.AddWithValue("email",email);
            cmd.Parameters.AddWithValue("time", DateTime.Now.ToString());
            cmd.ExecuteNonQuery();
            mySqlConn.Close();
            MessageBox.Show("Product buy successfull");
        }



        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard u = new UserDashboard();
            u.Show();
        }

        private void Don_Quixote_Click(object sender, EventArgs e)
        {
            buyBooks("Don Quixote",999);
        }

        private void Two_Cities_Click(object sender, EventArgs e)
        {
            buyBooks("A Tale of Two Cities", 850);
        }

        private void Lord_of_the_Rings_Click(object sender, EventArgs e)
        {
            buyBooks("The Lord of the Rings", 899);
        }

        private void Harry_Potter_Click(object sender, EventArgs e)
        {
            buyBooks("Harry Potter", 700);
        }

        private void The_Hobbit_Click(object sender, EventArgs e)
        {
            buyBooks("The Hobbit", 700);
        }

        private void Think_and_Grow_Click(object sender, EventArgs e)
        {
            buyBooks("Think and Grow Rich", 699);
        }
    }
}
