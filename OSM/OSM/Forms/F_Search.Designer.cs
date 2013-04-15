namespace OSM.Forms
{
    partial class F_Search
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butDoExperiment = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butGiveMark = new System.Windows.Forms.Button();
            this.butView = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonStuClass = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_MarkStatus = new System.Windows.Forms.ComboBox();
            this.cb_Mark = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.radioButtonStuNum = new System.Windows.Forms.RadioButton();
            this.radioButtonStuName = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_TeacherName = new System.Windows.Forms.ComboBox();
            this.cb_ChapterName = new System.Windows.Forms.ComboBox();
            this.radioButtonRSearch = new System.Windows.Forms.RadioButton();
            this.radioButtonESearch = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butCreatWord = new System.Windows.Forms.Button();
            this.checkElse = new System.Windows.Forms.CheckBox();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.butStatus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxOnlyMeFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.radioButtonOr = new System.Windows.Forms.RadioButton();
            this.radioButtonAnd = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butDoExperiment);
            this.groupBox1.Controls.Add(this.butClose);
            this.groupBox1.Controls.Add(this.butGiveMark);
            this.groupBox1.Controls.Add(this.butView);
            this.groupBox1.Location = new System.Drawing.Point(23, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // butDoExperiment
            // 
            this.butDoExperiment.Location = new System.Drawing.Point(216, 29);
            this.butDoExperiment.Name = "butDoExperiment";
            this.butDoExperiment.Size = new System.Drawing.Size(75, 23);
            this.butDoExperiment.TabIndex = 4;
            this.butDoExperiment.Text = "做此实验";
            this.butDoExperiment.UseVisualStyleBackColor = true;
            this.butDoExperiment.Click += new System.EventHandler(this.butDoExperiment_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(313, 29);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butGiveMark
            // 
            this.butGiveMark.Location = new System.Drawing.Point(27, 29);
            this.butGiveMark.Name = "butGiveMark";
            this.butGiveMark.Size = new System.Drawing.Size(75, 23);
            this.butGiveMark.TabIndex = 2;
            this.butGiveMark.Text = "批改";
            this.butGiveMark.UseVisualStyleBackColor = true;
            this.butGiveMark.Click += new System.EventHandler(this.butGiveMark_Click);
            // 
            // butView
            // 
            this.butView.Location = new System.Drawing.Point(119, 29);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(75, 23);
            this.butView.TabIndex = 0;
            this.butView.Text = "显示详情";
            this.butView.UseVisualStyleBackColor = true;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonStuClass);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cb_MarkStatus);
            this.groupBox2.Controls.Add(this.cb_Mark);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDate);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.radioButtonStuNum);
            this.groupBox2.Controls.Add(this.radioButtonStuName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCondition);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_TeacherName);
            this.groupBox2.Controls.Add(this.cb_ChapterName);
            this.groupBox2.Location = new System.Drawing.Point(23, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询条件";
            // 
            // radioButtonStuClass
            // 
            this.radioButtonStuClass.AutoSize = true;
            this.radioButtonStuClass.Location = new System.Drawing.Point(507, 94);
            this.radioButtonStuClass.Name = "radioButtonStuClass";
            this.radioButtonStuClass.Size = new System.Drawing.Size(71, 16);
            this.radioButtonStuClass.TabIndex = 21;
            this.radioButtonStuClass.TabStop = true;
            this.radioButtonStuClass.Text = "学生班级";
            this.radioButtonStuClass.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "批改状态:";
            // 
            // cb_MarkStatus
            // 
            this.cb_MarkStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MarkStatus.FormattingEnabled = true;
            this.cb_MarkStatus.Items.AddRange(new object[] {
            "全部",
            "已批改",
            "未批改"});
            this.cb_MarkStatus.Location = new System.Drawing.Point(310, 124);
            this.cb_MarkStatus.Name = "cb_MarkStatus";
            this.cb_MarkStatus.Size = new System.Drawing.Size(86, 20);
            this.cb_MarkStatus.TabIndex = 19;
            // 
            // cb_Mark
            // 
            this.cb_Mark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Mark.FormattingEnabled = true;
            this.cb_Mark.Items.AddRange(new object[] {
            "全部",
            "90 - 满分",
            "80 - 90分",
            "70 - 80分",
            "60 - 70分",
            "不及格"});
            this.cb_Mark.Location = new System.Drawing.Point(108, 124);
            this.cb_Mark.Name = "cb_Mark";
            this.cb_Mark.Size = new System.Drawing.Size(121, 20);
            this.cb_Mark.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "报告成绩:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(451, 27);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(121, 21);
            this.txtDate.TabIndex = 16;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(108, 59);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(464, 21);
            this.txtTitle.TabIndex = 15;
            // 
            // radioButtonStuNum
            // 
            this.radioButtonStuNum.AutoSize = true;
            this.radioButtonStuNum.Location = new System.Drawing.Point(398, 94);
            this.radioButtonStuNum.Name = "radioButtonStuNum";
            this.radioButtonStuNum.Size = new System.Drawing.Size(47, 16);
            this.radioButtonStuNum.TabIndex = 14;
            this.radioButtonStuNum.TabStop = true;
            this.radioButtonStuNum.Text = "学号";
            this.radioButtonStuNum.UseVisualStyleBackColor = true;
            // 
            // radioButtonStuName
            // 
            this.radioButtonStuName.AutoSize = true;
            this.radioButtonStuName.Location = new System.Drawing.Point(451, 94);
            this.radioButtonStuName.Name = "radioButtonStuName";
            this.radioButtonStuName.Size = new System.Drawing.Size(59, 16);
            this.radioButtonStuName.TabIndex = 13;
            this.radioButtonStuName.TabStop = true;
            this.radioButtonStuName.Text = "学生名";
            this.radioButtonStuName.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "关键字词:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "自定义条件:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "日期:";
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(108, 93);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(207, 21);
            this.txtCondition.TabIndex = 8;
            this.txtCondition.TextChanged += new System.EventHandler(this.txtCondition_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "实验标题:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "教师名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "章节名称:";
            // 
            // cb_TeacherName
            // 
            this.cb_TeacherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TeacherName.FormattingEnabled = true;
            this.cb_TeacherName.Location = new System.Drawing.Point(310, 27);
            this.cb_TeacherName.Name = "cb_TeacherName";
            this.cb_TeacherName.Size = new System.Drawing.Size(86, 20);
            this.cb_TeacherName.TabIndex = 1;
            // 
            // cb_ChapterName
            // 
            this.cb_ChapterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ChapterName.FormattingEnabled = true;
            this.cb_ChapterName.Location = new System.Drawing.Point(108, 27);
            this.cb_ChapterName.Name = "cb_ChapterName";
            this.cb_ChapterName.Size = new System.Drawing.Size(145, 20);
            this.cb_ChapterName.TabIndex = 0;
            this.cb_ChapterName.SelectedIndexChanged += new System.EventHandler(this.cb_ChapterName_SelectedIndexChanged);
            // 
            // radioButtonRSearch
            // 
            this.radioButtonRSearch.AutoSize = true;
            this.radioButtonRSearch.Location = new System.Drawing.Point(91, 31);
            this.radioButtonRSearch.Name = "radioButtonRSearch";
            this.radioButtonRSearch.Size = new System.Drawing.Size(71, 16);
            this.radioButtonRSearch.TabIndex = 13;
            this.radioButtonRSearch.TabStop = true;
            this.radioButtonRSearch.Text = "报告查询";
            this.radioButtonRSearch.UseVisualStyleBackColor = true;
            this.radioButtonRSearch.CheckedChanged += new System.EventHandler(this.radioButtonRSearch_CheckedChanged);
            // 
            // radioButtonESearch
            // 
            this.radioButtonESearch.AutoSize = true;
            this.radioButtonESearch.Location = new System.Drawing.Point(14, 31);
            this.radioButtonESearch.Name = "radioButtonESearch";
            this.radioButtonESearch.Size = new System.Drawing.Size(71, 16);
            this.radioButtonESearch.TabIndex = 12;
            this.radioButtonESearch.TabStop = true;
            this.radioButtonESearch.Text = "实验查询";
            this.radioButtonESearch.UseVisualStyleBackColor = true;
            this.radioButtonESearch.CheckedChanged += new System.EventHandler(this.radioButtonESearch_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butCreatWord);
            this.groupBox3.Controls.Add(this.checkElse);
            this.groupBox3.Controls.Add(this.checkAll);
            this.groupBox3.Controls.Add(this.butStatus);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(23, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 360);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询结果";
            // 
            // butCreatWord
            // 
            this.butCreatWord.Location = new System.Drawing.Point(471, 332);
            this.butCreatWord.Name = "butCreatWord";
            this.butCreatWord.Size = new System.Drawing.Size(61, 20);
            this.butCreatWord.TabIndex = 11;
            this.butCreatWord.Text = "生成Word";
            this.butCreatWord.UseVisualStyleBackColor = true;
            this.butCreatWord.Click += new System.EventHandler(this.butCreatWord_Click);
            // 
            // checkElse
            // 
            this.checkElse.AutoSize = true;
            this.checkElse.Location = new System.Drawing.Point(631, 335);
            this.checkElse.Name = "checkElse";
            this.checkElse.Size = new System.Drawing.Size(48, 16);
            this.checkElse.TabIndex = 8;
            this.checkElse.Text = "反选";
            this.checkElse.UseVisualStyleBackColor = true;
            this.checkElse.CheckedChanged += new System.EventHandler(this.checkElse_CheckedChanged);
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(584, 335);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(48, 16);
            this.checkAll.TabIndex = 7;
            this.checkAll.Text = "全选";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // butStatus
            // 
            this.butStatus.Location = new System.Drawing.Point(538, 332);
            this.butStatus.Name = "butStatus";
            this.butStatus.Size = new System.Drawing.Size(40, 20);
            this.butStatus.TabIndex = 6;
            this.butStatus.Text = "统计";
            this.butStatus.UseVisualStyleBackColor = true;
            this.butStatus.Click += new System.EventHandler(this.butStatus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(18, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(673, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "当前状态";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 60;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxOnlyMeFlag);
            this.groupBox4.Controls.Add(this.checkBoxAll);
            this.groupBox4.Controls.Add(this.butCancel);
            this.groupBox4.Controls.Add(this.butClear);
            this.groupBox4.Controls.Add(this.butSearch);
            this.groupBox4.Controls.Add(this.radioButtonOr);
            this.groupBox4.Controls.Add(this.radioButtonAnd);
            this.groupBox4.Location = new System.Drawing.Point(627, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(102, 247);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询操作";
            // 
            // checkBoxOnlyMeFlag
            // 
            this.checkBoxOnlyMeFlag.AutoSize = true;
            this.checkBoxOnlyMeFlag.Location = new System.Drawing.Point(15, 149);
            this.checkBoxOnlyMeFlag.Name = "checkBoxOnlyMeFlag";
            this.checkBoxOnlyMeFlag.Size = new System.Drawing.Size(72, 16);
            this.checkBoxOnlyMeFlag.TabIndex = 12;
            this.checkBoxOnlyMeFlag.Text = "只看本人";
            this.checkBoxOnlyMeFlag.UseVisualStyleBackColor = true;
            this.checkBoxOnlyMeFlag.Visible = false;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(15, 127);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAll.TabIndex = 22;
            this.checkBoxAll.Text = "显示全部";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(15, 88);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 21;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(15, 57);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 20;
            this.butClear.Text = "清空";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(15, 24);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 19;
            this.butSearch.Text = "查询";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // radioButtonOr
            // 
            this.radioButtonOr.AutoSize = true;
            this.radioButtonOr.Location = new System.Drawing.Point(19, 216);
            this.radioButtonOr.Name = "radioButtonOr";
            this.radioButtonOr.Size = new System.Drawing.Size(59, 16);
            this.radioButtonOr.TabIndex = 18;
            this.radioButtonOr.Text = "或运算";
            this.radioButtonOr.UseVisualStyleBackColor = true;
            this.radioButtonOr.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonAnd
            // 
            this.radioButtonAnd.AutoSize = true;
            this.radioButtonAnd.Checked = true;
            this.radioButtonAnd.Location = new System.Drawing.Point(19, 193);
            this.radioButtonAnd.Name = "radioButtonAnd";
            this.radioButtonAnd.Size = new System.Drawing.Size(59, 16);
            this.radioButtonAnd.TabIndex = 17;
            this.radioButtonAnd.TabStop = true;
            this.radioButtonAnd.Text = "与运算";
            this.radioButtonAnd.UseVisualStyleBackColor = true;
            this.radioButtonAnd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonRSearch);
            this.groupBox5.Controls.Add(this.radioButtonESearch);
            this.groupBox5.Location = new System.Drawing.Point(433, 206);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 67);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "查询类别";
            // 
            // F_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 666);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_Search";
            this.Text = "F_Search";
            this.Load += new System.EventHandler(this.F_ExperimentView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butGiveMark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TeacherName;
        private System.Windows.Forms.ComboBox cb_ChapterName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.RadioButton radioButtonOr;
        private System.Windows.Forms.RadioButton radioButtonAnd;
        private System.Windows.Forms.CheckBox checkBoxOnlyMeFlag;
        private System.Windows.Forms.RadioButton radioButtonRSearch;
        private System.Windows.Forms.RadioButton radioButtonESearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RadioButton radioButtonStuNum;
        private System.Windows.Forms.RadioButton radioButtonStuName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.RadioButton radioButtonStuClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_MarkStatus;
        private System.Windows.Forms.ComboBox cb_Mark;
        private System.Windows.Forms.Button butDoExperiment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.CheckBox checkElse;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.Button butStatus;
        private System.Windows.Forms.Button butCreatWord;
    }
}