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
    public partial class F_ExperimentStats : Form
    {
        public F_ExperimentStats()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();
        public static string Term_Field = "mark,IDS,date,title,class,IDC,flagCorrect";
        public static string Term_Value = "实验成绩,学生编号,完成时间,实验标题,学生班级,章节编号,实验是否被批改";
        public static string[] A_Field = Term_Field.Split(Convert.ToChar(','));
        public static string[] A_Value = Term_Value.Split(Convert.ToChar(','));
        public static DataSet MyDS_Grid;
        public static string Term_Field2 = "ID,IDT,IDC,title,flag";
        public static string Term_Value2 = "实验编号,教师编号,章节编号,实验题目,实验是否被发布";
        public static string[] B_Field = Term_Field2.Split(Convert.ToChar(','));
        public static string[] B_Value = Term_Value2.Split(Convert.ToChar(','));
        public static DataSet MyDS_Grid2;

        public void Stat_Class(int n)
        {
            if (n == 6)
            {
                MyDS_Grid = MyClass.getDataSet("select REPLACE(REPLACE([flagCorrect],1,'已批改'),0,'未批改')状态,count(" + A_Field[n] + ") as '份数' from tb_Report group by " + A_Field[n], "tb_Report");
            }
            else
            {
                MyDS_Grid = MyClass.getDataSet("select " + A_Field[n] + " as '" + A_Value[n] + "', count(" + A_Field[n] + ")  as '份数' from tb_Report group by " + A_Field[n], "tb_Report");
            }
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.Columns[0].Width = 240;
            dataGridView1.Columns[1].Width = 55;
        }

        public void Stat2_Class(int n)
        {
            if (n == 4)
            {
                MyDS_Grid2 = MyClass.getDataSet("select REPLACE(REPLACE([flag],1,'已发布'),0,'未发布')状态,count(" + B_Field[n] + ") as '份数' from tb_Experiment group by " + B_Field[n], "tb_Experiment");
            }
            else
            {
                MyDS_Grid2 = MyClass.getDataSet("select " + B_Field[n] + " as '" + B_Value[n] + "', count(" + B_Field[n] + ")  as '份数' from tb_Experiment group by " + B_Field[n], "tb_Experiment");
            }
            dataGridView2.DataSource = MyDS_Grid2.Tables[0];
            dataGridView2.Columns[0].Width = 240;
            dataGridView2.Columns[1].Width = 55;
        }


        private void F_ExperimentStats_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < A_Value.Length; i++)
                listBox1.Items.Add("按" + A_Value[i] + "统计");
            Stat_Class(0);
            listBox2.Items.Clear();
            for (int i = 0; i < B_Value.Length; i++)
                listBox2.Items.Add("按" + B_Value[i] + "统计");
            Stat2_Class(0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stat_Class(listBox1.SelectedIndex);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stat2_Class(listBox2.SelectedIndex);
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
