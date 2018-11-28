using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp2
{
    public partial class play_form : Form
    {
        SoundPlayer tick = new SoundPlayer(Application.StartupPath + "//Resources//tick.wav"); // khởi tạo âm thanh tick
        public int maxoldpoint = 0; // tạo biến lưu điểm cao nhất
        int t, m;  // biến phụ so sánh hai điểm cao nhất
       public  int lang;    // chỉ số ngôn ngữ
        void loadlang()
        {
            switch(lang)
            {
                
                case 1:
                    label3.Text = "WHICH ONE OF THE BOXES HAS AN IRREGULAR COLOR?? ";
                    lbdiem.Text = "SCORE";
                    lbloi.Text = "ERRORS";
                    label5.Text = "Your best result is ";
                    break;
                case 2:
                    label3.Text = "HỘP NÀO CÓ MÀU SẮC BẤT THƯỜNG ? ";
                    lbdiem.Text = "ĐIỂM";
                    lbloi.Text = "LỖI";
                    label5.Text = "Kết quả tốt nhất của bạn là";
                    break;
                default:
                    label3.Text = "HỘP NÀO CÓ MÀU SẮC BẤT THƯỜNG ? ";
                    lbdiem.Text = "ĐIỂM";
                    lbloi.Text = "LỖI";
                    label5.Text = "Kết quả tốt nhất của bạn là";
                    break;

            }
        } // theo chỉ số ngôn ngữ --> chỉnh ngôn ngữ cái control
#region abc
        public void loadform1()
        {
            tbloi.Text = "0";  //khoi tạo lỗi = 0   
            lbdiemcao.Text = maxoldpoint + ""; // lấy điểm cao nhất từ lần trước

            Loadfpn1(Convert.ToInt16(tbdiem.Text) + 1);    // chay số ô vuông trong lần chơi tương ứng
        }
        public void Loadfpn1(int m)   // 
        {
            if (m > 1)         
            {
                                
                lbthoigian.Text = "15";     //khởi tạo thoi gian = 15 giay
                timer1.Start();     //bắt đầu tính giờ
                Random r = new Random();
                int colo = r.Next(1, 250);  // tao chi so mau ngau nhien    
                int colo1 = r.Next(60, 255 - 30);          // tao chi so mau ngau nhien
                int colo2 = r.Next(1, 250);             //tạo chi so mau ngau nhien
                int a = r.Next(0, (m + 1) * (m + 1));       // lấy vị trí ô màu khác ngẫu nhiên
                for (int i = 0; i < (m + 1) * (m + 1); i++)     // lặp tạo ô và màu
                {

                    Button bt = new Button();                   //tạo button moi    
                   // bt.MouseHover += new EventHandler(bt_mousehover);
                    bt.FlatStyle = FlatStyle.Flat;              //chỉnh kiểu viền   
                    bt.FlatAppearance.BorderSize = 0;           // thu hẹp viền = 0 
                    bt.Name = "bt" + i;                         //tạo tên button theo chi so
                    //bt.Text = "bt " + i;
                    bt.Tag = i;          //tao thu tu button trong flow layout pannel
                    
                    bt.Size = new System.Drawing.Size(fpn1.Size.Height / (m + 1) - 6, fpn1.Size.Width / (m + 1) - 6); // tạo size cho button
                    fpn1.Controls.Add(bt);   //them vao flow layout panel
                    if ((int)bt.Tag != a)     // so sánh lấy button tương ứng với a -->tạo màu khác và sự kiện click khác
                    {
                        bt.BackColor = Color.FromArgb(colo, colo1, colo2);
                        bt.Click += new EventHandler(btsai_click);
                        
                    }
                    else
                    {
                        bt.BackColor = Color.FromArgb(colo, colo1 + 28 - Convert.ToInt16(lbthoigian.Text), colo2);
                        bt.Click += new EventHandler(btdung_click);
                        
                    }
                    bt.FlatAppearance.MouseOverBackColor = bt.BackColor;
                    bt.FlatAppearance.MouseDownBackColor = bt.BackColor;
                }
            }
            else   // truong hop choi lan dau ---> chon sai không được nhận
            {
                lbthoigian.Text = "15";  // khoi tao thoi gian ban dau = 15 giay
                Random r = new Random();    
                int colo = r.Next(1, 250);
                int colo1 = r.Next(60, 255 - 30);
                int colo2 = r.Next(1, 250);
                int a = r.Next(0, (m + 1) * (m + 1));      // nhu phia tren 
                for (int i = 0; i < (m + 1) * (m + 1); i++)
                {

                    Button bt = new Button();
                    bt.FlatStyle = FlatStyle.Flat;
                    
                    bt.FlatAppearance.BorderSize = 0;
                    bt.Name = "bt" + i;
                    //bt.Text = "bt " + i;
                    bt.Tag = i;
                    
                    bt.Size = new System.Drawing.Size(fpn1.Size.Height / (m + 1) - 6, fpn1.Size.Width / (m + 1) - 6);
                    fpn1.Controls.Add(bt);
                    if ((int)bt.Tag != a)
                    {
                        bt.BackColor = Color.FromArgb(colo, colo1, colo2);
                        // o day khong co su kien click nha ---> bam sai cung khong sao 
                    }
                    else
                    {
                        bt.BackColor = Color.FromArgb(colo, colo1 + 35 - Convert.ToInt16(lbthoigian.Text), colo2);
                        bt.Click += new EventHandler(btdung_click);
                    }
                    bt.FlatAppearance.MouseOverBackColor = bt.BackColor;
                    bt.FlatAppearance.MouseDownBackColor = bt.BackColor;
                }
            }



        }

        

        private void btdung_click(object sender, EventArgs e)   // bam vao ô đúng
        {
            fpn1.Controls.Clear();              // xóa sạch flow layout panel
            tbdiem.Text = Convert.ToInt16(tbdiem.Text) + 1 + "";        // +1 điểm
            switch (Convert.ToInt16(tbdiem.Text))     //theo số điểm sẽ tạo ra bảng tương ứng
            {
                case 1:
                case 2:
                    Loadfpn1(2);  // voi 1,2 điểm --> tao ma tran 3/3
                    break;
                case 3:
                case 4:
                case 5:
                    Loadfpn1(3);  //voi 3,4,5 diem tao ma tran 4/4
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    Loadfpn1(4);  // voi 6,7,8,9 điểm --> tạo ô 5/5
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    Loadfpn1(5);   // voi 10,11,12,13,14 --> tao ma tran 6/6
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Loadfpn1(6);   // tuong ứng như trên
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                    Loadfpn1(7);
                    break;
                default:            // trường hợp hoàn thành hết sẽ không tạo mới
                    {
                        Loadfpn1(7);   // vượt quá 27 diem -- > tiếp tục tạo bảng 8/8
                        break;
                    }

            }
        }
        private void btsai_click(object sender, EventArgs e)  // bam vao o sai
        {
            int i = Convert.ToInt16(tbloi.Text);   // lấy số thời gian trên label
            if (Convert.ToInt16(lbthoigian.Text) > 3)   // neu thi gian nhieu hon 3 --> - 3
            {
                lbthoigian.Text = Convert.ToInt16(lbthoigian.Text) - 3 + "";
                tbloi.Text = i + 1 + "";
            }
            else  // thoi gian nho hon 3 ---> thoi gian = 0
                lbthoigian.Text = "0";





        }   

        public play_form()
        {
            InitializeComponent();
            panel1.Visible = false;   // an panel chon ngon ngu
            loadform1();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(lbthoigian.Text);  // lay chi so thoi gian hien tai
            if (i > 0)  
            {
                lbthoigian.Text = i - 1 + "";  // tru di 1 don vi
                if (i <= 6)                     // thời gian <= 6
                {
                    tick.Play();       // chay file am thanh tick
                    pictureBox1.BackColor = Color.Red; //tao nền đồng hồ đỏ
                    lbthoigian.BackColor = Color.Red;           // màu text thời gian đỏ
                    


                }
                else
                {
                    tick.Stop();  // không cho phát âm thanh
                    pictureBox1.BackColor = Color.Turquoise; // chuyên đồng hồ sang nên xanh
                    lbthoigian.BackColor = Color.Turquoise;  // chuyển text thời gian -> xanh
                }

            }
            else
            {
                tick.Stop();  // dừng tick

                //this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)   // khởi tạo form 
        {
            lbdiemcao.Text = maxoldpoint + "";   // lấy điểm cao từ form 2 đã gửi
            loadlang();   // chạy ngôn ngữ 
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbthoigian_TextChanged(object sender, EventArgs e) // hết giờ tự động tắt form và chuyển qua form 2
        {
            if (lbthoigian.Text == "0")
                showf2();

        }

        private void btmultilang_Click(object sender, EventArgs e)
        {

        }

        #endregion


        private void button2_Click_1(object sender, EventArgs e)  // thay đổi trạng thái hiển thị panel multi_lang khi click vào button multi_lang
        {
            panel1.Visible = !panel1.Visible;
        }
#region bt_lang_click     // click vào button ngôn ngữ tương ứng ---> thay đổi chỉ số ngôn ngữ + chạy lại hàm set ngôn ngữ + ẩn panel multi_lang

        private void buttonEng_Click(object sender, EventArgs e)
        {
            lang = 2;
            loadlang();

            panel1.Visible = false;
        }

        private void buttonVie_Click(object sender, EventArgs e)
        {
            lang = 1;
            loadlang();

            panel1.Visible = false;
        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbthoigian_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void showf2()   
        {

            t = Convert.ToInt16(tbdiem.Text);  // gan diem cao cua lần chơi trước vào t
            m = Convert.ToInt16(lbdiemcao.Text);  // gán điểm của lần chơi này vào m
            
            result_form f2 = new result_form();   // tạo mới form 2
            f2.langcode = lang;  // set ngôn ngữ cho form 2
            if (t > m)
            {
                f2.pointmax = t;      // nếu lần chơi trước chơi cao hơn thì lấy điểm cao nhất = lần chơi trước
            }
            else
            {
                f2.pointmax = m;    //  nếu lần này chơi cao hơn thì lấy điểm cao nhất = điểm lần này
            }
            
            f2.Show();  // mở form kết quả
            this.Close();  // đóng form hiện tại
            f2.Focus();  // trỏ vào form 2
        }
         
    }
}
