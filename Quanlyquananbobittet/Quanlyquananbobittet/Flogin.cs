using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlyquananbobittet.DAO;

namespace Quanlyquananbobittet
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void Btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn thật sự muốn thoát ?","Thông báo",MessageBoxButtons.OKCancel);
            if (a == DialogResult.Cancel)
                e.Cancel = true;
            
            
        }

        private void Btlogin_Click(object sender, EventArgs e)
        {
            if (login(Tbusername.Text, Tbpassword.Text))
            {
                ftablemanager f2 = new ftablemanager();
                this.Hide();
                f2.ShowDialog();
                this.Show();
                Tbpassword.Text = "";
               

            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
        }
        private bool login(string username,string password)
        {
            return AccountDAO.Instance.login(username,password);
            
        }
    }
}
