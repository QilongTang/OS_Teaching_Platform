namespace OSM.Forms
{
    partial class F_InfoS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Info_teacher = new System.Windows.Forms.ComboBox();
            this.tbTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_BSDataSet = new OSM.db_BSDataSet();
            this.Info_class = new System.Windows.Forms.ComboBox();
            this.tbClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Info_sex = new System.Windows.Forms.ComboBox();
            this.Info_ID = new System.Windows.Forms.TextBox();
            this.Info_Email = new System.Windows.Forms.TextBox();
            this.Info_assignment = new System.Windows.Forms.TextBox();
            this.Info_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butConfirm = new System.Windows.Forms.Button();
            this.butAmend = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.tb_ClassTableAdapter = new OSM.db_BSDataSetTableAdapters.tb_ClassTableAdapter();
            this.tb_TeacherTableAdapter = new OSM.db_BSDataSetTableAdapters.tb_TeacherTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Info_teacher);
            this.groupBox1.Controls.Add(this.Info_class);
            this.groupBox1.Controls.Add(this.Info_sex);
            this.groupBox1.Controls.Add(this.Info_ID);
            this.groupBox1.Controls.Add(this.Info_Email);
            this.groupBox1.Controls.Add(this.Info_assignment);
            this.groupBox1.Controls.Add(this.Info_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(134, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通讯录信息";
            // 
            // Info_teacher
            // 
            this.Info_teacher.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbTeacherBindingSource, "IDT", true));
            this.Info_teacher.DataSource = this.tbTeacherBindingSource;
            this.Info_teacher.DisplayMember = "name";
            this.Info_teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Info_teacher.FormattingEnabled = true;
            this.Info_teacher.Location = new System.Drawing.Point(306, 57);
            this.Info_teacher.Name = "Info_teacher";
            this.Info_teacher.Size = new System.Drawing.Size(152, 20);
            this.Info_teacher.TabIndex = 15;
            this.Info_teacher.ValueMember = "IDT";
            // 
            // tbTeacherBindingSource
            // 
            this.tbTeacherBindingSource.DataMember = "tb_Teacher";
            this.tbTeacherBindingSource.DataSource = this.db_BSDataSet;
            // 
            // db_BSDataSet
            // 
            this.db_BSDataSet.DataSetName = "db_BSDataSet";
            this.db_BSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Info_class
            // 
            this.Info_class.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbClassBindingSource, "ID", true));
            this.Info_class.DataSource = this.tbClassBindingSource;
            this.Info_class.DisplayMember = "name";
            this.Info_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Info_class.FormattingEnabled = true;
            this.Info_class.Location = new System.Drawing.Point(57, 57);
            this.Info_class.Name = "Info_class";
            this.Info_class.Size = new System.Drawing.Size(185, 20);
            this.Info_class.TabIndex = 14;
            this.Info_class.ValueMember = "ID";
            // 
            // tbClassBindingSource
            // 
            this.tbClassBindingSource.DataMember = "tb_Class";
            this.tbClassBindingSource.DataSource = this.db_BSDataSet;
            // 
            // Info_sex
            // 
            this.Info_sex.FormattingEnabled = true;
            this.Info_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Info_sex.Location = new System.Drawing.Point(196, 25);
            this.Info_sex.Name = "Info_sex";
            this.Info_sex.Size = new System.Drawing.Size(46, 20);
            this.Info_sex.TabIndex = 13;
            // 
            // Info_ID
            // 
            this.Info_ID.Location = new System.Drawing.Point(306, 25);
            this.Info_ID.Name = "Info_ID";
            this.Info_ID.Size = new System.Drawing.Size(152, 21);
            this.Info_ID.TabIndex = 12;
            // 
            // Info_Email
            // 
            this.Info_Email.Location = new System.Drawing.Point(306, 89);
            this.Info_Email.Name = "Info_Email";
            this.Info_Email.Size = new System.Drawing.Size(152, 21);
            this.Info_Email.TabIndex = 10;
            // 
            // Info_assignment
            // 
            this.Info_assignment.Location = new System.Drawing.Point(57, 89);
            this.Info_assignment.Name = "Info_assignment";
            this.Info_assignment.Size = new System.Drawing.Size(185, 21);
            this.Info_assignment.TabIndex = 9;
            // 
            // Info_name
            // 
            this.Info_name.Location = new System.Drawing.Point(57, 25);
            this.Info_name.Name = "Info_name";
            this.Info_name.Size = new System.Drawing.Size(79, 21);
            this.Info_name.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "教师:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "学号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "作业:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "班级:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butConfirm);
            this.groupBox2.Controls.Add(this.butAmend);
            this.groupBox2.Controls.Add(this.butClose);
            this.groupBox2.Controls.Add(this.butCancel);
            this.groupBox2.Location = new System.Drawing.Point(134, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(135, 19);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 4;
            this.butConfirm.Text = "确认";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // butAmend
            // 
            this.butAmend.Location = new System.Drawing.Point(23, 20);
            this.butAmend.Name = "butAmend";
            this.butAmend.Size = new System.Drawing.Size(75, 23);
            this.butAmend.TabIndex = 2;
            this.butAmend.Text = "修改";
            this.butAmend.UseVisualStyleBackColor = true;
            this.butAmend.Click += new System.EventHandler(this.butAmend_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(373, 19);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "关闭";
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(255, 19);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // tb_ClassTableAdapter
            // 
            this.tb_ClassTableAdapter.ClearBeforeFill = true;
            // 
            // tb_TeacherTableAdapter
            // 
            this.tb_TeacherTableAdapter.ClearBeforeFill = true;
            // 
            // F_InfoS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_InfoS";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.F_InfoS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Info_sex;
        private System.Windows.Forms.TextBox Info_ID;
        private System.Windows.Forms.TextBox Info_Email;
        private System.Windows.Forms.TextBox Info_assignment;
        private System.Windows.Forms.TextBox Info_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butAmend;
        private System.Windows.Forms.Button butConfirm;
        private System.Windows.Forms.ComboBox Info_class;
        private db_BSDataSet db_BSDataSet;
        private System.Windows.Forms.BindingSource tbClassBindingSource;
        private db_BSDataSetTableAdapters.tb_ClassTableAdapter tb_ClassTableAdapter;
        private System.Windows.Forms.ComboBox Info_teacher;
        private System.Windows.Forms.BindingSource tbTeacherBindingSource;
        private db_BSDataSetTableAdapters.tb_TeacherTableAdapter tb_TeacherTableAdapter;
    }
}