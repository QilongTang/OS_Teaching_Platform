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
                MessageBox.Show("����Ȩ���������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admin_text.Clear();//�������
            }
        }

        private void doadmin_form_Load(object sender, EventArgs e)
        {
            admin_text.Focus();
        }
    }
}