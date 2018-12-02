namespace Quanlyquananbobittet
{
    partial class Fadmin
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
            this.Tbill = new System.Windows.Forms.TabControl();
            this.Tcomein = new System.Windows.Forms.TabPage();
            this.Tfood = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tptable = new System.Windows.Forms.TabPage();
            this.Tpaccount = new System.Windows.Forms.TabPage();
            this.Tbill.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbill
            // 
            this.Tbill.Controls.Add(this.Tcomein);
            this.Tbill.Controls.Add(this.Tfood);
            this.Tbill.Controls.Add(this.tabPage1);
            this.Tbill.Controls.Add(this.Tptable);
            this.Tbill.Controls.Add(this.Tpaccount);
            this.Tbill.Location = new System.Drawing.Point(3, 1);
            this.Tbill.Name = "Tbill";
            this.Tbill.SelectedIndex = 0;
            this.Tbill.Size = new System.Drawing.Size(703, 478);
            this.Tbill.TabIndex = 0;
            // 
            // Tcomein
            // 
            this.Tcomein.Location = new System.Drawing.Point(4, 22);
            this.Tcomein.Name = "Tcomein";
            this.Tcomein.Padding = new System.Windows.Forms.Padding(3);
            this.Tcomein.Size = new System.Drawing.Size(695, 452);
            this.Tcomein.TabIndex = 0;
            this.Tcomein.Text = "Doanh thu";
            this.Tcomein.UseVisualStyleBackColor = true;
            // 
            // Tfood
            // 
            this.Tfood.Location = new System.Drawing.Point(4, 22);
            this.Tfood.Name = "Tfood";
            this.Tfood.Padding = new System.Windows.Forms.Padding(3);
            this.Tfood.Size = new System.Drawing.Size(695, 452);
            this.Tfood.TabIndex = 1;
            this.Tfood.Text = "Thức ăn";
            this.Tfood.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 452);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Danh mục";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Tptable
            // 
            this.Tptable.Location = new System.Drawing.Point(4, 22);
            this.Tptable.Name = "Tptable";
            this.Tptable.Padding = new System.Windows.Forms.Padding(3);
            this.Tptable.Size = new System.Drawing.Size(695, 452);
            this.Tptable.TabIndex = 3;
            this.Tptable.Text = "Bàn ăn";
            this.Tptable.UseVisualStyleBackColor = true;
            // 
            // Tpaccount
            // 
            this.Tpaccount.Location = new System.Drawing.Point(4, 22);
            this.Tpaccount.Name = "Tpaccount";
            this.Tpaccount.Padding = new System.Windows.Forms.Padding(3);
            this.Tpaccount.Size = new System.Drawing.Size(695, 452);
            this.Tpaccount.TabIndex = 4;
            this.Tpaccount.Text = "Tài khoản";
            this.Tpaccount.UseVisualStyleBackColor = true;
            // 
            // Fadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 480);
            this.Controls.Add(this.Tbill);
            this.Name = "Fadmin";
            this.Text = "Fadmin";
            this.Tbill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbill;
        private System.Windows.Forms.TabPage Tcomein;
        private System.Windows.Forms.TabPage Tfood;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Tptable;
        private System.Windows.Forms.TabPage Tpaccount;
    }
}