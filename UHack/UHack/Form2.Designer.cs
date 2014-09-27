namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.dailyTotal = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolbarText = new System.Windows.Forms.ToolStripStatusLabel();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.socialLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.environmentalLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.physicalLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emotionalLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyTotal
            // 
            this.dailyTotal.AutoSize = true;
            this.dailyTotal.BackColor = System.Drawing.Color.Transparent;
            this.dailyTotal.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyTotal.ForeColor = System.Drawing.Color.White;
            this.dailyTotal.Location = new System.Drawing.Point(-3, 444);
            this.dailyTotal.Name = "dailyTotal";
            this.dailyTotal.Size = new System.Drawing.Size(239, 59);
            this.dailyTotal.TabIndex = 1;
            this.dailyTotal.Text = "Daily Total:";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.Color.White;
            this.pointsLabel.Location = new System.Drawing.Point(222, 444);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(49, 59);
            this.pointsLabel.TabIndex = 2;
            this.pointsLabel.Text = "0";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(12, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(148, 33);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "placeholder";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(851, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "Select an Achievement!";
            // 
            // toolbarText
            // 
            this.toolbarText.Name = "toolbarText";
            this.toolbarText.Size = new System.Drawing.Size(130, 17);
            this.toolbarText.Text = "Select an Achievement!";
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.layoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.Controls.Add(this.panel4, 1, 1);
            this.layoutPanel.Controls.Add(this.panel3, 0, 1);
            this.layoutPanel.Controls.Add(this.panel2, 1, 0);
            this.layoutPanel.Controls.Add(this.panel1, 0, 0);
            this.layoutPanel.Location = new System.Drawing.Point(18, 143);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 2;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.Size = new System.Drawing.Size(629, 261);
            this.layoutPanel.MouseEnter += new System.EventHandler(this.layoutPanel_MouseEnter);
            this.layoutPanel.MouseLeave += new System.EventHandler(this.layoutPanel_MouseLeave);
            this.layoutPanel.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.Controls.Add(this.socialLabel);
            this.panel4.Location = new System.Drawing.Point(319, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 120);
            this.panel4.TabIndex = 1;
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            // 
            // socialLabel
            // 
            this.socialLabel.AutoSize = true;
            this.socialLabel.BackColor = System.Drawing.Color.Transparent;
            this.socialLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socialLabel.ForeColor = System.Drawing.Color.White;
            this.socialLabel.Location = new System.Drawing.Point(17, 21);
            this.socialLabel.Name = "socialLabel";
            this.socialLabel.Size = new System.Drawing.Size(83, 36);
            this.socialLabel.TabIndex = 3;
            this.socialLabel.Text = "Social";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumBlue;
            this.panel3.Controls.Add(this.environmentalLabel);
            this.panel3.Location = new System.Drawing.Point(6, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 120);
            this.panel3.TabIndex = 6;
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // environmentalLabel
            // 
            this.environmentalLabel.AutoSize = true;
            this.environmentalLabel.BackColor = System.Drawing.Color.Transparent;
            this.environmentalLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.environmentalLabel.ForeColor = System.Drawing.Color.White;
            this.environmentalLabel.Location = new System.Drawing.Point(18, 21);
            this.environmentalLabel.Name = "environmentalLabel";
            this.environmentalLabel.Size = new System.Drawing.Size(187, 36);
            this.environmentalLabel.TabIndex = 2;
            this.environmentalLabel.Text = "Environmental";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.physicalLabel);
            this.panel2.Location = new System.Drawing.Point(319, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 120);
            this.panel2.TabIndex = 1;
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // physicalLabel
            // 
            this.physicalLabel.AutoSize = true;
            this.physicalLabel.BackColor = System.Drawing.Color.Transparent;
            this.physicalLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalLabel.ForeColor = System.Drawing.Color.White;
            this.physicalLabel.Location = new System.Drawing.Point(17, 16);
            this.physicalLabel.Name = "physicalLabel";
            this.physicalLabel.Size = new System.Drawing.Size(108, 36);
            this.physicalLabel.TabIndex = 1;
            this.physicalLabel.Text = "Physical";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.emotionalLabel);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 120);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // emotionalLabel
            // 
            this.emotionalLabel.AutoSize = true;
            this.emotionalLabel.BackColor = System.Drawing.Color.Transparent;
            this.emotionalLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emotionalLabel.ForeColor = System.Drawing.Color.White;
            this.emotionalLabel.Location = new System.Drawing.Point(18, 16);
            this.emotionalLabel.Name = "emotionalLabel";
            this.emotionalLabel.Size = new System.Drawing.Size(134, 36);
            this.emotionalLabel.TabIndex = 0;
            this.emotionalLabel.Text = "Emotional";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.stance4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 525);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.dailyTotal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Stance";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.layoutPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dailyTotal;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolbarText;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label socialLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label environmentalLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label physicalLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label emotionalLabel;
    }
}