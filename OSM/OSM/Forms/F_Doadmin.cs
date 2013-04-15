using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OSM
{
    public partial class F_Doadmin : Form
    {
        public F_Doadmin()
        {
            InitializeComponent();
        }

        private void do_button_Click(object sender, EventArgs e)
        {
            if (admin_text.Text.ToString() == "111111")
            {
                this.DialogResult = DialogResult.OK;
                //DataClass.MyMeans.User_Pope = "A";
            }
            else
            {
                MessageBox.Show("开启权限密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admin_text.Clear();//清空密码
            }
        }

        private void doadmin_form_Load(object sender, EventArgs e)
        {
            admin_text.Focus();
        }
    }
}