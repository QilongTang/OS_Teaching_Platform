namespace OSM.Forms
{
    partial class F_DoExperiment
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
            this.components = new System.ComponentModel.Container();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.butExperimentView = new System.Windows.Forms.Button();
            this.butPic = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butAccept = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRunning = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtALG = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cb_ChapterName = new System.Windows.Forms.ComboBox();
            this.tbChapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_BSDataSet = new OSM.db_BSDataSet();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelChapterName = new System.Windows.Forms.Label();
            this.labelStudentNum = new System.Windows.Forms.Label();
            this.tb_ChapterTableAdapter = new OSM.db_BSDataSetTableAdapters.tb_ChapterTableAdapter();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.butExperimentView);
            this.groupBox6.Controls.Add(this.butPic);
            this.groupBox6.Controls.Add(this.butClose);
            this.groupBox6.Controls.Add(this.butClear);
            this.groupBox6.Controls.Add(this.butAccept);
            this.groupBox6.Location = new System.Drawing.Point(60, 557);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(633, 42);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "操作";
            // 
            // butExperimentView
            // 
            this.butExperimentView.Location = new System.Drawing.Point(485, 13);
            this.butExperimentView.Name = "butExperimentView";
            this.butExperimentView.Size = new System.Drawing.Size(86, 23);
            this.butExperimentView.TabIndex = 11;
            this.butExperimentView.Text = "查看实验详情";
            this.butExperimentView.UseVisualStyleBackColor = true;
            this.butExperimentView.Click += new System.EventHandler(this.butExperimentView_Click);
            // 
            // butPic
            // 
            this.butPic.Location = new System.Drawing.Point(374, 13);
            this.butPic.Name = "butPic";
            this.butPic.Size = new System.Drawing.Size(75, 23);
            this.butPic.TabIndex = 10;
            this.butPic.Text = "提交图片";
            this.butPic.UseVisualStyleBackColor = true;
            this.butPic.Click += new System.EventHandler(this.butPic_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(265, 13);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 9;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(156, 13);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 8;
            this.butClear.Text = "清空";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butAccept
            // 
            this.butAccept.Location = new System.Drawing.Point(50, 13);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(73, 23);
            this.butAccept.TabIndex = 7;
            this.butAccept.Text = "提交";
            this.butAccept.UseVisualStyleBackColor = true;
            this.butAccept.Click += new System.EventHandler(this.butAccept_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtQuestion);
            this.groupBox5.Location = new System.Drawing.Point(60, 467);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(633, 84);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "问题与收获:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(27, 20);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(590, 60);
            this.txtQuestion.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtRunning);
            this.groupBox4.Location = new System.Drawing.Point(60, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(633, 91);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "运行结果:";
            // 
            // txtRunning
            // 
            this.txtRunning.Location = new System.Drawing.Point(28, 20);
            this.txtRunning.Multiline = true;
            this.txtRunning.Name = "txtRunning";
            this.txtRunning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRunning.Size = new System.Drawing.Size(590, 65);
            this.txtRunning.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtALG);
            this.groupBox3.Location = new System.Drawing.Point(60, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 144);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "算法设计:";
            // 
            // txtALG
            // 
            this.txtALG.Location = new System.Drawing.Point(27, 20);
            this.txtALG.Multiline = true;
            this.txtALG.Name = "txtALG";
            this.txtALG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtALG.Size = new System.Drawing.Size(591, 107);
            this.txtALG.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Location = new System.Drawing.Point(60, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 61);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "问题描述:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(27, 20);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(590, 35);
            this.txtDescription.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Location = new System.Drawing.Point(60, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 46);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实验题目:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(27, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(590, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(83, 54);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(223, 21);
            this.txtTime.TabIndex = 14;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(30, 57);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 12);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "日期:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtTime);
            this.groupBox8.Controls.Add(this.labelDate);
            this.groupBox8.Controls.Add(this.cb_ChapterName);
            this.groupBox8.Controls.Add(this.txtStudentNum);
            this.groupBox8.Controls.Add(this.txtStudentName);
            this.groupBox8.Controls.Add(this.labelStudentName);
            this.groupBox8.Controls.Add(this.labelChapterName);
            this.groupBox8.Controls.Add(this.labelStudentNum);
            this.groupBox8.Location = new System.Drawing.Point(60, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(633, 83);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "基本信息:";
            // 
            // cb_ChapterName
            // 
            this.cb_ChapterName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbChapterBindingSource, "IDC", true));
            this.cb_ChapterName.DataSource = this.tbChapterBindingSource;
            this.cb_ChapterName.DisplayMember = "name";
            this.cb_ChapterName.FormattingEnabled = true;
            this.cb_ChapterName.Location = new System.Drawing.Point(83, 25);
            this.cb_ChapterName.Name = "cb_ChapterName";
            this.cb_ChapterName.Size = new System.Drawing.Size(223, 20);
            this.cb_ChapterName.TabIndex = 20;
            this.cb_ChapterName.ValueMember = "IDC";
            // 
            // tbChapterBindingSource
            // 
            this.tbChapterBindingSource.DataMember = "tb_Chapter";
            this.tbChapterBindingSource.DataSource = this.db_BSDataSet;
            // 
            // db_BSDataSet
            // 
            this.db_BSDataSet.DataSetName = "db_BSDataSet";
            this.db_BSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(387, 24);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(211, 21);
            this.txtStudentNum.TabIndex = 19;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(387, 54);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(80, 21);
            this.txtStudentName.TabIndex = 18;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(334, 57);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(47, 12);
            this.labelStudentName.TabIndex = 16;
            this.labelStudentName.Text = "学生名:";
            // 
            // labelChapterName
            // 
            this.labelChapterName.AutoSize = true;
            this.labelChapterName.Location = new System.Drawing.Point(30, 28);
            this.labelChapterName.Name = "labelChapterName";
            this.labelChapterName.Size = new System.Drawing.Size(47, 12);
            this.labelChapterName.TabIndex = 15;
            this.labelChapterName.Text = "章节名:";
            // 
            // labelStudentNum
            // 
            this.labelStudentNum.AutoSize = true;
            this.labelStudentNum.Location = new System.Drawing.Point(334, 28);
            this.labelStudentNum.Name = "labelStudentNum";
            this.labelStudentNum.Size = new System.Drawing.Size(35, 12);
            this.labelStudentNum.TabIndex = 13;
            this.labelStudentNum.Text = "学号:";
            // 
            // tb_ChapterTableAdapter
            // 
            this.tb_ChapterTableAdapter.ClearBeforeFill = true;
            // 
            // F_DoExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 666);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_DoExperiment";
            this.Text = "F_DoExperiment";
            this.Load += new System.EventHandler(this.F_DoExperiment_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button butPic;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butAccept;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtRunning;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtALG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cb_ChapterName;
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelChapterName;
        private System.Windows.Forms.Label labelStudentNum;
        private db_BSDataSet db_BSDataSet;
        private System.Windows.Forms.BindingSource tbChapterBindingSource;
        private db_BSDataSetTableAdapters.tb_ChapterTableAdapter tb_ChapterTableAdapter;
        private System.Windows.Forms.Button butExperimentView;
    }
}