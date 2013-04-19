namespace OSM.Forms
{
    partial class F_GiveMark
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
            this.butOpenWord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMark = new System.Windows.Forms.MaskedTextBox();
            this.butPic = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.txtEvaluation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.butAmend = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRunning = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtALG = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_ChapterName = new System.Windows.Forms.ComboBox();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // butOpenWord
            // 
            this.butOpenWord.Location = new System.Drawing.Point(326, 13);
            this.butOpenWord.Name = "butOpenWord";
            this.butOpenWord.Size = new System.Drawing.Size(90, 25);
            this.butOpenWord.TabIndex = 2;
            this.butOpenWord.Text = "Doc Attached";
            this.butOpenWord.UseVisualStyleBackColor = true;
            this.butOpenWord.Click += new System.EventHandler(this.butOpenWord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMark);
            this.groupBox1.Controls.Add(this.butPic);
            this.groupBox1.Controls.Add(this.butClose);
            this.groupBox1.Controls.Add(this.txtEvaluation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.butAmend);
            this.groupBox1.Controls.Add(this.butOK);
            this.groupBox1.Controls.Add(this.butOpenWord);
            this.groupBox1.Location = new System.Drawing.Point(62, 587);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(83, 15);
            this.txtMark.Mask = "999";
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 29;
            // 
            // butPic
            // 
            this.butPic.Location = new System.Drawing.Point(238, 13);
            this.butPic.Name = "butPic";
            this.butPic.Size = new System.Drawing.Size(82, 25);
            this.butPic.TabIndex = 11;
            this.butPic.Text = "Pics Attached";
            this.butPic.UseVisualStyleBackColor = true;
            this.butPic.Click += new System.EventHandler(this.butPic_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(527, 13);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 25);
            this.butClose.TabIndex = 10;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // txtEvaluation
            // 
            this.txtEvaluation.Location = new System.Drawing.Point(83, 44);
            this.txtEvaluation.Name = "txtEvaluation";
            this.txtEvaluation.Size = new System.Drawing.Size(333, 20);
            this.txtEvaluation.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Review:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grade:";
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(527, 42);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 25);
            this.butCancel.TabIndex = 6;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butAmend
            // 
            this.butAmend.Location = new System.Drawing.Point(434, 42);
            this.butAmend.Name = "butAmend";
            this.butAmend.Size = new System.Drawing.Size(75, 25);
            this.butAmend.TabIndex = 5;
            this.butAmend.Text = "Modify";
            this.butAmend.UseVisualStyleBackColor = true;
            this.butAmend.Click += new System.EventHandler(this.butAmend_Click);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(434, 13);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 25);
            this.butOK.TabIndex = 4;
            this.butOK.Text = "Confirm";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtQuestion);
            this.groupBox5.Location = new System.Drawing.Point(62, 490);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(633, 91);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Questions and Gains:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(27, 22);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(590, 65);
            this.txtQuestion.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtRunning);
            this.groupBox4.Location = new System.Drawing.Point(62, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(633, 99);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ALG Outcome:";
            // 
            // txtRunning
            // 
            this.txtRunning.Location = new System.Drawing.Point(28, 22);
            this.txtRunning.Multiline = true;
            this.txtRunning.Name = "txtRunning";
            this.txtRunning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRunning.Size = new System.Drawing.Size(590, 70);
            this.txtRunning.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtALG);
            this.groupBox3.Location = new System.Drawing.Point(62, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 145);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ALG Design:";
            // 
            // txtALG
            // 
            this.txtALG.Location = new System.Drawing.Point(27, 22);
            this.txtALG.Multiline = true;
            this.txtALG.Name = "txtALG";
            this.txtALG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtALG.Size = new System.Drawing.Size(591, 116);
            this.txtALG.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Location = new System.Drawing.Point(62, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 66);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Problem Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(27, 22);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(590, 38);
            this.txtDescription.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtTime);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.cb_ChapterName);
            this.groupBox8.Controls.Add(this.txtStudentNum);
            this.groupBox8.Controls.Add(this.txtStudentName);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(62, 18);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(633, 75);
            this.groupBox8.TabIndex = 28;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Basic Info";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(83, 43);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(223, 20);
            this.txtTime.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date:";
            // 
            // cb_ChapterName
            // 
            this.cb_ChapterName.DisplayMember = "name";
            this.cb_ChapterName.FormattingEnabled = true;
            this.cb_ChapterName.Location = new System.Drawing.Point(83, 15);
            this.cb_ChapterName.Name = "cb_ChapterName";
            this.cb_ChapterName.Size = new System.Drawing.Size(223, 21);
            this.cb_ChapterName.TabIndex = 20;
            this.cb_ChapterName.ValueMember = "IDC";
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(387, 15);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(211, 20);
            this.txtStudentNum.TabIndex = 19;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(387, 43);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(80, 20);
            this.txtStudentName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "StudentName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ChapterName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "StudentNum:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTitle);
            this.groupBox6.Location = new System.Drawing.Point(62, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(633, 50);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ExperimentName:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(27, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(590, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // F_GiveMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 722);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_GiveMark";
            this.Text = "Grade Report";
            this.Load += new System.EventHandler(this.F_GiveMark_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOpenWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butAmend;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.TextBox txtEvaluation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtRunning;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtALG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button butPic;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_ChapterName;
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.MaskedTextBox txtMark;
    }
}