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

namespace OSM.Forms
{
    public partial class F_InfoT : Form
    {
        public F_InfoT()
        {
            InitializeComponent();
        }
        MyMeans MyDataClass = new MyMeans();
        MyModule MyMC = new MyModule();
        public static DataSet MyDS_Grid;

        private void F_InfoT_Load(object sender, EventArgs e)
        {
            if (DataClass.MyMeans.User_Pope == "A")//如果是管理员查看模式
            {
                Info_ID.Text = DataClass.Teacher.Teacher_ID;//显示教师ID
            }
            else//如果是教师自己查看模式
            {
                this.Info_ID.Text = DataClass.MyMeans.Login_ID.ToString();//显示教师ID
            }
            this.Info_ID.ReadOnly = true;//设置教师ID为只读
            Showall();//刷新信息
        }

        private void Showall()//显示所有信息
        {
            //用自定义方法getcom()在对应数据表中查找是否有当前登陆用户
            SqlDataReader temDR = MyDataClass.getcom("select * from tb_Teacher where IDT='" + Info_ID.Text.Trim() + "'");
            bool ifcom = temDR.Read();
            //当有记录时
            if (ifcom)
            {
                this.Tag = 1;//将窗口状态设置为浏览状态
                But_Status();//改变按钮状态
                //根据指定条件查找通讯录信息,并将结果存储在DataSet数据集中
                MyDS_Grid = MyDataClass.getDataSet("select name,sex,class,email from tb_Teacher where IDT='" + Info_ID.Text.Trim() + "'", "tb_Teacher");
                this.Info_name.Text = MyDS_Grid.Tables[0].Rows[0][0].ToString();//显示姓名
                this.Info_sex.Text = MyDS_Grid.Tables[0].Rows[0][1].ToString();//显示性别
                this.Info_class.Text = MyDS_Grid.Tables[0].Rows[0][2].ToString();//显示班级
                this.Info_Email.Text = MyDS_Grid.Tables[0].Rows[0][3].ToString();//显示E-mail 
            }
            else
            {
                this.butAmend.Enabled = false;
                this.butCancel.Enabled = false;
            }
        }

        private void But_Status()//调整按钮状态
        {
            if ((int)(this.Tag) == 1)//判断窗体的Tag属性值是否为1,以确认是否执行修改操作,tag值为1时表示显示状态
            {
                //按要求改变各个控件的状态
                this.butAmend.Enabled = true;
                this.butCancel.Enabled = false;
                this.butConfirm.Enabled = false;
                Info_class.ReadOnly = true;
                Info_Email.ReadOnly = true;
                Info_ID.ReadOnly = true;
                Info_name.ReadOnly = true;
                Info_sex.Enabled = false;
            }
            else
            {
                if ((int)(this.Tag) == 2)
                {
                    //按要求改变各个控件的状态
                    this.butCancel.Enabled = true;
                    this.butConfirm.Enabled = true;
                    this.butAmend.Enabled = false;
                    Info_class.ReadOnly = false;
                    Info_Email.ReadOnly = false;
                    Info_name.ReadOnly = false;
                    Info_sex.Enabled = true;
                }
            }
        }

        private void butCLose_Click(object sender, EventArgs e)
        {
            this.Close();//关闭本窗口
        }

        private void butAmend_Click(object sender, EventArgs e)
        {
            this.Tag = 2;//将窗口状态设置为修改状态
            But_Status();//改变按钮状态
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Tag = 1;//将窗口状态重新设置为浏览状态
            Showall();//刷新信息
            But_Status();//改变按钮状态
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            //用自定义方法getcom()在对应数据表中查找是否有当前登陆用户
            SqlDataReader temDR = MyDataClass.getcom("select * from tb_Teacher where IDT='" + Info_ID.Text.Trim() + "'");
            bool ifcom = temDR.Read();
            //当有记录时,表示用户名已经修改过用户信息,此时只需要更新
            if (ifcom)
            {
                try
                {
                    SqlDataReader Update = MyDataClass.getcom("update tb_Teacher set name='" + Info_name.Text.Trim() + "',sex='" + Info_sex.Text.Trim() + "',class='" + Info_class.Text.Trim() + "',email='" + Info_Email.Text.Trim() + "' where IDT='" + Info_ID.Text.Trim() + "'");
                    MessageBox.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Tag = 1;//将窗口状态设置为浏览状态
                    But_Status();//改变按钮状态
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告");
                }
            }
            else
            {
                try
                {
                    SqlDataReader New = MyDataClass.getcom("insert into tb_Teacher (IDT,name,sex,class,email) values('" + Info_ID.Text.Trim() + "','" + Info_name.Text.Trim() + "','" + Info_sex.Text.Trim() + "','" + Info_class.Text.Trim() + "','" + Info_Email.Text.Trim() + "')");
                    //MessageBox.Show("新建记录成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Tag = 1;//将窗口状态设置为浏览状态
                    But_Status();//改变按钮状态
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告");
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
