using Quanlyquananbobittet.DAO;
using Quanlyquananbobittet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyquananbobittet
{
    public partial class ftablemanager : Form
    {
        private AccountDTO acc;
        public double totalprices = 0;
        public CultureInfo culture = new CultureInfo("vi-VN");

        public AccountDTO Acc
        {
            get => acc;
            set
            {
                acc = value;
                loadaccount(acc.Type);
            }
        }

        public ftablemanager(AccountDTO acc)
        {

            InitializeComponent();
            this.Acc = acc;
            loadtable();
            loadcategory();

        }
        #region methous
        public void loadaccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinToolStripMenuItem.Text += "(" + Acc.Displayname + ")";

        }
        void loadcategory()
        {
            List<CategoryDTO> list = CategoryDAO.Instance.getlistcategory();
            Cbfoodcategory.DataSource = list;
            Cbfoodcategory.DisplayMember = "name";
        }
        void loadfoodbycategory(int id)
        {
            List<foodDTO> list = FoodDAO.Instance.getfoodbyidcategory(id);
            Cbfood.DataSource = list;
            Cbfood.DisplayMember = "name";
        }
        void loadtable()
        {
            Fpntable.Controls.Clear();
            List<tableDTO> listtable = TableDAO.Instance.loadtablelist();
            foreach (tableDTO item in listtable)
            {
                Button btn = new Button() { Width = TableDAO.btnwidth, Height = TableDAO.btnheight };
                btn.Click += Btn_Click;
                btn.Tag = item;
                btn.BackgroundImage = new Bitmap(Application.StartupPath + "\\table.png");
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.TextAlign = ContentAlignment.TopCenter;
                btn.Text = item.Name;
                btn.Font = new Font(btn.Font.FontFamily, 13, FontStyle.Bold);

                if (item.Status == "Trống")
                    btn.BackColor = Color.LawnGreen;
                else
                    btn.BackColor = Color.IndianRed;

                Fpntable.Controls.Add(btn);
            }
        }
        void Showbill(int idtable)
        {
            float totalprice = 0;
            Lvbill.Items.Clear();
            List<menuDTO> listbill = MenuDAO.Instance.getmenubyid(BillDAO.Instance.getuncheckbillbyid(idtable));
            foreach (menuDTO menu in listbill)
            {
                ListViewItem item = new ListViewItem(menu.Name.ToString());
                item.SubItems.Add(menu.Price.ToString());
                item.SubItems.Add(menu.Count.ToString());
                item.SubItems.Add(menu.Totalprice.ToString());

                totalprice += menu.Totalprice;
                Lvbill.Items.Add(item);
            }

            //Tbtotalprice.Text = totalprice.ToString(currency);
            Tbtotalprice.Text = totalprice.ToString("c", culture);
            totalprices = totalprice;
            loadtable();

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableid = ((sender as Button).Tag as tableDTO).ID;
            Lvbill.Tag = (sender as Button).Tag;
            Showbill(tableid);
        }
        #endregion
        #region event
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finfo fi = new Finfo(Acc);
            fi.Updateaccount += Fi_Updateaccount; ;

            fi.ShowDialog();
        }

        private void Fi_Updateaccount(object sender, accountevent e)
        {
            thôngTinToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.Displayname + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fadmin FA = new Fadmin();
            FA.useracc =acc.Username;
            FA.Updatefood += FA_Updatefood;
            FA.Addfood += FA_Addfood;
            FA.Deletefood += FA_Deletefood;
            FA.Addcategory += FA_Addcategory;
            FA.Deletecategory += FA_Deletecategory;
            FA.Updatecategory += FA_Updatecategory;
            FA.Addtable += FA_Addtable;
            FA.Updatetable += FA_Updatetable;
            FA.Deletetable += FA_Deletetable;
            FA.ShowDialog();

        }

        private void FA_Deletetable(object sender, EventArgs e)
        {
            loadfoodbycategory((Cbfoodcategory.SelectedItem as CategoryDTO).ID);
            if (Lvbill.Tag != null)
                Showbill((Lvbill.Tag as tableDTO).ID);
            loadtable();
        }

        private void FA_Updatetable(object sender, EventArgs e)
        {
            loadfoodbycategory((Cbfoodcategory.SelectedItem as CategoryDTO).ID);
            if (Lvbill.Tag != null)
                Showbill((Lvbill.Tag as tableDTO).ID);
            loadtable();
        }

        private void FA_Addtable(object sender, EventArgs e)
        {
            loadfoodbycategory((Cbfoodcategory.SelectedItem as CategoryDTO).ID);
            if (Lvbill.Tag != null)
                Showbill((Lvbill.Tag as tableDTO).ID);
            loadtable();
        }

        private void FA_Updatecategory(object sender, EventArgs e)
        {
            loadfoodbycategory((Cbfoodcategory.SelectedItem as CategoryDTO).ID);
            if (Lvbill.Tag != null)
                Showbill((Lvbill.Tag as tableDTO).ID);
            loadtable();
        }

        private void FA_Deletecategory(object sender, EventArgs e)
        {
            loadcategory();
            if (Lvbill.Tag != null)
                Showbill((Lvbill.Tag as tableDTO).ID);
            loadtable();
        }

        private void FA_Addcategory(object sender, EventArgs e)
        {
            loadfoodbycategory((Cbfoodcategory.SelectedItem as CategoryDTO).ID);
            if (Lvbill.Tag != null)
                Showbill((Lvbill.Tag as tableDTO).ID);
        }

        private void FA_Deletefood(object sender, EventArgs e)
        {
            loadfoodbycategory((Cbfoodcategory.SelectedItem as CategoryDTO).ID);
            if (Lvbill.Tag != null)
                Showbill((Lvbill.Tag as tableDTO).ID);
            loadtable();
        }

        private void FA_Addfood(object sender, EventArgs e)
        {
            loadfoodbycategory((Cbfoodcategory.SelectedItem as CategoryDTO).ID);
            if(Lvbill.Tag != null)
            Showbill((Lvbill.Tag as tableDTO).ID);
        }

        private void FA_Updatefood(object sender, EventArgs e)
        {
            loadfoodbycategory((Cbfoodcategory.SelectedItem as CategoryDTO).ID);
            if (Lvbill.Tag != null)
                Showbill((Lvbill.Tag as tableDTO).ID);
        }
        #endregion



        private void Cbfoodcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            CategoryDTO category = cb.SelectedItem as CategoryDTO;
            id = category.ID;
            loadfoodbycategory(id);
        }

        private void Btaddfood_Click(object sender, EventArgs e)
        {
            tableDTO table = Lvbill.Tag as tableDTO;
            try
            {
                int idbill = BillDAO.Instance.getuncheckbillbyid(table.ID);
                int idfood = (Cbfood.SelectedItem as foodDTO).ID;
                if (idbill == -1)
                {
                    BillDAO.Instance.insert(table.ID);
                    BillinfoDAO.Instance.insert(BillDAO.Instance.getmaxbill(), idfood, (int)Nmfoodcount.Value);
                }
                else
                {
                    BillinfoDAO.Instance.insert(idbill, idfood, (int)Nmfoodcount.Value);

                }
                Showbill(table.ID);
            }
            catch {

                MessageBox.Show("Mời chọn bàn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btcheckout_Click(object sender, EventArgs e)
        {
            try
            {

                tableDTO table = Lvbill.Tag as tableDTO;
                int idbill = BillDAO.Instance.getuncheckbillbyid(table.ID);
                if (idbill != -1)
                {
                    int discount = Convert.ToInt16(numericUpDown1.Value);

                    if (MessageBox.Show("Bạn muốn thanh toán hóa đơn bàn " + table.Name, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (MessageBox.Show("Tổng tiền ban đầu: " + totalprices + "\n Giảm giá: " + discount + "\n Số tiền thanh toán: " + (totalprices - (totalprices / 100 * discount)), "Thông tin thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)

                        {
                            BillDAO.Instance.checkout(idbill, totalprices - (totalprices / 100 * discount), discount);
                            Showbill(table.ID);
                        }
                    }
                }
            } catch
            {
                //MessageBox.Show("Vui lòng chọn bàn thanh toán!");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class accountevent : EventArgs
            {
            private AccountDTO acc;
            public accountevent( AccountDTO acc)
            {
                this.Acc = acc;               
            }

            public AccountDTO Acc { get => acc; set => acc = value; }
        }
    }

}
