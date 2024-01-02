namespace login_form
{
    partial class frmManager
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
            this.lvRequest = new System.Windows.Forms.ListView();
            this.lvWorker = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Workers";
            // 
            // lvRequest
            // 
            this.lvRequest.HideSelection = false;
            this.lvRequest.Location = new System.Drawing.Point(39, 68);
            this.lvRequest.Name = "lvRequest";
            this.lvRequest.Size = new System.Drawing.Size(460, 266);
            this.lvRequest.TabIndex = 2;
            this.lvRequest.UseCompatibleStateImageBehavior = false;
            this.lvRequest.View = System.Windows.Forms.View.Details;
            this.lvRequest.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lvWorker
            // 
            this.lvWorker.HideSelection = false;
            this.lvWorker.Location = new System.Drawing.Point(559, 68);
            this.lvWorker.Name = "lvWorker";
            this.lvWorker.Size = new System.Drawing.Size(189, 265);
            this.lvWorker.TabIndex = 3;
            this.lvWorker.UseCompatibleStateImageBehavior = false;
            this.lvWorker.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 4;
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(47, 374);
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(152, 22);
            this.textBoxRequest.TabIndex = 5;
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(232, 375);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(148, 22);
            this.textBoxWorker.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(44, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sign Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(661, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "RequestID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Worker Name";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(661, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 36);
            this.button4.TabIndex = 12;
            this.button4.Text = "Edit Profile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxWorker);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvWorker);
            this.Controls.Add(this.lvRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvRequest;
        private System.Windows.Forms.ListView lvWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
    }
}