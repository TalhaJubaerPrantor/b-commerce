using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pts
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
          
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
            MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
            mySqlConn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into users values(@u_name,@u_phone,@u_email,@u_address,@u_password)", mySqlConn);
            cmd.Parameters.AddWithValue("u_name",u_name.Text);
            cmd.Parameters.AddWithValue("u_phone", u_phone.Text);
            cmd.Parameters.AddWithValue("u_email", u_email.Text);
            cmd.Parameters.AddWithValue("u_address", u_address.Text);
            cmd.Parameters.AddWithValue("u_password", u_password.Text);
            cmd.ExecuteNonQuery();

            mySqlConn.Close();
            MessageBox.Show("User registration successful. Please login.");

            this.Hide();
            UserLogin u = new UserLogin();
            u.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin u=new UserLogin();
            u.Show();
        }
    }
}
