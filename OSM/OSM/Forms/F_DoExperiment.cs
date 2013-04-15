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
using System.IO;

namespace OSM.Forms
{
    public partial class F_DoExperiment : Form
    {
        public F_DoExperiment()
        {
            InitializeComponent();
        }
        MyModule myMC = new MyModule();
        MyMeans MyClass = new MyMeans();


        /*public bool CreateWordFile(string CheckedInfo)
        {
            try
            {
                Object Nothing = System.Reflection.Missing.Value;
                if (!Directory.Exists("D:/创建Word测试"))
                {
                    //如果要创建的目录不存在则创建目录
                    Directory.CreateDirectory("D:/创建Word测试");//创建文件所在目录
                }
                string name = "学生实验" + DataClass.MyMeans.Login_ID + DateTime.Now.ToString() + ".doc";
                object filename = "D://创建Word测试//" + name;//文件保存路径
                //创建Word文档
                Word.Application WordApp = new Word.Application();
                Word.Document WordDoc = WordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                //嵌入Word内容
                WordApp.Selection.ParagraphFormat.LineSpacing = 15f; // 设置文档的行间距
                //插入段落
                //WordApp.Selection.TypeParagraph();
                Word.Paragraph para;
                para = WordDoc.Content.Paragraphs.Add(ref Nothing);
                //正常格式
                para.Range.Font.Bold = 2;
                //para.Range.Font.Color = WdColor.wdColorRed;
                //para.Range.Font.Italic = 2;
                para.Range.Text = groupBox8.Text;//插入标题"基本信息"
                para.Range.InsertParagraphAfter();
                para.Range.Text = labelChapterName.Text+cb_ChapterName.Text;//插入章节名
                para.Range.InsertParagraphAfter();
                para.Range.Text = labelStudentName.Text + txtStudentName.Text +" "+ labelStudentNum.Text+txtStudentNum.Text;//插入学生名和学号
                para.Range.InsertParagraphAfter();
                para.Range.Font.Bold = 2;
                para.Range.Text = groupBox1.Text;//插入"实验题目"
                para.Range.InsertParagraphAfter();
                para.Range.Text = txtTitle.Text;//插入实验题目
                para.Range.InsertParagraphAfter();
                para.Range.Font.Bold = 2;
                para.Range.Text = groupBox2.Text;//插入"问题描述"
                para.Range.InsertParagraphAfter();
                para.Range.Text = txtDescription.Text;//插入问题描述
                para.Range.InsertParagraphAfter();
                para.Range.Font.Bold = 2;
                para.Range.Text = groupBox3.Text;//插入"算法设计"
                para.Range.InsertParagraphAfter();
                para.Range.Text = txtALG.Text;//插入算法设计
                para.Range.InsertParagraphAfter();
                para.Range.Font.Bold = 2;
                para.Range.Text = groupBox4.Text;//插入"运行结果"
                para.Range.InsertParagraphAfter();
                para.Range.Text = txtRunning.Text;//插入运行结果
                para.Range.InsertParagraphAfter();
                para.Range.Font.Bold = 2;
                para.Range.Text = groupBox5.Text;//插入"问题与收获"
                para.Range.InsertParagraphAfter();
                para.Range.Text = txtQuestion.Text;//插入问题与收获
                para.Range.InsertParagraphAfter();
                //落款
                WordDoc.Paragraphs.Last.Range.Text = "文档创建时间：" + DateTime.Now.ToString();
                WordDoc.Paragraphs.Last.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                //文件保存
                WordDoc.SaveAs(ref  filename, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing, ref  Nothing);
                WordDoc.Close(ref  Nothing, ref  Nothing, ref  Nothing);
                WordApp.Quit(ref  Nothing, ref  Nothing, ref  Nothing);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"警告");
                return false;
            }
        }*/

        private void F_DoExperiment_Load(object sender, EventArgs e)
        {
            if (this.Tag.Equals(0))//如果为学生新建实验报告模式
            {
                //初始化窗体中的学生信息
                this.txtStudentNum.Text = DataClass.MyMeans.Login_ID;//显示学号
                this.txtStudentName.Text = DataClass.Student.name;//显示学生名
                this.txtStudentNum.ReadOnly = true;
                this.txtStudentName.ReadOnly = true;
                //this.txtTime.Text = DateTime.Now.ToString();//显示开始实验的系统时间
                this.txtTime.Text = DateTime.Now.AddDays(0).ToString("yyyy年MM月dd日");//获取当天时间
                this.txtTime.ReadOnly = true;
                this.txtTitle.Text = DataClass.Experiment.ExperimentDone_Title;//显示正在进行的实验名
                this.txtTitle.ReadOnly = true;
                // TODO: 这行代码将数据加载到表“db_BSDataSet.tb_Chapter”中。您可以根据需要移动或删除它。
                this.tb_ChapterTableAdapter.Fill(this.db_BSDataSet.tb_Chapter);
                this.cb_ChapterName.Enabled = false;
            }
            else
            {
                if (this.Tag.Equals(1))//学生浏览实验报告模式
                {
                    //设置各个按钮不可用
                    this.butAccept.Enabled = false;
                    this.butClear.Enabled = false;
                    this.butExperimentView.Enabled = false;
                    this.butPic.Text = "查看图片";
                    //this.butSaveAsWord.Enabled = false;
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
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (this.Tag.Equals(2))//学生修改模式
                    {
                        //初始化窗体中的学生信息
                        this.txtStudentNum.Text = DataClass.MyMeans.Login_ID;//显示学号
                        this.txtStudentNum.ReadOnly = true;
                        this.txtStudentName.Text = DataClass.Student.name;//显示学生名
                        this.txtStudentName.ReadOnly = true;
                        try
                        {
                            SqlDataReader temDR = MyClass.getcom("select * from tb_Report where IDR='" + DataClass.Report.Report_ID_forStudent + "'");
                            if (temDR.Read())
                            {
                                this.txtTime.Text = temDR.GetValue(temDR.GetOrdinal("date")).ToString();
                                this.txtTime.ReadOnly = true;
                                int Charnum = Convert.ToInt32(temDR.GetValue(temDR.GetOrdinal("IDC")));
                                SqlDataReader temDR2 = MyClass.getcom("select * from tb_Chapter where IDC='" + Charnum + "'");
                                if (temDR2.Read())
                                {
                                    this.cb_ChapterName.Text = temDR2.GetString(temDR2.GetOrdinal("name"));
                                    this.cb_ChapterName.Enabled = false;//设置章节名只读
                                }
                                this.txtTitle.Text = temDR.GetString(temDR.GetOrdinal("title"));
                                this.txtTitle.ReadOnly = true;//设置标题只读
                                this.txtDescription.Text = temDR.GetValue(temDR.GetOrdinal("description")).ToString();
                                this.txtALG.Text = temDR.GetString(temDR.GetOrdinal("ALG"));
                                this.txtRunning.Text = temDR.GetString(temDR.GetOrdinal("running"));
                                this.txtQuestion.Text = temDR.GetString(temDR.GetOrdinal("question"));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        if (this.Tag.Equals(3))//教师浏览实验报告模式
                        {
                            //设置各个按钮不可用
                            this.butPic.Text = "查看图片";
                            this.butAccept.Enabled = false;
                            this.butClear.Enabled = false;
                            this.butExperimentView.Enabled = false;
                            //this.butSaveAsWord.Enabled = false;
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
                            if (this.Tag.Equals(4))//如果是学生重做模式,初始化功能与修改基本相同,只需要修改该模式下提交按钮的功能
                            {
                                //初始化窗体中的学生信息
                                this.txtStudentNum.Text = DataClass.MyMeans.Login_ID;//显示学号
                                this.txtStudentNum.ReadOnly = true;
                                this.txtStudentName.Text = DataClass.Student.name;//显示学生名
                                this.txtStudentName.ReadOnly = true;
                                try
                                {
                                    SqlDataReader temDR = MyClass.getcom("select * from tb_Report where IDR='" + DataClass.Report.Report_ID_forStudent + "'");
                                    if (temDR.Read())
                                    {
                                        this.txtTime.Text = temDR.GetValue(temDR.GetOrdinal("date")).ToString();
                                        this.txtTime.ReadOnly = true;
                                        int Charnum = Convert.ToInt32(temDR.GetValue(temDR.GetOrdinal("IDC")));
                                        SqlDataReader temDR2 = MyClass.getcom("select * from tb_Chapter where IDC='" + Charnum + "'");
                                        if (temDR2.Read())
                                        {
                                            this.cb_ChapterName.Text = temDR2.GetString(temDR2.GetOrdinal("name"));
                                            this.cb_ChapterName.Enabled = false;//设置章节名只读
                                        }
                                        this.txtTitle.Text = temDR.GetString(temDR.GetOrdinal("title"));
                                        this.txtTitle.ReadOnly = true;//设置标题只读
                                        this.txtDescription.Text = temDR.GetValue(temDR.GetOrdinal("description")).ToString();
                                        this.txtALG.Text = temDR.GetString(temDR.GetOrdinal("ALG"));
                                        this.txtRunning.Text = temDR.GetString(temDR.GetOrdinal("running"));
                                        this.txtQuestion.Text = temDR.GetString(temDR.GetOrdinal("question"));
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
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            //遍历该窗体父窗体的所有MDI子窗体
            foreach (Form childFrm in this.MdiParent.MdiChildren)
            {
                if (childFrm.Name != "F_Search" && childFrm.Name != "F_ExperimentManage" && childFrm.Name != "F_ReportManage")
                {//如果不是要找的子窗体则关闭
                    childFrm.Close();
                }
                //如果存在则显示子窗体
                if (childFrm.Name == "F_Search" || childFrm.Name == "F_ExperimentManage" || childFrm.Name == "F_ReportManage")
                {
                    childFrm.WindowState = FormWindowState.Maximized;
                    //给子窗体焦点
                    childFrm.Activate();
                }
            }
            this.Close();
        }

        private void butExperimentView_Click(object sender, EventArgs e)
        {
            //第一种方法全局变量法非常麻烦
            //第种方法出错,说集合已改变无法遍历
            /*foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "查看实验详情")
                {
                    f.Activate();//根据你要找的窗体的name匹配，假如已经打开刚激活它
                }
                else
                {
                    F_NewExperiment NE = new F_NewExperiment();
                    NE.Tag = 4;//学生观察实验内容模式
                    NE.Text = "查看实验详情";
                    NE.Show();
                }
            }*/
            //第三种方法,将此窗体设置为私有变量
            //如果在申明时初始化则关闭后无法再打开,如果在点击是初始化则还是可以重复打开
            //第四种办法 设置单独的bool型系统变量存放该窗体是否打开,虽然麻烦,但是高效
            if (DataClass.MyMeans.IfExperimentView == false)
            {
                F_NewExperiment New = new F_NewExperiment();
                New.Tag = 4;//学生在进行实验时观察实验内容模式
                New.Text = "查看实验详情";
                New.Show();
                DataClass.MyMeans.IfExperimentView = true;
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            this.txtDescription.Clear();
            this.txtALG.Clear();
            this.txtRunning.Clear();
            this.txtQuestion.Clear();
        }

        /*private void butSaveAsWord_Click(object sender, EventArgs e)
        {
            if (CreateWordFile(""))
            {
                MessageBox.Show("创建成功!请查看");
            }
        }*/

        private void butAccept_Click(object sender, EventArgs e)
        {
            if (txtALG.Text != null && txtDescription.Text != null && txtRunning.Text != null && txtQuestion.Text != null)
            {
                if (this.Tag.Equals(0))//如果是学生新建模式
                {
                    SqlDataReader temDR = MyClass.getcom("select * from tb_Student where IDS ='" + DataClass.MyMeans.Login_ID.ToString() + "'");
                    if (temDR.Read())
                    {
                        try
                        {
                            MyClass.getsqlcom("insert into tb_Report (IDE,IDS,date,title,description,ALG,running,question,IDC,class,mark,evaluation,flagSubmit,flagCorrect) values('" + DataClass.Experiment.Experiment_ID_forStudent + "','" + txtStudentNum.Text.Trim() + "','" + txtTime.Text.Trim() + "','" + txtTitle.Text.Trim() + "','" + txtDescription.Text.Trim() + "','" + txtALG.Text.Trim() + "','" + txtRunning.Text.Trim() + "','" + txtQuestion.Text.Trim() + "','" + cb_ChapterName.SelectedValue + "','" + temDR.GetString(temDR.GetOrdinal("class")) + "','无','无','false','false')");
                            MessageBox.Show("保存成功,请在报告管理中查改!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (this.Tag.Equals(2))//如果是学生修改模式
                    {
                        try
                        {
                            MyClass.getsqlcom("update tb_Report set description='" + txtDescription.Text.Trim() + "',ALG='" + txtALG.Text.Trim() + "',running='" + txtRunning.Text.Trim() + "',question='" + txtQuestion.Text.Trim() + "' where IDR='" + DataClass.Report.Report_ID_forStudent + "'");
                            MessageBox.Show("保存成功,请在报告管理中查改!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.butClose_Click(null, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "警告");
                        }
                    }
                    else
                    {
                        if (this.Tag.Equals(4))//如果是学生重做模式
                        {
                            try
                            {
                                MyClass.getsqlcom("update tb_Report set description='" + txtDescription.Text.Trim() + "',ALG='" + txtALG.Text.Trim() + "',running='" + txtRunning.Text.Trim() + "',question='" + txtQuestion.Text.Trim() + "',flagSubmit='true' where IDR='" + DataClass.Report.Report_ID_forStudent + "'");
                                MessageBox.Show("重做成功,并且已经自动帮您提交!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.butClose_Click(null, null);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "警告");
                            }
                        }
                    }
                }
            }
            else
                MessageBox.Show("请将实验报告填写完整!", "提示");
        }

        private void butPic_Click(object sender, EventArgs e)
        {
            if (this.Tag.Equals(0) || this.Tag.Equals(2) || this.Tag.Equals(4))//学生新建,修改和重做模式
            {
                /*if (txtALG.Text != "" && txtDescription.Text != "" && txtQuestion.Text != "" && txtRunning.Text != "")
                {*/
                F_PicView New = new F_PicView();
                New.MdiParent = this.MdiParent;
                New.Tag = this.Tag;//设置相应的模式
                New.Text = "图片操作";
                New.WindowState = FormWindowState.Maximized;//最大化
                New.Show();
                /*}
                else
                {
                    MessageBox.Show("请先填写实验报告内容再点击此按钮!", "提示");
                }*/
            }
            else
            {
                if (this.Tag.Equals(1))//学生查看实验报告模式
                {
                    DataClass.Student.Student_ID = DataClass.MyMeans.Login_ID;
                    F_PicView New = new F_PicView();
                    New.MdiParent = this.MdiParent;
                    New.Tag = 3;//设置为学生查看实验报告图片模式
                    New.Text = "图片查看";
                    New.WindowState = FormWindowState.Maximized;//最大化
                    New.Show();
                }
                else
                {
                    if (this.Tag.Equals(3))//教师查看实验报告模式
                    {
                        F_PicView New = new F_PicView();
                        New.MdiParent = this.MdiParent;
                        New.Tag = 1;//设置为教师查看实验报告图片模式
                        New.Text = "图片查看";
                        New.WindowState = FormWindowState.Maximized;//最大化
                        New.Show();
                    }
                }
            }
        }
    }
}
