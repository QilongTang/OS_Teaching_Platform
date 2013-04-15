namespace OSM.Forms
{
    partial class F_ExperimentManage
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
            this.butRefresh = new System.Windows.Forms.Button();
            this.butView = new System.Windows.Forms.Button();
            this.butCancelRelease = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butAmend = new System.Windows.Forms.Button();
            this.butRelease = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.butRefresh);
            this.groupBox1.Controls.Add(this.butView);
            this.groupBox1.Controls.Add(this.butCancelRelease);
            this.groupBox1.Controls.Add(this.butClose);
            this.groupBox1.Controls.Add(this.butDelete);
            this.groupBox1.Controls.Add(this.butAmend);
            this.groupBox1.Controls.Add(this.butRelease);
            this.groupBox1.Location = new System.Drawing.Point(56, 587);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态操作";
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(28, 30);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(75, 23);
            this.butRefresh.TabIndex = 6;
            this.butRefresh.Text = "刷新";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butView
            // 
            this.butView.Location = new System.Drawing.Point(308, 30);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(75, 23);
            this.butView.TabIndex = 5;
            this.butView.Text = "显示";
            this.butView.UseVisualStyleBackColor = true;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // butCancelRelease
            // 
            this.butCancelRelease.Location = new System.Drawing.Point(209, 30);
            this.butCancelRelease.Name = "butCancelRelease";
            this.butCancelRelease.Size = new System.Drawing.Size(75, 23);
            this.butCancelRelease.TabIndex = 4;
            this.butCancelRelease.Text = "取消发布";
            this.butCancelRelease.UseVisualStyleBackColor = true;
            this.butCancelRelease.Click += new System.EventHandler(this.butCancelRelease_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(583, 30);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(490, 30);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "删除";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butAmend
            // 
            this.butAmend.Location = new System.Drawing.Point(399, 30);
            this.butAmend.Name = "butAmend";
            this.butAmend.Size = new System.Drawing.Size(75, 23);
            this.butAmend.TabIndex = 1;
            this.butAmend.Text = "修改";
            this.butAmend.UseVisualStyleBackColor = true;
            this.butAmend.Click += new System.EventHandler(this.butAmend_Click);
            // 
            // butRelease
            // 
            this.butRelease.Location = new System.Drawing.Point(118, 30);
            this.butRelease.Name = "butRelease";
            this.butRelease.Size = new System.Drawing.Size(75, 23);
            this.butRelease.TabIndex = 0;
            this.butRelease.Text = "发布";
            this.butRelease.UseVisualStyleBackColor = true;
            this.butRelease.Click += new System.EventHandler(this.butRelease_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butCreatWord);
            this.groupBox2.Controls.Add(this.checkElse);
            this.groupBox2.Controls.Add(this.checkBoxAll);
            this.groupBox2.Controls.Add(this.butStatus);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(56, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 551);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "我的实验";
            // 
            // butCreatWord
            // 
            this.butCreatWord.Location = new System.Drawing.Point(436, 525);
            this.butCreatWord.Name = "butCreatWord";
            this.butCreatWord.Size = new System.Drawing.Size(61, 20);
            this.butCreatWord.TabIndex = 10;
            this.butCreatWord.Text = "生成Word";
            this.butCreatWord.UseVisualStyleBackColor = true;
            this.butCreatWord.Click += new System.EventHandler(this.butCreatWord_Click);
            // 
            // checkElse
            // 
            this.checkElse.AutoSize = true;
            this.checkElse.Location = new System.Drawing.Point(596, 528);
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
            this.checkBoxAll.Location = new System.Drawing.Point(549, 528);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(48, 16);
            this.checkBoxAll.TabIndex = 4;
            this.checkBoxAll.Text = "全选";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // butStatus
            // 
            this.butStatus.Location = new System.Drawing.Point(503, 525);
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
            this.dataGridView1.Size = new System.Drawing.Size(639, 499);
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
            // F_ExperimentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(794, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ExperimentManage";
            this.Text = "管理实验";
            this.Load += new System.EventHandler(this.F_ExperimentRelease_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butAmend;
        private System.Windows.Forms.Button butRelease;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butCancelRelease;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button butStatus;
        private System.Windows.Forms.CheckBox checkElse;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button butCreatWord;
    }
}