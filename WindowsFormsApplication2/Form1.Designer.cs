namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Header = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalWeekly = new System.Windows.Forms.Label();
            this.totalLifetime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emoDaily = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.physDaily = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.envDaily = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalDaily = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.socDaily = new System.Windows.Forms.Label();
            this.emoWeekly = new System.Windows.Forms.Label();
            this.physWeekly = new System.Windows.Forms.Label();
            this.envWeekly = new System.Windows.Forms.Label();
            this.socWeekly = new System.Windows.Forms.Label();
            this.emoLifetime = new System.Windows.Forms.Label();
            this.physLifetime = new System.Windows.Forms.Label();
            this.envLifetime = new System.Windows.Forms.Label();
            this.socLifetime = new System.Windows.Forms.Label();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(158, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(367, 78);
            this.Header.TabIndex = 0;
            this.Header.Text = "My Statistics";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(27, 117);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(73, 36);
            this.total.TabIndex = 1;
            this.total.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weekly Total  =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lifetime Total =";
            // 
            // totalWeekly
            // 
            this.totalWeekly.AutoSize = true;
            this.totalWeekly.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWeekly.Location = new System.Drawing.Point(222, 179);
            this.totalWeekly.Name = "totalWeekly";
            this.totalWeekly.Size = new System.Drawing.Size(108, 26);
            this.totalWeekly.TabIndex = 4;
            this.totalWeekly.Text = "#weekTotal";
            // 
            // totalLifetime
            // 
            this.totalLifetime.AutoSize = true;
            this.totalLifetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLifetime.Location = new System.Drawing.Point(222, 205);
            this.totalLifetime.Name = "totalLifetime";
            this.totalLifetime.Size = new System.Drawing.Size(127, 26);
            this.totalLifetime.TabIndex = 5;
            this.totalLifetime.Text = "#lifetimeTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Breakdown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Emotional =";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // emoDaily
            // 
            this.emoDaily.AutoSize = true;
            this.emoDaily.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoDaily.Location = new System.Drawing.Point(194, 339);
            this.emoDaily.Name = "emoDaily";
            this.emoDaily.Size = new System.Drawing.Size(93, 26);
            this.emoDaily.TabIndex = 8;
            this.emoDaily.Text = "emoDaily";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "Physical =";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // physDaily
            // 
            this.physDaily.AutoSize = true;
            this.physDaily.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physDaily.Location = new System.Drawing.Point(194, 365);
            this.physDaily.Name = "physDaily";
            this.physDaily.Size = new System.Drawing.Size(95, 26);
            this.physDaily.TabIndex = 10;
            this.physDaily.Text = "physDaily";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "Enviornmental =";
            // 
            // envDaily
            // 
            this.envDaily.AutoSize = true;
            this.envDaily.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.envDaily.Location = new System.Drawing.Point(194, 391);
            this.envDaily.Name = "envDaily";
            this.envDaily.Size = new System.Drawing.Size(85, 26);
            this.envDaily.TabIndex = 12;
            this.envDaily.Text = "envDaily";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 26);
            this.label12.TabIndex = 13;
            this.label12.Text = "Daily Total      =";
            // 
            // totalDaily
            // 
            this.totalDaily.AutoSize = true;
            this.totalDaily.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDaily.Location = new System.Drawing.Point(222, 153);
            this.totalDaily.Name = "totalDaily";
            this.totalDaily.Size = new System.Drawing.Size(104, 26);
            this.totalDaily.TabIndex = 14;
            this.totalDaily.Text = "#dailyTotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Daily";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Weekly";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lifetime";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 26);
            this.label13.TabIndex = 18;
            this.label13.Text = "Social =";
            // 
            // socDaily
            // 
            this.socDaily.AutoSize = true;
            this.socDaily.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socDaily.Location = new System.Drawing.Point(194, 417);
            this.socDaily.Name = "socDaily";
            this.socDaily.Size = new System.Drawing.Size(83, 26);
            this.socDaily.TabIndex = 19;
            this.socDaily.Text = "socDaily";
            // 
            // emoWeekly
            // 
            this.emoWeekly.AutoSize = true;
            this.emoWeekly.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoWeekly.Location = new System.Drawing.Point(334, 339);
            this.emoWeekly.Name = "emoWeekly";
            this.emoWeekly.Size = new System.Drawing.Size(113, 26);
            this.emoWeekly.TabIndex = 20;
            this.emoWeekly.Text = "emoWeekly";
            // 
            // physWeekly
            // 
            this.physWeekly.AutoSize = true;
            this.physWeekly.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physWeekly.Location = new System.Drawing.Point(334, 365);
            this.physWeekly.Name = "physWeekly";
            this.physWeekly.Size = new System.Drawing.Size(115, 26);
            this.physWeekly.TabIndex = 21;
            this.physWeekly.Text = "physWeekly";
            // 
            // envWeekly
            // 
            this.envWeekly.AutoSize = true;
            this.envWeekly.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.envWeekly.Location = new System.Drawing.Point(334, 391);
            this.envWeekly.Name = "envWeekly";
            this.envWeekly.Size = new System.Drawing.Size(105, 26);
            this.envWeekly.TabIndex = 22;
            this.envWeekly.Text = "envWeekly";
            // 
            // socWeekly
            // 
            this.socWeekly.AutoSize = true;
            this.socWeekly.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socWeekly.Location = new System.Drawing.Point(334, 417);
            this.socWeekly.Name = "socWeekly";
            this.socWeekly.Size = new System.Drawing.Size(103, 26);
            this.socWeekly.TabIndex = 23;
            this.socWeekly.Text = "socWeekly";
            // 
            // emoLifetime
            // 
            this.emoLifetime.AutoSize = true;
            this.emoLifetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emoLifetime.Location = new System.Drawing.Point(501, 339);
            this.emoLifetime.Name = "emoLifetime";
            this.emoLifetime.Size = new System.Drawing.Size(120, 26);
            this.emoLifetime.TabIndex = 24;
            this.emoLifetime.Text = "physLifetime";
            // 
            // physLifetime
            // 
            this.physLifetime.AutoSize = true;
            this.physLifetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physLifetime.Location = new System.Drawing.Point(501, 365);
            this.physLifetime.Name = "physLifetime";
            this.physLifetime.Size = new System.Drawing.Size(120, 26);
            this.physLifetime.TabIndex = 25;
            this.physLifetime.Text = "physLifetime";
            // 
            // envLifetime
            // 
            this.envLifetime.AutoSize = true;
            this.envLifetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.envLifetime.Location = new System.Drawing.Point(501, 388);
            this.envLifetime.Name = "envLifetime";
            this.envLifetime.Size = new System.Drawing.Size(110, 26);
            this.envLifetime.TabIndex = 26;
            this.envLifetime.Text = "envLifetime";
            // 
            // socLifetime
            // 
            this.socLifetime.AutoSize = true;
            this.socLifetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socLifetime.Location = new System.Drawing.Point(501, 414);
            this.socLifetime.Name = "socLifetime";
            this.socLifetime.Size = new System.Drawing.Size(108, 26);
            this.socLifetime.TabIndex = 27;
            this.socLifetime.Text = "socLifetime";
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            this.pieChart.DataSource = this.programBindingSource;
            this.pieChart.Location = new System.Drawing.Point(408, 117);
            this.pieChart.Name = "pieChart";
            this.pieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(183, 141);
            this.pieChart.TabIndex = 28;
            this.pieChart.Text = "chart1";
            this.pieChart.Click += new System.EventHandler(this.pieChart_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(WindowsFormsApplication2.Program);
            this.programBindingSource.CurrentChanged += new System.EventHandler(this.programBindingSource_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 476);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.socLifetime);
            this.Controls.Add(this.envLifetime);
            this.Controls.Add(this.physLifetime);
            this.Controls.Add(this.emoLifetime);
            this.Controls.Add(this.socWeekly);
            this.Controls.Add(this.envWeekly);
            this.Controls.Add(this.physWeekly);
            this.Controls.Add(this.emoWeekly);
            this.Controls.Add(this.socDaily);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalDaily);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.envDaily);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.physDaily);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emoDaily);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalLifetime);
            this.Controls.Add(this.totalWeekly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalWeekly;
        private System.Windows.Forms.Label totalLifetime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label emoDaily;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label physDaily;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label envDaily;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalDaily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label socDaily;
        private System.Windows.Forms.Label emoWeekly;
        private System.Windows.Forms.Label physWeekly;
        private System.Windows.Forms.Label envWeekly;
        private System.Windows.Forms.Label socWeekly;
        private System.Windows.Forms.Label emoLifetime;
        private System.Windows.Forms.Label physLifetime;
        private System.Windows.Forms.Label envLifetime;
        private System.Windows.Forms.Label socLifetime;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.BindingSource programBindingSource;

    }
}

