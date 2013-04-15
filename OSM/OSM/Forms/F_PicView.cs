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
    public partial class F_PicView : Form
    {
        public F_PicView()
        {
            InitializeComponent();
        }

        public List<Image> pic = new List<Image>();//存放大图 
        MyModule MyMC = new MyModule();

        public class ListViewEx : ListView  // 子类化ListView，在View属性是List的时候出垂直滚动条 
        {
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern int ShowScrollBar(IntPtr hWnd, int iBar, int bShow);
            const int SB_HORZ = 0;
            const int SB_VERT = 1;
            protected override void WndProc(ref Message m)
            {
                if (this.View == View.List)
                {
                    ShowScrollBar(this.Handle, SB_VERT, 1);
                    ShowScrollBar(this.Handle, SB_HORZ, 0);
                }
                base.WndProc(ref m);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "bmp文件(*.bmp)|*.bmp";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    string filename = openFileDialog.FileName;//获取图片路径
                    pic.Add(Image.FromFile(filename));//存放到pic list中
                    int a = Pic_listView.Items.Count;
                    if (MyMC.insertpic(Image.FromFile(filename), DataClass.Experiment.Experiment_ID_forStudent, DataClass.MyMeans.Login_ID, a))
                    {
                        MessageBox.Show("插入该图片成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("插入该图片失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    pic_pictureBox.Image = Image.FromFile(filename);
                    imageList1.Images.Add(Image.FromFile(filename));//存放图标
                    Pic_listView.SmallImageList = imageList1;//把图标加入到listview
                    Pic_listView.Items.Add("");
                    a = 0;
                    foreach (Image p in pic)//循环以至于view显示图标
                    {
                        Pic_listView.Items[a].ImageIndex = a;
                        a++;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("请选择图片文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("该操作将会清空所有该实验报告的图片,确定继续吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MyMC.deletepic(DataClass.Experiment.Experiment_ID_forStudent, DataClass.MyMeans.Login_ID.ToString());
                pic.Clear();
                Pic_listView.Clear();
                pic_pictureBox.Image = null;
                Pic_listView.Clear();
            }
            /*
            int a = 0;
            foreach (Image p in pic)//遍历整个list表
            {
                a++;
                if (!MyMC.insertpic(p, DataClass.Experiment.Experiment_ID_forStudent, DataClass.MyMeans.Login_ID))
                {
                    MessageBox.Show("插入第" + a.ToString() + "张图片失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("插入第" + a.ToString() + "张图片成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (a == pic.Count)
                MessageBox.Show("所有图片保存成功!","提示");*/
        }

        private void F_PicView_Load(object sender, EventArgs e)
        {
            imageList1.ImageSize = new Size(120, 120);
            Pic_listView.View = View.List;//设置为列样式,垂直显示滚动条
            Pic_listView.SmallImageList = imageList1;//把图标加入到listview
            if (this.Tag.Equals(0) || this.Tag.Equals(2) || this.Tag.Equals(4))//如果是学生新建或修改或重做实验报告模式
            {
                pic = MyMC.reImage(DataClass.Experiment.Experiment_ID_forStudent, DataClass.MyMeans.Login_ID);
                int a = 0;
                foreach (Image p in pic)//循环以至于view显示图标
                {
                    imageList1.Images.Add(p);
                    Pic_listView.Items.Add("");
                    Pic_listView.Items[a].ImageIndex = a;
                    a++;
                }
            }
            else
            {
                if (this.Tag.Equals(1))//如果是教师批改或查看实验报告模式
                {
                    this.butAdd.Enabled = false;
                    this.butDelete.Enabled = false;
                    this.butClear.Enabled = false;
                    pic = MyMC.reImage(DataClass.Experiment.Experiment_ID_forTeahcer, DataClass.Student.Student_ID);
                    int a = 0;
                    foreach (Image p in pic)//循环以至于view显示图标
                    {
                        imageList1.Images.Add(p);
                        Pic_listView.Items.Add("");
                        Pic_listView.Items[a].ImageIndex = a;
                        a++;
                    }
                }
                else
                {
                    if (this.Tag.Equals(3))//如果是学生查看实验报告图片模式
                    {
                        this.butAdd.Enabled = false;
                        this.butDelete.Enabled = false;
                        this.butClear.Enabled = false;
                        pic = MyMC.reImage(DataClass.Experiment.Experiment_ID_forStudent, DataClass.Student.Student_ID);
                        int a = 0;
                        foreach (Image p in pic)//循环以至于view显示图标
                        {
                            imageList1.Images.Add(p);
                            Pic_listView.Items.Add("");
                            Pic_listView.Items[a].ImageIndex = a;
                            a++;
                        }
                    }
                }
            }

        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (Pic_listView.FocusedItem == null)
                MessageBox.Show("请选择要删除的图片!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int a = Pic_listView.Items.IndexOf(Pic_listView.FocusedItem);//获取选取图片索引
                Pic_listView.Items.Remove(Pic_listView.FocusedItem);//移除listview item
                imageList1.Images.RemoveAt(a);//移除imagelist中图标
                if (MyMC.DeleteOnepic(DataClass.Experiment.Experiment_ID_forStudent, DataClass.MyMeans.Login_ID, a))
                {
                    MessageBox.Show("删除该图片成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除该图片失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                int b = 0;
                foreach (Image p in pic)//遍历整个list表
                {
                    if (b == a)
                    {
                        pic.Remove(p);//把选中的图从list移除
                        break;
                    }
                    b++;
                }
                b = 0;
                foreach (Image p in pic)//重新循环以至于view显示图标
                {
                    int FormerListIndex = Pic_listView.Items[b].ImageIndex;
                    MyMC.UpdatePicID(DataClass.Experiment.Experiment_ID_forStudent, DataClass.MyMeans.Login_ID, FormerListIndex, b);
                    Pic_listView.Items[b].ImageIndex = b;
                    b++;
                }
            }
            pic_pictureBox.Image = null;
        }

        private void Pic_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Pic_listView.Items.IndexOf(Pic_listView.FocusedItem);//获取选取图片索引
            int b = 0;
            foreach (Image p in pic)//遍历整个list表
            {
                if (b == a)
                {
                    pic_pictureBox.Image = p;//把选中的图放入picturebox中
                    break;
                }
                b++;
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            //遍历该窗体父窗体的所有MDI子窗体
            foreach (Form childFrm in this.MdiParent.MdiChildren)
            {//查找与指定名称相匹配的子窗体
                if (childFrm.Name == "F_DoExperiment" || childFrm.Name == "F_GiveMark")
                {//如果存在则显示子窗体
                    childFrm.WindowState = FormWindowState.Maximized;
                    //给子窗体焦点
                    childFrm.Activate();
                }
            }
            this.Close();
        }

        private void pic_pictureBox_Click(object sender, EventArgs e)
        {

        }

    }
}
