namespace Paper1
{
    partial class NewResourceForm
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDone = new System.Windows.Forms.Button();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.BoxQuantity = new System.Windows.Forms.TextBox();
            this.CheckListSkills = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Resource";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(11, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(111, 33);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resource Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resource Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Avaliable Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Allocated Skill(s):";
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(347, 378);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(111, 33);
            this.BtnDone.TabIndex = 6;
            this.BtnDone.Text = "Add Resource";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(399, 77);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(180, 31);
            this.BoxName.TabIndex = 7;
            this.BoxName.Text = "Resource name";
            // 
            // ComboType
            // 
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Location = new System.Drawing.Point(399, 117);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(180, 33);
            this.ComboType.TabIndex = 8;
            this.ComboType.Text = "Resource type";
            // 
            // BoxQuantity
            // 
            this.BoxQuantity.Location = new System.Drawing.Point(399, 160);
            this.BoxQuantity.Name = "BoxQuantity";
            this.BoxQuantity.Size = new System.Drawing.Size(180, 31);
            this.BoxQuantity.TabIndex = 9;
            this.BoxQuantity.Text = "Quantity";
            // 
            // CheckListSkills
            // 
            this.CheckListSkills.FormattingEnabled = true;
            this.CheckListSkills.Items.AddRange(new object[] {
            "Cyber Security",
            "Software Solutions",
            "Networking",
            "Web Tech"});
            this.CheckListSkills.Location = new System.Drawing.Point(399, 202);
            this.CheckListSkills.Name = "CheckListSkills";
            this.CheckListSkills.Size = new System.Drawing.Size(180, 116);
            this.CheckListSkills.TabIndex = 11;
            // 
            // NewResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckListSkills);
            this.Controls.Add(this.BoxQuantity);
            this.Controls.Add(this.ComboType);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Name = "NewResourceForm";
            this.Text = "NewResourceForm";
            this.Load += new System.EventHandler(this.NewResourceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BtnBack;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BtnDone;
        private TextBox BoxName;
        private ComboBox ComboType;
        private TextBox BoxQuantity;
        private CheckedListBox CheckListSkills;
    }
}