using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSM.ModuleClass;

namespace OSM.Forms
{
    public partial class F_Menu : Form
    {
        DataClass.MyMeans MyClass = new OSM.DataClass.MyMeans();
        MyModule MyFrm = new MyModule();
        ModuleClass.MyModule MyMenu = new OSM.ModuleClass.MyModule();
        public F_Menu()
        {
            InitializeComponent();
        }

        private void F_Menu_Load(object sender, EventArgs e)
        {
            MyMenu.GetMenu(treeView1, menuStrip1);//使用菜单栏中的项填充导航菜单
            toolStripStatusLabel3.Text = DataClass.MyMeans.Login_Name;
            toolStripStatusLabel5.Text = DataClass.MyMeans.Login_Time;
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyFrm.Show_Form(sender.ToString().Trim(), 1);
        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyFrm.Show_Form(sender.ToString().Trim(), 1);
        }
    }
}
