using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class entryForm : Form
    {
        public entryForm()
        {
            InitializeComponent();

            username.Text = Properties.Settings.Default.firstName;
            password.Text = Properties.Settings.Default.lastName;
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            /*
            if (username.Text.Length == 0 || password.Text.Length == 0)
            {
                //message box when no names
                MessageBox.Show("Please enter a first name and last name.");
            }
            else
            {
                //set first and last names
                Properties.Settings.Default.firstName = username.Text;
                Properties.Settings.Default.lastName = password.Text;
                Properties.Settings.Default.Save();

                //create main form
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
             */
            //send you to new user form
            this.Hide();
            NewUser user = new NewUser(username.Text, password.Text);
            user.ShowDialog();

        }

        private void firstLabel_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text.Length == 0 || password.Text.Length == 0)
            {
                //message box when no names
                MessageBox.Show("Please enter a username and password.");
            }
            else
            {
                //set first and last names
                //Properties.Settings.Default.firstName = username.Text;
                //Properties.Settings.Default.lastName = password.Text;
                //Properties.Settings.Default.Save();


                try
                {
                    String connString = "Data Source=localhost;Initial Catalog=Stance;";
                    SqlConnection conn = new SqlConnection(connString);
                    //SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "";

                    /*
                    // Create a new adapter and give it a query to fetch sales order, contact,  
                    // address, and product information for sales in the year 2002. Point connection  
                    // information to the configuration setting "AdventureWorks".
                    //string connectionString = "Data Source=localhost;Initial Catalog=AdventureWorks;"
                    //    + "Integrated Security=true;";
                    System.Data.SqlClient.SqlConnectionStringBuilder builder =
                    new System.Data.SqlClient.SqlConnectionStringBuilder();
                    builder["Data Source"] = "(local)";
                    builder["integrated Security"] = true;
                    builder["Initial Catalog"] = "AdventureWorks;NewValue=Bad";
                    Console.WriteLine(builder.ConnectionString);

                    MessageBox.Show("");
                    
                    //SqlDataAdapter da = new SqlDataAdapter(connectionString);
                     */

                } catch (SqlException ex) {
                    Console.WriteLine("SQL exception occurred: " + ex.Message);
                }
                
                //create main form
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

    }
}
