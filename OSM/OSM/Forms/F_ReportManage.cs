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
using Word;


namespace OSM.Forms
{
    public partial class F_ReportManage : Form
    {
        public F_ReportManage()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();
        MyModule MyMC = new MyModule();
        DataSet MyDS_Grid = new DataSet();
        string AllRep = "select * from tb_Report where IDS= '" + DataClass.MyMeans.Login_ID.ToString() + "'";//学生实验报告管理时的sql语句

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Showall()
        {
            try
            {
                //调用公共类中的方法获取所有信息,并存储到DataSet数据集中
                MyDS_Grid = MyClass.getDataSet(AllRep, "tb_Report");
                DataTable DT = MyDS_Grid.Tables[0];//初始化一个数据表
                dataGridView1.DataSource = DT.DefaultView;//为DataGridView设置数据源
                dataGridView1.Columns[1].Visible = false;//设置DataGridView控件的第一列实验报告编号不可见
                dataGridView1.Columns[3].Visible = false;//设置DataGridView控件的第三列实验所属于学生编号不可见
                dataGridView1.Columns[2].HeaderText = "实验编号";//设置DataGridView控件的第二列标题为实验编号
                dataGridView1.Columns[2].Width = 80;//设置DataGridView控件的第二列列宽为80
                dataGridView1.Columns[4].HeaderText = "实验日期";//设置DataGridView控件的第四列标题为实验日期
                dataGridView1.Columns[5].HeaderText = "实验题目";//设置DataGridView控件的第五列标题为实验名
                dataGridView1.Columns[6].HeaderText = "实验描述";//设置DataGridView控件的第六列标题为实验描述
                dataGridView1.Columns[7].HeaderText = "实验算法";//设置DataGridView控件的第七列标题为实验算法
                dataGridView1.Columns[8].HeaderText = "运行结果";//设置DataGridView控件的第八列标题为运行结果
                dataGridView1.Columns[9].HeaderText = "实验问题";//设置DataGridView控件的第九列标题为是实验问题
                dataGridView1.Columns[10].HeaderText = "实验成绩";//设置DataGridView控件的第十列标题为是实验成绩
                dataGridView1.Columns[11].HeaderText = "实验评价";//设置DataGridView控件的第十一列标题为是实验评价
                dataGridView1.Columns[12].HeaderText = "是否提交";//设置DataGridView控件的第十二列标题为是是否提交
                dataGridView1.Columns[13].HeaderText = "是否批改";//设置DataGridView控件的第十三列标题为是是否批改
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[15].Visible = false;
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
            }
            catch (SqlException ex)//捕获异常
            {
                MessageBox.Show(ex.Message);//弹出异常信息提示
            }
        }

        private void F_MarkView_Load(object sender, EventArgs e)
        {
            Showall();
        }

        private void butAccept_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要提交所选实验吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
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
                                MyClass.getsqlcom("Update tb_Report set flagSubmit = 'true' where IDR='" + id.ToString() + "'");   //执行SQL语句
                            }
                        }
                    }
                    catch (Exception ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出异常提示信息
                    }
                }
                MessageBox.Show("提交成功!", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information); //显示消息
                Showall();
            }
        }

        private void butReDo_Click(object sender, EventArgs e)
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
                            //当提交状态为0,批改状态为1
                            if ((bool.Parse(dataGridView1.Rows[i].Cells[13].Value.ToString()) == true) && (bool.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()) != true))
                            {
                                DataClass.Report.Report_ID_forStudent = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                DataClass.Experiment.Experiment_ID_forStudent = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                F_DoExperiment New = new F_DoExperiment();
                                New.MdiParent = this.MdiParent;
                                New.WindowState = FormWindowState.Maximized;
                                New.Text = "重做实验报告";
                                New.Tag = 4;//设置为学生重做模式
                                New.Show();
                            }
                            else
                            {
                                MessageBox.Show("当前实验报告不能重做", "错误");
                            }
                        }
                        else
                        {
                            MessageBox.Show("多选修改将只能修改您勾选的第一个实验报告", "提示");
                            break;
                        }
                    }
                }

            }
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
                            //当批改状态为0,提交状态为0
                            if ((bool.Parse(dataGridView1.Rows[i].Cells[13].Value.ToString()) != true) && (bool.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()) != true))
                            {
                                DataClass.Report.Report_ID_forStudent = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                DataClass.Experiment.Experiment_ID_forStudent = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                F_DoExperiment New = new F_DoExperiment();
                                New.MdiParent = this.MdiParent;
                                New.WindowState = FormWindowState.Maximized;
                                New.Text = "修改实验报告";
                                New.Tag = 2;//设置为学生修改模式
                                New.Show();
                            }
                            else
                            {
                                MessageBox.Show("当前实验报告不能修改", "错误");
                            }
                        }
                        else
                        {
                            MessageBox.Show("多选修改将只能修改您勾选的第一个实验报告", "提示");
                            break;
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
                            DataClass.Report.Report_ID_forTeacher = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            /*F_GiveMark New = new F_GiveMark();
                            New.MdiParent = this.MdiParent;
                            New.WindowState = FormWindowState.Maximized;
                            New.Text = "显示实验报告";
                            New.Tag = 1;//设置新窗体的tag值为1表示教师浏览模式
                            New.Show();*/
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
                                    DataClass.Report.Report_ID_forStudent = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                    DataClass.Experiment.Experiment_ID_forStudent = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                    //如果批改状态为0,则查看实验报告.如果批改状态为1,则直接查看带有分数和评语的窗体
                                    if (bool.Parse(dataGridView1.Rows[i].Cells[13].Value.ToString()) != true)
                                    {
                                        F_DoExperiment New = new F_DoExperiment();
                                        New.MdiParent = this.MdiParent;
                                        New.WindowState = FormWindowState.Maximized;
                                        New.Text = "显示实验";
                                        New.Tag = 1;//设置新窗体的tag值为1表示学生浏览模式
                                        New.Show();
                                    }
                                    else
                                    {
                                        F_GiveMark New = new F_GiveMark();
                                        New.MdiParent = this.MdiParent;
                                        New.WindowState = FormWindowState.Maximized;
                                        New.Text = "显示实验";
                                        New.Tag = 2;//设置新窗体的tag值为2表示学生浏览模式
                                        New.Show();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("多选显示将只显示您勾选的第一个", "提示");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void butCancelRealease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要取消提交所选实验报告吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
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
                                MyClass.getsqlcom("Update tb_Report set flagSubmit = 'false' where IDR='" + id.ToString() + "'"); //执行SQL语句
                            }
                        }
                    }
                    catch (Exception ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出异常提示信息
                    }
                }
                MessageBox.Show("取消提交成功!", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information); //显示消息
                Showall();
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Showall();
            checkBoxAll.Checked = false;
            checkElse.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("!");
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
                                //当未提交未批改的报告才可以删除
                                if ((bool.Parse(dataGridView1.Rows[i].Cells[13].Value.ToString()) != true) && (bool.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()) != true))
                                {
                                    string idr = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                    string ide = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                    dataGridView1.Rows.RemoveAt(i);//移除处于选定状态的记录                    
                                    MyClass.getsqlcom("Delete from tb_Report where IDR='" + idr.ToString() + "'");   //执行SQL语句,删除报告
                                    MyMC.deletepic(ide.ToString(), DataClass.MyMeans.Login_ID.ToString());
                                    //MyClass.getsqlcom("Delete from tb_Picture where IDE='" +  dataGridView1.Rows[i].Cells[2].Value.ToString() + "' and IDS='" + DataClass.MyMeans.Login_ID.ToString() + "'");//执行SQL语句删除图片
                                    i--;//不改变循环变量的i的值
                                }
                                else
                                {
                                    MessageBox.Show("包含已经提交或批改的报告，将跳过！", "提示");
                                }
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

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
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

        private void checkElse_CheckedChanged(object sender, EventArgs e)
        {
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
            checkBoxAll.Checked = false;
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
    }
}
