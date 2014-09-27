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
    public partial class NewUser : Form
    {
        private String username;
        private String password;

        public NewUser(String username, String password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();

            firstName.Text = Properties.Settings.Default.firstName;
            lastName.Text = Properties.Settings.Default.lastName;
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            if (firstName.Text.Length == 0 || lastName.Text.Length == 0)
            {
                //message box when no names
                MessageBox.Show("Please enter a first name and last name.");
            }
            else
            {
                //set first and last names
                //Properties.Settings.Default.firstName = firstName.Text;
                //Properties.Settings.Default.lastName = lastName.Text;
                //Properties.Settings.Default.Save();
                

                String connString = "Data Source=localhost;Initial Catalog=Stance; Integrated Security=true";
                String query = "INSERT INTO user (id, firstName, lastName, password, username) "
                                + "VALUES (, '" + firstName.Text + "', '" + lastName.Text + "', '" + password + "', '" + username + "');";
                //ConnectionSQL conn = new ConnectionSQL(connString, query);
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(query, conn);
                //MessageBox.Show(firstName.Text + " " + lastName.Text + " " + password + " " + username);
                try
                {
                    conn.Open();
                    cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL exception occurred: " + ex.Message);
                }
                MessageBox.Show(conn.State.ToString());
                conn.Close();
                //create main form
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }

        }

        private void ConnectionSQL(string connString, string query)
        {
            throw new NotImplementedException();
        }

        private void firstLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
