using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSM.DataClass;
using OSM.Forms;

namespace OSM.Forms
{
    public partial class F_Register : Form
    {
        public F_Register()
        {
            InitializeComponent();
        }

        MyMeans MyClass = new MyMeans();

        private void Accept()
        {
            try
            {
                if (txtUserName.Text != "" && txtPwd.Text != "" && txtPwd2.Text != "")
                {
                    //用自定义方法getcom()在Login数据表中查找是否有当前登陆用户
                    SqlDataReader temDR = MyClass.getcom("select * from tb_UserLogin where name='" + txtUserName.Text.Trim() + "' or popenum='"+ txtpopenum.Text.Trim() +"'");
                    bool ifcom = temDR.Read();
                    //当有记录时,表示用户名或权限号已经被注册
                    if (ifcom)
                    {
                        MessageBox.Show("该用户名或权限号已经被使用,请重新注册!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//显示具有指定内容的消息框
                        txtUserName.Clear();//用户名已经被注册时将会把用户名和密码栏都清空
                        txtPwd.Clear();
                        txtPwd2.Clear();
                        txtpopenum.Clear();
                        txtUserName.Focus();//鼠标焦点指向用户名栏便于用户重新输入
                    }
                    else//未重复注册
                    {
                        if (txtPwd.Text.Trim() != txtPwd2.Text.Trim())//如果两个密码栏中密码不同
                        {
                            MessageBox.Show("两次输入密码不一致,请重新注册!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//显示具有指定内容的消息框
                            txtPwd.Clear();
                            txtPwd2.Clear();
                            txtPwd.Focus();//鼠标焦点指向密码栏1以便于重新输入密码
                        }
                        else//两个密码栏密码想同
                        {
                            if (radioButton1.Checked || radioButton2.Checked)//身份按钮有被选中
                            {
                                string pope = radioButton1.Checked == true ? "T" : "S";
                                //此处代码仍然按照教师号指定设计而非自动生成,如果需要教师号自动生成,则pope="T"的情况中代码需要修改
                                if (pope == "S")
                                {
                                    SqlDataReader Reg = MyClass.getcom("insert into tb_UserLogin (name,password,pope,popenum) values('" + txtUserName.Text.Trim() + "','" + txtPwd.Text.ToString() + "','" + pope + "','" + txtpopenum.Text.Trim() + "')");
                                    MessageBox.Show("请妥善保管您的登录名和密码并登录系统!", "注册成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();//关闭当前窗口
                                    F_Login Login = new OSM.F_Login();
                                    Login.Show();
                                }
                                else
                                {
                                    if (pope == "T")
                                    {
                                        SqlDataReader Reg = MyClass.getcom("insert into tb_UserLogin (name,password,pope,popenum) values('" + txtUserName.Text.Trim() + "','" + txtPwd.Text.ToString() + "','" + pope + "','" + txtpopenum.Text.Trim() + "')");
                                        MessageBox.Show("请妥善保管您的登录名和密码并登录系统!", "注册成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();//关闭当前窗口
                                        F_Login Login = new OSM.F_Login();
                                        Login.Show();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("请勾选注册身份!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请将注册信息添加完整!", "信息输入不完整", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
            }
        }

        private void F_Register_Load(object sender, EventArgs e)
        {
            txtpopenum.Visible=false;
            label4.Visible=false;
        }

        private void butAccept_Click(object sender, EventArgs e)
        {
            Accept();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("注册尚未完成,确定返回吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Hide();
                F_Login Login = new OSM.F_Login();
                Login.Show();
            }
            else
            { }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = "学号:";
            txtpopenum.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = "教师号:";
            txtpopenum.Visible = true;
        }

    }
}
