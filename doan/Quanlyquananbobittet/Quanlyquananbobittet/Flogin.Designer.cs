namespace Quanlyquananbobittet
{
    partial class Flogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btexit = new System.Windows.Forms.Button();
            this.Btlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Tbpassword = new System.Windows.Forms.TextBox();
            this.Lbpassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tbusername = new System.Windows.Forms.TextBox();
            this.Lbusername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btexit);
            this.panel1.Controls.Add(this.Btlogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 176);
            this.panel1.TabIndex = 0;
            // 
            // Btexit
            // 
            this.Btexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btexit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btexit.Location = new System.Drawing.Point(481, 124);
            this.Btexit.Name = "Btexit";
            this.Btexit.Size = new System.Drawing.Size(75, 34);
            this.Btexit.TabIndex = 4;
            this.Btexit.Text = "Thoát";
            this.Btexit.UseVisualStyleBackColor = true;
            this.Btexit.Click += new System.EventHandler(this.Btexit_Click);
            // 
            // Btlogin
            // 
            this.Btlogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btlogin.Location = new System.Drawing.Point(348, 124);
            this.Btlogin.Name = "Btlogin";
            this.Btlogin.Size = new System.Drawing.Size(109, 34);
            this.Btlogin.TabIndex = 3;
            this.Btlogin.Text = "Đăng nhập";
            this.Btlogin.UseVisualStyleBackColor = true;
            this.Btlogin.Click += new System.EventHandler(this.Btlogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Tbpassword);
            this.panel3.Controls.Add(this.Lbpassword);
            this.panel3.Location = new System.Drawing.Point(3, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 44);
            this.panel3.TabIndex = 2;
            // 
            // Tbpassword
            // 
            this.Tbpassword.Location = new System.Drawing.Point(186, 16);
            this.Tbpassword.Name = "Tbpassword";
            this.Tbpassword.PasswordChar = '*';
            this.Tbpassword.Size = new System.Drawing.Size(344, 20);
            this.Tbpassword.TabIndex = 1;
            this.Tbpassword.Text = "123";
            this.Tbpassword.UseSystemPasswordChar = true;
            // 
            // Lbpassword
            // 
            this.Lbpassword.AutoSize = true;
            this.Lbpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbpassword.Location = new System.Drawing.Point(24, 16);
            this.Lbpassword.Name = "Lbpassword";
            this.Lbpassword.Size = new System.Drawing.Size(78, 19);
            this.Lbpassword.TabIndex = 0;
            this.Lbpassword.Text = "Mật khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Tbusername);
            this.panel2.Controls.Add(this.Lbusername);
            this.panel2.Location = new System.Drawing.Point(3, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 44);
            this.panel2.TabIndex = 0;
            // 
            // Tbusername
            // 
            this.Tbusername.Location = new System.Drawing.Point(186, 16);
            this.Tbusername.Name = "Tbusername";
            this.Tbusername.Size = new System.Drawing.Size(344, 20);
            this.Tbusername.TabIndex = 0;
            this.Tbusername.Text = "huy";
            // 
            // Lbusername
            // 
            this.Lbusername.AutoSize = true;
            this.Lbusername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbusername.Location = new System.Drawing.Point(24, 16);
            this.Lbusername.Name = "Lbusername";
            this.Lbusername.Size = new System.Drawing.Size(124, 19);
            this.Lbusername.TabIndex = 0;
            this.Lbusername.Text = "Tên đăng nhập";
            // 
            // Flogin
            // 
            this.AcceptButton = this.Btlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btexit;
            this.ClientSize = new System.Drawing.Size(599, 197);
            this.Controls.Add(this.panel1);
            this.Name = "Flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Flogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Tbpassword;
        private System.Windows.Forms.Label Lbpassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Tbusername;
        private System.Windows.Forms.Label Lbusername;
        private System.Windows.Forms.Button Btexit;
        private System.Windows.Forms.Button Btlogin;
    }
}

