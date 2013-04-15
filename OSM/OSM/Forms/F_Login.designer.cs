namespace OSM
{
    partial class F_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.butLogin = new System.Windows.Forms.Button();
            this.butRegister = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(80, 152);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(75, 23);
            this.butLogin.TabIndex = 0;
            this.butLogin.Text = "登录";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butRegister
            // 
            this.butRegister.Location = new System.Drawing.Point(174, 152);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(75, 23);
            this.butRegister.TabIndex = 1;
            this.butRegister.Text = "注册";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Location = new System.Drawing.Point(68, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 12);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "用户名:";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.BackColor = System.Drawing.Color.Transparent;
            this.labelPwd.Location = new System.Drawing.Point(68, 104);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(35, 12);
            this.labelPwd.TabIndex = 3;
            this.labelPwd.Text = "密码:";
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butClose.Location = new System.Drawing.Point(269, 152);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "取消";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(121, 61);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 21);
            this.txtUserName.TabIndex = 5;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(121, 101);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(172, 21);
            this.txtUserPwd.TabIndex = 6;
            this.txtUserPwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(133, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "操作系统实验教学平台V1.0";
            // 
            // F_Login
            // 
            this.AcceptButton = this.butLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.butClose;
            this.ClientSize = new System.Drawing.Size(453, 270);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.butLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.Label label1;
    }
}

