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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
            showData();
        }

        private void switchToUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f=new firstPage();
            f.Show();
        }


        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage f = new firstPage();
            f.Show();
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {

        }

       



        public void showData()
        {
            string email = UserLogin.email;

            string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
            MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
            mySqlConn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT  time,p_name,email,p_price FROM orders", mySqlConn);
         
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                orderdItem.Rows.Add(dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3),false,false,false,false,false,"",false,"Update","Delete");
            }
            
        }




         public int isPayed = 0, isConfirmed = 0, isProcessed = 0, isPackaged = 0, isDelivering = 0, isDelivired = 0;

        private void orderdItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            
            DataGridViewRow selectedRow = orderdItem.Rows[index];

            string findUsing = selectedRow.Cells[0].Value.ToString();

            if (orderdItem.Columns[e.ColumnIndex].Name == "payment") isPayed = 1;
            if (orderdItem.Columns[e.ColumnIndex].Name == "confirm") isConfirmed = 1;
            if (orderdItem.Columns[e.ColumnIndex].Name == "processing") isProcessed = 1;
            if (orderdItem.Columns[e.ColumnIndex].Name == "packing") isPackaged = 1;
            if (orderdItem.Columns[e.ColumnIndex].Name == "delivering") isDelivering = 1;
            if (orderdItem.Columns[e.ColumnIndex].Name == "delivered") isDelivired = 1;

            if (orderdItem.Columns[e.ColumnIndex].Name == "update" ) {
                try {

                    string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
                    MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
                    mySqlConn.Open();


                    MySqlCommand cmd = new MySqlCommand("update orders set payment=@payment,confirmation=@confirmation,proccessing=@proccessing,packaging=@packaging,deliverying=@deliverying,delivired=@delivired  where time=@findUsing;", mySqlConn);
                    cmd.Parameters.AddWithValue("@payment", isPayed);
                    cmd.Parameters.AddWithValue("@confirmation", isConfirmed);
                    cmd.Parameters.AddWithValue("@proccessing", isProcessed);
                    cmd.Parameters.AddWithValue("@packaging", isPackaged);
                    cmd.Parameters.AddWithValue("@deliverying", isDelivering);
                    cmd.Parameters.AddWithValue("@delivired", isDelivired);
                    cmd.Parameters.AddWithValue("@findUsing", findUsing);



                    cmd.ExecuteNonQuery();
                    mySqlConn.Close();
                    MessageBox.Show("Product Updated");


                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }



            if (orderdItem.Columns[e.ColumnIndex].Name == "delete")
            {
                try
                {

                    string sqlCon = "server=127.0.0.1;user=root;database=ecommerce;password=";
                    MySqlConnection mySqlConn = new MySqlConnection(sqlCon);
                    mySqlConn.Open();


                    MySqlCommand cmd = new MySqlCommand("delete from orders where time=@findUsing;", mySqlConn);
                    cmd.Parameters.AddWithValue("@findUsing", findUsing);
                    cmd.ExecuteNonQuery();
                    mySqlConn.Close();
                    MessageBox.Show("Product Deleted");

                    this.Hide();
                    adminDashboard a=new adminDashboard();
                    a.Show();
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
           



        }
    }
}
 //MessageBox.Show(selectedRow.Cells[0].Value.ToString());