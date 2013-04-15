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
namespace OSM.Forms
{
    public partial class F_GiveMark : Form
    {
        public F_GiveMark()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();
        string FormerMark = "";
        string FormerEvaluation = "";

        private void butClose_Click(object sender, EventArgs e)
        {
            //遍历该窗体父窗体的所有MDI子窗体
            foreach (Form childFrm in this.MdiParent.MdiChildren)
            {//查找与指定名称相匹配的子窗体
                if (childFrm.Name != "F_Search" && childFrm.Name != "F_ReportManage")
                {//如果不是要找的子窗体则关闭
                    childFrm.Close();
                }
                if (childFrm.Name == "F_Search" || childFrm.Name == "F_ReportManage")
                {//如果存在则显示子窗体
                    childFrm.WindowState = FormWindowState.Maximized;
                    //给子窗体焦点
                    childFrm.Activate();
                }
            }
            this.Close();
        }

        private void F_GiveMark_Load(object sender, EventArgs e)
        {
            if (this.Tag.Equals(0))//如果是教师第一次批改实验报告模式
            {
                this.butAmend.Enabled = false;
                this.butCancel.Enabled = false;
                try
                {
                    SqlDataReader temDR = MyClass.getcom("select * from tb_Report where IDR='" + DataClass.Report.Report_ID_forTeacher + "'");
                    if (temDR.Read())
                    {
                        this.txtTime.Text = temDR.GetValue(temDR.GetOrdinal("date")).ToString();
                        this.txtTime.ReadOnly = true;
                        SqlDataReader temDR2 = MyClass.getcom("select * from tb_Chapter where IDC='" + temDR.GetValue(temDR.GetOrdinal("IDC")) + "'");
                        if (temDR2.Read())
                        {
                            this.cb_ChapterName.Text = temDR2.GetString(temDR2.GetOrdinal("name"));
                            this.cb_ChapterName.Enabled = false;//设置章节名只读
                        }
                        this.txtStudentNum.Text = temDR.GetString(temDR.GetOrdinal("IDS"));
                        SqlDataReader temDR3 = MyClass.getcom("select * from tb_Student where IDS ='" + this.txtStudentNum.Text.Trim() + "'");
                        if (temDR3.Read())
                            this.txtStudentName.Text = temDR3.GetString(temDR3.GetOrdinal("name"));
                        this.txtStudentNum.ReadOnly = true;
                        this.txtStudentName.ReadOnly = true;
                        this.txtTitle.Text = temDR.GetString(temDR.GetOrdinal("title"));
                        this.txtTitle.ReadOnly = true;
                        this.txtDescription.Text = temDR.GetValue(temDR.GetOrdinal("description")).ToString();
                        this.txtDescription.ReadOnly = true;
                        this.txtALG.Text = temDR.GetString(temDR.GetOrdinal("ALG"));
                        this.txtALG.ReadOnly = true;
                        this.txtRunning.Text = temDR.GetString(temDR.GetOrdinal("running"));
                        this.txtRunning.ReadOnly = true;
                        this.txtQuestion.Text = temDR.GetString(temDR.GetOrdinal("question"));
                        this.txtQuestion.ReadOnly = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (this.Tag.Equals(1))//如果是教师修改已经批改过的报告模式
                {
                    this.butOK.Enabled = false;
                    this.butCancel.Enabled = false;
                    try
                    {
                        SqlDataReader temDR = MyClass.getcom("select * from tb_Report where IDR='" + DataClass.Report.Report_ID_forTeacher + "'");
                        if (temDR.Read())
                        {
                            this.txtTime.Text = temDR.GetValue(temDR.GetOrdinal("date")).ToString();
                            this.txtTime.ReadOnly = true;
                            SqlDataReader temDR2 = MyClass.getcom("select * from tb_Chapter where IDC='" + temDR.GetValue(temDR.GetOrdinal("IDC")) + "'");
                            if (temDR2.Read())
                            {
                                this.cb_ChapterName.Text = temDR2.GetString(temDR2.GetOrdinal("name"));
                                this.cb_ChapterName.Enabled = false;//设置章节名只读
                            }
                            this.txtStudentNum.Text = temDR.GetString(temDR.GetOrdinal("IDS"));
                            SqlDataReader temDR3 = MyClass.getcom("select * from tb_Student where IDS ='" + this.txtStudentNum.Text.Trim() + "'");
                            if (temDR3.Read())
                                this.txtStudentName.Text = temDR3.GetString(temDR3.GetOrdinal("name"));
                            this.txtStudentNum.ReadOnly = true;
                            this.txtStudentName.ReadOnly = true;
                            this.txtTitle.Text = temDR.GetString(temDR.GetOrdinal("title"));
                            this.txtTitle.ReadOnly = true;
                            this.txtDescription.Text = temDR.GetValue(temDR.GetOrdinal("description")).ToString();
                            this.txtDescription.ReadOnly = true;
                            this.txtALG.Text = temDR.GetString(temDR.GetOrdinal("ALG"));
                            this.txtALG.ReadOnly = true;
                            this.txtRunning.Text = temDR.GetString(temDR.GetOrdinal("running"));
                            this.txtRunning.ReadOnly = true;
                            this.txtQuestion.Text = temDR.GetString(temDR.GetOrdinal("question"));
                            this.txtQuestion.ReadOnly = true;
                            this.txtMark.Text = temDR.GetString(temDR.GetOrdinal("mark"));
                            this.txtMark.ReadOnly = true;
                            this.txtEvaluation.Text = temDR.GetString(temDR.GetOrdinal("evaluation"));
                            this.txtEvaluation.ReadOnly = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (this.Tag.Equals(2))//如果是学生查看已被批分的实验报告模式
                    {
                        this.butAmend.Enabled = false;
                        this.butCancel.Enabled = false;
                        this.butOK.Enabled = false;
                        try
                        {
                            SqlDataReader temDR = MyClass.getcom("select * from tb_Report where IDR='" + DataClass.Report.Report_ID_forStudent + "'");
                            if (temDR.Read())
                            {
                                this.txtTime.Text = temDR.GetValue(temDR.GetOrdinal("date")).ToString();
                                this.txtTime.ReadOnly = true;
                                SqlDataReader temDR2 = MyClass.getcom("select * from tb_Chapter where IDC='" + temDR.GetValue(temDR.GetOrdinal("IDC")) + "'");
                                if (temDR2.Read())
                                {
                                    this.cb_ChapterName.Text = temDR2.GetString(temDR2.GetOrdinal("name"));
                                    this.cb_ChapterName.Enabled = false;//设置章节名只读
                                }
                                this.txtStudentNum.Text = temDR.GetString(temDR.GetOrdinal("IDS"));
                                SqlDataReader temDR3 = MyClass.getcom("select * from tb_Student where IDS ='" + this.txtStudentNum.Text.Trim() + "'");
                                if (temDR3.Read())
                                    this.txtStudentName.Text = temDR3.GetString(temDR3.GetOrdinal("name"));
                                this.txtStudentNum.ReadOnly = true;
                                this.txtStudentName.ReadOnly = true;
                                this.txtTitle.Text = temDR.GetString(temDR.GetOrdinal("title"));
                                this.txtTitle.ReadOnly = true;
                                this.txtDescription.Text = temDR.GetValue(temDR.GetOrdinal("description")).ToString();
                                this.txtDescription.ReadOnly = true;
                                this.txtALG.Text = temDR.GetString(temDR.GetOrdinal("ALG"));
                                this.txtALG.ReadOnly = true;
                                this.txtRunning.Text = temDR.GetString(temDR.GetOrdinal("running"));
                                this.txtRunning.ReadOnly = true;
                                this.txtQuestion.Text = temDR.GetString(temDR.GetOrdinal("question"));
                                this.txtQuestion.ReadOnly = true;
                                this.txtMark.Text = temDR.GetString(temDR.GetOrdinal("mark"));
                                this.txtMark.ReadOnly = true;
                                this.txtEvaluation.Text = temDR.GetString(temDR.GetOrdinal("evaluation"));
                                this.txtEvaluation.ReadOnly = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butPic_Click(object sender, EventArgs e)
        {
            if (this.Tag.Equals(2))
            {
                F_PicView picview = new F_PicView();
                DataClass.Student.Student_ID = this.txtStudentNum.Text.Trim();
                picview.MdiParent = this.MdiParent;
                picview.Tag = 3;
                picview.Text = "查看附图";
                picview.Show();
            }
            else
            {
                F_PicView picview = new F_PicView();
                DataClass.Student.Student_ID = this.txtStudentNum.Text.Trim();
                picview.MdiParent = this.MdiParent;
                picview.Tag = 1;
                picview.Text = "查看附图";
                picview.Show();
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtEvaluation.Text != "")
            {
                if (txtMark.Text != "")
                {
                    if (Convert.ToInt32(txtMark.Text.Trim()) < 60)//如果不及格,则让学生退回重做
                    {
                        try
                        {
                            MyClass.getsqlcom("update tb_Report set mark='" + txtMark.Text.Trim() + "',evaluation='" + txtEvaluation.Text.Trim() + "',flagCorrect='true',flagSubmit='false' where IDR='" + DataClass.Report.Report_ID_forTeacher + "'");
                            MessageBox.Show("保存成功,欢迎继续使用!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.butClose_Click(null, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "警告");
                        }
                    }
                    else//如果学生及格,则不用重做
                    {
                        try
                        {
                            MyClass.getsqlcom("update tb_Report set mark='" + txtMark.Text.Trim() + "',evaluation='" + txtEvaluation.Text.Trim() + "',flagCorrect='true',flagSubmit='true' where IDR='" + DataClass.Report.Report_ID_forTeacher + "'");
                            MessageBox.Show("保存成功,欢迎继续使用!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.butClose_Click(null, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "警告");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请输入完整评分后再次按确认!", "提示");
                }
            }
            else
            {
                MessageBox.Show("请输入完整评语后再次按确认!", "提示");
            }
        }

        private void butAmend_Click(object sender, EventArgs e)
        {
            this.butOK.Enabled = true;
            this.butCancel.Enabled = true;
            this.butAmend.Enabled = false;
            this.txtEvaluation.ReadOnly = false;
            this.txtMark.ReadOnly = false;
            FormerMark = txtMark.Text.Trim();
            FormerEvaluation = txtEvaluation.Text.Trim();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            txtMark.Text = FormerMark;
            txtEvaluation.Text = FormerEvaluation;
            this.butOK.Enabled = false;
            this.butCancel.Enabled = false;
            this.butAmend.Enabled = true;
            this.txtEvaluation.ReadOnly = true;
            this.txtMark.ReadOnly = true;
        }

        private void butOpenWord_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = DataClass.Report.Report_Path;//Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "word文档(*.doc)|*.doc";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    System.Diagnostics.Process.Start(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
