using Quanlyquananbobittet.DAO;
using Quanlyquananbobittet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quanlyquananbobittet.ftablemanager;

namespace Quanlyquananbobittet
{
    public partial class Finfo : Form
    {
        private AccountDTO acc;
        public Finfo(AccountDTO acc)
        {
            InitializeComponent();
            this.Acc = acc;
        }

        public AccountDTO Acc
        {
            get => acc;
            set
            {
                acc = value;
                loadaccount(Acc);
            }
        }
        public void loadaccount(AccountDTO acc)
        {
            Tbusername.Text = acc.Username;
            Tbdisplayname.Text = acc.Displayname;
        }

        private void Btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void update()
        {
            string username = Tbusername.Text;
            string displayname = Tbdisplayname.Text;
            string password = Tbpassword.Text;
            string newpassword = Tbnewpassword.Text;
            string renewpassword = Tbagain.Text;
            if (!newpassword.Equals(renewpassword))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            } else
            {
                if (AccountDAO.Instance.updates(username, displayname, password, newpassword))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    if (updateaccount != null)
                        updateaccount(this, new accountevent(AccountDAO.Instance.getaccountbyusername(username)));
                }
                else
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu");
            }

        }
        private event EventHandler<accountevent> updateaccount;
        public event EventHandler<accountevent> Updateaccount
        {
            add { updateaccount += value; }
            remove { updateaccount -= value; }
         }


        private void Btupdate_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
