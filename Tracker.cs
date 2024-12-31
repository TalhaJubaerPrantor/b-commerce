using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pts
{
    public partial class Tracker : Form
    {

        //string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
        //SqlCommand cmd;
        //SqlDataAdapter adpt;
        //DataTable dt;


        public static int totalValue= 0;
        public static int totalOrder = 0;



        public Tracker()
        {
            InitializeComponent();
            showData();
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

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f = new firstPage();
            f.Show();
        }

        private void switchToUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f = new firstPage();
            f.Show();
        }

        public void showData()
        {
            string email = UserLogin.email;

            string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
            MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
            mySqlConn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT time,p_name,p_price FROM orders where email=@u_email", mySqlConn);
            cmd.Parameters.AddWithValue("@u_email", email);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                myOrders.Rows.Add(dr.GetValue(0).ToString(),dr.GetValue(1).ToString(), dr.GetValue(2),"Track");
                totalValue = totalValue + Convert.ToInt32( dr.GetValue(2));
                totalOrder = totalOrder + 1;
            }

        }

        private void myOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = myOrders.Rows[index];
            string findUsing = selectedRow.Cells[0].Value.ToString();
            string email = UserLogin.email;

            if (myOrders.Columns[e.ColumnIndex].Name == "trackBtn")
            {
                try
                {

                    string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
                    MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
                    mySqlConn.Open();


                    MySqlCommand cmd = new MySqlCommand("select payment,confirmation,proccessing,packaging,deliverying,delivired from orders where time=@findUsing and email=@email;", mySqlConn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@findUsing", findUsing);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read()) {
                        if (dr.GetValue(0).ToString() == "0") t_payment.BackColor = Color.Red;
                        else if(dr.GetValue(0).ToString() == "1") t_payment.BackColor = Color.Green;

                        if (dr.GetValue(1).ToString() == "0") t_confirm.BackColor = Color.Red;
                        else if (dr.GetValue(1).ToString() == "1") t_confirm.BackColor = Color.Green;

                        if (dr.GetValue(2).ToString() == "0") t_processing.BackColor = Color.Red;
                        else if (dr.GetValue(2).ToString() == "1") t_processing.BackColor = Color.Green;

                        if (dr.GetValue(3).ToString() == "0") t_packing.BackColor = Color.Red;
                        else if (dr.GetValue(3).ToString() == "1") t_packing.BackColor = Color.Green;

                        if (dr.GetValue(4).ToString() == "0") t_delivering.BackColor = Color.Red;
                        else if (dr.GetValue(4).ToString() == "1") t_delivering.BackColor = Color.Green;

                        if (dr.GetValue(5).ToString() == "0") t_delivered.BackColor = Color.Red;
                        else if (dr.GetValue(5).ToString() == "1") t_delivered.BackColor = Color.Green;
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
