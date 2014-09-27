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

        private void Form1_Load(object sender, EventArgs e)
        {
            Header.Text = "My Statistics";
            total.Text = "Total";


            //this is where the queries will fill in the data tables
            totalDaily.Text = "100";
            totalWeekly.Text = "200";
            totalLifetime.Text = "300";

            envDaily.Text = "45";
            emoDaily.Text = "25";
            physDaily.Text = "75";
            socDaily.Text = "300";

            envWeekly.Text = "45";
            emoWeekly.Text = "25";
            physWeekly.Text = "75";
            socWeekly.Text = "300";

            
            envLifetime.Text = "45"; 
            emoLifetime.Text = "25";
            physLifetime.Text = "75";
            socLifetime.Text = "300";
            
            //this is the pie chart with all of the daily data in it
            pieChart.Series["Series1"].Points.AddY(Convert.ToDouble(envDaily.Text));
            MessageBox.Show(pieChart.Series["Series1"].Points[0].MarkerColor.ToString());

            pieChart.Series["Series1"].Points.AddY(Convert.ToDouble(emoDaily.Text));
            pieChart.Series["Series1"].Points[1].MarkerColor = Color.Red;

            pieChart.Series["Series1"].Points.AddY(Convert.ToDouble(physDaily.Text));
            pieChart.Series["Series1"].Points[2].MarkerColor = Color.BlueViolet;

            pieChart.Series["Series1"].Points.AddY(Convert.ToDouble(socDaily.Text));
            pieChart.Series["Series1"].Points[3].MarkerColor = Color.Cyan;



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

        private void pieChart_Click(object sender, EventArgs e)
        {

        }
    }
}
