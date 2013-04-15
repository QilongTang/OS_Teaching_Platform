using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OSM.DataClass;

namespace OSM.Forms
{
    public partial class F_UpdatePwd : Form
    {
        public F_UpdatePwd()
        {
            InitializeComponent();
        }
        MyMeans MyClass = new MyMeans();

        private void updata_button_Click(object sender, EventArgs e)
        {
            if (oldpwd_text.Text.Trim() == DataClass.MyMeans.User_Pwd)//�жϾ������Ƿ���ȷ
            {
                if (newpwd_text1.Text == newpwd_text2.Text)//�ж���������������
                {
                    try
                    {
                        MyClass.getsqlcom("update tb_UserLogin set password='" + newpwd_text1.Text.Trim() + "' where IDU=" + DataClass.MyMeans.User_ID.ToString() + "");
                        DataClass.MyMeans.User_Pwd=newpwd_text1.Text.Trim();//�������븳ֵ��ϵͳ����
                        this.DialogResult = DialogResult.OK;
                        this.Close();//ģʽ�˳�
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("�������������벻һ��!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oldpwd_text.Text = "";
                    newpwd_text1.Text = "";
                    newpwd_text2.Text = "";
                    oldpwd_text.Focus();
                }
            }
            else
            {
                MessageBox.Show("�������!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oldpwd_text.Text = "";
                newpwd_text1.Text = "";
                newpwd_text2.Text = "";
                oldpwd_text.Focus();
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_updatePwd_Load(object sender, EventArgs e)
        {

        }
    }
}