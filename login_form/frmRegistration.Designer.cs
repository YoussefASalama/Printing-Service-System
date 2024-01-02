namespace Registration
{
    partial class frmRegistration
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(280, 102);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(212, 22);
            this.nameTxtBox.TabIndex = 0;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(280, 147);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(212, 22);
            this.emailTxtBox.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(280, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 22);
            this.textBox3.TabIndex = 3;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(280, 249);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(212, 22);
            this.PasswordTxtBox.TabIndex = 4;
            this.PasswordTxtBox.UseSystemPasswordChar = true;
            this.PasswordTxtBox.TextChanged += new System.EventHandler(this.PasswordTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(215, 147);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(204, 255);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Role:";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Manager",
            "Customer",
            "Worker"});
            this.RoleComboBox.Location = new System.Drawing.Point(280, 301);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(212, 24);
            this.RoleComboBox.TabIndex = 10;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(376, 363);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(176, 62);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 48);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Register A New User";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 62);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "frmRegistration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button btnCancel;
    }
}

