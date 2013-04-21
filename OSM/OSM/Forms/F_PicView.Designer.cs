namespace OSM.Forms
{
    partial class F_PicView
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
            this.Pic_listView = new System.Windows.Forms.ListView();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pic_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_listView
            // 
            this.Pic_listView.Location = new System.Drawing.Point(626, 13);
            this.Pic_listView.Name = "Pic_listView";
            this.Pic_listView.Size = new System.Drawing.Size(114, 523);
            this.Pic_listView.TabIndex = 0;
            this.Pic_listView.UseCompatibleStateImageBehavior = false;
            this.Pic_listView.View = System.Windows.Forms.View.List;
            this.Pic_listView.SelectedIndexChanged += new System.EventHandler(this.Pic_listView_SelectedIndexChanged);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(649, 543);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 25);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "插入";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(649, 574);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 25);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "删除";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(649, 606);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 25);
            this.butClear.TabIndex = 3;
            this.butClear.Text = "清空";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pic_pictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 655);
            this.panel1.TabIndex = 4;
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(649, 637);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 25);
            this.butClose.TabIndex = 5;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pic_pictureBox
            // 
            this.pic_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pic_pictureBox.Name = "pic_pictureBox";
            this.pic_pictureBox.Size = new System.Drawing.Size(608, 605);
            this.pic_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_pictureBox.TabIndex = 0;
            this.pic_pictureBox.TabStop = false;
            this.pic_pictureBox.Click += new System.EventHandler(this.pic_pictureBox_Click);
            // 
            // F_PicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 722);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.Pic_listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_PicView";
            this.Text = "F_PicView";
            this.Load += new System.EventHandler(this.F_PicView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Pic_listView;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pic_pictureBox;
    }
}