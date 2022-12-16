namespace Paper1
{
    partial class SignUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxUsername = new System.Windows.Forms.TextBox();
            this.BoxUserId = new System.Windows.Forms.TextBox();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.BoxRePassword = new System.Windows.Forms.TextBox();
            this.ComboUserType = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Account Creation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID (For login):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Re-Enter Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "User Type:";
            // 
            // BoxUsername
            // 
            this.BoxUsername.Location = new System.Drawing.Point(376, 120);
            this.BoxUsername.Name = "BoxUsername";
            this.BoxUsername.Size = new System.Drawing.Size(255, 31);
            this.BoxUsername.TabIndex = 8;
            this.BoxUsername.Text = "User name";
            // 
            // BoxUserId
            // 
            this.BoxUserId.Location = new System.Drawing.Point(376, 163);
            this.BoxUserId.Name = "BoxUserId";
            this.BoxUserId.Size = new System.Drawing.Size(255, 31);
            this.BoxUserId.TabIndex = 9;
            this.BoxUserId.Text = "User ID (minimun 8 characters)";
            // 
            // BoxPassword
            // 
            this.BoxPassword.Location = new System.Drawing.Point(376, 206);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Size = new System.Drawing.Size(255, 31);
            this.BoxPassword.TabIndex = 10;
            this.BoxPassword.Text = "Password";
            // 
            // BoxRePassword
            // 
            this.BoxRePassword.Location = new System.Drawing.Point(376, 249);
            this.BoxRePassword.Name = "BoxRePassword";
            this.BoxRePassword.Size = new System.Drawing.Size(255, 31);
            this.BoxRePassword.TabIndex = 11;
            this.BoxRePassword.Text = "Re-enter password (to confirm)";
            // 
            // ComboUserType
            // 
            this.ComboUserType.FormattingEnabled = true;
            this.ComboUserType.Location = new System.Drawing.Point(376, 292);
            this.ComboUserType.Name = "ComboUserType";
            this.ComboUserType.Size = new System.Drawing.Size(255, 33);
            this.ComboUserType.TabIndex = 12;
            this.ComboUserType.Text = "User type";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(112, 34);
            this.BtnBack.TabIndex = 13;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(309, 359);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(165, 34);
            this.BtnDone.TabIndex = 14;
            this.BtnDone.Text = "Create Account";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.ComboUserType);
            this.Controls.Add(this.BoxRePassword);
            this.Controls.Add(this.BoxPassword);
            this.Controls.Add(this.BoxUserId);
            this.Controls.Add(this.BoxUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox BoxUsername;
        private TextBox BoxUserId;
        private TextBox BoxPassword;
        private TextBox BoxRePassword;
        private ComboBox ComboUserType;
        private Button BtnBack;
        private Button BtnDone;
    }
}