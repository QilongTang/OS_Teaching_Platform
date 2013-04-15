namespace OSM.Forms
{
    partial class F_Lock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Lock));
            this.labelLocking = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.butAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLocking
            // 
            this.labelLocking.AutoSize = true;
            this.labelLocking.Location = new System.Drawing.Point(143, 133);
            this.labelLocking.Name = "labelLocking";
            this.labelLocking.Size = new System.Drawing.Size(65, 12);
            this.labelLocking.TabIndex = 1;
            this.labelLocking.Text = "程序锁定中";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(54, 151);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(35, 12);
            this.labelPwd.TabIndex = 2;
            this.labelPwd.Text = "密码:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(95, 148);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(166, 21);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // butAccept
            // 
            this.butAccept.Location = new System.Drawing.Point(56, 190);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(75, 23);
            this.butAccept.TabIndex = 4;
            this.butAccept.Text = "解锁";
            this.butAccept.UseVisualStyleBackColor = true;
            this.butAccept.Click += new System.EventHandler(this.butAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(235, 190);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(145, 190);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 6;
            this.butClear.Text = "清空";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 98);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // F_Lock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 254);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.butAccept);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelLocking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Lock";
            this.Text = "F_Lock";
            this.Load += new System.EventHandler(this.F_Lock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocking;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button butAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}