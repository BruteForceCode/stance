using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jordan();
        }

        public void Jordan()
        {
            MessageBox.Show("here");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Header.Text = "My Statistics";
            total.Text = "Total";

            

            awDaily.Text = "12";
            eDaily.Text = "1";
            perDaily.Text = "14";
            physDaily.Text = "3";

            int test = 12;
            int test2 = 14;

            pieChart.Series["int"] = test;
            pieChart.Series[int] = test2;

            /*pieChart.DataSource = awDaily;
            pieChart.DataSource = eDaily;
            pieChart.DataSource = perDaily;
            pieChart.DataSource = perDaily;
            pieChart.DataSource = physDaily;*/

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void programBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //awDaily;
            //eDaily = 0;
            //perDaily = 0;
            //physDaily = 0;
        }

    }
}
