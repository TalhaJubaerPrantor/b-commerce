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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }





        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f = new firstPage();
            f.Show();
        }


        private void loginBtn_Click_2(object sender, EventArgs e)
        {
            if (a_email.Text == "" ||a_password.Text=="")
            {
                warning.Text = "Email or password cannot be empty";
            }
            else
            {
                try
                {
                    string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
                    MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
                    mySqlConn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM admin where a_email=@a_email AND a_password=@a_password", mySqlConn);
                    cmd.Parameters.AddWithValue("@a_email", a_email.Text);
                    cmd.Parameters.AddWithValue("@a_password", a_password.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        //MessageBox.Show("Login successfull");
                        this.Hide();
                        adminDashboard a = new adminDashboard();
                        a.Show();
                    }
                    else
                    {
                        warning.Text = "Email or password incorrect";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }









            }

        }
    }
}
