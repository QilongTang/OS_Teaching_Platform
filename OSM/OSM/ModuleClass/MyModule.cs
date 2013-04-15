using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OSM.Forms;
using System.IO;
using System.Drawing;


namespace OSM.ModuleClass
{
    class MyModule
    {
        #region 公共变量
        //声明MyMeans类的一个对象,以调用其方法
        DataClass.MyMeans MyDataClass = new OSM.DataClass.MyMeans();
        public static string ADDs = "";//用来存储或添加或修改的SQL语句
        public static string FindValue = "";//存储查询条件
        #endregion

        #region  将时间转换成指定的格式
        /// <summary>
        /// 将时间转换成yyyy-mm-dd格式.
        /// </summary>
        /// <param name="NDate">日期</param>
        /// <returns>返回String对象</returns>
        public string Time_Format(string NDate)
        {
            string sh, sm, se;
            int hh, mm, ss;
            try
            {
                hh = Convert.ToDateTime(NDate).Hour;
                mm = Convert.ToDateTime(NDate).Minute;
                ss = Convert.ToDateTime(NDate).Second;

            }
            catch
            {
                return "";
            }
            sh = Convert.ToString(hh);
            if (sh.Length < 2)
                sh = "0" + sh;
            sm = Convert.ToString(mm);
            if (sm.Length < 2)
                sm = "0" + sm;
            se = Convert.ToString(ss);
            if (se.Length < 2)
                se = "0" + se;
            return sh + sm + se;
        }
        #endregion

        #region 遍历清空指定的控件
        ///<summary>
        ///遍历清空指定的控件
        ///</summary>
        ///<param name="Con">可视化控件</param>
        public void Clear_Control(Control.ControlCollection Con)
        {
            foreach (Control C in Con)
            {//遍历可视化组件中所有的控件
                if (C.GetType().Name == "TextBox")//判断是否为TextBox控件
                    if (((TextBox)C).Visible == true)//判断当前控件是否为现实
                        ((TextBox)C).Clear();//清空当前控件
                if (C.GetType().Name == "MaskedTextBox")//判断是否为MaskedTextBox控件
                    if (((MaskedTextBox)C).Visible == true)//判断当前控件是否为现实
                        ((MaskedTextBox)C).Clear();//清空当前控件
                if (C.GetType().Name == "ComboBox")//判断是否为ComboBox控件
                    if (((ComboBox)C).Visible == true)//判断当前控件是否为现实
                        ((ComboBox)C).Text = "";//清空当前控件
                if (C.GetType().Name == "PictureBox")//判断是否为PictureBox控件
                    if (((PictureBox)C).Visible == true)//判断当前控件是否为现实
                        ((PictureBox)C).Image = null;//清空当前控件
            }
        }
        #endregion

        #region  清空控件集上的控件信息
        /// <summary>
        /// 清空GroupBox控件上的控件信息.
        /// </summary>
        /// <param name="n">控件个数</param>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
        public void Clear_Grids(int n, Control.ControlCollection GBox, string TName)
        {
            string sID = "";
            for (int i = 2; i < n; i++)
            {
                sID = TName + i.ToString();
                foreach (Control C in GBox)
                {
                    if (C.GetType().Name == "TextBox" | C.GetType().Name == "MaskedTextBox" | C.GetType().Name == "ComboBox")
                        if (C.Name == sID)
                        {
                            C.Text = "";
                        }
                }
            }
        }
        #endregion

        #region  组合查询条件
        /// <summary>
        /// 根据控件是否为空组合查询条件.
        /// </summary>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
        /// <param name="TName">查询关系</param>
        public void Find_Grids(Control.ControlCollection GBox, string TName, string ANDSign)
        {
            string sID = "";    //定义局部变量
            if (FindValue.Length > 0)
                FindValue = FindValue + ANDSign;
            foreach (Control C in GBox)
            { //遍历控件集上的所有控件
                if (C.GetType().Name == "TextBox" | C.GetType().Name == "ComboBox")
                { //判断是否要遍历的控件
                    if (C.GetType().Name == "ComboBox" && C.Text != "")
                    {   //当指定控件不为空时
                        sID = C.Name;
                        if (sID.IndexOf(TName) > -1)
                        {    //当TName参数是当前控件名中的部分信息时
                            string[] Astr = sID.Split(Convert.ToChar('_')); //用“_”符号分隔当前控件的名称,获取相应的字段名
                            FindValue = FindValue + "(" + Astr[1] + " = '" + C.Text + "')" + ANDSign;   //生成查询条件
                        }
                    }
                    if (C.GetType().Name == "TextBox" && C.Text != "")  //如果当前为TextBox控件，并且控件不为空
                    {
                        sID = C.Name;   //获取当前控件的名称
                        if (sID.IndexOf(TName) > -1)    //判断TName参数值是否为当前控件名的子字符串
                        {
                            string[] Astr = sID.Split(Convert.ToChar('_')); //以“_”为分隔符，将控件名存入到一维数组中
                            string m_Sgin = ""; //用于记录逻辑运算符
                            string mID = "";    //用于记录字段名
                            if (Astr.Length > 2)    //当数组的元素个数大于2时
                                mID = Astr[1] + "_" + Astr[2];  //将最后两个元素组成字段名
                            else
                                mID = Astr[1];  //获取当前条件所对应的字段名称
                            foreach (Control C1 in GBox)    //遍历控件集
                            {
                                if (C1.GetType().Name == "ComboBox")    //判断是否为ComboBox组件
                                    if ((C1.Name).IndexOf(mID) > -1)    //判断当前组件名是否包含条件组件的部分文件名
                                    {
                                        if (C1.Text == "")  //当查询条件为空时
                                            break;  //退出本次循环
                                        else
                                        {
                                            m_Sgin = C1.Text;   //将条件值存储到m_Sgin变量中
                                            break;
                                        }
                                    }
                            }
                            if (m_Sgin != "")   //当该务件不为空时
                                FindValue = FindValue + "(" + mID + m_Sgin + C.Text + ")" + ANDSign;    //组合SQL语句的查询条件
                        }
                    }
                }
            }
            if (FindValue.Length > 0)   //当存储查询条的变量不为空时，删除逻辑运算符AND和OR
            {
                if (FindValue.IndexOf("AND") > -1)  //判断是否用AND连接条件
                    FindValue = FindValue.Substring(0, FindValue.Length - 4);
                if (FindValue.IndexOf("OR") > -1)  //判断是否用OR连接条件
                    FindValue = FindValue.Substring(0, FindValue.Length - 3);
            }
            else
                FindValue = "";

        }
        #endregion

        #region 将StatusStrip控件中的信息添加到treeView控件中
        ///<summary>
        ///读取菜单中的信息
        ///</summary>
        ///<param name="treeV">TreeView控件</param>
        ///<param name="MenuS">MenuStrip控件</param>
        public void GetMenu(TreeView treeV, MenuStrip MenuS)
        {
            //遍历MenuStrip组件中的一级菜单项
            for (int i = 0; i < MenuS.Items.Count; i++)
            {
                //将一级菜单项的名称添加到TreeView组件的根节点中,并设置当前节点的子节点newNode1
                TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);
                //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                //判断当前菜单项中是否有二级菜单项
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)//遍历二级菜单项
                    {
                        //将二级菜单项名称添加到TreeView组件的子节点newNode1中,并设置当前节点的子节点
                        TreeNode newNode2 = newNode1.Nodes.Add(newmenu.DropDownItems[j].Text);
                        //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                        //判断二级菜单项中是否有三级菜单项
                        if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)
                            for (int p = 0; p < newmenu2.DropDownItems.Count; p++)//遍历三级菜单项
                                //将三级菜单项名称添加到TreeView组件的子节点newNode2中
                                newNode2.Nodes.Add(newmenu2.DropDownItems[p].Text);
                    }
            }
        }
        #endregion

        #region  根据用户权限设置主窗体菜单
        /// <summary>
        /// 根据用户权限设置菜单是否可用.
        /// </summary>
        /// <param name="MenuS">MenuStrip控件</param>
        /// <param name="UName">当前登录用户名</param>
        public void MainPope(MenuStrip MenuS, String UName)
        {
            string Str = "";
            string MenuName = "";
            DataSet DSet = MyDataClass.getDataSet("select ID from tb_UserLogin where Name='" + UName + "'", "tb_Login");    //获取当前登录用户的信息
            string UID = Convert.ToString(DSet.Tables[0].Rows[0][0]);   //获取当前用户编号
            DSet = MyDataClass.getDataSet("select ID,PopeName,Pope from tb_UserPope where ID='" + UID + "'", "tb_UserPope");    //获取当前用户的权限信息
            bool bo = false;
            for (int k = 0; k < DSet.Tables[0].Rows.Count; k++) //遍历当前用户的权限名称
            {
                Str = Convert.ToString(DSet.Tables[0].Rows[k][1]);  //获取权限名称
                if (Convert.ToInt32(DSet.Tables[0].Rows[k][2]) == 1)    //判断权限是否可用
                    bo = true;
                else
                    bo = false;
                for (int i = 0; i < MenuS.Items.Count; i++) //遍历菜单栏中的一级菜单项
                {
                    ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];  //记录当前菜单项下的所有信息
                    if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)    //如果当前菜单项有子级菜单项
                        for (int j = 0; j < newmenu.DropDownItems.Count; j++)    //遍历二级菜单项
                        {
                            MenuName = newmenu.DropDownItems[j].Name;   //获取当前菜单项的名称
                            if (MenuName.IndexOf(Str) > -1) //如果包含权限名称
                                newmenu.DropDownItems[j].Enabled = bo;  //根据权限设置可用状态
                            ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];   //记录当前菜单项的所有信息
                            if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)  //如果当前菜单项有子级菜单项
                                for (int p = 0; p < newmenu2.DropDownItems.Count; p++)  //遍历三级菜单项
                                {
                                    MenuName = newmenu2.DropDownItems[p].Name;  //获取当前菜单项的名称
                                    if (MenuName.IndexOf(Str) > -1) //如果包含权限名称
                                        newmenu2.DropDownItems[p].Enabled = bo;  //根据权限设置可用状态
                                }
                        }
                }
            }
        }
        #endregion

        #region  向comboBox控件传递数据表中的数据
        /// <summary>
        /// 动态向comboBox控件的下拉列表添加数据.
        /// </summary>
        /// <param name="cobox">comboBox控件</param>
        /// <param name="TableName">数据表名称</param>
        public void CoPassData(ComboBox cobox, string TableName)
        {
            cobox.Items.Clear();
            DataClass.MyMeans MyDataClass = new OSM.DataClass.MyMeans();
            SqlDataReader MyDR = MyDataClass.getcom("select * from " + TableName);
            if (MyDR.HasRows)
            {
                while (MyDR.Read())
                {
                    if (MyDR[1].ToString() != "" && MyDR[1].ToString() != null)
                    {
                        cobox.Items.Add(MyDR[1].ToString());
                        cobox.DisplayMember = "name";
                        cobox.ValueMember = "ID";
                    }
                }
            }
        }
        #endregion

        #region 图片操作中的插入操作
        /// <summary>
        /// PicView中点击插入后在数据库中存储图片所调用的函数
        /// </summary>
        /// <param name="pic">原图变量</param>
        /// <param name="ide">实验编号</param>
        /// <param name="ids">学生编号</param>
        /// /// <param name="a">图片索引,即listview中的序号,即表中单个实验报告的第几张图</param>
        /// <returns></returns>
        public bool insertpic(Image pic, string ide, string ids,int a)//插入图片操作
        {
            /*//文件流
            FileStream mypic =
                new FileStream(@"" + filename + "", FileMode.Open, FileAccess.Read);
            //文件流长度
            int le = (int)(mypic.Length);
            //创建二进制数组
            byte[] ca = new byte[le];
            /* 读取字节，从0开始到最后，插入到上面定义的二进制的数组里面。
             * 这句比较重要，如果没有这句，数据插入不会出错；
             * 但是最终插入的数据是错误的，非图片二进制数据。
             */
            /*Stream myst = mypic;
            myst.Read(ca, 0, le);*/
            try
            {
                string SaveFile = "c:\\a.jpg";
                pic.Save(SaveFile, System.Drawing.Imaging.ImageFormat.Jpeg);//先存至路径
                //转换文件 
                FileStream sr = new FileStream(SaveFile, FileMode.Open, FileAccess.Read);//文件流
                byte[] ca = new byte[sr.Length];
                sr.Read(ca, 0, (int)ca.Length);//图片转换为2进制
                sr.Close();
                /*MemoryStream ms = new MemoryStream();
                pic.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = new byte[ms.Length];
                ms.Write(bytes, 0, (int)ms.Length);*/
                string sql = "Insert into [tb_Picture] values("+ a +",'" + ide + "','" + ids + "',(@pic))";
                SqlConnection sc = new SqlConnection("Trusted_Connection=SSPI;Database=db_BS");
                sc.Open();
                SqlCommand mm =new SqlCommand(sql, sc);
                mm.Parameters.Add("@pic", SqlDbType.Image);//执行语句参数类型
                mm.Parameters[0].Value = ca;//执行语句参数值（二进制文件）
                //打开连接，执行语句
                mm.ExecuteNonQuery();
                sc.Close();
                //讲处理过程中保存的图片删除
                File.Delete(SaveFile); 
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 清空该报告中所有图片
        /// <summary>
        /// PicView中点击清空按钮所调用的函数
        /// </summary>
        /// <param name="ide">实验编号</param>
        /// <param name="ids">学生学号</param>
        /// <returns></returns>
        public bool deletepic(string ide, string ids)//删除某份实验报告所有图片
        {
            string sql = "DELETE from [tb_Picture] WHERE [IDE] ='" + ide + "' and [IDS] = '" + ids +"'";//查询此实验报告信息
            SqlDataReader temDR=MyDataClass.getcom(sql);
            if (temDR.Read())
                return true;
            else
                return false;
        }
        #endregion

        #region 删除当前所选择的图片
        /// <summary>
        /// PicView中单击删除所调用的函数
        /// </summary>
        /// <param name="ide">实验编号</param>
        /// <param name="ids">学生学号</param>
        /// <param name="a">图片在listview中的索引,即表中单个实验报告的第几张图</param>
        /// <returns></returns>
        public bool DeleteOnepic(string ide, string ids,int a)//删除某份实验报告所有图片
        {
            string sql = "DELETE from [tb_Picture] WHERE [IDE] ='" + ide + "' and [IDS] = '" + ids + "' and IDP =" + a + "";//删除指定的图片
            try
            {
                MyDataClass.getsqlcom(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region 删除操作后更新列表中其余图片的IDP
        /// <summary>
        /// 删除操作后更新列表中其余图片的IDP
        /// </summary>
        /// <param name="ide">实验编号</param>
        /// <param name="ids">学生编号</param>
        /// <param name="a">图片在listview中原来的索引,即表中单个实验报告的第几张图</param>
        /// /// <param name="b">图片在listview中现在的索引,即表中单个实验报告的第几张图</param>
        public void UpdatePicID(string ide, string ids, int a,int b)
        {
            string sql = "update [tb_Picture] set IDP =" + b + " WHERE [IDE] ='" + ide + "' and [IDS] = '" + ids + "'and IDP =" + a + "";//查询此实验报告信息
            try
            {
                MyDataClass.getsqlcom(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 从数据库返回所有该实验报告中的图片
        public List<Image> reImage(string ide, string ids)//返回图片
        {
            List<Image> pic = new List<Image>();//存放大图
            string sql = "SELECT [Picture] from [tb_Picture] WHERE [IDE] ='" + ide + "' and [IDS] = '" + ids +"'";//查询此实验报告信息
            /*SqlConnection sc = new SqlConnection("Trusted_Connection=SSPI;Database=db_BS");
            sc.Open();
            SqlCommand cmd = new SqlCommand(sql, sc); //执行语句*/
            SqlDataReader dr = MyDataClass.getcom(sql);
            //if (Convert.DBNull != dr)
                while (dr.Read())
                {
                    byte[] mybyte = ((byte[])dr["Picture"]);
                    //创建内存流。
                    MemoryStream myStream = new MemoryStream();
                    //图片二进制，写入内存
                    foreach (byte a in mybyte)
                    {
                        myStream.WriteByte(a);
                    }
                    //以内存数据流，创建图片对象。
                    Image myImage = Image.FromStream(myStream);
                    myStream.Close();
                    pic.Add(myImage);
                }
                MyDataClass.con_close();// sc.Close();
            return pic;

            /*byte[] b= (byte[])cmd.ExecuteScalar();
            if (b.Length>0)
            {
               MemoryStream stream = new MemoryStream(b, true);
               stream.Write(b, 0, b.Length);
               Image a= new Bitmap(stream);
               return a;
               stream.Close();
            }
            else
                return null;
            conn.Close();
            if (Convert.DBNull != cmd.ExecuteScalar())
                return Image.FromStream(new MemoryStream((Byte[])cmd.ExecuteScalar()));
            else
                return null;
            conn.Close();*/
        }
        #endregion
    }
}
