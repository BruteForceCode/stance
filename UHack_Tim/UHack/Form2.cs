using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Topic emotionals;
        Topic physicals;
        Topic environmentals;
        Topic socials;
        int selected;
        int theTotal;

        public Form2()
        {
            InitializeComponent();

            pointsLabel.Text = Properties.Settings.Default.todayPoints.ToString();
            nameLabel.Text = Properties.Settings.Default.firstName + " " + Properties.Settings.Default.lastName;
            pointsLabel.Text = Properties.Settings.Default.todayPoints.ToString();
            setPointsColor();

            theTotal = 0;
            selected = -1;

            setTopics();
        }

        private void setTopics()
        {
            emotionals = new Topic("Emotional");
            physicals = new Topic("Physical");
            environmentals = new Topic("Environmental");
            socials = new Topic("Social");

            //emotionals
            emotionals.add(new Accomplishment("Worked on homework", 20));
            emotionals.add(new Accomplishment("Learned something new", 30));
            emotionals.add(new Accomplishment("Random act of kindness", 50));
            emotionals.add(new Accomplishment("Cried away all the pain", 20));
            emotionals.add(new Accomplishment("Procrastin- ated", -30));
            emotionals.add(new Accomplishment("Lingered", -20));
            emotionals.add(new Accomplishment("Overate", -40));
            emotionals.add(new Accomplishment("Guilt", -30));

            //physicals
            physicals.add(new Accomplishment("Ran a mile", 30));
            physicals.add(new Accomplishment("Lifted Weights", 40));
            physicals.add(new Accomplishment("Played Outside", 10));
            physicals.add(new Accomplishment("Healthy Eating", 30));
            physicals.add(new Accomplishment("Binge Drinking", -30));
            physicals.add(new Accomplishment("Drug Use", -5));
            physicals.add(new Accomplishment("Heroin", -100));
            physicals.add(new Accomplishment("Junk Food", -20));

            //physicals
            environmentals.add(new Accomplishment("Ride bike to work", 30));
            environmentals.add(new Accomplishment("Picked up litter", 40));
            environmentals.add(new Accomplishment("Drove a hybrid", 10));
            environmentals.add(new Accomplishment("Planted a tree", 30));
            environmentals.add(new Accomplishment("Littered", -30));
            environmentals.add(new Accomplishment("Drove a Hummer", -20));
            environmentals.add(new Accomplishment("Left the lights on", -40));
            environmentals.add(new Accomplishment("Wasted electricity", -20));

            //social
            socials.add(new Accomplishment("Met new friend", 30));
            socials.add(new Accomplishment("Random act of kindness", 40));
            socials.add(new Accomplishment("Meditate", 10));
            socials.add(new Accomplishment("Went to a party", 30));
            socials.add(new Accomplishment("One night stand", -30));
            socials.add(new Accomplishment("Walk of shame", -20));
            socials.add(new Accomplishment("Passed out drunk", -40));
            socials.add(new Accomplishment("Gossipped", -20));
        }

        private void setPointsColor()
        {
            int points = Properties.Settings.Default.todayPoints;
            if (points <= 0)
            {
                pointsLabel.ForeColor = Color.Maroon;
            }
            else if (points <= 100)
            {
                pointsLabel.ForeColor = Color.Orange;
            }
            else
            {
                pointsLabel.ForeColor = Color.DarkGreen;
            }
        }

        private void populateList(Topic topics)
        {
            List<Accomplishment> list = topics.getAccomplishments();
            tLabel0.Text = ((Accomplishment)list[0]).getName();
            tLabel1.Text = ((Accomplishment)list[1]).getName();
            tLabel2.Text = ((Accomplishment)list[2]).getName();
            tLabel3.Text = ((Accomplishment)list[3]).getName();
            tLabel4.Text = ((Accomplishment)list[4]).getName();
            tLabel5.Text = ((Accomplishment)list[5]).getName();
            tLabel6.Text = ((Accomplishment)list[6]).getName();
            tLabel7.Text = ((Accomplishment)list[7]).getName();
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

        private void panel1_Click(object sender, System.EventArgs e)
        {
            //move layout panel to left 
            retract();

            //change status label
            statusLabel.Text = "emotional";

            //make selection panel visible
            changeSelectionPanel();
            populateList(emotionals);
            selected = 1;

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

        private void panel2_Click(object sender, System.EventArgs e)
        {
            //move layout panel to left 
            retract();

            //change status label
            statusLabel.Text = "physical";

            //make selection panel visible
            changeSelectionPanel();
            populateList(physicals);
            selected = 2;

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

        private void panel3_Click(object sender, System.EventArgs e)
        {
            //move layout panel to left 
            retract();

            //change status label
            statusLabel.Text = "environmental";

            //make selection panel visible
            changeSelectionPanel();
            populateList(environmentals);
            selected = 3;
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

        private void panel4_Click(object sender, System.EventArgs e)
        {
            //move layout panel to left 
            retract();

            //change label
            statusLabel.Text = "social";

            //make selection panel visible
            changeSelectionPanel();
            populateList(socials);
            selected = 4;
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

        private void retract()
        {
            layoutPanel.Width = 60;
        }

        private void returnOriginal()
        {
            returnButton.Visible = false;
            selectionPanel.Visible = false;
            layoutPanel.Width = 629;
            layoutPanel.Height = 261;
            statusLabel.Text = "select a category...";

            //return panel
            tPanel0.BackColor = Color.Green;
            tPanel1.BackColor = Color.Green;
            tPanel2.BackColor = Color.Green;
            tPanel3.BackColor = Color.Green;
            tPanel4.BackColor = Color.Red;
            tPanel5.BackColor = Color.Red;
            tPanel6.BackColor = Color.Red;
            tPanel7.BackColor = Color.Red;
            pointLabel.Text = "-";
            theTotal = 0;
        }

        private void changeSelectionPanel()
        {
            selectionPanel.Location = new Point(88, 143);
            selectionPanel.Width = 500;
            selectionPanel.Height = 261;
            selectionPanel.Visible = true;
            returnButton.Visible = true;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            returnOriginal();
        }

        private void returnButton_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            returnButton.BackColor = Color.DarkGreen;
        }

        private void returnButton_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
            returnButton.BackColor = Color.LimeGreen;
        }


        //stuff
        private void tLabel0_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void tLabel1_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void tLabel2_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void tLabel3_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void tLabel4_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void tLabel5_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void tLabel6_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void tLabel7_MouseEnter(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void tLabel0_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void tLabel1_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void tLabel2_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void tLabel3_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void tLabel4_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void tLabel5_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void tLabel6_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void tLabel7_MouseLeave(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void tLabel0_Click(object sender, System.EventArgs e)
        {
            int num = 0;
            tPanel0.BackColor = Color.DarkGreen;
            updatePoints(num);
        }
        private void tLabel1_Click(object sender, System.EventArgs e)
        {
            int num = 1;
            tPanel1.BackColor = Color.DarkGreen;
            updatePoints(num);
        }
        private void tLabel2_Click(object sender, System.EventArgs e)
        {
            int num = 2;
            tPanel2.BackColor = Color.DarkGreen;
            updatePoints(num);
        }
        private void tLabel3_Click(object sender, System.EventArgs e)
        {
            int num = 3;
            tPanel3.BackColor = Color.DarkGreen;
            updatePoints(num);
        }
        private void tLabel4_Click(object sender, System.EventArgs e)
        {
            int num = 4;
            tPanel4.BackColor = Color.Maroon;
            updatePoints(num);
        }
        private void tLabel5_Click(object sender, System.EventArgs e)
        {
            int num = 5;
            tPanel5.BackColor = Color.Maroon;
            updatePoints(num);
        }
        private void tLabel6_Click(object sender, System.EventArgs e)
        {
            int num = 6;
            tPanel6.BackColor = Color.Maroon;
            updatePoints(num);
        }
        private void tLabel7_Click(object sender, System.EventArgs e)
        {
            int num = 7;
            tPanel7.BackColor = Color.Maroon;
            updatePoints(num);
        }

        private void updatePoints(int num)
        {
            Topic theTop;
            if (selected == 1)
            {
                theTop = emotionals;
            }
            else if (selected == 2)
            {
                theTop = physicals;
            }
            else if (selected == 3)
            {
                theTop = environmentals;
            }
            else if (selected == 4)
            {
                theTop = socials;
            }
            else
            {
                theTop = null;
            }

            theTotal += theTop.getAccomplishments()[num].getPointValue();

            pointLabel.Text = theTotal.ToString();

            //set color of point label
            if (theTotal >= 0)
            {
                pointLabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                pointLabel.ForeColor = Color.Maroon;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.todayPoints += theTotal;
            setPointsColor();
            Properties.Settings.Default.Save();
            pointsLabel.Text = Properties.Settings.Default.todayPoints.ToString();
            returnOriginal();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
