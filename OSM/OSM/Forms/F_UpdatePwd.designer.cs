namespace OSM.Forms
{
    partial class F_UpdatePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_UpdatePwd));
            this.oldpwd_label = new System.Windows.Forms.Label();
            this.newpwd_label1 = new System.Windows.Forms.Label();
            this.newpwd_label2 = new System.Windows.Forms.Label();
            this.oldpwd_text = new System.Windows.Forms.TextBox();
            this.newpwd_text1 = new System.Windows.Forms.TextBox();
            this.newpwd_text2 = new System.Windows.Forms.TextBox();
            this.updata_button = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldpwd_label
            // 
            this.oldpwd_label.AutoSize = true;
            this.oldpwd_label.BackColor = System.Drawing.Color.Transparent;
            this.oldpwd_label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldpwd_label.Location = new System.Drawing.Point(107, 43);
            this.oldpwd_label.Name = "oldpwd_label";
            this.oldpwd_label.Size = new System.Drawing.Size(53, 12);
            this.oldpwd_label.TabIndex = 0;
            this.oldpwd_label.Text = "旧密码：";
            // 
            // newpwd_label1
            // 
            this.newpwd_label1.AutoSize = true;
            this.newpwd_label1.BackColor = System.Drawing.Color.Transparent;
            this.newpwd_label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newpwd_label1.Location = new System.Drawing.Point(107, 71);
            this.newpwd_label1.Name = "newpwd_label1";
            this.newpwd_label1.Size = new System.Drawing.Size(47, 12);
            this.newpwd_label1.TabIndex = 1;
            this.newpwd_label1.Text = "新密码:";
            // 
            // newpwd_label2
            // 
            this.newpwd_label2.AutoSize = true;
            this.newpwd_label2.BackColor = System.Drawing.Color.Transparent;
            this.newpwd_label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newpwd_label2.Location = new System.Drawing.Point(102, 103);
            this.newpwd_label2.Name = "newpwd_label2";
            this.newpwd_label2.Size = new System.Drawing.Size(65, 12);
            this.newpwd_label2.TabIndex = 2;
            this.newpwd_label2.Text = "重新输入：";
            // 
            // oldpwd_text
            // 
            this.oldpwd_text.Font = new System.Drawing.Font("宋体", 9F);
            this.oldpwd_text.Location = new System.Drawing.Point(178, 36);
            this.oldpwd_text.Name = "oldpwd_text";
            this.oldpwd_text.PasswordChar = '*';
            this.oldpwd_text.Size = new System.Drawing.Size(126, 21);
            this.oldpwd_text.TabIndex = 3;
            // 
            // newpwd_text1
            // 
            this.newpwd_text1.Font = new System.Drawing.Font("宋体", 9F);
            this.newpwd_text1.Location = new System.Drawing.Point(178, 68);
            this.newpwd_text1.Name = "newpwd_text1";
            this.newpwd_text1.PasswordChar = '*';
            this.newpwd_text1.Size = new System.Drawing.Size(126, 21);
            this.newpwd_text1.TabIndex = 4;
            // 
            // newpwd_text2
            // 
            this.newpwd_text2.Font = new System.Drawing.Font("宋体", 9F);
            this.newpwd_text2.Location = new System.Drawing.Point(178, 100);
            this.newpwd_text2.Name = "newpwd_text2";
            this.newpwd_text2.PasswordChar = '*';
            this.newpwd_text2.Size = new System.Drawing.Size(126, 21);
            this.newpwd_text2.TabIndex = 5;
            // 
            // updata_button
            // 
            this.updata_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.updata_button.Location = new System.Drawing.Point(132, 141);
            this.updata_button.Name = "updata_button";
            this.updata_button.Size = new System.Drawing.Size(80, 24);
            this.updata_button.TabIndex = 6;
            this.updata_button.Text = "确认修改";
            this.updata_button.UseVisualStyleBackColor = true;
            this.updata_button.Click += new System.EventHandler(this.updata_button_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(243, 142);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // F_UpdatePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 268);
            this.ControlBox = false;
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.updata_button);
            this.Controls.Add(this.newpwd_text2);
            this.Controls.Add(this.newpwd_text1);
            this.Controls.Add(this.oldpwd_text);
            this.Controls.Add(this.newpwd_label2);
            this.Controls.Add(this.newpwd_label1);
            this.Controls.Add(this.oldpwd_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_UpdatePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.F_updatePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldpwd_label;
        private System.Windows.Forms.Label newpwd_label1;
        private System.Windows.Forms.Label newpwd_label2;
        private System.Windows.Forms.TextBox oldpwd_text;
        private System.Windows.Forms.TextBox newpwd_text1;
        private System.Windows.Forms.TextBox newpwd_text2;
        private System.Windows.Forms.Button updata_button;
        private System.Windows.Forms.Button butCancel;
    }
}