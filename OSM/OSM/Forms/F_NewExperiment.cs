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
    public partial class F_NewExperiment : Form
    {
        public F_NewExperiment()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();
        MyModule MyMClass = new MyModule();
        static string Experiment_ID = "";

        private void butClose_Click(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                this.Close();
                DataClass.MyMeans.IfExperimentView = false;
            }
            else
            {
                //遍历该窗体父窗体的所有MDI子窗体
                foreach (Form childFrm in this.MdiParent.MdiChildren)
                {
                    if (childFrm.Name == "F_ExperimentManage")
                    {
                        //如果存在则显示子窗体
                        childFrm.WindowState = FormWindowState.Maximized;
                        //给子窗体焦点
                        childFrm.Activate();
                    }
                    this.Close();
                }
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            //清空所有控件 
            this.cb_ChapterNum.Text = null;
            this.cb_ChapterName.Text = null;
            this.txtDetail.Text = null;
            this.txtGuidance.Text = null;
            this.txtPreparation.Text = null;
            this.txtPurpose.Text = null;
            this.txtTitle.Text = null;
        }

        private void F_NewExperiment_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“db_BSDataSet.tb_Chapter”中。您可以根据需要移动或删除它。
            this.tb_ChapterTableAdapter.Fill(this.db_BSDataSet.tb_Chapter);
            butGetChapterNum.Enabled = false;
            if (this.Tag.Equals(0))//教师新建模式
            {
                this.butDoExperiment.Visible = false;
                this.txtTeacherNum.Text = DataClass.MyMeans.Login_ID.ToString();
                this.txtTeacherNum.ReadOnly = true;//设置教师编号为只读
                this.txtExperimentNum.ReadOnly = true;//设置章节编号为只读
                butGetChapterNum.Enabled = true;
                try
                {
                    //自动生成教师名
                    SqlDataReader temDR = MyClass.getcom("select * from tb_Teacher where IDT='" + this.txtTeacherNum.Text.Trim() + "'");
                    if (temDR.Read())
                    {
                        this.txtTeacherName.Text = temDR.GetString(temDR.GetOrdinal("name"));
                        this.txtTeacherName.ReadOnly = true;//设置教师名为只读
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告");
                }
            }
            else
                if (this.Tag.Equals(1))//教师浏览模式
                {
                    this.butDoExperiment.Visible = false;
                    try
                    {
                        SqlDataReader temDR = MyClass.getcom("select * from tb_Experiment where ID='" + DataClass.Experiment.Experiment_ID_forTeahcer + "'");
                        if (temDR.Read())
                        {
                            this.txtTeacherNum.Text = temDR.GetValue(temDR.GetOrdinal("IDT")).ToString();
                            this.txtTeacherNum.ReadOnly = true;
                            SqlDataReader temDR2 = MyClass.getcom("select * from tb_Teacher where IDT='" + this.txtTeacherNum.Text.Trim() + "'");
                            if (temDR2.Read())
                            {
                                this.txtTeacherName.Text = temDR2.GetString(temDR2.GetOrdinal("name"));
                                this.txtTeacherName.ReadOnly = true;//设置教师名为只读
                            }
                            this.cb_ChapterNum.Text = temDR.GetValue(temDR.GetOrdinal("IDC")).ToString();
                            this.cb_ChapterNum.Enabled = false;
                            this.cb_ChapterName.Enabled = false;
                            //this.cb_ChaperNum.DropDownStyle = ComboBoxStyle.DropDownList;
                            //this.cb_ChapterName.DropDownStyle = ComboBoxStyle.DropDownList;
                            this.txtTitle.Text = temDR.GetString(temDR.GetOrdinal("title"));
                            this.txtTitle.ReadOnly = true;
                            this.txtExperimentNum.Text = temDR.GetValue(temDR.GetOrdinal("IDE")).ToString();
                            this.txtExperimentNum.ReadOnly = true;
                            this.txtPurpose.Text = temDR.GetString(temDR.GetOrdinal("purpose"));
                            this.txtPurpose.ReadOnly = true;
                            this.txtDetail.Text = temDR.GetString(temDR.GetOrdinal("detail"));
                            this.txtDetail.ReadOnly = true;
                            this.txtGuidance.Text = temDR.GetString(temDR.GetOrdinal("guidance"));
                            this.txtGuidance.ReadOnly = true;
                            this.txtPreparation.Text = temDR.GetString(temDR.GetOrdinal("preparation"));
                            this.txtPreparation.ReadOnly = true;
                            this.butAccept.Enabled = false;
                            this.butClear.Enabled = false;
                            this.butOpenFile.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "警告");
                    }
                }
                else
                    if (this.Tag.Equals(2))//教师修改模式
                    {
                        this.butDoExperiment.Visible = false;
                        this.butGetChapterNum.Enabled = true;
                        try
                        {
                            SqlDataReader temDR = MyClass.getcom("select * from tb_Experiment where ID='" + DataClass.Experiment.Experiment_ID_forTeahcer + "'");
                            if (temDR.Read())
                            {
                                this.txtTeacherNum.Text = temDR.GetValue(temDR.GetOrdinal("IDT")).ToString();
                                this.txtTeacherNum.ReadOnly = true;
                                SqlDataReader temDR2 = MyClass.getcom("select * from tb_Teacher where IDT='" + this.txtTeacherNum.Text.Trim() + "'");
                                if (temDR2.Read())
                                {
                                    this.txtTeacherName.Text = temDR2.GetString(temDR2.GetOrdinal("name"));
                                    this.txtTeacherName.ReadOnly = true;//设置教师名为只读
                                }
                                this.cb_ChapterNum.Text = temDR.GetValue(temDR.GetOrdinal("IDC")).ToString();
                                this.txtTitle.Text = temDR.GetString(temDR.GetOrdinal("title"));
                                this.txtExperimentNum.Text = temDR.GetValue(temDR.GetOrdinal("IDE")).ToString();
                                this.txtPurpose.Text = temDR.GetString(temDR.GetOrdinal("purpose"));
                                this.txtDetail.Text = temDR.GetString(temDR.GetOrdinal("detail"));
                                this.txtGuidance.Text = temDR.GetString(temDR.GetOrdinal("guidance"));
                                this.txtPreparation.Text = temDR.GetString(temDR.GetOrdinal("preparation"));

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "警告");
                        }
                    }
                    else
                        if (this.Tag.Equals(3))//学生做实验模式
                        {
                            try
                            {
                                SqlDataReader temDR = MyClass.getcom("select * from tb_Experiment where ID='" + DataClass.Experiment.Experiment_ID_forStudent + "'");
                                if (temDR.Read())
                                {
                                    this.txtTeacherNum.Text = temDR.GetValue(temDR.GetOrdinal("IDT")).ToString();
                                    this.txtTeacherNum.ReadOnly = true;
                                    SqlDataReader temDR2 = MyClass.getcom("select * from tb_Teacher where IDT='" + this.txtTeacherNum.Text.Trim() + "'");
                                    if (temDR2.Read())
                                    {
                                        this.txtTeacherName.Text = temDR2.GetString(temDR2.GetOrdinal("name"));
                                        this.txtTeacherName.ReadOnly = true;//设置教师名为只读
                                    }
                                    this.cb_ChapterNum.Text = temDR.GetValue(temDR.GetOrdinal("IDC")).ToString();
                                    this.cb_ChapterNum.Enabled = false;
                                    this.cb_ChapterName.Enabled = false;
                                    //this.cb_ChaperNum.DropDownStyle = ComboBoxStyle.DropDownList;
                                    //this.cb_ChapterName.DropDownStyle = ComboBoxStyle.DropDownList;
                                    this.txtTitle.Text = temDR.GetString(temDR.GetOrdinal("title"));
                                    this.txtTitle.ReadOnly = true;
                                    this.txtExperimentNum.Text = temDR.GetValue(temDR.GetOrdinal("IDE")).ToString();
                                    this.txtExperimentNum.ReadOnly = true;
                                    this.txtPurpose.Text = temDR.GetString(temDR.GetOrdinal("purpose"));
                                    this.txtPurpose.ReadOnly = true;
                                    this.txtDetail.Text = temDR.GetString(temDR.GetOrdinal("detail"));
                                    this.txtDetail.ReadOnly = true;
                                    this.txtGuidance.Text = temDR.GetString(temDR.GetOrdinal("guidance"));
                                    this.txtGuidance.ReadOnly = true;
                                    this.txtPreparation.Text = temDR.GetString(temDR.GetOrdinal("preparation"));
                                    this.txtPreparation.ReadOnly = true;
                                    this.butAccept.Enabled = false;
                                    this.butClear.Enabled = false;
                                    this.butOpenFile.Enabled = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "警告");
                            }
                        }
                        else
                            if (this.Tag.Equals(4))//学生浏览模式
                            {
                                this.butDoExperiment.Enabled = false;
                                try
                                {
                                    SqlDataReader temDR = MyClass.getcom("select * from tb_Experiment where ID='" + DataClass.Experiment.Experiment_ID_forStudent + "'");
                                    if (temDR.Read())
                                    {
                                        this.txtTeacherNum.Text = temDR.GetValue(temDR.GetOrdinal("IDT")).ToString();
                                        this.txtTeacherNum.ReadOnly = true;
                                        SqlDataReader temDR2 = MyClass.getcom("select * from tb_Teacher where IDT='" + this.txtTeacherNum.Text.Trim() + "'");
                                        if (temDR2.Read())
                                        {
                                            this.txtTeacherName.Text = temDR2.GetString(temDR2.GetOrdinal("name"));
                                            this.txtTeacherName.ReadOnly = true;//设置教师名为只读
                                        }
                                        this.cb_ChapterNum.Text = temDR.GetValue(temDR.GetOrdinal("IDC")).ToString();
                                        this.cb_ChapterNum.Enabled = false;
                                        this.cb_ChapterName.Enabled = false;
                                        //this.cb_ChaperNum.DropDownStyle = ComboBoxStyle.DropDownList;
                                        //this.cb_ChapterName.DropDownStyle = ComboBoxStyle.DropDownList;
                                        this.txtTitle.Text = temDR.GetString(temDR.GetOrdinal("title"));
                                        this.txtTitle.ReadOnly = true;
                                        this.txtExperimentNum.Text = temDR.GetValue(temDR.GetOrdinal("IDE")).ToString();
                                        this.txtExperimentNum.ReadOnly = true;
                                        this.txtPurpose.Text = temDR.GetString(temDR.GetOrdinal("purpose"));
                                        this.txtPurpose.ReadOnly = true;
                                        this.txtDetail.Text = temDR.GetString(temDR.GetOrdinal("detail"));
                                        this.txtDetail.ReadOnly = true;
                                        this.txtGuidance.Text = temDR.GetString(temDR.GetOrdinal("guidance"));
                                        this.txtGuidance.ReadOnly = true;
                                        this.txtPreparation.Text = temDR.GetString(temDR.GetOrdinal("preparation"));
                                        this.txtPreparation.ReadOnly = true;
                                        this.butAccept.Enabled = false;
                                        this.butClear.Enabled = false;
                                        this.butOpenFile.Enabled = false;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "警告");
                                }
                            }

        }

        private void butAccept_Click(object sender, EventArgs e)
        {
            //提交时再次确认实验编号
            butGetChapterNum_Click(null, null);
            string a = txtExperimentNum.Text.Trim();
            string b = cb_ChapterNum.Text.Trim();
            string c = txtTeacherNum.Text.Trim();
            if (Convert.ToInt32(a) < 10)
                a = "0" + a;
            if (Convert.ToInt32(b) < 10)
                b = "0" + b;
            if (Convert.ToInt32(c) < 10)
                c = "0" + c;
            Experiment_ID = c + b + a;
            if (txtTitle.Text != null && txtExperimentNum != null && txtDetail != null)
            {
                if (this.Tag.Equals(0))
                {
                    try
                    {
                        MyClass.getcom("insert into tb_Experiment (ID,IDE,IDT,IDC,title,purpose,detail,preparation,guidance,flag) values('" + Experiment_ID.ToString() + "','" + txtExperimentNum.Text.Trim() + "','" + txtTeacherNum.Text.Trim() + "','" + this.cb_ChapterNum.Text.Trim() + "','" + txtTitle.Text.Trim() + "','" + txtPurpose.Text.Trim() + "','" + txtDetail.Text.Trim() + "','" + txtPreparation.Text.Trim() + "','" + txtGuidance.Text.Trim() + "','false')");
                        MessageBox.Show("新建成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cb_ChapterNum.Enabled = false;
                        this.cb_ChapterName.Enabled = false;
                        this.txtDetail.ReadOnly = true;
                        this.txtGuidance.ReadOnly = true;
                        this.txtPreparation.ReadOnly = true;
                        this.txtPurpose.ReadOnly = true;
                        this.txtTitle.ReadOnly = true;
                        this.butAccept.Enabled = false;
                        this.butClear.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "警告");
                    }
                }
                else
                {
                    if (this.Tag.Equals(2))
                    {
                        try
                        {
                            MyClass.getcom("update tb_Experiment set IDE='" + txtExperimentNum.Text.Trim() + "',IDT='" + txtTeacherNum.Text.Trim() + "',IDC='" + this.cb_ChapterNum.Text.Trim() + "',title='" + txtTitle.Text.Trim() + "',purpose='" + txtPurpose.Text.Trim() + "',detail='" + txtDetail.Text.Trim() + "',preparation='" + txtPreparation.Text.Trim() + "',guidance='" + txtGuidance.Text.Trim() + "'where ID='" + Experiment_ID.ToString() + "'");
                            MessageBox.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.cb_ChapterNum.Enabled = false;
                            this.cb_ChapterName.Enabled = false;
                            this.txtDetail.ReadOnly = true;
                            this.txtGuidance.ReadOnly = true;
                            this.txtPreparation.ReadOnly = true;
                            this.txtPurpose.ReadOnly = true;
                            this.txtTitle.ReadOnly = true;
                            this.butAccept.Enabled = false;
                            this.butClear.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "警告");
                        }
                    }
                }
            }
            else
                MessageBox.Show("实验内容不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butDoExperiment_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MyClass.getcom("select * from tb_Report where IDE='" + DataClass.Experiment.Experiment_ID_forStudent + "' and IDS='" + DataClass.MyMeans.Login_ID + "'").Read())
                {
                    SqlDataReader temDR = MyClass.getcom("select * from tb_Experiment where ID='" + DataClass.Experiment.Experiment_ID_forStudent + "'");
                    if (temDR.Read())
                        DataClass.Experiment.ExperimentDone_Title = temDR.GetString(temDR.GetOrdinal("title"));
                    F_DoExperiment Do = new F_DoExperiment();
                    Do.MdiParent = this.MdiParent;
                    Do.WindowState = FormWindowState.Maximized;
                    Do.Tag = 0;
                    Do.Text = "进行实验";
                    Do.Show();
                }
                else
                {
                    MessageBox.Show("您已经做过此实验,请去报告管理查看");
                    this.butDoExperiment.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butGetChapterNum_Click(object sender, EventArgs e)
        {
            //自动获得章节号
            try
            {
                SqlDataReader temDR = MyClass.getcom("SELECT MAX(IDE) FROM tb_Experiment WHERE IDC = '" + cb_ChapterNum.SelectedValue + "'");
                if (temDR.Read())
                {
                    if (temDR.GetValue(0).ToString()!="null")
                    {
                        txtExperimentNum.Text = (Convert.ToInt32(temDR.GetValue(0)) + 1).ToString();
                    }
                    else
                        txtExperimentNum.Text = "1";
                }
            }
            catch (Exception)
            {
                txtExperimentNum.Text = "1";
                //MessageBox.Show(ex.Message);
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            //在编辑实验标题时自动获取实验编号
            butGetChapterNum_Click(null,null);
        }
    }
}
