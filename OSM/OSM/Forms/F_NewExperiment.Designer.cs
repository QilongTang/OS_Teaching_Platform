namespace OSM.Forms
{
    partial class F_NewExperiment
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butGetChapterNum = new System.Windows.Forms.Button();
            this.txtExperimentNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPreparation = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtGuidance = new System.Windows.Forms.TextBox();
            this.butAccept = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.butDoExperiment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtTeacherNum = new System.Windows.Forms.TextBox();
            this.cb_ChapterNum = new System.Windows.Forms.ComboBox();
            this.tbChapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_BSDataSet = new OSM.db_BSDataSet();
            this.cb_ChapterName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dbBSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ChapterTableAdapter = new OSM.db_BSDataSetTableAdapters.tb_ChapterTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBSDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(31, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(444, 21);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.butGetChapterNum);
            this.groupBox1.Controls.Add(this.txtExperimentNum);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Location = new System.Drawing.Point(44, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实验题目:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "实验编号:";
            // 
            // butGetChapterNum
            // 
            this.butGetChapterNum.Location = new System.Drawing.Point(581, 20);
            this.butGetChapterNum.Name = "butGetChapterNum";
            this.butGetChapterNum.Size = new System.Drawing.Size(36, 23);
            this.butGetChapterNum.TabIndex = 23;
            this.butGetChapterNum.Text = "Get";
            this.butGetChapterNum.UseVisualStyleBackColor = true;
            this.butGetChapterNum.Click += new System.EventHandler(this.butGetChapterNum_Click);
            // 
            // txtExperimentNum
            // 
            this.txtExperimentNum.Location = new System.Drawing.Point(545, 20);
            this.txtExperimentNum.Name = "txtExperimentNum";
            this.txtExperimentNum.Size = new System.Drawing.Size(23, 21);
            this.txtExperimentNum.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPurpose);
            this.groupBox2.Location = new System.Drawing.Point(44, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "实验目的:";
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(27, 20);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPurpose.Size = new System.Drawing.Size(590, 35);
            this.txtPurpose.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDetail);
            this.groupBox3.Location = new System.Drawing.Point(44, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 103);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "实验内容:";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(27, 20);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetail.Size = new System.Drawing.Size(591, 76);
            this.txtDetail.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPreparation);
            this.groupBox4.Location = new System.Drawing.Point(44, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(633, 91);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "准备知识:";
            // 
            // txtPreparation
            // 
            this.txtPreparation.Location = new System.Drawing.Point(28, 20);
            this.txtPreparation.Multiline = true;
            this.txtPreparation.Name = "txtPreparation";
            this.txtPreparation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreparation.Size = new System.Drawing.Size(590, 65);
            this.txtPreparation.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtGuidance);
            this.groupBox5.Location = new System.Drawing.Point(44, 413);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(633, 138);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "实验指导";
            // 
            // txtGuidance
            // 
            this.txtGuidance.Location = new System.Drawing.Point(27, 20);
            this.txtGuidance.Multiline = true;
            this.txtGuidance.Name = "txtGuidance";
            this.txtGuidance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuidance.Size = new System.Drawing.Size(590, 112);
            this.txtGuidance.TabIndex = 0;
            // 
            // butAccept
            // 
            this.butAccept.Location = new System.Drawing.Point(84, 13);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(75, 23);
            this.butAccept.TabIndex = 7;
            this.butAccept.Text = "提交";
            this.butAccept.UseVisualStyleBackColor = true;
            this.butAccept.Click += new System.EventHandler(this.butAccept_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(219, 13);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 8;
            this.butClear.Text = "清空";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butClose.Location = new System.Drawing.Point(347, 13);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 9;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butOpenFile
            // 
            this.butOpenFile.Location = new System.Drawing.Point(542, 13);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(75, 23);
            this.butOpenFile.TabIndex = 10;
            this.butOpenFile.Text = "绑定课件";
            this.butOpenFile.UseVisualStyleBackColor = true;
            this.butOpenFile.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.butDoExperiment);
            this.groupBox6.Controls.Add(this.butOpenFile);
            this.groupBox6.Controls.Add(this.butClose);
            this.groupBox6.Controls.Add(this.butClear);
            this.groupBox6.Controls.Add(this.butAccept);
            this.groupBox6.Location = new System.Drawing.Point(44, 557);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(633, 42);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "操作";
            // 
            // butDoExperiment
            // 
            this.butDoExperiment.Location = new System.Drawing.Point(475, 13);
            this.butDoExperiment.Name = "butDoExperiment";
            this.butDoExperiment.Size = new System.Drawing.Size(75, 23);
            this.butDoExperiment.TabIndex = 11;
            this.butDoExperiment.Text = "开始做实验";
            this.butDoExperiment.UseVisualStyleBackColor = true;
            this.butDoExperiment.Click += new System.EventHandler(this.butDoExperiment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "章节号:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtTeacherName);
            this.groupBox7.Controls.Add(this.txtTeacherNum);
            this.groupBox7.Controls.Add(this.cb_ChapterNum);
            this.groupBox7.Controls.Add(this.cb_ChapterName);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Location = new System.Drawing.Point(44, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(633, 56);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "基本信息";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(545, 24);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(73, 21);
            this.txtTeacherName.TabIndex = 22;
            // 
            // txtTeacherNum
            // 
            this.txtTeacherNum.Location = new System.Drawing.Point(442, 24);
            this.txtTeacherNum.Name = "txtTeacherNum";
            this.txtTeacherNum.Size = new System.Drawing.Size(33, 21);
            this.txtTeacherNum.TabIndex = 21;
            // 
            // cb_ChapterNum
            // 
            this.cb_ChapterNum.DataSource = this.tbChapterBindingSource;
            this.cb_ChapterNum.DisplayMember = "IDC";
            this.cb_ChapterNum.FormattingEnabled = true;
            this.cb_ChapterNum.Location = new System.Drawing.Point(59, 25);
            this.cb_ChapterNum.Name = "cb_ChapterNum";
            this.cb_ChapterNum.Size = new System.Drawing.Size(47, 20);
            this.cb_ChapterNum.TabIndex = 14;
            this.cb_ChapterNum.ValueMember = "IDC";
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
            // cb_ChapterName
            // 
            this.cb_ChapterName.DataSource = this.tbChapterBindingSource;
            this.cb_ChapterName.DisplayMember = "name";
            this.cb_ChapterName.FormattingEnabled = true;
            this.cb_ChapterName.Location = new System.Drawing.Point(155, 25);
            this.cb_ChapterName.Name = "cb_ChapterName";
            this.cb_ChapterName.Size = new System.Drawing.Size(223, 20);
            this.cb_ChapterName.TabIndex = 20;
            this.cb_ChapterName.ValueMember = "IDC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "教师名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "章节名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "教师号:";
            // 
            // dbBSDataSetBindingSource
            // 
            this.dbBSDataSetBindingSource.DataSource = this.db_BSDataSet;
            this.dbBSDataSetBindingSource.Position = 0;
            // 
            // dbBSDataSetBindingSource1
            // 
            this.dbBSDataSetBindingSource1.DataSource = this.db_BSDataSet;
            this.dbBSDataSetBindingSource1.Position = 0;
            // 
            // tb_ChapterTableAdapter
            // 
            this.tb_ChapterTableAdapter.ClearBeforeFill = true;
            // 
            // F_NewExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.butClose;
            this.ClientSize = new System.Drawing.Size(752, 666);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_NewExperiment";
            this.Text = "新建实验";
            this.Load += new System.EventHandler(this.F_NewExperiment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBSDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPreparation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtGuidance;
        private System.Windows.Forms.Button butAccept;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ChapterNum;
        private System.Windows.Forms.ComboBox cb_ChapterName;
        private System.Windows.Forms.Label label5;
        private db_BSDataSet db_BSDataSet;
        private System.Windows.Forms.BindingSource dbBSDataSetBindingSource;
        private System.Windows.Forms.BindingSource dbBSDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tbChapterBindingSource;
        private db_BSDataSetTableAdapters.tb_ChapterTableAdapter tb_ChapterTableAdapter;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtTeacherNum;
        private System.Windows.Forms.Button butDoExperiment;
        private System.Windows.Forms.Button butGetChapterNum;
        private System.Windows.Forms.TextBox txtExperimentNum;

    }
}