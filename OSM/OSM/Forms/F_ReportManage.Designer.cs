namespace OSM.Forms
{
    partial class F_ReportManage
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
            this.butDelete = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.butAmend = new System.Windows.Forms.Button();
            this.butCancelRealease = new System.Windows.Forms.Button();
            this.butAccept = new System.Windows.Forms.Button();
            this.butView = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butReDo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butCreatWord = new System.Windows.Forms.Button();
            this.checkElse = new System.Windows.Forms.CheckBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.butStatus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butDelete);
            this.groupBox1.Controls.Add(this.butRefresh);
            this.groupBox1.Controls.Add(this.butAmend);
            this.groupBox1.Controls.Add(this.butCancelRealease);
            this.groupBox1.Controls.Add(this.butAccept);
            this.groupBox1.Controls.Add(this.butView);
            this.groupBox1.Controls.Add(this.butClose);
            this.groupBox1.Controls.Add(this.butReDo);
            this.groupBox1.Location = new System.Drawing.Point(63, 590);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(345, 29);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 3;
            this.butDelete.Text = "删除";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(21, 29);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(75, 23);
            this.butRefresh.TabIndex = 3;
            this.butRefresh.Text = "刷新";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butAmend
            // 
            this.butAmend.Location = new System.Drawing.Point(426, 29);
            this.butAmend.Name = "butAmend";
            this.butAmend.Size = new System.Drawing.Size(75, 23);
            this.butAmend.TabIndex = 0;
            this.butAmend.Text = "修改";
            this.butAmend.UseVisualStyleBackColor = true;
            this.butAmend.Click += new System.EventHandler(this.butAmend_Click);
            // 
            // butCancelRealease
            // 
            this.butCancelRealease.Location = new System.Drawing.Point(183, 29);
            this.butCancelRealease.Name = "butCancelRealease";
            this.butCancelRealease.Size = new System.Drawing.Size(75, 23);
            this.butCancelRealease.TabIndex = 3;
            this.butCancelRealease.Text = "取消提交";
            this.butCancelRealease.UseVisualStyleBackColor = true;
            this.butCancelRealease.Click += new System.EventHandler(this.butCancelRealease_Click);
            // 
            // butAccept
            // 
            this.butAccept.Location = new System.Drawing.Point(102, 29);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(75, 23);
            this.butAccept.TabIndex = 3;
            this.butAccept.Text = "提交";
            this.butAccept.UseVisualStyleBackColor = true;
            this.butAccept.Click += new System.EventHandler(this.butAccept_Click);
            // 
            // butView
            // 
            this.butView.Location = new System.Drawing.Point(264, 29);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(75, 23);
            this.butView.TabIndex = 2;
            this.butView.Text = "显示";
            this.butView.UseVisualStyleBackColor = true;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(588, 29);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butReDo
            // 
            this.butReDo.Location = new System.Drawing.Point(507, 29);
            this.butReDo.Name = "butReDo";
            this.butReDo.Size = new System.Drawing.Size(75, 23);
            this.butReDo.TabIndex = 1;
            this.butReDo.Text = "重做";
            this.butReDo.UseVisualStyleBackColor = true;
            this.butReDo.Click += new System.EventHandler(this.butReDo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butCreatWord);
            this.groupBox2.Controls.Add(this.checkElse);
            this.groupBox2.Controls.Add(this.checkBoxAll);
            this.groupBox2.Controls.Add(this.butStatus);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(63, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 560);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "我的实验报告";
            // 
            // butCreatWord
            // 
            this.butCreatWord.Location = new System.Drawing.Point(440, 534);
            this.butCreatWord.Name = "butCreatWord";
            this.butCreatWord.Size = new System.Drawing.Size(61, 20);
            this.butCreatWord.TabIndex = 9;
            this.butCreatWord.Text = "生成Word";
            this.butCreatWord.UseVisualStyleBackColor = true;
            this.butCreatWord.Click += new System.EventHandler(this.butCreatWord_Click);
            // 
            // checkElse
            // 
            this.checkElse.AutoSize = true;
            this.checkElse.Location = new System.Drawing.Point(600, 537);
            this.checkElse.Name = "checkElse";
            this.checkElse.Size = new System.Drawing.Size(48, 16);
            this.checkElse.TabIndex = 8;
            this.checkElse.Text = "反选";
            this.checkElse.UseVisualStyleBackColor = true;
            this.checkElse.CheckedChanged += new System.EventHandler(this.checkElse_CheckedChanged);
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(553, 537);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(48, 16);
            this.checkBoxAll.TabIndex = 7;
            this.checkBoxAll.Text = "全选";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // butStatus
            // 
            this.butStatus.Location = new System.Drawing.Point(507, 535);
            this.butStatus.Name = "butStatus";
            this.butStatus.Size = new System.Drawing.Size(40, 19);
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(642, 508);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "当前状态";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 60;
            // 
            // F_ReportManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ReportManage";
            this.Text = "F_ReportManage";
            this.Load += new System.EventHandler(this.F_MarkView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butReDo;
        private System.Windows.Forms.Button butAmend;
        private System.Windows.Forms.Button butAccept;
        private System.Windows.Forms.Button butCancelRealease;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.CheckBox checkElse;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button butStatus;
        private System.Windows.Forms.Button butCreatWord;
    }
}