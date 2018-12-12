namespace Quanlyquananbobittet
{
    partial class ftablemanager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnbill = new System.Windows.Forms.Panel();
            this.Lvbill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Btdiscount = new System.Windows.Forms.Button();
            this.Btcheckout = new System.Windows.Forms.Button();
            this.Fpntable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nmfoodcount = new System.Windows.Forms.NumericUpDown();
            this.Btaddfood = new System.Windows.Forms.Button();
            this.Cbfood = new System.Windows.Forms.ComboBox();
            this.Cbfoodcategory = new System.Windows.Forms.ComboBox();
            this.Tbtotalprice = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.Pnbill.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nmfoodcount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // Pnbill
            // 
            this.Pnbill.Controls.Add(this.Lvbill);
            this.Pnbill.Location = new System.Drawing.Point(417, 98);
            this.Pnbill.Name = "Pnbill";
            this.Pnbill.Size = new System.Drawing.Size(371, 266);
            this.Pnbill.TabIndex = 3;
            // 
            // Lvbill
            // 
            this.Lvbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Lvbill.GridLines = true;
            this.Lvbill.Location = new System.Drawing.Point(4, 0);
            this.Lvbill.Name = "Lvbill";
            this.Lvbill.Size = new System.Drawing.Size(367, 263);
            this.Lvbill.TabIndex = 0;
            this.Lvbill.UseCompatibleStateImageBehavior = false;
            this.Lvbill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 90;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Tbtotalprice);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.Btdiscount);
            this.panel4.Controls.Add(this.Btcheckout);
            this.panel4.Location = new System.Drawing.Point(417, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 72);
            this.panel4.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(0, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Btdiscount
            // 
            this.Btdiscount.Location = new System.Drawing.Point(0, 3);
            this.Btdiscount.Name = "Btdiscount";
            this.Btdiscount.Size = new System.Drawing.Size(82, 32);
            this.Btdiscount.TabIndex = 5;
            this.Btdiscount.Text = "Giảm giá";
            this.Btdiscount.UseVisualStyleBackColor = true;
            // 
            // Btcheckout
            // 
            this.Btcheckout.Location = new System.Drawing.Point(293, 3);
            this.Btcheckout.Name = "Btcheckout";
            this.Btcheckout.Size = new System.Drawing.Size(75, 65);
            this.Btcheckout.TabIndex = 4;
            this.Btcheckout.Text = "Thanh toán";
            this.Btcheckout.UseVisualStyleBackColor = true;
            // 
            // Fpntable
            // 
            this.Fpntable.AutoScroll = true;
            this.Fpntable.Location = new System.Drawing.Point(12, 31);
            this.Fpntable.Name = "Fpntable";
            this.Fpntable.Size = new System.Drawing.Size(399, 411);
            this.Fpntable.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Nmfoodcount);
            this.panel1.Controls.Add(this.Btaddfood);
            this.panel1.Controls.Add(this.Cbfood);
            this.panel1.Controls.Add(this.Cbfoodcategory);
            this.panel1.Location = new System.Drawing.Point(417, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 65);
            this.panel1.TabIndex = 5;
            // 
            // Nmfoodcount
            // 
            this.Nmfoodcount.Location = new System.Drawing.Point(309, 30);
            this.Nmfoodcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Nmfoodcount.Name = "Nmfoodcount";
            this.Nmfoodcount.Size = new System.Drawing.Size(58, 20);
            this.Nmfoodcount.TabIndex = 3;
            // 
            // Btaddfood
            // 
            this.Btaddfood.Location = new System.Drawing.Point(228, 14);
            this.Btaddfood.Name = "Btaddfood";
            this.Btaddfood.Size = new System.Drawing.Size(75, 48);
            this.Btaddfood.TabIndex = 2;
            this.Btaddfood.Text = "Thêm món";
            this.Btaddfood.UseVisualStyleBackColor = true;
            // 
            // Cbfood
            // 
            this.Cbfood.FormattingEnabled = true;
            this.Cbfood.Location = new System.Drawing.Point(16, 41);
            this.Cbfood.Name = "Cbfood";
            this.Cbfood.Size = new System.Drawing.Size(206, 21);
            this.Cbfood.TabIndex = 1;
            // 
            // Cbfoodcategory
            // 
            this.Cbfoodcategory.FormattingEnabled = true;
            this.Cbfoodcategory.Location = new System.Drawing.Point(16, 14);
            this.Cbfoodcategory.Name = "Cbfoodcategory";
            this.Cbfoodcategory.Size = new System.Drawing.Size(206, 21);
            this.Cbfoodcategory.TabIndex = 0;
            // 
            // Tbtotalprice
            // 
            this.Tbtotalprice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbtotalprice.Location = new System.Drawing.Point(89, 27);
            this.Tbtotalprice.Name = "Tbtotalprice";
            this.Tbtotalprice.Size = new System.Drawing.Size(198, 26);
            this.Tbtotalprice.TabIndex = 6;
            this.Tbtotalprice.Text = "0";
            this.Tbtotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ftablemanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fpntable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Pnbill);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ftablemanager";
            this.Text = "Phần mềm quản lý ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pnbill.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nmfoodcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel Pnbill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel Fpntable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Nmfoodcount;
        private System.Windows.Forms.Button Btaddfood;
        private System.Windows.Forms.ComboBox Cbfood;
        private System.Windows.Forms.ComboBox Cbfoodcategory;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Btdiscount;
        private System.Windows.Forms.Button Btcheckout;
        private System.Windows.Forms.ListView Lvbill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox Tbtotalprice;
    }
}