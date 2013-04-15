using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSM.ModuleClass;
using OSM.DataClass;
using OSM.SkinClass;
using SnippingTool;

namespace OSM.Forms
{
    public partial class F_Parent : Form
    {
        System.Windows.Forms.MdiClient mdiClient;
        MyMeans MyDataClass = new MyMeans();
        MyModule MyFrm = new MyModule();
        MyModule MyMenu = new MyModule();

        public F_Parent()
        {
            InitializeComponent();
            int iCnt = this.Controls.Count;
            for (int i = 0; i < this.Controls.Count; i++)
            {//遍历控件列表，找到MdiClient，也就是MDI客户区
                if (this.Controls[i].GetType().ToString() == "System.Windows.Forms.MdiClient")
                {//获取窗体客户区实例
                    this.mdiClient = (System.Windows.Forms.MdiClient)this.Controls[i];
                    break;
                }
            }
        }

        public bool checkchildfrm(string childfrmname)
        {//遍历MDI子窗体
            foreach (Form childFrm in this.MdiChildren)
            {//查找与指定名称相匹配的子窗体
                if (childFrm.Name != childfrmname)
                {//如果不是要找的子窗体则关闭
                    childFrm.Close();
                }
                if (childFrm.Name == childfrmname)
                {//如果存在则显示子窗体
                    //if (childFrm.WindowState == FormWindowState.Minimized)
                    childFrm.WindowState = FormWindowState.Maximized;
                    //给子窗体焦点
                    childFrm.Activate();
                    return true;//返回成功找到布尔值
                }
            }
            return false;//返回没有成功找到布尔值
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // 创建此子窗体的一个新实例
            Form childForm = new Form();
            // 在显示该窗体前使其成为此 MDI 窗体的子窗体
            childForm.MdiParent = this;
            //childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void F_Parent_Load(object sender, EventArgs e)
        {
            MySkinClass.AddSkinMenu(更改皮肤ToolStripMenuItem);
            MyMenu.GetMenu(treeView1, menuStrip1);//使用菜单栏中的项填充导航菜单
            treeView1.ExpandAll();
            treeView1.Visible = false;
            toolStripStatusLabel3.Text = DataClass.MyMeans.Login_Name + "|";
            toolStripStatusLabel5.Text = DataClass.MyMeans.Login_Time;
            if (DataClass.MyMeans.User_Pope == "S")
            {
                教师操作ToolStripMenuItem.Enabled = false;
                for (int j = 0; j < 管理员功能ToolStripMenuItem.DropDownItems.Count; j++)
                {
                    管理员功能ToolStripMenuItem.DropDownItems[j].Enabled = false;
                }
            }
            else
            {
                if (DataClass.MyMeans.User_Pope == "T")
                {
                    学生操作ToolStripMenuItem.Enabled = false;
                    for (int j = 1; j < 管理员功能ToolStripMenuItem.DropDownItems.Count; j++)
                    {
                        管理员功能ToolStripMenuItem.DropDownItems[j].Enabled = false;
                    }
                }
            }

        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void vMwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "exe文件(*.exe)|*.exe";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                System.Diagnostics.Process.Start(FileName);
                //存储路径,下次直接快捷打开,如果路径更改,则清空后重复第一次操作
            }
        }

        private void 实验管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_ExperimentManage") == false)
            {
                F_ExperimentManage F_ER = new F_ExperimentManage();
                F_ER.MdiParent = this;
                F_ER.Tag = 0;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Text = "实验管理";
                F_ER.Show();
            }
        }

        private void 个人信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DataClass.MyMeans.User_Pope == "S")
            {
                if (checkchildfrm("F_InfoS") == false)
                {
                    F_InfoS F_ER = new F_InfoS();
                    F_ER.MdiParent = this;
                    F_ER.WindowState = FormWindowState.Maximized;
                    F_ER.Text = "个人信息";
                    F_ER.Show();
                }
            }
            else
            {
                if (checkchildfrm("F_InfoT") == false)
                {
                    F_InfoT F_ER = new F_InfoT();
                    F_ER.MdiParent = this;
                    F_ER.WindowState = FormWindowState.Maximized;
                    F_ER.Text = "个人信息";
                    F_ER.Show();
                }
            }
        }

        private void 新建实验ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_NewExperiment") == false)
            {
                F_NewExperiment F_ER = new F_NewExperiment();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Text = "新建实验";
                F_ER.Tag = 0;//设置窗体的tag值为0代表新建模式
                F_ER.Show();
            }
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataClass.MyMeans.Login_n++;
            Application.Restart();
        }

        private void 实验统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_ExperimentStats") == false)
            {
                F_ExperimentStats F_ER = new F_ExperimentStats();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Text = "实验统计";
                F_ER.Show();
            }
        }

        private void 数据库备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataClass.MyMeans.IFBackup == false)
            {
                F_HaveBack F_HB = new F_HaveBack();
                F_HB.Text = "数据库备份";
                F_HB.Show();
                DataClass.MyMeans.IFBackup = true;
            }
        }

        private void 教师操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //用自定义方法getcom()在对应数据表中查找是否有当前登陆用户
            SqlDataReader temDR = MyDataClass.getcom("select * from tb_Teacher where IDT='" + DataClass.MyMeans.Login_ID.ToString() + "'");
            bool ifcom = temDR.Read();
            //当有记录时,表示用户名已经修改过用户信息,此时只需要更新
            if (ifcom)
            { }
            else
            {
                if (MessageBox.Show("您的个人信息还未完善请填写", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (checkchildfrm("F_InfoT") == false)
                    {
                        F_InfoT F_ER = new F_InfoT();
                        F_ER.Text = "完善个人信息";
                        if (F_ER.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("个人信息补充成功！欢迎进入操作系统教学实验平台!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//行数为零警告
                        }
                    }
                }
            }
        }

        private void 学生操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //用自定义方法getcom()在对应数据表中查找是否有当前登陆用户
            SqlDataReader temDR = MyDataClass.getcom("select * from tb_Student where IDS='" + DataClass.MyMeans.Login_ID.ToString() + "'");
            bool ifcom = temDR.Read();
            //当有记录时,表示用户名已经修改过用户信息,此时只需要更新
            if (ifcom)
            {
                DataClass.Student.name = temDR.GetString(temDR.GetOrdinal("name"));
            }
            else
            {
                if (MessageBox.Show("您的个人信息还未完善请填写", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (checkchildfrm("F_InfoS") == false)
                    {
                        F_InfoS F_ER = new F_InfoS();
                        F_ER.Text = "完善个人信息";
                        if (F_ER.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("个人信息补充成功！欢迎进入操作系统教学实验平台!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//行数为零警告
                        }
                    }
                }
            }
        }

        private void 报告管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_MarkView") == false)
            {
                F_ReportManage F_ER = new F_ReportManage();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Tag = 1;//设置为学生浏览模式
                F_ER.Text = "报告管理";
                F_ER.Show();
            }
        }

        private void 实验选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_ExperimentManage") == false)
            {
                F_ExperimentManage F_EV = new F_ExperimentManage();
                F_EV.MdiParent = this;
                F_EV.WindowState = FormWindowState.Maximized;
                F_EV.Tag = 1;
                F_EV.Text = "实验选择";
                F_EV.Show();
            }
        }

        private void 截图工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string FileName = "D:\\SnippingTool.exe";
            //System.Diagnostics.Process.Start(FileName);
            Main SnippingForm = new Main();//新建SnippingTool项目的main窗体来截图
            SnippingForm.Show();
        }

        private void 查找实验ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_Search") == false)
            {
                F_Search F_ER = new F_Search();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Tag = 0;//教师查询实验模式
                F_ER.Text = "实验查找";
                F_ER.Show();
            }
            else
            {
                foreach (Form childFrm in this.MdiChildren)
                {//查找与指定名称相匹配的子窗体
                    childFrm.Close();
                }
                F_Search F_ER = new F_Search();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Tag = 0;//教师查询实验报告模式
                F_ER.Text = "实验查找";
                F_ER.Show();
            }

        }

        private void 实验查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_Search") == false)
            {
                F_Search F_ER = new F_Search();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Tag = 2;//学生查询实验报告模式
                F_ER.Text = "实验查找";
                F_ER.Show();
            }
            else
            {
                foreach (Form childFrm in this.MdiChildren)
                {//查找与指定名称相匹配的子窗体
                    childFrm.Close();
                }
                F_Search F_ER = new F_Search();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Tag = 2;//学生查询实验报告模式
                F_ER.Text = "实验查找";
                F_ER.Show();
            }
        }

        private void 报告查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_Search") == false)
            {
                F_Search F_ER = new F_Search();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Tag = 3;//学生查询实验报告模式
                F_ER.Text = "报告查找";
                F_ER.Show();
            }
            else
            {
                foreach (Form childFrm in this.MdiChildren)
                {//查找与指定名称相匹配的子窗体
                    childFrm.Close();
                }
                F_Search F_ER = new F_Search();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Tag = 3;//学生查询实验报告模式
                F_ER.Text = "报告查找";
                F_ER.Show();
            }
        }

        private void 批改报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_Search") == false)
            {
                F_Search F_ER = new F_Search();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Tag = 1;//教师查询实验报告模式
                F_ER.Text = "报告查找";
                F_ER.Show();
            }
            else
            {
                foreach (Form childFrm in this.MdiChildren)
                {//查找与指定名称相匹配的子窗体
                    childFrm.Close();
                }
                F_Search F_ER = new F_Search();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Tag = 1;//教师查询实验报告模式
                F_ER.Text = "报告查找";
                F_ER.Show();
            }
        }

        private void 锁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Lock F_ER = new F_Lock();
            F_ER.Text = "锁定";
            if (F_ER.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("解锁成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//行数为零警告
            }
        }

        private void 管理员功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 开启管理员权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_Doadmin") == false)
            {
                F_Doadmin F_ER = new F_Doadmin();
                if (F_ER.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("开启权限成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//行数为零警告
                    for (int j = 1; j < this.管理员功能ToolStripMenuItem.DropDownItems.Count; j++)
                    {
                        管理员功能ToolStripMenuItem.DropDownItems[j].Enabled = true;
                    }
                    管理员功能ToolStripMenuItem.DropDownItems[0].Enabled = false;
                }
            }
        }

        private void 密码修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_UpdatePwd F_ER = new F_UpdatePwd();
            if (F_ER.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("密码修改成功,请妥善保管您的新密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//行数为零警告
            }
        }

        private void 章节管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (checkchildfrm("F_ChapterManage") == false)
            {
                F_ChapterManage F_ER = new F_ChapterManage();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Text = "章节管理";
                F_ER.Show();
            }
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkchildfrm("F_InfoManage") == false)
            {
                F_InfoManage F_ER = new F_InfoManage();
                F_ER.MdiParent = this;
                F_ER.WindowState = FormWindowState.Maximized;
                F_ER.Text = "用户管理";
                F_ER.Show();
            }
        }


        /*private int childFormNumber = 0;
        System.Windows.Forms.MdiClient mdiClient;
        public Main_form_s()
        {
            InitializeComponent();
            //获取当前主窗体的子控件数量
            int iCnt = this.Controls.Count;
            for (int i = 0; i < this.Controls.Count; i++)
            {//遍历控件列表，找到MdiClient，也就是MDI客户区
                if (this.Controls[i].GetType().ToString() ==
                    "System.Windows.Forms.MdiClient")
                {//获取窗体客户区实例
                    this.mdiClient = (System.Windows.Forms.MdiClient)this.Controls[i];
                    break;
                }
            }
        }
        public bool checkchildfrm(string childfrmname)
        {//遍历MDI子窗体
            foreach (Form childFrm in this.MdiChildren)
            {//查找与指定名称相匹配的子窗体
                if (childFrm.Name == childfrmname)
                {//如果存在则显示子窗体
                    if (childFrm.WindowState == FormWindowState.Minimized)
                        childFrm.WindowState = FormWindowState.Normal;
                    //给子窗体焦点
                    childFrm.Activate();
                    return true;//返回成功找到布尔值
                }
            }
            return false;//返回没有成功找到布尔值
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            // 创建此子窗体的一个新实例。
            Form childForm = new Form();
            // 在显示该窗体前使其成为此 MDI 窗体的子窗体。
            childForm.MdiParent = this;
            childForm.Text = "窗口" + childFormNumber++;
            childForm.Show();
        }*/
    }
}
