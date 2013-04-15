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
    public partial class F_ChapterManage : Form
    {
        public F_ChapterManage()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();
        public static DataSet MyDS_Grid;
        String idc = "";//存储操作的章节ID

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

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_ChapterManage_Load(object sender, EventArgs e)
        {
            DataInit();//初始化数据空间
            txtChapterName.ReadOnly = true;//设置四个text控件为只读
            txtChapNum.ReadOnly = true;
            txtExpNum.ReadOnly = true;
            txtRepNum.ReadOnly = true;
            butOK.Enabled = false;//确认取消按钮不可用
            butCancel.Enabled = false;
        }

        private void DataInit()
        {
            string AllChapter = "SELECT [IDC] AS 章节编号,[name] AS 章节名称 from tb_Chapter";//查询章节信息sql语句
            MyDS_Grid = MyClass.getDataSet(AllChapter, "tb_Chapter");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];//在datagridview中显示查询结果
            dataGridView1.AutoGenerateColumns = true;
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
            dataGridView1.Columns[1].Width = 80;//设置DataGridView控件的第一列列宽为80
            dataGridView1.Columns[2].Width = 496;//设置DataGridView控件的第二列列宽为496
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtChapterName.Clear();
            txtExpNum.Clear();
            txtRepNum.Clear();
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                idc = dataGridView1.CurrentRow.Cells[1].Value.ToString();//获取操作的章节名
                txtChapterName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();//显示章节名
                txtChapNum.Text = idc;//显示章节编号
                SqlDataReader temDR = MyClass.getcom("select count ('" + idc + "') as '份数' from tb_Report where IDC= '" + idc + "'");//统计该章节的实验报告份数
                if (temDR.Read())
                {
                    txtRepNum.Text=temDR.GetValue(temDR.GetOrdinal("份数")).ToString()+"份";//显示该章节的实验报告份数
                }
                temDR = MyClass.getcom("select count ('" + idc + "')  as '份数' from tb_Experiment where IDC= '" + idc + "'");//统计该章节的实验数
                if (temDR.Read())
                {
                    txtExpNum.Text = temDR.GetValue(temDR.GetOrdinal("份数")).ToString()+"份";//显示该章节的实验数
                }
            } 
        }

        private void butAmend_Click(object sender, EventArgs e)
        {
            this.Tag = 0;//设置为修改操作
            int select_n = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null) //当当前单元格的内容不为空时
                {
                    //当该行处于选定状态时
                    if (bool.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) == true)
                    {
                        select_n++;
                    }
                }
            }
            if (select_n == 0)
            {
                MessageBox.Show("请勾选操作项!");
            }
            else//当存在操作项时
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() != idc)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = null;//取消勾选
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[0].Value = true;//勾选目标项
                    }
                }
                if (MessageBox.Show("章节内容是重要信息,确定修改吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    //设置text控件取消只读
                    txtChapterName.ReadOnly = false;
                    butOK.Enabled = true;//激活确认取消按钮
                    butCancel.Enabled = true;
                    //屏蔽操作按钮
                    butAdd.Enabled = false;
                    butAmend.Enabled = false;
                    butDelete.Enabled = false;
                }
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (this.Tag.Equals(0))//如果是修改操作
            {
                try
                {
                    MyClass.getsqlcom("update tb_Chapter set name='" + txtChapterName.Text.Trim() + "' where IDC='" + idc + "'");//更新数据库中信息
                    MessageBox.Show("修改成功!");
                    txtChapterName.ReadOnly = true;//改回只读
                    butCancel.Enabled = false;
                    butOK.Enabled = false;
                    DataInit();//初始化数据空间
                    //激活前三个功能按钮
                    butAmend.Enabled = true;
                    butDelete.Enabled = true;
                    butAdd.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (this.Tag.Equals(1))//如果是增加操作
                {
                    try
                    {
                        MyClass.getsqlcom("insert into tb_Chapter (IDC,name) values('"+ txtChapNum.Text.Trim()+"','" + txtChapterName.Text.Trim() + "')");//更新数据库中信息
                        MessageBox.Show("新增章节成功!");
                        txtChapterName.ReadOnly = true;//改回只读
                        txtChapNum.ReadOnly = true;
                        txtChapterName.Clear();//清空输入控件
                        txtChapNum.Clear();
                        butCancel.Enabled = false;
                        butOK.Enabled = false;
                        DataInit();//初始化数据空间
                        //激活前三个功能按钮
                        butAmend.Enabled = true;
                        butDelete.Enabled = true;
                        butAdd.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            //将四个text控件清空并设置为只读
            txtChapterName.Clear();
            txtChapNum.Clear();
            txtExpNum.Clear();
            txtRepNum.Clear();
            txtChapterName.ReadOnly = true;
            txtChapNum.ReadOnly = true;
            txtExpNum.ReadOnly = true;
            txtRepNum.ReadOnly = true;
            //取消激活确认取消按钮
            butOK.Enabled = false;
            butCancel.Enabled = false;
            //激活前三个功能按钮
            butAmend.Enabled = true;
            butDelete.Enabled = true;
            butAdd.Enabled = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
            {
                dataGridView1.Rows[i].Cells[0].Value = null;//取消勾选
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            this.Tag = 1;//设置为增加操作
            //先清空勾选项
            for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
            {
                dataGridView1.Rows[i].Cells[0].Value = null;//取消勾选
            }
            //设置text控件取消只读并清空
            txtChapNum.Text = (Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[1].Value) + 1).ToString();
            txtChapterName.Clear();
            txtExpNum.Clear();
            txtRepNum.Clear();
            txtChapNum.ReadOnly = true;
            txtChapterName.ReadOnly = false;
            butOK.Enabled = true;//激活确认取消按钮
            butCancel.Enabled = true;
            //屏蔽操作按钮
            butAdd.Enabled = false;
            butAmend.Enabled = false;
            butDelete.Enabled = false;
            txtChapNum.Focus();
        }

        private void butDelete_Click(object sender, EventArgs e)
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
                    }
                }
            }
            if (select_n == 0)
            {
                MessageBox.Show("请勾选操作项!");
            }
            else
            {
                if (MessageBox.Show("确定要删除所选章节和相应的实验、实验报告吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
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
                                    string id = dataGridView1.Rows[i].Cells[1].Value.ToString();//获取操作的章节号
                                    dataGridView1.Rows.RemoveAt(i);//移除处于选定状态的记录                    
                                    MyClass.getsqlcom("Delete from tb_Chapter where IDC='" + id.ToString() + "'");   //执行SQL语句,删除章节
                                    MyClass.getsqlcom("Delete from tb_Experiment where IDC='" + id.ToString() + "'");   //执行SQL语句,删除章节内的实验
                                    MyClass.getsqlcom("Delete from tb_Report where IDC='" + id.ToString() + "'");   //执行SQL语句,删除章节内的报告
                                    //MyClass.getsqlcom("Delete from tb_Picture AS e INNER JOIN tb_Experiment AS s ON e.IDE=s.IDE where (s.IDC='" + idc.ToString() + "')");   //执行SQL语句,删除章节内报告的图片
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
                    DataInit();//刷新页面
                }
            }
        }
    }
}
