namespace login_form
{
    partial class frmWorker
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
            this.CompleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.lsvDisplay = new System.Windows.Forms.ListView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompleteBtn
            // 
            this.CompleteBtn.Location = new System.Drawing.Point(41, 380);
            this.CompleteBtn.Name = "CompleteBtn";
            this.CompleteBtn.Size = new System.Drawing.Size(146, 43);
            this.CompleteBtn.TabIndex = 7;
            this.CompleteBtn.Text = "Complete";
            this.CompleteBtn.UseVisualStyleBackColor = true;
            this.CompleteBtn.Click += new System.EventHandler(this.CompleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "My Requests";
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.Location = new System.Drawing.Point(613, 304);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(146, 43);
            this.SignOutBtn.TabIndex = 10;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = true;
            this.SignOutBtn.Click += new System.EventHandler(this.SignOutBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(613, 353);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(146, 43);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(121, 330);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(99, 22);
            this.txtRequestID.TabIndex = 11;
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Location = new System.Drawing.Point(38, 333);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(77, 16);
            this.lblRequestID.TabIndex = 12;
            this.lblRequestID.Text = "Request ID:";
            this.lblRequestID.Click += new System.EventHandler(this.label2_Click);
            // 
            // lsvDisplay
            // 
            this.lsvDisplay.HideSelection = false;
            this.lsvDisplay.Location = new System.Drawing.Point(12, 72);
            this.lsvDisplay.Name = "lsvDisplay";
            this.lsvDisplay.Size = new System.Drawing.Size(776, 226);
            this.lsvDisplay.TabIndex = 13;
            this.lsvDisplay.UseCompatibleStateImageBehavior = false;
            this.lsvDisplay.View = System.Windows.Forms.View.Details;
            this.lsvDisplay.SelectedIndexChanged += new System.EventHandler(this.lsvDisplay_SelectedIndexChanged);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(613, 402);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(146, 43);
            this.EditBtn.TabIndex = 14;
            this.EditBtn.Text = "Edit Profile";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // frmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.lsvDisplay);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.txtRequestID);
            this.Controls.Add(this.CompleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignOutBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "frmWorker";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CompleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.ListView lsvDisplay;
        private System.Windows.Forms.Button EditBtn;
    }
}