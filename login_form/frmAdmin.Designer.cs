namespace Report_Income
{
    partial class frmAdmin
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnVReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPickMonth = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lsvDisplay = new System.Windows.Forms.ListView();
            this.RequestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServiceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(13, 296);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(114, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Total Income:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(133, 296);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(71, 20);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "RM 0.00";
            // 
            // btnVReport
            // 
            this.btnVReport.Location = new System.Drawing.Point(3, 206);
            this.btnVReport.Name = "btnVReport";
            this.btnVReport.Size = new System.Drawing.Size(111, 29);
            this.btnVReport.TabIndex = 4;
            this.btnVReport.Text = "View Report";
            this.btnVReport.UseVisualStyleBackColor = true;
            this.btnVReport.Click += new System.EventHandler(this.btnVReport_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "View Income";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPickMonth);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnVReport);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 258);
            this.panel1.TabIndex = 6;
            // 
            // lblPickMonth
            // 
            this.lblPickMonth.AutoSize = true;
            this.lblPickMonth.Location = new System.Drawing.Point(3, 15);
            this.lblPickMonth.Name = "lblPickMonth";
            this.lblPickMonth.Size = new System.Drawing.Size(86, 16);
            this.lblPickMonth.TabIndex = 12;
            this.lblPickMonth.Text = "Pick a month:";
            this.lblPickMonth.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(3, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lsvDisplay
            // 
            this.lsvDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RequestID,
            this.ServiceType});
            this.lsvDisplay.FullRowSelect = true;
            this.lsvDisplay.HideSelection = false;
            this.lsvDisplay.Location = new System.Drawing.Point(282, 12);
            this.lsvDisplay.Name = "lsvDisplay";
            this.lsvDisplay.Size = new System.Drawing.Size(464, 378);
            this.lsvDisplay.TabIndex = 11;
            this.lsvDisplay.UseCompatibleStateImageBehavior = false;
            this.lsvDisplay.View = System.Windows.Forms.View.Details;
            this.lsvDisplay.SelectedIndexChanged += new System.EventHandler(this.lsvDisplay_SelectedIndexChanged);
            // 
            // RequestID
            // 
            this.RequestID.Text = "RequestID";
            this.RequestID.Width = 90;
            // 
            // ServiceType
            // 
            this.ServiceType.Text = "ServiceType";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 29);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(145, 361);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(115, 29);
            this.btnSignOut.TabIndex = 14;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(144, 326);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(115, 29);
            this.btnAddNewUser.TabIndex = 15;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 402);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lsvDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lbl1);
            this.Name = "frmAdmin";
            this.Text = "Report and Income";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnVReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lsvDisplay;
        private System.Windows.Forms.ColumnHeader RequestID;
        private System.Windows.Forms.ColumnHeader ServiceType;
        private System.Windows.Forms.Label lblPickMonth;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnAddNewUser;
    }
}

