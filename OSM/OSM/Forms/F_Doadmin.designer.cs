namespace OSM
{
    partial class F_Doadmin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.but_OK = new System.Windows.Forms.Button();
            this.admin_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_OK
            // 
            this.but_OK.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_OK.Location = new System.Drawing.Point(128, 64);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 25);
            this.but_OK.TabIndex = 0;
            this.but_OK.Text = "Activate";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.do_button_Click);
            // 
            // admin_text
            // 
            this.admin_text.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.admin_text.Location = new System.Drawing.Point(73, 23);
            this.admin_text.Name = "admin_text";
            this.admin_text.PasswordChar = '*';
            this.admin_text.Size = new System.Drawing.Size(193, 23);
            this.admin_text.TabIndex = 1;
            // 
            // F_Doadmin
            // 
            this.AcceptButton = this.but_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 108);
            this.Controls.Add(this.admin_text);
            this.Controls.Add(this.but_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Doadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activate Administrator";
            this.Load += new System.EventHandler(this.doadmin_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.TextBox admin_text;
    }
}