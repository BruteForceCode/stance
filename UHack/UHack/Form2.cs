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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            pointsLabel.Text = Properties.Settings.Default.todayPoints.ToString();
            nameLabel.Text = Properties.Settings.Default.firstName + " " + Properties.Settings.Default.lastName;
            setPointsColor();
        }

        private void setPointsColor()
        {
            int points = Properties.Settings.Default.todayPoints;
            if (points < 100)
            {
                pointsLabel.ForeColor = Color.Maroon;
            }
            else if (points < 200)
            {
                pointsLabel.ForeColor = Color.Orange;
            }
            else
            {
                pointsLabel.ForeColor = Color.LimeGreen;
            }
        }

        private void panel1_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;

            panel1.BackColor = Color.Maroon;

            System.Drawing.SolidBrush brush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Maroon);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(brush1, new System.Drawing.Rectangle(719, 150, 79, 76));
            brush1.Dispose();
            formGraphics.Dispose();
        }
        
        private void panel1_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;

            panel1.BackColor = Color.Red;
        }

        private void panel2_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;

            panel2.BackColor = Color.Indigo;

            System.Drawing.SolidBrush brush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Indigo);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(brush1, new System.Drawing.Rectangle(719, 150, 79, 76));
            brush1.Dispose();
        }

        private void panel2_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;

            panel2.BackColor = Color.BlueViolet;
        }

        private void panel3_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;

            panel3.BackColor = Color.DarkBlue;

            System.Drawing.SolidBrush brush1 = new System.Drawing.SolidBrush(System.Drawing.Color.DarkBlue);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(brush1, new System.Drawing.Rectangle(719, 150, 79, 76));
            brush1.Dispose();
        }

        private void panel3_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;

            panel3.BackColor = Color.MediumBlue;
        }

        private void panel4_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;

            panel4.BackColor = Color.DarkCyan;

            System.Drawing.SolidBrush brush1 = new System.Drawing.SolidBrush(System.Drawing.Color.DarkCyan);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(brush1, new System.Drawing.Rectangle(719, 150, 79, 76));
            brush1.Dispose();
        }

        private void panel4_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;

            panel4.BackColor = Color.Cyan;
        }

        private void layoutPanel_MouseEnter(object sender, System.EventArgs e)
        {
        }

        private void layoutPanel_MouseLeave(object sender, System.EventArgs e)
        {
            drawWhiteCircle();
        }

        private void drawWhiteCircle()
        {
            System.Drawing.SolidBrush brush1 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(brush1, new System.Drawing.Rectangle(719, 150, 79, 76));
            brush1.Dispose();
        }
    }
}
