using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSM.DataClass;

namespace OSM.Forms
{
    public partial class F_InfoManage : Form
    {
        public F_InfoManage()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();
        public static DataSet MyDS_Grid;
        string id = "";

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void DataInit_Class()
        {
            string AllChapter = "SELECT [ID] AS 班级编号,[name] AS 班级名称,[code] AS 班级验证码 from tb_Class";//查询章节信息sql语句
            MyDS_Grid = MyClass.getDataSet(AllChapter, "tb_Class");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];//在datagridview中显示查询结果
            dataGridView1.AutoGenerateColumns = true;
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
            dataGridView1.Columns[1].Width = 80;//设置DataGridView控件的第一列列宽为80
            dataGridView1.Columns[2].Width = 296;//设置DataGridView控件的第二列列宽为296
            dataGridView1.Columns[3].Width = 200;//设置DataGridView控件的第二列列宽为200
        }

        private void DataInit_Stu()
        {
            string AllChapter = "SELECT [IDS] AS 学生编号,[name] AS 学生名称,[Sex] AS 性别,[class] AS 学生班级,[email] AS 电子邮箱 from tb_Student";//查询学生信息sql语句
            MyDS_Grid = MyClass.getDataSet(AllChapter, "tb_Student");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];//在datagridview中显示查询结果
            dataGridView1.AutoGenerateColumns = true;
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
            dataGridView1.Columns[1].Width = 80;//设置DataGridView控件的第一列列宽为80
            dataGridView1.Columns[2].Width = 80;//设置DataGridView控件的第二列列宽为160
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 216;
        }

        private void DataInit_Tea()
        {
            string AllChapter = "SELECT [IDT] AS 教师编号,[name] AS 教师名称,[Sex] AS 性别,[class] AS 教师班级,[email] AS 电子邮箱 from tb_Teacher";//查询教师信息sql语句
            MyDS_Grid = MyClass.getDataSet(AllChapter, "tb_Teacher");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];//在datagridview中显示查询结果
            dataGridView1.AutoGenerateColumns = true;
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
            dataGridView1.Columns[1].Width = 80;//设置DataGridView控件的第一列列宽为80
            dataGridView1.Columns[2].Width = 80;//设置DataGridView控件的第二列列宽为160
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 216;
        }

        private void radioButton_Class_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Class.Checked == true)
            {
                DataInit_Class();//初始化学生列表
                butAdd.Enabled = true;//允许管理员新增班级
                mtxt_Code.ReadOnly = true;//禁用清空三个输入框
                mtxt_Code.Clear();
                txt_ClassNum.ReadOnly = true;
                txt_ClassNum.Clear();
                txt_ClassName.ReadOnly = true; ;
                txt_ClassName.Clear();
            }
            else
            {
                dataGridView1.DataSource = null;//清空数据
            }
        }

        private void radioButton_Stu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Stu.Checked == true)
            {
                DataInit_Stu();//初始化学生列表
                butAdd.Enabled = false;//禁止管理员新增学生
                mtxt_Code.ReadOnly = true;//禁用清空三个输入框
                mtxt_Code.Clear();
                txt_ClassNum.ReadOnly = true;
                txt_ClassNum.Clear();
                txt_ClassName.ReadOnly = true; ;
                txt_ClassName.Clear();
            }
            else
            {
                dataGridView1.DataSource = null;//清空数据
            }
        }

        private void radioButton_Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Tea.Checked == true)
            {
                DataInit_Tea();//初始化教师列表
                butAdd.Enabled = false;//禁止管理员新增教师
                mtxt_Code.ReadOnly = true;//禁用清空三个输入框
                txt_ClassNum.ReadOnly = true;
                txt_ClassName.ReadOnly = true;
                txt_ClassNum.Clear();
                mtxt_Code.Clear();
                txt_ClassName.Clear();
            }
            else
            {
                dataGridView1.DataSource = null;//清空数据
            }
        }

        private void F_InfoManage_Load(object sender, EventArgs e)
        {
            mtxt_Code.ReadOnly = true;//禁用三个输入框
            txt_ClassNum.ReadOnly = true;
            txt_ClassName.ReadOnly = true; ;
            butOK.Enabled = false;//确认取消按钮不可用
            butCancel.Enabled = false;
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
            txt_ClassNum.Text = (Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value) + 1).ToString(); ;
            mtxt_Code.Clear();
            txt_ClassName.Clear();
            mtxt_Code.ReadOnly = false;
            txt_ClassNum.ReadOnly = true;
            txt_ClassName.ReadOnly = false; ;
            butOK.Enabled = true;//激活确认取消按钮
            butCancel.Enabled = true;
            //屏蔽操作按钮
            butAdd.Enabled = false;
            butAmend.Enabled = false;
            butDelete.Enabled = false;
            txt_ClassName.Focus();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            //禁用清空三个输入框
            mtxt_Code.ReadOnly = true;
            mtxt_Code.Clear();
            txt_ClassNum.ReadOnly = true;
            txt_ClassNum.Clear();
            txt_ClassName.ReadOnly = true; ;
            txt_ClassName.Clear();
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

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (radioButton_Class.Checked == true)
            {
                #region 班级删除操作
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
                    if (MessageBox.Show("确定要删除所选班级和班级内的实验报告吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
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
                                        string classname = dataGridView1.Rows[i].Cells[2].Value.ToString();//获取操作的班级名
                                        dataGridView1.Rows.RemoveAt(i);//移除处于选定状态的记录                    
                                        MyClass.getsqlcom("Delete from tb_Report where class='" + classname.ToString() + "'");   //执行SQL语句,删除班级内的报告
                                        MyClass.getsqlcom("Delete from tb_Class where name='" + classname.ToString() + "'");  //执行SQL语句,删除班级
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
                        DataInit_Class();//刷新页面
                    }
                }
                #endregion
            }
            else
            {
                if (radioButton_Stu.Checked == true)
                {
                    #region 学生删除操作
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
                        if (MessageBox.Show("确定要删除所选学生和该学生的实验报告吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
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
                                            string ids = dataGridView1.Rows[i].Cells[1].Value.ToString();//获取操作的学生号
                                            dataGridView1.Rows.RemoveAt(i);//移除处于选定状态的记录                    
                                            MyClass.getsqlcom("Delete from tb_Report where IDS='" + ids.ToString() + "'");   //执行SQL语句,删除学生的报告
                                            MyClass.getsqlcom("Delete from tb_Picture IDS='" + ids.ToString() + "')");   //执行SQL语句,删除学生报告内的图片
                                            MyClass.getsqlcom("Delete from tb_Student where IDS='" + ids.ToString() + "'");//执行SQL语句,删除学生
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
                            DataInit_Stu();//刷新页面
                        }
                    }
                    #endregion
                }
                else
                {
                    if (radioButton_Tea.Checked == true)
                    {
                        #region 教师删除操作
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
                            if (MessageBox.Show("确定要删除所选教师和该教师的实验吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//判断是否在弹出的对话框中单击"确定"按钮
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
                                                string idt = dataGridView1.Rows[i].Cells[1].Value.ToString();//获取操作的学生号
                                                dataGridView1.Rows.RemoveAt(i);//移除处于选定状态的记录                    
                                                MyClass.getsqlcom("Delete from tb_Experiment where IDT='" + idt.ToString() + "'"); //执行SQL语句,删除教师的实验
                                                MyClass.getsqlcom("Delete from tb_Teacher where IDT='" + idt.ToString() + "'"); //执行SQL语句,删除教师
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
                                DataInit_Tea();//刷新页面
                            }
                        }
                        #endregion
                    }
                }
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (this.Tag.Equals(0))//如果是修改操作
            {
                try
                {
                    MyClass.getsqlcom("update tb_Class set name='" + txt_ClassName.Text.Trim() + "',code='" + mtxt_Code.Text.Trim() + "' where ID='" + txt_ClassNum.Text.Trim() + "'");//更新数据库中信息
                    MessageBox.Show("修改成功!");
                    txt_ClassName.ReadOnly = true;//改回只读
                    mtxt_Code.ReadOnly = true;
                    butCancel.Enabled = false;
                    butOK.Enabled = false;
                    DataInit_Class();//初始化数据空间
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
                        MyClass.getsqlcom("insert into tb_Class (ID,name,code) values('" + txt_ClassNum.Text.Trim() + "','" + txt_ClassName.Text.Trim() + "','" + mtxt_Code.Text.Trim() + "')");//更新数据库中信息
                        MessageBox.Show("新增班级成功!");
                        //禁用清空三个输入框
                        mtxt_Code.ReadOnly = true;
                        mtxt_Code.Clear();
                        txt_ClassNum.ReadOnly = true;
                        txt_ClassNum.Clear();
                        txt_ClassName.ReadOnly = true; ;
                        txt_ClassName.Clear();
                        butCancel.Enabled = false;
                        butOK.Enabled = false;
                        DataInit_Class();//初始化数据空间
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
                    }
                }
            }
            if (select_n == 0)
            {
                MessageBox.Show("请勾选操作项!");
            }
            else//当存在操作项时
            {
                if (radioButton_Class.Checked == true)
                {
                    #region 班级修改操作
                    this.Tag = 0;//设置为修改操作
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() != id)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = null;//取消勾选
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[0].Value = true;//勾选目标项
                        }
                    }
                    if (MessageBox.Show("班级内容是重要信息,确定修改吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        //设置text控件取消只读
                        txt_ClassName.ReadOnly = false;
                        mtxt_Code.ReadOnly = false;
                        butOK.Enabled = true;//激活确认取消按钮
                        butCancel.Enabled = true;
                        //屏蔽操作按钮
                        butAdd.Enabled = false;
                        butAmend.Enabled = false;
                        butDelete.Enabled = false;
                    }
                    #endregion
                }
                else
                {
                    if (radioButton_Stu.Checked == true)
                    {
                        #region 学生修改操作
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                        {
                            if (dataGridView1.Rows[i].Cells[1].Value.ToString() != id)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = null;//取消勾选
                            }
                            else
                            {
                                dataGridView1.Rows[i].Cells[0].Value = true;//勾选目标项
                            }
                        }
                        Student.Student_ID = id.ToString();
                        DataClass.MyMeans.User_Pope = "A";//用户权限设置为管理员
                        F_InfoS infoS = new F_InfoS();
                        infoS.Text = "修改学生信息";
                        if (infoS.ShowDialog() == DialogResult.OK)//模式化窗体
                        {
                            DataInit_Stu();//初始化学生列表
                        }
                        DataClass.MyMeans.User_Pope = "T";//用户权限设置为普通教师
                        #endregion
                    }
                    else
                    {
                        if (radioButton_Tea.Checked == true)
                        {
                            #region 教师修改操作
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)  //循环遍历DataGridView控件中的每一行
                            {
                                if (dataGridView1.Rows[i].Cells[1].Value.ToString() != id)
                                {
                                    dataGridView1.Rows[i].Cells[0].Value = null;//取消勾选
                                }
                                else
                                {
                                    dataGridView1.Rows[i].Cells[0].Value = true;//勾选目标项
                                }
                            }
                            Teacher.Teacher_ID = id.ToString();
                            DataClass.MyMeans.User_Pope = "A";//用户权限设置为管理员
                            F_InfoT infoS = new F_InfoT();
                            infoS.Text = "修改教师信息";
                            if (infoS.ShowDialog() == DialogResult.OK)//模式化窗体
                            {
                                DataInit_Tea();//初始化教师列表
                            }
                            DataClass.MyMeans.User_Pope = "T";//用户权限设置为普通教师
                            #endregion
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton_Class.Checked == true)
            {
                #region 班级操作
                txt_ClassName.Clear();
                txt_ClassNum.Clear();
                mtxt_Code.Clear();
                if (e.ColumnIndex != -1 && e.RowIndex != -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    id = dataGridView1.CurrentRow.Cells[1].Value.ToString();//获取操作的班级号
                    txt_ClassName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();//显示班级名
                    txt_ClassNum.Text = id;//显示章节编号
                    mtxt_Code.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();//显示班级验证码
                }
                #endregion
            }
            else
            {
                if (radioButton_Stu.Checked == true)
                {
                    #region 学生操作
                    if (e.ColumnIndex != -1 && e.RowIndex != -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                    {
                        id = dataGridView1.CurrentRow.Cells[1].Value.ToString();//获取操作的学号
                    }
                    #endregion
                }
                else
                {
                    if (radioButton_Tea.Checked == true)
                    {
                        #region 教师操作
                        if (e.ColumnIndex != -1 && e.RowIndex != -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                        {
                            id = dataGridView1.CurrentRow.Cells[1].Value.ToString();//获取操作的教师号
                        }
                        #endregion
                    }
                }
            }
        }
    }
}
