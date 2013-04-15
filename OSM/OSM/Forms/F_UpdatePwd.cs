using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OSM.DataClass;

namespace OSM.Forms
{
    public partial class F_UpdatePwd : Form
    {
        public F_UpdatePwd()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();

        private void updata_button_Click(object sender, EventArgs e)
        {
            if (oldpwd_text.Text.Trim() == DataClass.MyMeans.User_Pwd)//判断旧密码是否正确
            {
                if (newpwd_text1.Text == newpwd_text2.Text)//判断新密码两次输入
                {
                    try
                    {
                        MyClass.getsqlcom("update tb_UserLogin set password='" + newpwd_text1.Text.Trim() + "' where IDU=" + DataClass.MyMeans.User_ID.ToString() + "");
                        DataClass.MyMeans.User_Pwd=newpwd_text1.Text.Trim();//将新密码赋值给系统变量
                        this.DialogResult = DialogResult.OK;
                        this.Close();//模式退出
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("新密码两次输入不一样!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oldpwd_text.Text = "";
                    newpwd_text1.Text = "";
                    newpwd_text2.Text = "";
                    oldpwd_text.Focus();
                }
            }
            else
            {
                MessageBox.Show("密码错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oldpwd_text.Text = "";
                newpwd_text1.Text = "";
                newpwd_text2.Text = "";
                oldpwd_text.Focus();
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_updatePwd_Load(object sender, EventArgs e)
        {

        }
    }
}