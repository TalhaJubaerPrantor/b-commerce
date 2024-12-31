using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ZstdSharp.Unsafe;
using MySql.Data.MySqlClient;
using System.Xml.Linq;
namespace Pts
{
    public partial class UserLogin : Form
    {

        public static string email = "";
        
        public UserLogin()
        {
            InitializeComponent();
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (u_email.Text == "" || u_password.Text== "")
            {
                loginError.Text = "Email or password cannot be empty";
            }
            else { 

            try { 
            string sqlCon ="server=127.0.0.1;user=root;database=ecommerce;password=";
            MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
            mySqlConn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users where u_email=@u_email AND u_password=@u_password", mySqlConn);
            cmd.Parameters.AddWithValue("@u_email", u_email.Text);
            cmd.Parameters.AddWithValue("u_password", u_password.Text);
            MySqlDataAdapter da= new MySqlDataAdapter(cmd);
                
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               
                this.Hide();
                UserDashboard u = new UserDashboard();
                u.Show();
                }
            else
            {
                    loginError.Text = "Email or password incorrect";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            email=u_email.Text;

        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserRegister u=new UserRegister();
            u.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f=new firstPage();
            f.Show();
        }
    }
}
