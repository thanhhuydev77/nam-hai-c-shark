using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class result_form : Form
    {
        public int langcode;  //ma ngon ngu 
        public int pointmax;       // diem cao
        public result_form() 
        {
            InitializeComponent();
            loadlang();
            
        }
        void loadlang()  // ham cai dat ngon ngu( chuyen ngon ngu cua cai control theo langcode)
        {
            switch(langcode)
            {

                case 1:
                    btplay.Text = "PLAY AGAIN";
                    lbbest.Text = "Score";
                    switch (pointmax)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            lblevel.Text = "Bat";
                            lbdetail.Text = "Your color vision is not something to write home about. Bats live in the dark and rely on other senses than sight, and that's what you should do too.";
                           break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:

                            lblevel.Text = "MOLE";
                            lbdetail.Text = "You have moderate color vision. You see your closest perimeter but don't go on any big adventures as you will probably get lost.";
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                            lblevel.Text = "DOG";
                            lbdetail.Text = "You have decent color vision. You see most of the sticks that are thrown to you but sometimes you're just lost.";
                            break;
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                            lblevel.Text = "CAT";
                            lbdetail.Text = "You have good color vision. The mice should hide when you're on the move.";
                            break;
                        case 20:
                        case 21:
                        case 22:
                        case 23:
                        case 24:
                            lblevel.Text = "TIGER";
                            lbdetail.Text = "Your color vision is superb. You wouldn't have any problems surviving in the jungle. You can see when the neighbouring tiger visits the bathroom faaaar away.";
                            break;
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                            lblevel.Text = "HAWK";
                            lbdetail.Text = "Wow, you have excellent color vision. You can see a worm from the top of a tree.";
                            break;
                        default:
                            lblevel.Text = "ROBOT";
                            lbdetail.Text = "Your color vision and survival skills are incredible. You can recognize a mosquito from miles away.";
                            break;

                    }
                    break;
                case 2:
                    btplay.Text = "CHƠI LẠI";
                    lbbest.Text = "ĐIỂM CAO NHẤT";
                    switch (pointmax)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            lblevel.Text = "DƠI";
                            lbdetail.Text = "Tầm nhìn màu sắc của bạn không phải là một cái gì đó để viết về nhà. Dơi sống trong bóng tối và dựa vào các giác quan khác ngoài tầm nhìn, và đó là những gì bạn nên làm.";
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:

                            lblevel.Text = "CHUỘT CHŨI";
                            lbdetail.Text = "Bạn có tầm nhìn màu trung bình. Bạn thấy chu vi gần nhất của bạn nhưng không đi vào bất kỳ cuộc phiêu lưu lớn như bạn có thể sẽ bị lạc.";
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                            lblevel.Text = "CHÓ";
                            lbdetail.Text = "Bạn có tầm nhìn màu sắc phong nha. Bạn thấy hầu hết các que được ném cho bạn nhưng đôi khi bạn chỉ bị mất.";
                            break;
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                            lblevel.Text = "MÈO";
                            lbdetail.Text = "Bạn có tầm nhìn màu sắc tốt. Những con chuột nên ẩn khi bạn đang di chuyển.";
                            break;
                        case 20:
                        case 21:
                        case 22:
                        case 23:
                        case 24:
                            lblevel.Text = "HỔ";
                            lbdetail.Text = "Tầm nhìn màu sắc của bạn là tuyệt vời. Bạn sẽ không có bất kỳ vấn đề tồn tại trong rừng. Bạn có thể thấy khi con hổ lân cận ghé thăm phòng tắm.";
                            break;
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                            lblevel.Text = "ĐẠI BÀNG";
                            lbdetail.Text = "Wow, bạn có tầm nhìn màu sắc tuyệt vời. Bạn có thể thấy một con sâu từ trên đỉnh của một cái cây.";
                            break;
                        default:
                            lblevel.Text = "ROBOT";
                            lbdetail.Text = "Kỹ năng sống và màu sắc của bạn thật đáng kinh ngạc. Bạn có thể nhận ra một con muỗi từ dặm.";
                            break;

                    }
                    break;
                default:
                    btplay.Text = "CHƠI LẠI";
                    lbbest.Text = "ĐIỂM CAO NHẤT";
                    switch (pointmax)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            lblevel.Text = "DƠI";
                            lbdetail.Text = "Tầm nhìn màu sắc của bạn không phải là một cái gì đó để viết về nhà. Dơi sống trong bóng tối và dựa vào các giác quan khác ngoài tầm nhìn, và đó là những gì bạn nên làm.";
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:

                            lblevel.Text = "CHUỘT CHŨI";
                            lbdetail.Text = "Bạn có tầm nhìn màu trung bình. Bạn thấy chu vi gần nhất của bạn nhưng không đi vào bất kỳ cuộc phiêu lưu lớn như bạn có thể sẽ bị lạc.";
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                            lblevel.Text = "CHÓ";
                            lbdetail.Text = "Bạn có tầm nhìn màu sắc phong nha. Bạn thấy hầu hết các que được ném cho bạn nhưng đôi khi bạn chỉ bị mất.";
                            break;
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                            lblevel.Text = "MÈO";
                            lbdetail.Text = "Bạn có tầm nhìn màu sắc tốt. Những con chuột nên ẩn khi bạn đang di chuyển.";
                            break;
                        case 20:
                        case 21:
                        case 22:
                        case 23:
                        case 24:
                            lblevel.Text = "HỔ";
                            lbdetail.Text = "Tầm nhìn màu sắc của bạn là tuyệt vời. Bạn sẽ không có bất kỳ vấn đề tồn tại trong rừng. Bạn có thể thấy khi con hổ lân cận ghé thăm phòng tắm.";
                            break;
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                            lblevel.Text = "ĐẠI BÀNG";
                            lbdetail.Text = "Wow, bạn có tầm nhìn màu sắc tuyệt vời. Bạn có thể thấy một con sâu từ trên đỉnh của một cái cây.";
                            break;
                        default:
                            lblevel.Text = "ROBOT";
                            lbdetail.Text = "Kỹ năng sống và màu sắc của bạn thật đáng kinh ngạc. Bạn có thể nhận ra một con muỗi từ dặm.";
                            break;

                    }
                    break;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {           
            label3.Text = pointmax + "";    //khoi tao diem cao nhat bang pointmax da duoc truyen truoc do 
            progressBar1.Value = pointmax;  //khoi tao gia tri cho thanh process bar tuong ung voi so diem
            loadlang();                 // cai dat ngon ngu tuong ung
        }
        
        private void btplay_Click(object sender, EventArgs e)
        {
            play_form f1 = new play_form();        // tao form choi moi
            f1.maxoldpoint = pointmax;      // nap diem cao nhat hien tai
            f1.lang = langcode;             //nap ngon ngu hien tai
            f1.Show();                      //hien form
            this.Close();                      // dong form ket qua
            
        }

        private void btout_Click(object sender, EventArgs e)
        {
            Application.Exit();  // thoat khoi chuong trinh
        }
    }
}
