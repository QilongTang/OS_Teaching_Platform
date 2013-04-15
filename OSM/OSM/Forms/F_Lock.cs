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
    public partial class F_Lock : Form
    {
        public F_Lock()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();
        private int Click_Times = 0;

        private void F_Lock_Load(object sender, EventArgs e)
        {
            labelPwd.Visible = false;
            txtPwd.Visible = false;
            butAccept.Visible = false;
            buttonCancel.Visible = false;
            butClear.Visible = false;
            pictureBox1.Image = OSM.Properties.Resources.Lock;
        }

        private void butUnLock_Click(object sender, EventArgs e)
        {
            labelPwd.Visible = true;
            txtPwd.Visible = true;
            butAccept.Visible = true;
            buttonCancel.Visible = true;
            butClear.Visible = true;
        }

        private void butAccept_Click(object sender, EventArgs e)
        {
            SqlDataReader temDR = MyClass.getcom("select * from tb_UserLogin where popenum ='" + DataClass.MyMeans.Login_ID.ToString() + "'");//查找权限标识跟当前登录人ID相同的记录
            if (temDR.Read())//如果有记录
            {
                if (txtPwd.Text.Trim() == temDR.GetString(temDR.GetOrdinal("password")))//如果输入的密码跟记录相同
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码错误!", "提示");
                    txtPwd.Text = "";
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            labelPwd.Visible = false;
            txtPwd.Text = "";
            txtPwd.Visible = false;
            butAccept.Visible = false;
            buttonCancel.Visible = false;
            butClear.Visible = false;
            if (Click_Times % 8 == 1)
            {
                pictureBox1.Image = OSM.Properties.Resources.Lock;
                Click_Times = 0;
            }

            if (Click_Times % 8 == 3)
            {
                pictureBox1.Image = OSM.Properties.Resources.黑白Lock;
                Click_Times = 2;
            }
            if (Click_Times % 8 == 5)
            {
                pictureBox1.Image = OSM.Properties.Resources.日光海岸Lock;
                Click_Times = 4;
            }

            if (Click_Times % 8 == 7)
            {
                pictureBox1.Image = OSM.Properties.Resources.素描Lock;
                Click_Times = 6;
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtPwd.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Click_Times % 8 == 0)
            {
                pictureBox1.Image = OSM.Properties.Resources.Lock凹;
                labelPwd.Visible = true;
                txtPwd.Visible = true;
                butAccept.Visible = true;
                buttonCancel.Visible = true;
                butClear.Visible = true;
            }
            if (Click_Times % 8 == 1)
            {
                pictureBox1.Image = OSM.Properties.Resources.黑白Lock;
                labelPwd.Visible = false;
                txtPwd.Text = "";
                txtPwd.Visible = false;
                butAccept.Visible = false;
                buttonCancel.Visible = false;
                butClear.Visible = false;
            }
            if (Click_Times % 8 == 2)
            {
                pictureBox1.Image = OSM.Properties.Resources.黑白Lock凹;
                labelPwd.Visible = true;
                txtPwd.Visible = true;
                butAccept.Visible = true;
                buttonCancel.Visible = true;
                butClear.Visible = true;
            }
            if (Click_Times % 8 == 3)
            {
                pictureBox1.Image = OSM.Properties.Resources.日光海岸Lock;
                labelPwd.Visible = false;
                txtPwd.Text = "";
                txtPwd.Visible = false;
                butAccept.Visible = false;
                buttonCancel.Visible = false;
                butClear.Visible = false;
            }
            if (Click_Times % 8 == 4)
            {
                pictureBox1.Image = OSM.Properties.Resources.日光海岸Lock凹;
                labelPwd.Visible = true;
                txtPwd.Visible = true;
                butAccept.Visible = true;
                buttonCancel.Visible = true;
                butClear.Visible = true;
            }
            if (Click_Times % 8 == 5)
            {
                pictureBox1.Image = OSM.Properties.Resources.素描Lock;
                labelPwd.Visible = false;
                txtPwd.Text = "";
                txtPwd.Visible = false;
                butAccept.Visible = false;
                buttonCancel.Visible = false;
                butClear.Visible = false;
            }
            if (Click_Times % 8 == 6)
            {
                pictureBox1.Image = OSM.Properties.Resources.素描Lock凹;
                labelPwd.Visible = true;
                txtPwd.Visible = true;
                butAccept.Visible = true;
                buttonCancel.Visible = true;
                butClear.Visible = true;
            }
            if (Click_Times % 8 == 7)
            {
                pictureBox1.Image = OSM.Properties.Resources.Lock;
                labelPwd.Visible = false;
                txtPwd.Text = "";
                txtPwd.Visible = false;
                butAccept.Visible = false;
                buttonCancel.Visible = false;
                butClear.Visible = false;
            }
            Click_Times++;
        }
    }
}
