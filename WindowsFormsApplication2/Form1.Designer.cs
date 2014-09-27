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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Header = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalWeekly = new System.Windows.Forms.Label();
            this.totalLifetime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.physDaily = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.perDaily = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.awDaily = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalDaily = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.eDaily = new System.Windows.Forms.Label();
            this.physWeekly = new System.Windows.Forms.Label();
            this.perWeekly = new System.Windows.Forms.Label();
            this.awWeekly = new System.Windows.Forms.Label();
            this.eWeekly = new System.Windows.Forms.Label();
            this.physLifetime = new System.Windows.Forms.Label();
            this.perLifetime = new System.Windows.Forms.Label();
            this.awLifetime = new System.Windows.Forms.Label();
            this.eLifetime = new System.Windows.Forms.Label();
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
            this.label6.Size = new System.Drawing.Size(151, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Physical            =";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // physDaily
            // 
            this.physDaily.AutoSize = true;
            this.physDaily.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physDaily.Location = new System.Drawing.Point(194, 339);
            this.physDaily.Name = "physDaily";
            this.physDaily.Size = new System.Drawing.Size(105, 26);
            this.physDaily.TabIndex = 8;
            this.physDaily.Text = "#physDaily";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "Personal           =";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // perDaily
            // 
            this.perDaily.AutoSize = true;
            this.perDaily.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perDaily.Location = new System.Drawing.Point(194, 365);
            this.perDaily.Name = "perDaily";
            this.perDaily.Size = new System.Drawing.Size(93, 26);
            this.perDaily.TabIndex = 10;
            this.perDaily.Text = "#perDaily";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "Awareness        =";
            // 
            // awDaily
            // 
            this.awDaily.AutoSize = true;
            this.awDaily.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awDaily.Location = new System.Drawing.Point(194, 391);
            this.awDaily.Name = "awDaily";
            this.awDaily.Size = new System.Drawing.Size(90, 26);
            this.awDaily.TabIndex = 12;
            this.awDaily.Text = "#awDaily";
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
            this.label3.Location = new System.Drawing.Point(206, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Daily";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Weekly";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(501, 290);
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
            this.label13.Size = new System.Drawing.Size(151, 26);
            this.label13.TabIndex = 18;
            this.label13.Text = "Enviornmental =";
            // 
            // eDaily
            // 
            this.eDaily.AutoSize = true;
            this.eDaily.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDaily.Location = new System.Drawing.Point(194, 417);
            this.eDaily.Name = "eDaily";
            this.eDaily.Size = new System.Drawing.Size(75, 26);
            this.eDaily.TabIndex = 19;
            this.eDaily.Text = "#eDaily";
            // 
            // physWeekly
            // 
            this.physWeekly.AutoSize = true;
            this.physWeekly.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physWeekly.Location = new System.Drawing.Point(334, 339);
            this.physWeekly.Name = "physWeekly";
            this.physWeekly.Size = new System.Drawing.Size(125, 26);
            this.physWeekly.TabIndex = 20;
            this.physWeekly.Text = "#physWeekly";
            // 
            // perWeekly
            // 
            this.perWeekly.AutoSize = true;
            this.perWeekly.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perWeekly.Location = new System.Drawing.Point(334, 365);
            this.perWeekly.Name = "perWeekly";
            this.perWeekly.Size = new System.Drawing.Size(113, 26);
            this.perWeekly.TabIndex = 21;
            this.perWeekly.Text = "#perWeekly";
            // 
            // awWeekly
            // 
            this.awWeekly.AutoSize = true;
            this.awWeekly.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awWeekly.Location = new System.Drawing.Point(334, 391);
            this.awWeekly.Name = "awWeekly";
            this.awWeekly.Size = new System.Drawing.Size(110, 26);
            this.awWeekly.TabIndex = 22;
            this.awWeekly.Text = "#awWeekly";
            // 
            // eWeekly
            // 
            this.eWeekly.AutoSize = true;
            this.eWeekly.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eWeekly.Location = new System.Drawing.Point(334, 417);
            this.eWeekly.Name = "eWeekly";
            this.eWeekly.Size = new System.Drawing.Size(95, 26);
            this.eWeekly.TabIndex = 23;
            this.eWeekly.Text = "#eWeekly";
            // 
            // physLifetime
            // 
            this.physLifetime.AutoSize = true;
            this.physLifetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physLifetime.Location = new System.Drawing.Point(501, 339);
            this.physLifetime.Name = "physLifetime";
            this.physLifetime.Size = new System.Drawing.Size(130, 26);
            this.physLifetime.TabIndex = 24;
            this.physLifetime.Text = "#physLifetime";
            // 
            // perLifetime
            // 
            this.perLifetime.AutoSize = true;
            this.perLifetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perLifetime.Location = new System.Drawing.Point(501, 365);
            this.perLifetime.Name = "perLifetime";
            this.perLifetime.Size = new System.Drawing.Size(118, 26);
            this.perLifetime.TabIndex = 25;
            this.perLifetime.Text = "#perLifetime";
            // 
            // awLifetime
            // 
            this.awLifetime.AutoSize = true;
            this.awLifetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awLifetime.Location = new System.Drawing.Point(501, 388);
            this.awLifetime.Name = "awLifetime";
            this.awLifetime.Size = new System.Drawing.Size(115, 26);
            this.awLifetime.TabIndex = 26;
            this.awLifetime.Text = "#awLifetime";
            // 
            // eLifetime
            // 
            this.eLifetime.AutoSize = true;
            this.eLifetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLifetime.Location = new System.Drawing.Point(501, 414);
            this.eLifetime.Name = "eLifetime";
            this.eLifetime.Size = new System.Drawing.Size(100, 26);
            this.eLifetime.TabIndex = 27;
            this.eLifetime.Text = "#eLifetime";
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            this.pieChart.DataSource = this.programBindingSource;
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(418, 117);
            this.pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(183, 141);
            this.pieChart.TabIndex = 28;
            this.pieChart.Text = "chart1";
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
            this.Controls.Add(this.eLifetime);
            this.Controls.Add(this.awLifetime);
            this.Controls.Add(this.perLifetime);
            this.Controls.Add(this.physLifetime);
            this.Controls.Add(this.eWeekly);
            this.Controls.Add(this.awWeekly);
            this.Controls.Add(this.perWeekly);
            this.Controls.Add(this.physWeekly);
            this.Controls.Add(this.eDaily);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalDaily);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.awDaily);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.perDaily);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.physDaily);
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
        private System.Windows.Forms.Label physDaily;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label perDaily;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label awDaily;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalDaily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label eDaily;
        private System.Windows.Forms.Label physWeekly;
        private System.Windows.Forms.Label perWeekly;
        private System.Windows.Forms.Label awWeekly;
        private System.Windows.Forms.Label eWeekly;
        private System.Windows.Forms.Label physLifetime;
        private System.Windows.Forms.Label perLifetime;
        private System.Windows.Forms.Label awLifetime;
        private System.Windows.Forms.Label eLifetime;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.BindingSource programBindingSource;

    }
}

