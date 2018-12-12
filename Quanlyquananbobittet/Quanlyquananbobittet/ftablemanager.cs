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
        public ftablemanager()
        {
            InitializeComponent();
            loadtable();
            
            
        }
        #region methos
        void loadtable()
        {
           List<tableDTO> listtable = TableDAO.Instance.loadtablelist();
            foreach (tableDTO item in listtable)
            {
                Button btn = new Button() { Width = TableDAO.btnwidth,Height = TableDAO.btnheight };
                btn.Click += Btn_Click;
                btn.Tag = item;
                btn.BackgroundImage = new Bitmap(Application.StartupPath + "\\table.png");
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.TextAlign = ContentAlignment.TopCenter;
                btn.Text = item.Name ;
                btn.Font = new Font(btn.Font.FontFamily,13,FontStyle.Bold);

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
                  foreach( menuDTO menu in listbill)
            {
                ListViewItem item = new ListViewItem(menu.Name.ToString());
                item.SubItems.Add(menu.Price.ToString());
                item.SubItems.Add(menu.Count.ToString());
                item.SubItems.Add(menu.Totalprice.ToString());
              
               totalprice += menu.Totalprice;
                Lvbill.Items.Add(item);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //Tbtotalprice.Text = totalprice.ToString(currency);
            Tbtotalprice.Text = totalprice.ToString("c", culture);



        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableid = ((sender as Button).Tag as tableDTO).ID;
            Showbill(tableid);
        }
        #endregion
        #region event
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finfo fi = new Finfo();
            fi.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fadmin FA = new Fadmin();
            FA.ShowDialog();

        }
        #endregion

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
