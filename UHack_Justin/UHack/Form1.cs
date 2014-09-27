using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                Properties.Settings.Default.firstName = firstName.Text;
                Properties.Settings.Default.lastName = lastName.Text;
                Properties.Settings.Default.Save();

                //create main form
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }

        }

    }
}
