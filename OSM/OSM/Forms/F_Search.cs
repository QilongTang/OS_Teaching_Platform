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
using System.IO;

namespace OSM.Forms
{
    public partial class F_Search : Form
    {
        public F_Search()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();
        DataSet MyDS_Grid = new DataSet();
        MyModule MyMC = new MyModule();
        public string ARsign = " AND ";
        //string AllExp = "SELECT e.ID,e.IDE,e.IDT,e.IDC,e.title,e.purpose,e.detail,e.preparation,e.guidance,e.flag FROM tb_Experiment AS e INNER JOIN tb_Student AS s ON e.IDT = s.IDT WHERE (s.IDS = '" + DataClass.MyMeans.Login_ID + "')";
        string AllExp = "SELECT [ID] AS 实验编号, [title] AS 实验名称 ,REPLACE(REPLACE([flag],1,'已发布'),0,'未发布')状态,[purpose] AS 实验目的,[detail] AS 实验内容,[preparation] AS 实验准备 from tb_Experiment where flag='true'";//只显示已经发布的实验
        string AllRep = "SELECT [IDR] AS 报告编号,[IDE] AS 实验编号,[IDS] AS 学生学号,[date] AS 完成时间,[title] AS 实验名称,REPLACE(REPLACE([flagCorrect],1,'已批改'),0,'未批改')状态,[mark] AS 实验成绩 from tb_Report where flagSubmit='true'";//若已经退回的实验报告则不考虑,只显示已经提交的

        public string makesql(string sql, string ARsign)//组装查询sql语句
        {
            if (cb_ChapterName.Text.Trim() != "")//如果实验章节有选择
            {
                string a;
                SqlDataReader MyDR = MyClass.getcom("select * from tb_Chapter where name ='" + cb_ChapterName.Text.Trim() + "'");
                if (MyDR.Read())
                {
                    int id = Convert.ToInt32(MyDR.GetValue(0));
                    if (id < 10)
                        a = "0" + id.ToString();
                    else
                        a = id.ToString();
                    //sql += ARsign +"[IDC] LIKE '__" + a + "__'";
                    sql += ARsign + "[IDC] ='" + a + "'";
                }
            }
            if (cb_TeacherName.Text.Trim() != "")//如果实验章节有选择
            {
                string a;
                SqlDataReader MyDR = MyClass.getcom("select * from tb_Teacher where name ='" + cb_TeacherName.Text.Trim() + "'");
                if (MyDR.Read())
                {
                    int id = Convert.ToInt32(MyDR.GetValue(0));
                    if (id < 10)
                        a = "0" + id.ToString();
                    else
                        a = id.ToString();
                    sql += ARsign + "IDT = '" + a + "'";
                }
            }
            if (txtDate.Text.ToString() != "")//如果输入了时间
            {
                string a = "%" + txtDate.Text.ToString() + "%";
                sql += ARsign + " [date] LIKE '" + a + "'";
            }
            if (txtTitle.Text.ToString() != "")//如果输入了实验标题
            {
                string a = "%" + txtTitle.Text.ToString() + "%";
                sql += ARsign + " [title] LIKE '" + a + "'";
            }

            if (txtCondition.Text.ToString() != "")//如果输入了关键字
            {
                if (radioButtonStuClass.Checked == true)//如果输入的是学生班级
                {
                    string a = "%" + txtCondition.Text.Trim() + "%";
                    sql += ARsign + " [class] LIKE '" + a + "'";
                }
                else
                {
                    if (radioButtonStuName.Checked == true)//如果输入的是学生名
                    {
                        SqlDataReader MyDR = MyClass.getcom("select * from tb_Student where name like '%" + txtCondition.Text.Trim() + "%'");//先搜索该学生是否存在
                        if (MyDR.Read())
                        {
                            string ids = MyDR.GetString(MyDR.GetOrdinal("IDS")).ToString();
                            sql += ARsign + "[IDS] LIKE '" + ids + "'";//如果该学生存在,则将查到的学号套入查找
                        }
                        else
                            sql += ARsign + "[IDS] LIKE '    '";//如果该学生不存在,则学号为空白
                    }
                    else
                    {
                        if (radioButtonStuNum.Checked == true)//如果输入的是学生学号
                        {
                            string a = "%" + txtCondition.Text.Trim() + "%";
                            sql += ARsign + " [IDS] LIKE '" + a + "'";
                        }
                        else
                        {
                            MessageBox.Show("请点选关键词条件!", "提示");
                        }
                    }
                }
            }
            if (cb_MarkStatus.Text != "全部" && cb_MarkStatus.Text != "")//如果是批改状态查询
            {
                if (cb_MarkStatus.Text == "已批改")
                {
                    sql += ARsign + "flagCorrect='true' and flagCorrect is not null";
                }
                else
                {
                    if (cb_MarkStatus.Text == "未批改")
                    {
                        sql += ARsign + "flagCorrect='false' and flagCorrect is not null";
                    }
                }
            }
            if (cb_Mark.Text != "全部" && cb_Mark.Text != "")//如果按分数范围查询
            {
                if (cb_Mark.Text == "不及格")
                    sql += ARsign + "mark<60";
                if (cb_Mark.Text == "60 - 70分")
                    sql += ARsign + "mark>60 and mark<70 and mark is not null";
                if (cb_Mark.Text == "70 - 80分")
                    sql += ARsign + "mark>70 and mark<80 and mark is not null";
                if (cb_Mark.Text == "80 - 90分")
                    sql += ARsign + " mark>80 and mark<90 and mark is not null";
                if (cb_Mark.Text == "90 - 满分")
                    sql += ARsign + "mark>90 and mark<100 and mark is not null";
            }
            return sql;
        }


        private void F_ExperimentView_Load(object sender, EventArgs e)
        {
            MyMC.CoPassData(cb_TeacherName, "tb_Teacher");
            MyMC.CoPassData(cb_ChapterName, "tb_Chapter");
            checkBoxOnlyMeFlag.Checked = true;
            butCreatWord.Enabled = false;
            if (this.Tag.Equals(0))//如果是教师查实验模式
            {
                radioButtonESearch.Checked = true;//查实验勾选
                butGiveMark.Enabled = false;//批改实验按钮失效
                butDoExperiment.Enabled = false;
                txtDate.Enabled = false;
                txtCondition.Enabled = false;
                cb_Mark.Enabled = false;
                cb_MarkStatus.Enabled = false;
                radioButtonStuNum.Enabled = false;
                radioButtonStuName.Enabled = false;
                radioButtonStuClass.Enabled = false;
            }
            else
            {
                if (this.Tag.Equals(1))//如果是教师查实验报告模式
                {
                    butGiveMark.Enabled = true;
                    radioButtonRSearch.Checked = true;//查实验报告被选中
                    butDoExperiment.Enabled = false;
                    cb_TeacherName.Enabled = false;
                    butCreatWord.Enabled = true;//使生成文档按钮可用
                }
                else
                {
                    if (this.Tag.Equals(2))//如果是学生查实验模式
                    {
                        butGiveMark.Enabled = false;//批改实验按钮失效
                        radioButtonESearch.Checked = true;//查实验勾选
                        txtDate.Enabled = false;
                        butDoExperiment.Enabled = true;
                        txtCondition.Enabled = false;
                        cb_Mark.Enabled = false;
                        cb_MarkStatus.Enabled = false;
                        radioButtonStuNum.Enabled = false;
                        radioButtonStuName.Enabled = false;
                        radioButtonStuClass.Enabled = false;
                    }
                    else
                    {
                        if (this.Tag.Equals(3))//如果是学生查报告模式
                        {
                            butGiveMark.Enabled = false;//批改实验按钮失效
                            radioButtonRSearch.Checked = true;//查实验报告被选中
                            butDoExperiment.Enabled = false;
                            cb_TeacherName.Enabled = false;
                        }
                    }
                }
            }
        }

        private void butView_Click(object sender, EventArgs e)
        {
            int select_n = 0;
            if (radioButtonESearch.Checked == true && (this.Tag.Equals(0) || this.Tag.Equals(1)))//教师浏览实验
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                    {
                        //当该行处于选定状态时
                        if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                        {
                            select_n++;
                            if (select_n < 2)
                            {
                                DataClass.Experiment.Experiment_ID_forTeahcer = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                F_NewExperiment New = new F_NewExperiment();
                                New.MdiParent = this.MdiParent;
                                New.WindowState = FormWindowState.Maximized;
                                New.Text = "显示实验";
                                New.Tag = 1;//设置新窗体的tag值为1表示教师浏览实验模式
                                New.Show();
                            }
                            else
                            {
                                MessageBox.Show("多选查看时将只打开您勾选的第一个实验", "提示");
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                if (radioButtonRSearch.Checked == true && (this.Tag.Equals(0) || this.Tag.Equals(1)))//教师浏览实验报告模式
                {
                    select_n = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                        {
                            //当该行处于选定状态时
                            if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                            {
                                select_n++;
                                if (select_n < 2)
                                {
                                    DataClass.Report.Report_ID_forTeacher = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                    DataClass.Experiment.Experiment_ID_forTeahcer = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                    DataClass.Student.Student_ID = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                    F_DoExperiment New = new F_DoExperiment();
                                    New.MdiParent = this.MdiParent;
                                    New.WindowState = FormWindowState.Maximized;
                                    New.Text = "显示实验报告";
                                    New.Tag = 3;//设置新窗体的tag值为3表示教师浏览实验报告模式
                                    New.Show();
                                }
                                else
                                {
                                    MessageBox.Show("多选查看时将只打开您勾选的第一个实验", "提示");
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (radioButtonESearch.Checked == true && (this.Tag.Equals(2) || this.Tag.Equals(3)))//学生浏览实验模式
                    {
                        select_n = 0;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                            {
                                //当该行处于选定状态时
                                if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                                {
                                    select_n++;
                                    if (select_n < 2)
                                    {
                                        DataClass.Experiment.Experiment_ID_forStudent = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                        F_NewExperiment New = new F_NewExperiment();
                                        New.MdiParent = this.MdiParent;
                                        New.WindowState = FormWindowState.Maximized;
                                        New.Text = "显示实验";
                                        New.Tag = 4;//设置新窗体的tag值为4表示学生浏览实验模式
                                        New.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("多选查看时将只打开您勾选的第一个实验", "提示");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (radioButtonRSearch.Checked == true && (this.Tag.Equals(2) || this.Tag.Equals(3)))//学生浏览实验报告模式
                        {
                            select_n = 0;
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                            {
                                if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                                {
                                    //当该行处于选定状态时
                                    if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                                    {
                                        select_n++;
                                        if (select_n < 2)
                                        {
                                            DataClass.Report.Report_ID_forStudent = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                            DataClass.Experiment.Experiment_ID_forStudent = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                            F_DoExperiment New = new F_DoExperiment();
                                            New.MdiParent = this.MdiParent;
                                            New.WindowState = FormWindowState.Maximized;
                                            New.Text = "显示实验报告";
                                            New.Tag = 1;//设置新窗体的tag值为1表示学生浏览实验报告模式
                                            New.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("多选查看时将只打开您勾选的第一个实验", "提示");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ARsign = " AND ";
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ARsign = " OR ";
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            //按照指定的条件进行查询
            try
            {
                if (radioButtonESearch.Checked == true)//如果是查实验模式
                {
                    MyDS_Grid = MyClass.getDataSet(makesql(AllExp, this.ARsign), "tb_Experiment");
                }
                else
                {
                    if (radioButtonRSearch.Checked == true)//如果是查报告模式
                    {
                        MyDS_Grid = MyClass.getDataSet(makesql(AllRep, this.ARsign), "tb_Report");
                    }
                }
                //在dataGridView1控件是显示查询的结果
                dataGridView1.DataSource = MyDS_Grid.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                checkBoxAll.Checked = false;
                int rnum = dataGridView1.Rows.Count;//获取表行数
                if (rnum == 0)
                {
                    MessageBox.Show("未找到！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//行数为零警告
                    butView.Enabled = false;//显示详情不可用
                    if ((this.Tag.Equals(1) || this.Tag.Equals(0)) && radioButtonRSearch.Checked == true)//如果是教师查询实验报告模式
                    {
                        butGiveMark.Enabled = true;//批改可用
                    }
                    else
                        butGiveMark.Enabled = false;
                }
                else
                {
                    butView.Enabled = true;//显示详情可用
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked == true)//当全选按钮被选中的时候
            {
                if (radioButtonESearch.Checked == true)
                {
                    MyDS_Grid = MyClass.getDataSet(AllExp, "tb_Experiment");
                    dataGridView1.DataSource = MyDS_Grid.Tables[0];
                    dataGridView1.AutoGenerateColumns = true;
                }
                else
                {
                    if (radioButtonRSearch.Checked == true)
                    {
                        MyDS_Grid = MyClass.getDataSet(AllRep, "tb_Report");
                        dataGridView1.DataSource = MyDS_Grid.Tables[0];
                        dataGridView1.AutoGenerateColumns = true;
                    }
                }
            }
            else//取消全选
            {//清空控件信息
                dataGridView1.DataSource = null;
            }
        }

        #region  清空控件集上的查询条件
        private void butClear_Click(object sender, EventArgs e)
        {
            cb_ChapterName.Text = null;
            cb_TeacherName.Text = null;
            txtDate.Text = null;
            txtTitle.Text = null;
            txtCondition.Text = null;
            cb_MarkStatus.Text = null;
            cb_Mark.Text = null;
            radioButtonStuNum.Checked = false;
            radioButtonStuName.Checked = false;
            radioButtonStuClass.Checked = false;
            dataGridView1.DataSource = null;
            checkAll.Checked = false;
            checkElse.Checked = false;
        }
        #endregion

        private void butDoExperiment_Click(object sender, EventArgs e)
        {
            int select_n = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                {
                    //当该行处于选定状态时
                    if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                    {
                        select_n++;
                        if (select_n < 2)
                        {
                            DataClass.Experiment.Experiment_ID_forStudent = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            F_NewExperiment Do = new F_NewExperiment();
                            Do.MdiParent = this.MdiParent;
                            Do.WindowState = FormWindowState.Maximized;
                            Do.Tag = 3;//设置为学生做实验模式
                            Do.Text = "进行实验";
                            Do.Show();
                        }
                        else
                        {
                            MessageBox.Show("多选批改时将只打开您勾选的第一个实验", "提示");
                            break;
                        }
                    }
                }
            }
        }

        private void radioButtonESearch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonESearch.Checked == true)
            {
                this.Text = "实验查询";
                dataGridView1.DataSource = null;
                butGiveMark.Enabled = false;
                radioButtonStuNum.Enabled = false;
                radioButtonStuName.Enabled = false;
                radioButtonStuClass.Enabled = false;
                txtCondition.Enabled = false;
                cb_Mark.Enabled = false;
                cb_MarkStatus.Enabled = false;
                txtDate.Enabled = false;
                cb_TeacherName.Enabled = true;
                butCreatWord.Enabled = false;
                if (this.Tag.Equals(2) || this.Tag.Equals(3))
                    butDoExperiment.Enabled = true;
                else
                    butDoExperiment.Enabled = false;
                if (this.Tag.Equals(1))
                {
                    butGiveMark.Enabled = false;
                }
            }
        }

        private void radioButtonRSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRSearch.Checked == true)
            {
                this.Text = "报告查询";
                dataGridView1.DataSource = null;
                radioButtonStuNum.Enabled = true;
                radioButtonStuName.Enabled = true;
                radioButtonStuClass.Enabled = true;
                txtCondition.Enabled = true;
                cb_Mark.Enabled = true;
                cb_MarkStatus.Enabled = true;
                txtDate.Enabled = true;
                butDoExperiment.Enabled = false;
                cb_TeacherName.Enabled = false;
                if (this.Tag.Equals(0))
                {
                    butGiveMark.Enabled = true;
                    butCreatWord.Enabled = true;
                }
                if (this.Tag.Equals(1))
                {
                    butGiveMark.Enabled = true;
                    butCreatWord.Enabled = true;
                }
                if (this.Tag.Equals(2))
                    butGiveMark.Enabled = false;
            }
        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonStuClass.Checked != true && radioButtonStuName.Checked != true && radioButtonStuNum.Checked != true)
            {
                MessageBox.Show("请先点选关键词查询条件!");
                txtCondition.Text = "";
            }
        }

        private void butGiveMark_Click(object sender, EventArgs e)
        {
            int select_n = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                {
                    //当该行处于选定状态时
                    if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                    {
                        select_n++;
                        if (select_n < 2)
                        {
                            string ids = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            SqlDataReader temDR = MyClass.getcom("select * from tb_Student where IDS='" + ids.ToString() + "'");
                            if (temDR.Read())
                            {
                                if (DataClass.MyMeans.Login_ID == temDR.GetString(temDR.GetOrdinal("IDT")))//如果该报告作者学生的老师是当前用户
                                {
                                    DataClass.Report.Report_ID_forTeacher = dataGridView1.Rows[i].Cells[1].Value.ToString();//传递报告号到全局变量
                                    DataClass.Experiment.Experiment_ID_forTeahcer = dataGridView1.Rows[i].Cells[2].Value.ToString();//传递试验号到全局变量
                                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "未批改")
                                    {
                                        F_GiveMark Do = new F_GiveMark();
                                        Do.MdiParent = this.MdiParent;
                                        Do.WindowState = FormWindowState.Maximized;
                                        Do.Tag = 0;//设置为教师首次批改实验报告模式
                                        Do.Text = "批改实验报告";
                                        Do.Show();
                                    }
                                    else
                                    {
                                        F_GiveMark Do = new F_GiveMark();
                                        Do.MdiParent = this.MdiParent;
                                        Do.WindowState = FormWindowState.Maximized;
                                        Do.Tag = 1;//设置为教师查看已批改过的实验报告模式
                                        Do.Text = "批改实验报告";
                                        Do.Show();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("您无权利批改该实验报告,它不属于您的学生!", "提示");
                                }
                            }
                            else
                            {
                                MessageBox.Show("该学生无记录,您无法批改!", "提示");
                            }
                        }
                        else
                        {
                            MessageBox.Show("多选批改时将只打开您勾选的第一个实验报告", "提示");
                            break;
                        }
                    }
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            checkElse.Checked = false;
            if (checkAll.Checked == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                {
                    try
                    {
                        dataGridView1.Rows[i].Cells[0].Value = true;
                    }
                    catch (Exception ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出异常提示信息
                    }
                }
            }
            else
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                {
                    try
                    {
                        dataGridView1.Rows[i].Cells[0].Value = false;
                    }
                    catch (Exception ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出异常提示信息
                    }
                }
            }
        }

        private void checkElse_CheckedChanged(object sender, EventArgs e)
        {
            checkAll.Checked = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
            {
                try
                {
                    //当该行未选定过，初始为null 如不增加此行会无法获取Value的string 未选点反选会出错
                    if (dataGridView1.Rows[i].Cells[0].Value == null || bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == false)
                        dataGridView1.Rows[i].Cells[0].Value = true;//选定
                    else//已经选过
                    {
                        if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)//为选中状态
                            dataGridView1.Rows[i].Cells[0].Value = false;//取消
                        else
                            dataGridView1.Rows[i].Cells[0].Value = true;//选中
                    }
                }
                catch (Exception ex)//捕获异常
                {
                    MessageBox.Show(ex.Message);//弹出异常提示信息
                }
            }
        }

        private void butStatus_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                {
                    if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true) //单元格选中
                    {
                        count++;
                    }
                }
            }
            MessageBox.Show("所选项目共" + count.ToString() + "份! ", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butCreatWord_Click(object sender, EventArgs e)
        {
            Loading.loading f = new Loading.loading();  //实例化进度条
            List<Image> pic = new List<Image>();//存放大图
            if (MessageBox.Show("确定要将所选报告生成Word文档?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                string filesave = fbd.SelectedPath;//获得选择的文件夹路径来存储
                if (filesave != "")
                {
                    DataClass.Report.Report_Path = filesave;//保存最近的实验报告生成路径
                    WordHandle word = new WordHandle();
                    int Select_num = 0;//变量用于存储勾选变量
                    string SaveFile = "c:\\a.jpg";
                    string docname;//文档名字
                    string reporthead;//文档头
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                        {
                            if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true) //单元格选中
                            {
                                Select_num++;
                            }
                        }
                    }
                    if (Select_num == 0)//如果没有勾选项
                    {
                        MessageBox.Show("请选择操作项!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information); //显示消息
                    }
                    else
                    {//如果选择了项目则开始生成word
                        f.LoadOpen(this);  //打开进度条
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                        {
                            try
                            {
                                if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                                {
                                    if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true) //单元格选中
                                    {
                                        string idr = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                        string ide = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                        string ids = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                        SqlDataReader temDR = MyClass.getcom("select * from tb_Report where IDR='" + idr.ToString() + "'");
                                        SqlDataReader temDR2 = MyClass.getcom("select * from tb_Experiment where ID='" + ide.ToString() + "'");
                                        SqlDataReader temDR3 = MyClass.getcom("select * from tb_Student where IDS='" + ids.ToString() + "'");
                                        if (temDR.Read() && temDR2.Read() && temDR3.Read())
                                        {
                                            
                                            docname = "\\" + ide.ToString() + "_" + ids.ToString() + "_" + temDR3.GetString(temDR3.GetOrdinal("class")) + "_" + temDR3.GetString(temDR3.GetOrdinal("name")) + ".doc";//编辑头信息
                                            word.CreateAWord();
                                            word.InsertText(temDR2.GetString(temDR2.GetOrdinal("title")), 20, Word.WdColor.wdColorDarkRed, 2, Word.WdParagraphAlignment.wdAlignParagraphCenter);
                                            word.NewLine();
                                            reporthead = "实验编号：" + ide.ToString() + "    学号：" + ids.ToString() + "    班级：" + temDR3.GetString(temDR3.GetOrdinal("class")) + "    姓名：" + temDR3.GetString(temDR3.GetOrdinal("name")) + "    时间：" + temDR.GetString(temDR.GetOrdinal("date")) + "    分数：" + temDR.GetString(temDR.GetOrdinal("mark"));
                                            word.InsertText(reporthead, 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphCenter);
                                            word.NewLine();
                                            word.InsertText("一.实验目的", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(temDR2.GetString(temDR2.GetOrdinal("purpose")), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText("二.问题描述", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(temDR.GetString(temDR.GetOrdinal("description")), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText("三.算法设计", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(temDR.GetString(temDR.GetOrdinal("ALG")), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText("四.运行结果", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(temDR.GetString(temDR.GetOrdinal("running")), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText("附图：", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            //插图片
                                            pic = MyMC.reImage(ide.ToString(), ids);
                                            foreach (Image p in pic)
                                            {
                                                //p.Save(SaveFile, System.Drawing.Imaging.ImageFormat.Jpeg);//先存至路径
                                                //word.InsertPicture(SaveFile);
                                                //源代码会出现GDI+一般性错误因为用到的数据会处于锁定状态
                                                #region 解决方法
                                                /* 症状
                                         Bitmap 对象或一个 图像 对象从一个文件, 构造时该文件仍保留锁定对于对象的生存期。 
                                         因此, 无法更改图像并将其保存回它产生相同的文件。
                                         替代方法
                                         创建非索引映像。
                                         创建索引映像。
                                         这两种情况下, 原始 位图 上调用 Bitmap.Dispose() 方法删除该文件上锁或删除要求， 流或内存保持活动。

                                         创建非索引图像
                                         即使原始映像被索引格式中该方法要求新图像位于每像素 (超过 8 位 -) -, 非索引像素格式。
                                         此变通方法使用 Graphics.DrawImage() 方法来将映像复制到新 位图 对象：
                                         1.    构造从流、 从内存, 或从文件原始 位图 。
                                         2.    创建新 位图 的相同大小, 带有是超过 8 位 - - 像素 (BPP) 每像素格式。
                                         3.    使用 Graphics.FromImage() 方法以获取有关二 位图 Graphics 对象。
                                         4.    用于 Graphics.DrawImage() 绘制首 位图 到二 位图 。
                                         5.    用于 Graphics.Dispose() 处置是 图形 。
                                         6.    用于 Bitmap.Dispose() 是首 位图 处置。

                                         创建索引映像
                                         此解决办法在索引格式创建一个 Bitmap 对象：
                                         1.    构造从流、 从内存, 或从文件原始 位图 。
                                         2.    创建新 位图 具有相同的大小和像素格式作为首 位图 。
                                         3.    使用 Bitmap.LockBits() 方法来锁定整个图像对于两 Bitmap 对象以其本机像素格式。
                                         4.    使用 Marshal.Copy 函数或其他内存复制函数来从首 位图 复制到二 位图 图像位。
                                         5.    使用 Bitmap.UnlockBits() 方法可以解锁两 Bitmap 对象。
                                         6.    用于 Bitmap.Dispose() 是首 位图 处置。
                                         */
                                                #endregion 解决方法
                                                Bitmap bmp = new Bitmap(p);
                                                //新建第二个bitmap类型的bmp2变量，我这里是根据我的程序需要设置的。
                                                Bitmap bmp2 = new Bitmap(p.Width, p.Height,
                                                System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
                                                //将第一个bmp拷贝到bmp2中
                                                Graphics draw = Graphics.FromImage(bmp2);
                                                draw.DrawImage(bmp, 0, 0);
                                                bmp2.Save(SaveFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                draw.Dispose();
                                                bmp.Dispose();//释放bmp文件资源
                                                word.InsertPicture(SaveFile);
                                            }
                                            word.NewLine();
                                            pic.Clear();
                                            word.InsertText("五.问题与收获", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(temDR.GetString(temDR.GetOrdinal("question")), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText("六.教师评价", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(temDR.GetString(temDR.GetOrdinal("evaluation")), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.SaveWord(filesave + docname, docname);//保存路径
                                            File.Delete(SaveFile);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)//捕获异常
                            {
                                MessageBox.Show(ex.Message);//弹出异常提示信息
                                break;
                            }
                        }
                        f.LoadClose(this); //关闭进度条
                        MessageBox.Show("生成文档结束!", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information); //显示消息
                    }
                }
            }
        }


        private void cb_ChapterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(cb_ChapterName.SelectedValue);
        }
    }
}
