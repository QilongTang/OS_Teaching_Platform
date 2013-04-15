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
using OSM.ModuleClass;
using OSM.Forms;

namespace OSM
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();

        private void Login()
        {
            try
            {
                if (txtUserName.Text != "" & txtUserPwd.Text != "")
                {
                    //用自定义方法getcom()在Login数据表中查找是否有当前登陆用户
                    SqlDataReader temDR = MyClass.getcom("select * from tb_UserLogin where name='" + txtUserName.Text.Trim() + "'and password='" + txtUserPwd.Text.Trim() + "'");
                    bool ifcom = temDR.Read();
                    //当有记录时,表示用户名和密码正确
                    if (ifcom)
                    {
                        string today = DateTime.Now.ToString("yyyy年MM月");//获取当天时间
                        if (today== "2012年05月"|| today == "2012年06月" || today == "2012年07月")
                        {
                            DataClass.MyMeans.Login_Name = txtUserName.Text.Trim();//将用户名记录到公共变量中
                            DataClass.MyMeans.Login_ID = temDR.GetValue(temDR.GetOrdinal("popenum")).ToString();//获取权限下的编号
                            DataClass.MyMeans.Login_Time = DateTime.Now.ToString();//获取当前登录时间
                            DataClass.MyMeans.User_Pope = temDR.GetString(temDR.GetOrdinal("pope"));//获取当前登录者权限
                            DataClass.MyMeans.User_Pwd = temDR.GetString(temDR.GetOrdinal("password"));//获取当前登录者密码
                            DataClass.MyMeans.User_ID = Convert.ToInt32(temDR.GetValue(temDR.GetOrdinal("IDU")));//获取当前登录者ID
                            this.Hide();//关闭当前窗口
                            F_Parent Main = new F_Parent();//建立新窗口
                            Main.Show();//显示新窗口
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//显示具有指定内容的消息框
                        txtUserName.Text = "";//用户名密码错误时将会把用户名和密码栏都清空
                        txtUserPwd.Text = "";
                        txtUserName.Focus();//鼠标焦点指向用户名栏便于用户重新输入
                    }
                    MyClass.con_close();//关闭数据库连接
                }
                else
                    MessageBox.Show("请将登录信息添加完整!", "信息输入不完整", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n')//判断是否按下enter键
            {
                txtUserPwd.Focus();//将鼠标焦点移动到密码文本框
                //Login();
            }
        }

        private void txtUserPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n')//判断是否按下enter键
            {
                butLogin.Focus();//将鼠标脚垫移动到登陆按钮
                Login();
            }
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = butLogin;
            this.CancelButton = butClose;
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            F_Register Reg = new OSM.Forms.F_Register();//建立新窗口
            Reg.Show();
            this.Hide();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎再次使用!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
