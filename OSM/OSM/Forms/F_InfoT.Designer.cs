﻿namespace OSM.Forms
{
    partial class F_InfoT
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butConfirm = new System.Windows.Forms.Button();
            this.butAmend = new System.Windows.Forms.Button();
            this.butCLose = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Info_sex = new System.Windows.Forms.ComboBox();
            this.Info_ID = new System.Windows.Forms.TextBox();
            this.Info_Email = new System.Windows.Forms.TextBox();
            this.Info_class = new System.Windows.Forms.TextBox();
            this.Info_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butConfirm);
            this.groupBox2.Controls.Add(this.butAmend);
            this.groupBox2.Controls.Add(this.butCLose);
            this.groupBox2.Controls.Add(this.butCancel);
            this.groupBox2.Location = new System.Drawing.Point(138, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(135, 21);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 25);
            this.butConfirm.TabIndex = 4;
            this.butConfirm.Text = "Confirm";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // butAmend
            // 
            this.butAmend.Location = new System.Drawing.Point(23, 22);
            this.butAmend.Name = "butAmend";
            this.butAmend.Size = new System.Drawing.Size(75, 25);
            this.butAmend.TabIndex = 2;
            this.butAmend.Text = "Modify";
            this.butAmend.UseVisualStyleBackColor = true;
            this.butAmend.Click += new System.EventHandler(this.butAmend_Click);
            // 
            // butCLose
            // 
            this.butCLose.Location = new System.Drawing.Point(373, 21);
            this.butCLose.Name = "butCLose";
            this.butCLose.Size = new System.Drawing.Size(75, 25);
            this.butCLose.TabIndex = 3;
            this.butCLose.Text = "Close";
            this.butCLose.Click += new System.EventHandler(this.butCLose_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(255, 21);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 25);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Info_sex);
            this.groupBox1.Controls.Add(this.Info_ID);
            this.groupBox1.Controls.Add(this.Info_Email);
            this.groupBox1.Controls.Add(this.Info_class);
            this.groupBox1.Controls.Add(this.Info_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(138, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory Information";
            // 
            // Info_sex
            // 
            this.Info_sex.FormattingEnabled = true;
            this.Info_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Info_sex.Location = new System.Drawing.Point(215, 27);
            this.Info_sex.Name = "Info_sex";
            this.Info_sex.Size = new System.Drawing.Size(46, 21);
            this.Info_sex.TabIndex = 13;
            // 
            // Info_ID
            // 
            this.Info_ID.Location = new System.Drawing.Point(348, 27);
            this.Info_ID.Name = "Info_ID";
            this.Info_ID.Size = new System.Drawing.Size(98, 20);
            this.Info_ID.TabIndex = 12;
            // 
            // Info_Email
            // 
            this.Info_Email.Location = new System.Drawing.Point(267, 65);
            this.Info_Email.Name = "Info_Email";
            this.Info_Email.Size = new System.Drawing.Size(179, 20);
            this.Info_Email.TabIndex = 10;
            // 
            // Info_class
            // 
            this.Info_class.Location = new System.Drawing.Point(57, 65);
            this.Info_class.Name = "Info_class";
            this.Info_class.Size = new System.Drawing.Size(133, 20);
            this.Info_class.TabIndex = 8;
            // 
            // Info_name
            // 
            this.Info_name.Location = new System.Drawing.Point(57, 27);
            this.Info_name.Name = "Info_name";
            this.Info_name.Size = new System.Drawing.Size(92, 20);
            this.Info_name.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TeacherNum:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // F_InfoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_InfoT";
            this.Text = "Personal Info";
            this.Load += new System.EventHandler(this.F_InfoT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butConfirm;
        private System.Windows.Forms.Button butAmend;
        private System.Windows.Forms.Button butCLose;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Info_sex;
        private System.Windows.Forms.TextBox Info_ID;
        private System.Windows.Forms.TextBox Info_Email;
        private System.Windows.Forms.TextBox Info_class;
        private System.Windows.Forms.TextBox Info_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}