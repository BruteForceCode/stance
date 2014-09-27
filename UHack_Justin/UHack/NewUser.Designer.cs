namespace WindowsFormsApplication1
{
    partial class NewUser
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(63, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(247, 82);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "STANCE";
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.firstLabel.ForeColor = System.Drawing.Color.White;
            this.firstLabel.Location = new System.Drawing.Point(48, 102);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(111, 27);
            this.firstLabel.TabIndex = 1;
            this.firstLabel.Text = "First Name";
            this.firstLabel.Click += new System.EventHandler(this.firstLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // createAccount
            // 
            this.createAccount.BackColor = System.Drawing.Color.Maroon;
            this.createAccount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccount.ForeColor = System.Drawing.Color.White;
            this.createAccount.Location = new System.Drawing.Point(85, 197);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(202, 45);
            this.createAccount.TabIndex = 3;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = false;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.White;
            this.firstName.Location = new System.Drawing.Point(175, 108);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(134, 20);
            this.firstName.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.White;
            this.lastName.Location = new System.Drawing.Point(175, 151);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(134, 20);
            this.lastName.TabIndex = 5;
            // 
            // entryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 272);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "entryForm";
            this.Text = "PlaceHolder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
    }
}

