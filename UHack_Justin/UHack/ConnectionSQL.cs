using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ConnectionSQL
    {
        //String connString = "";
        //String query = "";

        public void connectionSQL(String connString, String query)
        {
            //this.connString = connString;
            //this.query = query;
            connectIt(connString, query);
        }
        public void connectIt(String connString, String query) {

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            //MessageBox.Show(firstName.Text + " " + lastName.Text + " " + password + " " + username);
            try
            {
                conn.Open();
                cmd.ExecuteScalar();
            } catch (SqlException ex)
            {
                MessageBox.Show("SQL exception occurred: " + ex.Message);
            }
            MessageBox.Show(conn.State.ToString());
            conn.Close();
        }

    }
}
