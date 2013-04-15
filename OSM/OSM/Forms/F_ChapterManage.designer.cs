namespace OSM.Forms
{
    partial class F_ChapterManage
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
            this.txtChapNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.txtRepNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChapterName = new System.Windows.Forms.TextBox();
            this.butClose = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butAmend = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkElse);
            this.groupBox2.Controls.Add(this.checkBoxAll);
            this.groupBox2.Controls.Add(this.butStatus);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(58, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 502);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已有章节";
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
            this.groupBox1.Controls.Add(this.txtChapNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.butOK);
            this.groupBox1.Controls.Add(this.txtRepNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtExpNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtChapterName);
            this.groupBox1.Controls.Add(this.butClose);
            this.groupBox1.Controls.Add(this.butDelete);
            this.groupBox1.Controls.Add(this.butAmend);
            this.groupBox1.Location = new System.Drawing.Point(58, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态操作";
            // 
            // txtChapNum
            // 
            this.txtChapNum.Location = new System.Drawing.Point(549, 20);
            this.txtChapNum.Name = "txtChapNum";
            this.txtChapNum.Size = new System.Drawing.Size(58, 21);
            this.txtChapNum.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "章节编号：";
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(57, 90);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 15;
            this.butAdd.Text = "增加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(447, 90);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 14;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(351, 90);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 13;
            this.butOK.Text = "确认";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // txtRepNum
            // 
            this.txtRepNum.Location = new System.Drawing.Point(287, 53);
            this.txtRepNum.Name = "txtRepNum";
            this.txtRepNum.Size = new System.Drawing.Size(64, 21);
            this.txtRepNum.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "包含报告：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "包含实验：";
            // 
            // txtExpNum
            // 
            this.txtExpNum.Location = new System.Drawing.Point(129, 53);
            this.txtExpNum.Name = "txtExpNum";
            this.txtExpNum.Size = new System.Drawing.Size(70, 21);
            this.txtExpNum.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "章节名称：";
            // 
            // txtChapterName
            // 
            this.txtChapterName.Location = new System.Drawing.Point(129, 20);
            this.txtChapterName.Name = "txtChapterName";
            this.txtChapterName.Size = new System.Drawing.Size(353, 21);
            this.txtChapterName.TabIndex = 7;
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(540, 90);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(155, 90);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "删除";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butAmend
            // 
            this.butAmend.Location = new System.Drawing.Point(254, 90);
            this.butAmend.Name = "butAmend";
            this.butAmend.Size = new System.Drawing.Size(75, 23);
            this.butAmend.TabIndex = 1;
            this.butAmend.Text = "修改";
            this.butAmend.UseVisualStyleBackColor = true;
            this.butAmend.Click += new System.EventHandler(this.butAmend_Click);
            // 
            // F_ChapterManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ChapterManage";
            this.Text = "F_ChapterManage";
            this.Load += new System.EventHandler(this.F_ChapterManage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkElse;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button butStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRepNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChapterName;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butAmend;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.TextBox txtChapNum;
        private System.Windows.Forms.Label label4;
    }
}