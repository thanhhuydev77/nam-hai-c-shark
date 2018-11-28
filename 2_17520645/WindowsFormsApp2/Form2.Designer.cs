namespace WindowsFormsApp2
{
    partial class result_form
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbbest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbdetail = new System.Windows.Forms.Label();
            this.lblevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btout = new System.Windows.Forms.Button();
            this.btplay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.ForeColor = System.Drawing.Color.Aqua;
            this.progressBar1.Location = new System.Drawing.Point(187, 307);
            this.progressBar1.MarqueeAnimationSpeed = 28;
            this.progressBar1.Maximum = 28;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(439, 38);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // lbbest
            // 
            this.lbbest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbbest.BackColor = System.Drawing.Color.Transparent;
            this.lbbest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbbest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbest.ForeColor = System.Drawing.Color.Black;
            this.lbbest.Location = new System.Drawing.Point(100, 277);
            this.lbbest.Name = "lbbest";
            this.lbbest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbbest.Size = new System.Drawing.Size(239, 28);
            this.lbbest.TabIndex = 5;
            this.lbbest.Text = "Kết quả tốt nhất ";
            this.lbbest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbdetail);
            this.panel1.Controls.Add(this.lblevel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(218, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 145);
            this.panel1.TabIndex = 7;
            // 
            // lbdetail
            // 
            this.lbdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdetail.Location = new System.Drawing.Point(3, 40);
            this.lbdetail.Name = "lbdetail";
            this.lbdetail.Size = new System.Drawing.Size(376, 101);
            this.lbdetail.TabIndex = 1;
            this.lbdetail.Text = "label4";
            // 
            // lblevel
            // 
            this.lblevel.AutoSize = true;
            this.lblevel.Location = new System.Drawing.Point(134, 0);
            this.lblevel.Name = "lblevel";
            this.lblevel.Size = new System.Drawing.Size(124, 42);
            this.lblevel.TabIndex = 0;
            this.lblevel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(187, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btout
            // 
            this.btout.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btout.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._44_512;
            this.btout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btout.FlatAppearance.BorderSize = 0;
            this.btout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btout.Location = new System.Drawing.Point(683, 1);
            this.btout.Name = "btout";
            this.btout.Size = new System.Drawing.Size(59, 50);
            this.btout.TabIndex = 4;
            this.btout.UseVisualStyleBackColor = false;
            this.btout.Click += new System.EventHandler(this.btout_Click);
            // 
            // btplay
            // 
            this.btplay.BackColor = System.Drawing.Color.RoyalBlue;
            this.btplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btplay.FlatAppearance.BorderSize = 0;
            this.btplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btplay.ForeColor = System.Drawing.Color.White;
            this.btplay.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btplay.Location = new System.Drawing.Point(218, 65);
            this.btplay.Name = "btplay";
            this.btplay.Size = new System.Drawing.Size(386, 58);
            this.btplay.TabIndex = 1;
            this.btplay.Text = "chơi lại";
            this.btplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btplay.UseVisualStyleBackColor = false;
            this.btplay.Click += new System.EventHandler(this.btplay_Click);
            // 
            // result_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(743, 480);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbbest);
            this.Controls.Add(this.btout);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.Name = "result_form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btplay;
        private System.Windows.Forms.Button btout;
        private System.Windows.Forms.Label lbbest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbdetail;
        private System.Windows.Forms.Label lblevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}