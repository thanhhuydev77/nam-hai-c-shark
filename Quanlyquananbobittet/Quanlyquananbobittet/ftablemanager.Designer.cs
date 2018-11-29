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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cbfoodcategory = new System.Windows.Forms.ComboBox();
            this.Cbfood = new System.Windows.Forms.ComboBox();
            this.Btaddfood = new System.Windows.Forms.Button();
            this.Nmfoodcount = new System.Windows.Forms.NumericUpDown();
            this.Btcheckout = new System.Windows.Forms.Button();
            this.Btdiscount = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nmfoodcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(417, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 266);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.Btdiscount);
            this.panel4.Controls.Add(this.Btcheckout);
            this.panel4.Location = new System.Drawing.Point(417, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 72);
            this.panel4.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(399, 411);
            this.flowLayoutPanel1.TabIndex = 5;
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
            // Cbfoodcategory
            // 
            this.Cbfoodcategory.FormattingEnabled = true;
            this.Cbfoodcategory.Location = new System.Drawing.Point(16, 14);
            this.Cbfoodcategory.Name = "Cbfoodcategory";
            this.Cbfoodcategory.Size = new System.Drawing.Size(206, 21);
            this.Cbfoodcategory.TabIndex = 0;
            // 
            // Cbfood
            // 
            this.Cbfood.FormattingEnabled = true;
            this.Cbfood.Location = new System.Drawing.Point(16, 41);
            this.Cbfood.Name = "Cbfood";
            this.Cbfood.Size = new System.Drawing.Size(206, 21);
            this.Cbfood.TabIndex = 1;
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
            // Btcheckout
            // 
            this.Btcheckout.Location = new System.Drawing.Point(293, 3);
            this.Btcheckout.Name = "Btcheckout";
            this.Btcheckout.Size = new System.Drawing.Size(75, 65);
            this.Btcheckout.TabIndex = 4;
            this.Btcheckout.Text = "Thanh toán";
            this.Btcheckout.UseVisualStyleBackColor = true;
            // 
            // Btdiscount
            // 
            this.Btdiscount.Location = new System.Drawing.Point(205, 3);
            this.Btdiscount.Name = "Btdiscount";
            this.Btdiscount.Size = new System.Drawing.Size(82, 32);
            this.Btdiscount.TabIndex = 5;
            this.Btdiscount.Text = "Giảm giá";
            this.Btdiscount.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(205, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // ftablemanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ftablemanager";
            this.Text = "Phần mềm quản lý ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nmfoodcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Nmfoodcount;
        private System.Windows.Forms.Button Btaddfood;
        private System.Windows.Forms.ComboBox Cbfood;
        private System.Windows.Forms.ComboBox Cbfoodcategory;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Btdiscount;
        private System.Windows.Forms.Button Btcheckout;
    }
}