namespace WindowsFormsApp2
{
    partial class play_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(play_form));
            this.pn1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbthoigian = new System.Windows.Forms.Label();
            this.lbloi = new System.Windows.Forms.Label();
            this.lbdiem = new System.Windows.Forms.Label();
            this.tbloi = new System.Windows.Forms.TextBox();
            this.tbdiem = new System.Windows.Forms.TextBox();
            this.fpn1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lbdiemcao = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonVie = new System.Windows.Forms.Button();
            this.buttonEng = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pn1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.White;
            this.pn1.Controls.Add(this.label3);
            this.pn1.Controls.Add(this.lbthoigian);
            this.pn1.Controls.Add(this.pictureBox1);
            this.pn1.Controls.Add(this.lbloi);
            this.pn1.Controls.Add(this.lbdiem);
            this.pn1.Controls.Add(this.tbloi);
            this.pn1.Controls.Add(this.tbdiem);
            this.pn1.Controls.Add(this.fpn1);
            this.pn1.Location = new System.Drawing.Point(397, 83);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(548, 451);
            this.pn1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 96);
            this.label3.TabIndex = 7;
            this.label3.Text = " HỘP NÀO CÓ MÀU SẮC BẤT THƯỜNG?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbthoigian
            // 
            this.lbthoigian.BackColor = System.Drawing.Color.Turquoise;
            this.lbthoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthoigian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbthoigian.Location = new System.Drawing.Point(443, 44);
            this.lbthoigian.Name = "lbthoigian";
            this.lbthoigian.Size = new System.Drawing.Size(50, 37);
            this.lbthoigian.TabIndex = 6;
            this.lbthoigian.Text = "15";
            this.lbthoigian.TextChanged += new System.EventHandler(this.lbthoigian_TextChanged);
            this.lbthoigian.Click += new System.EventHandler(this.lbthoigian_Click);
            // 
            // lbloi
            // 
            this.lbloi.AutoSize = true;
            this.lbloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloi.Location = new System.Drawing.Point(353, 261);
            this.lbloi.Name = "lbloi";
            this.lbloi.Size = new System.Drawing.Size(37, 25);
            this.lbloi.TabIndex = 4;
            this.lbloi.Text = "lỗi";
            // 
            // lbdiem
            // 
            this.lbdiem.AutoSize = true;
            this.lbdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiem.Location = new System.Drawing.Point(344, 168);
            this.lbdiem.Name = "lbdiem";
            this.lbdiem.Size = new System.Drawing.Size(62, 25);
            this.lbdiem.TabIndex = 3;
            this.lbdiem.Text = "điểm";
            // 
            // tbloi
            // 
            this.tbloi.BackColor = System.Drawing.Color.Red;
            this.tbloi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbloi.Enabled = false;
            this.tbloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbloi.ForeColor = System.Drawing.Color.White;
            this.tbloi.Location = new System.Drawing.Point(330, 295);
            this.tbloi.Name = "tbloi";
            this.tbloi.Size = new System.Drawing.Size(100, 24);
            this.tbloi.TabIndex = 2;
            this.tbloi.Text = "0";
            this.tbloi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbdiem
            // 
            this.tbdiem.BackColor = System.Drawing.Color.Lime;
            this.tbdiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbdiem.Enabled = false;
            this.tbdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdiem.ForeColor = System.Drawing.Color.White;
            this.tbdiem.Location = new System.Drawing.Point(330, 199);
            this.tbdiem.Name = "tbdiem";
            this.tbdiem.Size = new System.Drawing.Size(100, 24);
            this.tbdiem.TabIndex = 1;
            this.tbdiem.Text = "0";
            this.tbdiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fpn1
            // 
            this.fpn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fpn1.Location = new System.Drawing.Point(23, 168);
            this.fpn1.Name = "fpn1";
            this.fpn1.Size = new System.Drawing.Size(260, 260);
            this.fpn1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 48);
            this.label5.TabIndex = 3;
            this.label5.Text = " kết quả tốt nhất của bạn là ";
            // 
            // lbdiemcao
            // 
            this.lbdiemcao.AutoSize = true;
            this.lbdiemcao.BackColor = System.Drawing.Color.White;
            this.lbdiemcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiemcao.Location = new System.Drawing.Point(366, 337);
            this.lbdiemcao.Name = "lbdiemcao";
            this.lbdiemcao.Size = new System.Drawing.Size(0, 24);
            this.lbdiemcao.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonVie);
            this.panel1.Controls.Add(this.buttonEng);
            this.panel1.Location = new System.Drawing.Point(109, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 61);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(7, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 68);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonVie
            // 
            this.buttonVie.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.vietnam;
            this.buttonVie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVie.FlatAppearance.BorderSize = 0;
            this.buttonVie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVie.Location = new System.Drawing.Point(122, 3);
            this.buttonVie.Name = "buttonVie";
            this.buttonVie.Size = new System.Drawing.Size(85, 49);
            this.buttonVie.TabIndex = 23;
            this.buttonVie.UseVisualStyleBackColor = true;
            this.buttonVie.Click += new System.EventHandler(this.buttonEng_Click);
            // 
            // buttonEng
            // 
            this.buttonEng.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.uk;
            this.buttonEng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEng.FlatAppearance.BorderSize = 0;
            this.buttonEng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEng.Location = new System.Drawing.Point(12, 3);
            this.buttonEng.Name = "buttonEng";
            this.buttonEng.Size = new System.Drawing.Size(85, 49);
            this.buttonEng.TabIndex = 22;
            this.buttonEng.UseVisualStyleBackColor = true;
            this.buttonEng.Click += new System.EventHandler(this.buttonVie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(436, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.eyetest;
            this.pictureBox2.Location = new System.Drawing.Point(15, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(399, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // play_form
            // 
            this.AccessibleName = "f1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 700);
            this.ControlBox = false;
            this.Controls.Add(this.lbdiemcao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "play_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.FlowLayoutPanel fpn1;
        private System.Windows.Forms.Label lbloi;
        private System.Windows.Forms.Label lbdiem;
        private System.Windows.Forms.TextBox tbloi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbthoigian;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbdiem;
        public System.Windows.Forms.Label lbdiemcao;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEng;
        private System.Windows.Forms.Button buttonVie;
    }
}

