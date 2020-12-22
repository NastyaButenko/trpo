namespace Laba3_2
{
    partial class ConstructForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstructForm));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("", 6);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("", 7);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("", 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("", 7);
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgListFlat = new System.Windows.Forms.ImageList(this.components);
            this.listView2 = new System.Windows.Forms.ListView();
            this.imgListDecor = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.Silver;
            this.pnlBorder.Controls.Add(this.lblTitle);
            this.pnlBorder.Controls.Add(this.imgLogo);
            this.pnlBorder.Controls.Add(this.btnMinimize);
            this.pnlBorder.Controls.Add(this.btnClose);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(600, 30);
            this.pnlBorder.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(30, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(510, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Конструктор";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(30, 30);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Location = new System.Drawing.Point(540, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(570, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Plum;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 370);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Просмотр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(317, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Плитка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(317, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Декор:";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(34, 40);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(246, 253);
            this.panel1.TabIndex = 3;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // imgListFlat
            // 
            this.imgListFlat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListFlat.ImageStream")));
            this.imgListFlat.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListFlat.Images.SetKeyName(0, "510x510resize_product18677_26_1356318184.jpg");
            this.imgListFlat.Images.SetKeyName(1, "510x510resize_product19064_6_1356342222.jpg");
            this.imgListFlat.Images.SetKeyName(2, "510x510resize_product19360_41_1356410884.jpg");
            this.imgListFlat.Images.SetKeyName(3, "510x510resize_product19400_39_1356412875.jpg");
            this.imgListFlat.Images.SetKeyName(4, "510x510resize_product19905_39_1356491005.jpg");
            this.imgListFlat.Images.SetKeyName(5, "510x510resize_product20687_32_1356682995.jpg");
            this.imgListFlat.Images.SetKeyName(6, "510x510resize_product94442_43_1369728249.jpg");
            this.imgListFlat.Images.SetKeyName(7, "510x510resize_product94443_57_1369728296.jpg");
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.listView2.LargeImageList = this.imgListDecor;
            this.listView2.Location = new System.Drawing.Point(317, 188);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(246, 105);
            this.listView2.SmallImageList = this.imgListFlat;
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDown);
            // 
            // imgListDecor
            // 
            this.imgListDecor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDecor.ImageStream")));
            this.imgListDecor.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDecor.Images.SetKeyName(0, "510x510resize_product15955_74_1355886433.jpg");
            this.imgListDecor.Images.SetKeyName(1, "510x510resize_product16101_95_1355889740.jpg");
            this.imgListDecor.Images.SetKeyName(2, "510x510resize_product16121_57_1355889907.jpg");
            this.imgListDecor.Images.SetKeyName(3, "510x510resize_product16122_47_1355889931.jpg");
            this.imgListDecor.Images.SetKeyName(4, "510x510resize_product16153_50_1355890644.jpg");
            this.imgListDecor.Images.SetKeyName(5, "510x510resize_product16164_31_1355890748.jpg");
            this.imgListDecor.Images.SetKeyName(6, "510x510resize_product16188_79_1355891226.jpg");
            this.imgListDecor.Images.SetKeyName(7, "510x510resize_product16241_8_1355891889.jpg");
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(317, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.LargeImageList = this.imgListFlat;
            this.listView1.Location = new System.Drawing.Point(317, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 105);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // ConstructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlBorder);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ConstructForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ImageList imgListFlat;
        private System.Windows.Forms.ImageList imgListDecor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}

