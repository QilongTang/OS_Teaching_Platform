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
    public partial class F_ExperimentManage : Form
    {
        public F_ExperimentManage()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();
        DataSet MyDS_Grid = new DataSet();
        MyModule MyMC = new MyModule();
        string AllExp = "select * from tb_Experiment where IDT= '" + DataClass.MyMeans.Login_ID.ToString() + "'";//教师实验管理时的sql语句
        string AllExp2 = "SELECT e.ID,e.IDE,e.IDT,e.IDC,e.title,e.purpose,e.detail,e.preparation,e.guidance,e.flag FROM tb_Experiment AS e INNER JOIN tb_Student AS s ON e.IDT = s.IDT and e.flag='" + true + "' WHERE (s.IDS = '" + DataClass.MyMeans.Login_ID + "')";//学生查看教师已发布实验时的sql语句

        public void Showall()
        {
            if (this.Tag.Equals(0))
            {
                try
                {
                    //调用公共类中的方法获取所有信息,并存储到DataSet数据集中
                    MyDS_Grid = MyClass.getDataSet(AllExp, "tb_Experiment");
                    DataTable DT = MyDS_Grid.Tables[0];//初始化一个数据表
                    dataGridView1.DataSource = DT.DefaultView;//为DataGridView设置数据源
                    dataGridView1.Columns[4].Visible = false;//设置DataGridView控件的第四列章节编号不可见
                    dataGridView1.Columns[2].Visible = false;//设置DataGridView控件的第二列实验所属于章节编号不可见
                    dataGridView1.Columns[3].Visible = false;//设置DataGridView控件的第三列实验所属于教师编号不可见
                    dataGridView1.Columns[1].HeaderText = "实验编号";//设置DataGridView控件的第三列标题为章节号
                    dataGridView1.Columns[1].Width = 80;//设置DataGridView控件的第三列列宽为5
                    dataGridView1.Columns[5].HeaderText = "实验题目";//设置DataGridView控件的第四列标题为实验名
                    dataGridView1.Columns[6].HeaderText = "实验目的";//设置DataGridView控件的第五列标题为实验目的
                    dataGridView1.Columns[7].HeaderText = "实验内容";//设置DataGridView控件的第六列标题为实验内容
                    dataGridView1.Columns[8].HeaderText = "准备知识";//设置DataGridView控件的第七列标题为章节号
                    dataGridView1.Columns[9].HeaderText = "实验指导";//设置DataGridView控件的第八列标题为章节号
                    dataGridView1.Columns[10].HeaderText = "是否被发布";//设置DataGridView控件的第九列标题为是否被发布
                    for (int i = 1; i < dataGridView1.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].ReadOnly = true;
                    }
                    /*int i = 0;
                    foreach(DataRow row in MyDS_Grid.Tables[0].Rows)
                    {
                        this.dataGridView1.Rows[i].Tag = row["IDE"].ToString();
                        i++;
                    }*/
                    if (dataGridView1.RowCount > 1)//判断DataGridView控件中是否有行
                    {
                        //当控件中有行时,修改和删除按钮设置为可用
                        butAmend.Enabled = true;
                        butDelete.Enabled = true;
                    }
                    else
                    {
                        //当控件中没有行时,修改和删除按钮设置为不可用
                        butAmend.Enabled = false;
                        butDelete.Enabled = false;
                    }
                }
                catch (SqlException ex)//捕获异常
                {
                    MessageBox.Show(ex.Message);//弹出异常信息提示
                }
            }
            else
            {
                if (this.Tag.Equals(1))
                {
                    try
                    {
                        //调用公共类中的方法获取所有信息,并存储到DataSet数据集中
                        MyDS_Grid = MyClass.getDataSet(AllExp2, "tb_Experiment");
                        DataTable DT = MyDS_Grid.Tables[0];//初始化一个数据表
                        dataGridView1.DataSource = DT.DefaultView;//为DataGridView设置数据源
                        dataGridView1.Columns[4].Visible = false;//设置DataGridView控件的第四列章节编号不可见
                        dataGridView1.Columns[2].Visible = false;//设置DataGridView控件的第二列实验所属于章节编号不可见
                        dataGridView1.Columns[3].Visible = false;//设置DataGridView控件的第三列实验所属于教师编号不可见
                        dataGridView1.Columns[1].HeaderText = "实验编号";//设置DataGridView控件的第三列标题为章节号
                        dataGridView1.Columns[1].Width = 80;//设置DataGridView控件的第三列列宽为5
                        dataGridView1.Columns[5].HeaderText = "实验题目";//设置DataGridView控件的第四列标题为实验名
                        dataGridView1.Columns[6].HeaderText = "实验目的";//设置DataGridView控件的第五列标题为实验目的
                        dataGridView1.Columns[7].HeaderText = "实验内容";//设置DataGridView控件的第六列标题为实验内容
                        dataGridView1.Columns[8].HeaderText = "准备知识";//设置DataGridView控件的第七列标题为章节号
                        dataGridView1.Columns[9].HeaderText = "实验指导";//设置DataGridView控件的第八列标题为章节号
                        dataGridView1.Columns[10].HeaderText = "是否被发布";//设置DataGridView控件的第九列标题为是否被发布
                        for (int i = 1; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                        /*int i = 0;
                        foreach(DataRow row in MyDS_Grid.Tables[0].Rows)
                        {
                            this.dataGridView1.Rows[i].Tag = row["IDE"].ToString();
                            i++;
                        }*/
                        if (dataGridView1.RowCount > 1)//判断DataGridView控件中是否有行
                        {
                            //当控件中有行时,修改和删除按钮设置为可用
                            butAmend.Enabled = true;
                            butDelete.Enabled = true;
                        }
                        else
                        {
                            //当控件中没有行时,修改和删除按钮设置为不可用
                            butAmend.Enabled = false;
                            butDelete.Enabled = false;
                        }
                    }
                    catch (SqlException ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出异常信息提示
                    }
                }
            }
        }


        private void F_ExperimentRelease_Load(object sender, EventArgs e)
        {
            //初始化时根据窗体的tag值判断模式,0为教师浏览模式,1为学生浏览模式
            if (this.Tag.Equals(0))//教师浏览模式时,按钮全部可用
            {
            }
            else
            {
                if (this.Tag.Equals(1))//学生浏览模式时,部分按钮不可用
                {
                    //下列四项操作只有教师具有权限,因此设置为不可见
                    this.butAmend.Visible = false;
                    this.butCancelRelease.Visible = false;
                    this.butRelease.Visible = false;
                    this.butDelete.Visible = false;
                }
            }
            Showall();//显示所有符合条件的实验内容
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除所选实验吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                        {
                            //当该行处于选定状态时
                            if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                            {
                                string id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                dataGridView1.Rows.RemoveAt(i);//移除处于选定状态的记录                    
                                MyClass.getsqlcom("Delete from tb_Experiment where ID='" + id.ToString() + "'");   //执行SQL语句
                                i--;//不改变循环变量的i的值
                            }
                        }
                    }
                    catch (Exception ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出异常提示信息
                    }
                }
                MessageBox.Show("删除成功!", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information); //显示消息
                Showall();
            }
        }

        private void butRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要发布所选实验吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                        {
                            //当该行处于选定状态时
                            if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                            {
                                string id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                //int id = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                                MyClass.getsqlcom("Update tb_Experiment set flag = 'true' where ID='" + id.ToString() + "'");   //执行SQL语句

                            }
                        }
                    }
                    catch (Exception ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出异常提示信息
                    }
                }
                MessageBox.Show("发布成功!", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information); //显示消息
                Showall();
            }
        }

        private void butCancelRelease_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定要取消发布所选实验吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                        {
                            //当该行处于选定状态时
                            if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                            {
                                string id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                //int id = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                                MyClass.getsqlcom("Update tb_Experiment set flag = 'false' where ID='" + id.ToString() + "'");   //执行SQL语句

                            }
                        }
                    }
                    catch (Exception ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出异常提示信息
                    }
                }
                MessageBox.Show("取消发布成功!", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information); //显示消息
                Showall();
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAmend_Click(object sender, EventArgs e)
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
                            DataClass.Experiment.Experiment_ID_forTeahcer = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            F_NewExperiment New = new F_NewExperiment();
                            New.MdiParent = this.MdiParent;
                            New.WindowState = FormWindowState.Maximized;
                            New.Text = "修改实验";
                            New.Tag = 2;//设置为教师修改模式
                            New.Show();
                        }
                        else
                        {
                            MessageBox.Show("多选修改时将只打开您勾选的第一个实验", "提示");
                        }
                    }
                }
            }
        }

        private void butView_Click(object sender, EventArgs e)
        {
            if (this.Tag.Equals(0))//如果是教师浏览模式
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
                                DataClass.Experiment.Experiment_ID_forTeahcer = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                F_NewExperiment New = new F_NewExperiment();
                                New.MdiParent = this.MdiParent;
                                New.WindowState = FormWindowState.Maximized;
                                New.Text = "显示实验";
                                New.Tag = 1;//设置新窗体的tag值为1表示教师浏览模式
                                New.Show();
                            }
                            else
                            {
                                MessageBox.Show("多选显示将只显示勾选的第一个", "提示");
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                if (this.Tag.Equals(1))//如果是学生浏览模式
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
                                    F_NewExperiment New = new F_NewExperiment();
                                    New.MdiParent = this.MdiParent;
                                    New.WindowState = FormWindowState.Maximized;
                                    New.Text = "显示实验";
                                    New.Tag = 3;//设置新窗体的tag值为3表示学生浏览模式
                                    New.Show();
                                }
                                else
                                {
                                    MessageBox.Show("多选显示将只显示勾选的第一个", "提示");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Showall();
            checkBoxAll.Checked = false;
            checkElse.Checked = false;
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

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            checkElse.Checked = false;
            if (checkBoxAll.Checked == true)
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
            checkBoxAll.Checked = false;
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

        private void butCreatWord_Click(object sender, EventArgs e)
        {
            Loading.loading f = new Loading.loading();  //实例化进度条
            if (MessageBox.Show("确定要将所选实验生成Word文档?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                string filesave = fbd.SelectedPath;//获得选择的文件夹路径来存储
                if (filesave != "")
                {
                    DataClass.Report.Report_Path = filesave;//保存最近的实验报告生成路径
                    WordHandle word = new WordHandle();
                    int Celect_num = 0;
                    string SaveFile = "c:\\a.jpg";
                    string docname;//文档名字
                    string reporthead;//文档头
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                        {
                            if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true) //单元格选中
                            {
                                Celect_num++;
                            }
                        }
                    }
                    if (Celect_num == 0)//如果没有勾选项
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
                                        Celect_num++;
                                        string ide = dataGridView1.Rows[i].Cells[1].Value.ToString();//实验总编号
                                        string idc = dataGridView1.Rows[i].Cells[4].Value.ToString();//章节编号
                                        string idt = dataGridView1.Rows[i].Cells[3].Value.ToString();//教师号
                                        SqlDataReader temDR2 = MyClass.getcom("select * from tb_Chapter where IDC='" + idc.ToString() + "'");
                                        SqlDataReader temDR3 = MyClass.getcom("select * from tb_Teacher where IDT='" + idt.ToString() + "'");
                                        if (temDR2.Read() && temDR3.Read())
                                        {
                                            docname = "\\" + ide.ToString() + "_" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "_" + temDR3.GetString(temDR3.GetOrdinal("class")) + "_" + temDR3.GetString(temDR3.GetOrdinal("name")) + ".doc";//编辑头信息
                                            word.CreateAWord();
                                            word.InsertText(dataGridView1.Rows[i].Cells[5].Value.ToString(), 20, Word.WdColor.wdColorDarkRed, 2, Word.WdParagraphAlignment.wdAlignParagraphCenter);
                                            word.NewLine();
                                            reporthead = "实验编号：" + ide.ToString() + "    教师号：" + idt.ToString() + "    班级：" + temDR3.GetString(temDR3.GetOrdinal("class")) + "    教师姓名：" + temDR3.GetString(temDR3.GetOrdinal("name")) + "    时间：" + DateTime.Now.AddDays(0).ToString("yyyy年MM月dd日") + "    所属章节：" + temDR2.GetString(temDR2.GetOrdinal("name"));
                                            word.InsertText(reporthead, 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphCenter);
                                            word.NewLine();
                                            word.InsertText("一.实验题目", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(dataGridView1.Rows[i].Cells[5].Value.ToString(), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText("二.实验目的", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(dataGridView1.Rows[i].Cells[6].Value.ToString(), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText("三.实验内容", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(dataGridView1.Rows[i].Cells[7].Value.ToString(), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText("四.准备知识", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(dataGridView1.Rows[i].Cells[8].Value.ToString(), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText("五.实验指导", 15, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.InsertText(dataGridView1.Rows[i].Cells[9].Value.ToString(), 10, Word.WdColor.wdColorBlack, 1, Word.WdParagraphAlignment.wdAlignParagraphLeft);
                                            word.NewLine();
                                            word.SaveWord(filesave + docname, docname);//保存路径
                                            File.Delete(SaveFile);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)//捕获异常
                            {
                                //f.LoadClose(this); //关闭进度条
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
    }
}
