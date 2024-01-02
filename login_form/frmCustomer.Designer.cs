namespace Assignment
{
    partial class frmCustomer
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.grpAddNew = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.lblUrgent = new System.Windows.Forms.Label();
            this.cboUrgent = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.lblBinding = new System.Windows.Forms.Label();
            this.cboBinding = new System.Windows.Forms.ComboBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lsvDisplay = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(32, 36);
            this.cboType.Margin = new System.Windows.Forms.Padding(4);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(160, 24);
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // grpAddNew
            // 
            this.grpAddNew.Controls.Add(this.lblTotal);
            this.grpAddNew.Controls.Add(this.btnAddRequest);
            this.grpAddNew.Controls.Add(this.lblUrgent);
            this.grpAddNew.Controls.Add(this.cboUrgent);
            this.grpAddNew.Controls.Add(this.lblColor);
            this.grpAddNew.Controls.Add(this.cboColor);
            this.grpAddNew.Controls.Add(this.lblBinding);
            this.grpAddNew.Controls.Add(this.cboBinding);
            this.grpAddNew.Controls.Add(this.lblPages);
            this.grpAddNew.Controls.Add(this.txtPages);
            this.grpAddNew.Controls.Add(this.cboType);
            this.grpAddNew.Location = new System.Drawing.Point(16, 171);
            this.grpAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddNew.Name = "grpAddNew";
            this.grpAddNew.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddNew.Size = new System.Drawing.Size(665, 368);
            this.grpAddNew.TabIndex = 2;
            this.grpAddNew.TabStop = false;
            this.grpAddNew.Text = "Add New Request";
            this.grpAddNew.Enter += new System.EventHandler(this.grpAddNew_Enter);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(79, 295);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total: ";
            this.lblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(440, 273);
            this.btnAddRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(161, 59);
            this.btnAddRequest.TabIndex = 10;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUrgent
            // 
            this.lblUrgent.AutoSize = true;
            this.lblUrgent.Location = new System.Drawing.Point(365, 187);
            this.lblUrgent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrgent.Name = "lblUrgent";
            this.lblUrgent.Size = new System.Drawing.Size(61, 16);
            this.lblUrgent.TabIndex = 9;
            this.lblUrgent.Text = "Urgency:";
            this.lblUrgent.Click += new System.EventHandler(this.lblUrgent_Click);
            // 
            // cboUrgent
            // 
            this.cboUrgent.FormattingEnabled = true;
            this.cboUrgent.Items.AddRange(new object[] {
            "Urgent",
            "Not Urgent"});
            this.cboUrgent.Location = new System.Drawing.Point(440, 183);
            this.cboUrgent.Margin = new System.Windows.Forms.Padding(4);
            this.cboUrgent.Name = "cboUrgent";
            this.cboUrgent.Size = new System.Drawing.Size(160, 24);
            this.cboUrgent.TabIndex = 8;
            this.cboUrgent.SelectedIndexChanged += new System.EventHandler(this.cboUrgent_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(376, 102);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 16);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color:";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "Color",
            "Black and White"});
            this.cboColor.Location = new System.Drawing.Point(440, 98);
            this.cboColor.Margin = new System.Windows.Forms.Padding(4);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(160, 24);
            this.cboColor.TabIndex = 6;
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.cboColor_SelectedIndexChanged);
            // 
            // lblBinding
            // 
            this.lblBinding.AutoSize = true;
            this.lblBinding.Location = new System.Drawing.Point(21, 187);
            this.lblBinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBinding.Name = "lblBinding";
            this.lblBinding.Size = new System.Drawing.Size(55, 16);
            this.lblBinding.TabIndex = 5;
            this.lblBinding.Text = "Binding:";
            // 
            // cboBinding
            // 
            this.cboBinding.FormattingEnabled = true;
            this.cboBinding.Items.AddRange(new object[] {
            "Comb Binding",
            "Thick Cover"});
            this.cboBinding.Location = new System.Drawing.Point(83, 183);
            this.cboBinding.Margin = new System.Windows.Forms.Padding(4);
            this.cboBinding.Name = "cboBinding";
            this.cboBinding.Size = new System.Drawing.Size(160, 24);
            this.cboBinding.TabIndex = 4;
            this.cboBinding.SelectedIndexChanged += new System.EventHandler(this.cboBinding_SelectedIndexChanged);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(21, 102);
            this.lblPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(50, 16);
            this.lblPages.TabIndex = 3;
            this.lblPages.Text = "Pages:";
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(83, 98);
            this.txtPages.Margin = new System.Windows.Forms.Padding(4);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(160, 22);
            this.txtPages.TabIndex = 2;
            this.txtPages.TextChanged += new System.EventHandler(this.txtPages_TextChanged);
            // 
            // lsvDisplay
            // 
            this.lsvDisplay.FullRowSelect = true;
            this.lsvDisplay.GridLines = true;
            this.lsvDisplay.HideSelection = false;
            this.lsvDisplay.Location = new System.Drawing.Point(16, 15);
            this.lsvDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.lsvDisplay.Name = "lsvDisplay";
            this.lsvDisplay.Size = new System.Drawing.Size(851, 148);
            this.lsvDisplay.TabIndex = 13;
            this.lsvDisplay.UseCompatibleStateImageBehavior = false;
            this.lsvDisplay.View = System.Windows.Forms.View.Details;
            this.lsvDisplay.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(707, 480);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 59);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(707, 414);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(161, 59);
            this.btnSignOut.TabIndex = 14;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(688, 207);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(168, 39);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome,";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(707, 347);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 59);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit Account";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 564);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lsvDisplay);
            this.Controls.Add(this.grpAddNew);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddNew.ResumeLayout(false);
            this.grpAddNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.GroupBox grpAddNew;
        private System.Windows.Forms.Label lblBinding;
        private System.Windows.Forms.ComboBox cboBinding;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label lblUrgent;
        private System.Windows.Forms.ComboBox cboUrgent;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddRequest;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView lsvDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnEdit;
    }
}

