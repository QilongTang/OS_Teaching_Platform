namespace OSM.Forms
{
    partial class F_InfoManage
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
            this.checkElse = new System.Windows.Forms.CheckBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.butStatus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.mtxt_Code = new System.Windows.Forms.MaskedTextBox();
            this.butAmend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_Class = new System.Windows.Forms.RadioButton();
            this.radioButton_Stu = new System.Windows.Forms.RadioButton();
            this.radioButton_Tea = new System.Windows.Forms.RadioButton();
            this.txt_ClassNum = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkElse);
            this.groupBox2.Controls.Add(this.checkBoxAll);
            this.groupBox2.Controls.Add(this.butStatus);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(60, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 502);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已有用户";
            // 
            // checkElse
            // 
            this.checkElse.AutoSize = true;
            this.checkElse.Location = new System.Drawing.Point(603, 479);
            this.checkElse.Name = "checkElse";
            this.checkElse.Size = new System.Drawing.Size(48, 16);
            this.checkElse.TabIndex = 5;
            this.checkElse.Text = "反选";
            this.checkElse.UseVisualStyleBackColor = true;
            this.checkElse.CheckedChanged += new System.EventHandler(this.checkElse_CheckedChanged);
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(549, 479);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(48, 16);
            this.checkBoxAll.TabIndex = 4;
            this.checkBoxAll.Text = "全选";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // butStatus
            // 
            this.butStatus.Location = new System.Drawing.Point(503, 475);
            this.butStatus.Name = "butStatus";
            this.butStatus.Size = new System.Drawing.Size(40, 20);
            this.butStatus.TabIndex = 3;
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
            this.dataGridView1.Location = new System.Drawing.Point(19, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(639, 449);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "当前状态";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ClassNum);
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.butOK);
            this.groupBox1.Controls.Add(this.mtxt_Code);
            this.groupBox1.Controls.Add(this.butAmend);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.butClose);
            this.groupBox1.Controls.Add(this.butDelete);
            this.groupBox1.Location = new System.Drawing.Point(339, 545);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态操作";
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(261, 52);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(57, 23);
            this.butCancel.TabIndex = 23;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(198, 52);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(57, 23);
            this.butOK.TabIndex = 22;
            this.butOK.Text = "确认";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // mtxt_Code
            // 
            this.mtxt_Code.Location = new System.Drawing.Point(339, 24);
            this.mtxt_Code.Mask = "99999";
            this.mtxt_Code.Name = "mtxt_Code";
            this.mtxt_Code.Size = new System.Drawing.Size(40, 21);
            this.mtxt_Code.TabIndex = 21;
            this.mtxt_Code.ValidatingType = typeof(int);
            // 
            // butAmend
            // 
            this.butAmend.Location = new System.Drawing.Point(135, 52);
            this.butAmend.Name = "butAmend";
            this.butAmend.Size = new System.Drawing.Size(57, 23);
            this.butAmend.TabIndex = 1;
            this.butAmend.Text = "修改";
            this.butAmend.UseVisualStyleBackColor = true;
            this.butAmend.Click += new System.EventHandler(this.butAmend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "验证码:";
            // 
            // txt_ClassName
            // 
            this.txt_ClassName.Location = new System.Drawing.Point(177, 24);
            this.txt_ClassName.Name = "txt_ClassName";
            this.txt_ClassName.Size = new System.Drawing.Size(103, 21);
            this.txt_ClassName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "班级名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "班级编号:";
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(12, 52);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(57, 23);
            this.butAdd.TabIndex = 15;
            this.butAdd.Text = "增加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(322, 52);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(57, 23);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(75, 52);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(57, 23);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "删除";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_Class);
            this.groupBox3.Controls.Add(this.radioButton_Stu);
            this.groupBox3.Controls.Add(this.radioButton_Tea);
            this.groupBox3.Location = new System.Drawing.Point(60, 545);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询种类";
            // 
            // radioButton_Class
            // 
            this.radioButton_Class.AutoSize = true;
            this.radioButton_Class.Location = new System.Drawing.Point(178, 41);
            this.radioButton_Class.Name = "radioButton_Class";
            this.radioButton_Class.Size = new System.Drawing.Size(71, 16);
            this.radioButton_Class.TabIndex = 7;
            this.radioButton_Class.TabStop = true;
            this.radioButton_Class.Text = "班级信息";
            this.radioButton_Class.UseVisualStyleBackColor = true;
            this.radioButton_Class.CheckedChanged += new System.EventHandler(this.radioButton_Class_CheckedChanged);
            // 
            // radioButton_Stu
            // 
            this.radioButton_Stu.AutoSize = true;
            this.radioButton_Stu.Location = new System.Drawing.Point(101, 41);
            this.radioButton_Stu.Name = "radioButton_Stu";
            this.radioButton_Stu.Size = new System.Drawing.Size(71, 16);
            this.radioButton_Stu.TabIndex = 8;
            this.radioButton_Stu.TabStop = true;
            this.radioButton_Stu.Text = "学生用户";
            this.radioButton_Stu.UseVisualStyleBackColor = true;
            this.radioButton_Stu.CheckedChanged += new System.EventHandler(this.radioButton_Stu_CheckedChanged);
            // 
            // radioButton_Tea
            // 
            this.radioButton_Tea.AutoSize = true;
            this.radioButton_Tea.Location = new System.Drawing.Point(19, 41);
            this.radioButton_Tea.Name = "radioButton_Tea";
            this.radioButton_Tea.Size = new System.Drawing.Size(71, 16);
            this.radioButton_Tea.TabIndex = 7;
            this.radioButton_Tea.TabStop = true;
            this.radioButton_Tea.Text = "教师用户";
            this.radioButton_Tea.UseVisualStyleBackColor = true;
            this.radioButton_Tea.CheckedChanged += new System.EventHandler(this.radioButton_Tea_CheckedChanged);
            // 
            // txt_ClassNum
            // 
            this.txt_ClassNum.Location = new System.Drawing.Point(75, 24);
            this.txt_ClassNum.Name = "txt_ClassNum";
            this.txt_ClassNum.Size = new System.Drawing.Size(31, 21);
            this.txt_ClassNum.TabIndex = 24;
            // 
            // F_InfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 666);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_InfoManage";
            this.Text = "F_InfoManage";
            this.Load += new System.EventHandler(this.F_InfoManage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkElse;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button butStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butAmend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_Stu;
        private System.Windows.Forms.RadioButton radioButton_Tea;
        private System.Windows.Forms.RadioButton radioButton_Class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_Code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox txt_ClassNum;
    }
}