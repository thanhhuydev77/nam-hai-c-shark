using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlyquananbobittet.DAO;
using Quanlyquananbobittet.DTO;

namespace Quanlyquananbobittet
{
    public partial class Fadmin : Form
    {
        public string useracc;
        BindingSource tablesource = new BindingSource();
        BindingSource categorysource = new BindingSource();
        BindingSource source = new BindingSource();
        BindingSource accsource = new BindingSource();
        public Fadmin()
        {
            InitializeComponent();
            load();

        }
        void load()
        {
            DGtable.DataSource = tablesource;
            Dgcategory.DataSource = categorysource;
            accsource.DataSource = AccountDAO.Instance.getlistaccount();
            Dgvfood.DataSource = source;
            Dtgvaccount.DataSource = accsource;
            getlist(); 
            loaddatetimepickerbill();
            loadlistbillbydate(Dpcheckin.Value, Dpcheckout.Value);
            foodbinding();
            loadcategorytocombox(Cbfoodcategory);
            loadcategory();
            loadtable();
            bindingcategory();
            bindingacc();
            bindingtable();


        }

        private void bindingtable()
        {
            Tbnametable.DataBindings.Add(new Binding("text",DGtable.DataSource,"name", true,DataSourceUpdateMode.Never));
            Tbidtable.DataBindings.Add(new Binding("text", DGtable.DataSource, "id", true, DataSourceUpdateMode.Never));
            Cbstatustable.DataBindings.Add(new Binding("text", DGtable.DataSource, "status", true, DataSourceUpdateMode.Never));
        }

        private void loadtable()
        {
            tablesource.DataSource = TableDAO.Instance.loadtablelist();
        }

        void bindingacc()
        {
            Tbdisplayname.DataBindings.Add(new Binding("text", Dtgvaccount.DataSource, "displayname", true, DataSourceUpdateMode.Never));
            tbnameacc.DataBindings.Add(new Binding("text", Dtgvaccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            Cbtypesacc.DataBindings.Add(new Binding("selectedindex", Dtgvaccount.DataSource, "type", true, DataSourceUpdateMode.Never));

        }
        void loaddatetimepickerbill()
        {
            DateTime now = DateTime.Now;
            Dpcheckin.Value = new DateTime(now.Year,now.Month,1);
            Dpcheckout.Value = Dpcheckin.Value.AddMonths(1).AddDays(-1);
        }
         void loadlistbillbydate(DateTime dci, DateTime dco)
        {
            DataTable listbill = BillDAO.Instance.getlistbillbydate(dci,dco);
            Dtgvbill.DataSource = listbill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadlistbillbydate(Dpcheckin.Value, Dpcheckout.Value);
            
        }
        void getlist()
        {
            source.DataSource = FoodDAO.Instance.getilstfood();
        }
        private void Btviewfood_Click(object sender, EventArgs e)
        {
            getlist();
        }
        void foodbinding()
        {

            Tbnamefood.DataBindings.Add(new Binding("text",Dgvfood.DataSource,"name",true,DataSourceUpdateMode.Never));
            Tbfoodid.DataBindings.Add(new Binding("text", Dgvfood.DataSource, "id",true,DataSourceUpdateMode.Never));
            Nudfoodprice.DataBindings.Add(new Binding("text", Dgvfood.DataSource, "price", true, DataSourceUpdateMode.Never));
            Cbfoodcategory.DataBindings.Add(new Binding("selectedvalue",Dgvfood.DataSource,"idcategory", true, DataSourceUpdateMode.Never));
            //Tbfoodcategory.DataBindings.Add(new Binding("text", Dgvfood.DataSource, "category"));
        }
        void loadcategorytocombox(ComboBox cb)
        {
            
            cb.DataSource = CategoryDAO.Instance.getlistcategory();
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
        }
        private void Dgvfood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try { int row = e.RowIndex;
            //    Dgvfood.Rows[row].Selected = true;
            //}catch
            //{ }
            //}
        }
        private void Dtgvbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try {
            //    int row = e.RowIndex;
            //    Dtgvbill.Rows[row].Selected = true;
            //}catch
            //{ }

        }

        private void Btaddfood_Click(object sender, EventArgs e)
        {
            
            string namefood = Tbnamefood.Text;
            int idcategory =(Cbfoodcategory.SelectedItem as CategoryDTO).ID;
            double price = (double)Nudfoodprice.Value;
            if(FoodDAO.Instance.insertfood(namefood,idcategory,price))
            {
                MessageBox.Show("Thêm món thành công!");
                getlist();
                if (addfood != null)
                    addfood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi thêm thức ăn!");
            }
        }

        private void Bteditfood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Tbfoodid.Text);
            string namefood = Tbnamefood.Text;
            int idcategory = (Cbfoodcategory.SelectedItem as CategoryDTO).ID;
            double price = (double)Nudfoodprice.Value;
            
            if (FoodDAO.Instance.updatefood(id, namefood, idcategory, price))
            {
                MessageBox.Show("Cập nhật thức ăn thành công!");
                getlist();
                if (updatefood != null)
                    updatefood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi cập nhật thức ăn!");
            }
        }
        private event EventHandler addfood;
        public event EventHandler Addfood
        {
            add { addfood += value; }
            remove { addfood -= value; }
        }
        private event EventHandler updatefood;
        public event EventHandler  Updatefood
        {
            add { updatefood += value; }
            remove { updatefood -= value; }
        }
        private event EventHandler deletefood;
        public event EventHandler Deletefood
        {
            add { deletefood += value; }
            remove { deletefood -= value; }
        }

        private void btdeletefood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Tbfoodid.Text);
            if (FoodDAO.Instance.deletefood(id))
            {
                MessageBox.Show("xóa thức ăn thành công!");
                getlist();
                if (deletefood != null)
                    deletefood(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("có lỗi khi xóa thức ăn!");
            }
        }
        List<foodDTO> searchfoodbyname(string name)
        {
            List<foodDTO> list = FoodDAO.Instance.searchfoodbyname(name);
           
            return list;
        }
        private void Btsearchfood_Click(object sender, EventArgs e)
        {
            source.DataSource = searchfoodbyname(Tbsearchfood.Text);
        }

        private void Btviewacc_Click(object sender, EventArgs e)
        {
            accsource.DataSource = AccountDAO.Instance.getlistaccount();
        }
        

        private void Dtgvaccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    int row = e.RowIndex;
            //    Dtgvaccount.Rows[row].Selected = true;
            //}
            //catch
            //{ }
        }
        void addacc(string username, string displayname, int type)
        {
            if (AccountDAO.Instance.insertaccount(username, displayname, type))
            {
                MessageBox.Show("Thêm tài khoản mới thành công!");

            }
            else
                MessageBox.Show("Thêm tài khoản thất bại !");
            accsource.DataSource = AccountDAO.Instance.getlistaccount();
        }
        private void Btaddacc_Click(object sender, EventArgs e)
        {
            string username = tbnameacc.Text;
            string displayname = Tbdisplayname.Text;
            int type = Cbtypesacc.SelectedIndex;
            addacc(username ,displayname,type);
        }
        void updateacc(string username, string displayname, int type)
        {
            if (AccountDAO.Instance.updateaccount(username, displayname, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");

            }
            else
                MessageBox.Show("Cập nhật tài khoản thất bại !");
            accsource.DataSource = AccountDAO.Instance.getlistaccount();
        }
        void deleteacc(string username)
        {
            if (useracc != username)
            {
                if (AccountDAO.Instance.deleteaccount(username))
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                }
                else
                    MessageBox.Show("Xóa tài khoản thất bại !");
                accsource.DataSource = AccountDAO.Instance.getlistaccount();
            }
            else
                MessageBox.Show("Không thể xóa tài khoản đang sử dụng!");
        }
        
        private void bteditacc_Click(object sender, EventArgs e)
        {
            string username = tbnameacc.Text;
            string displayname = Tbdisplayname.Text;
            int type = Cbtypesacc.SelectedIndex;
            updateacc(username, displayname, type);
        }

        private void Btdeleteacc_Click(object sender, EventArgs e)
        {
            string username = tbnameacc.Text;
            deleteacc(username);
        }
        void resetacc(string username)
        {
            if (AccountDAO.Instance.resetacc(username))
                MessageBox.Show("Đặt lại mật khẩu thành công!");
            else
                MessageBox.Show("Đặt lại mật khẩu thất bại!");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            resetacc(tbnameacc.Text);
        }

        private void Dtgvaccount_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dtgvaccount.Rows[e.RowIndex].Selected = true;
        }

        private void Dtgvbill_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            Dtgvbill.Rows[e.RowIndex].Selected = true;
        }

        private void Dgvfood_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dgvfood.Rows[e.RowIndex].Selected = true;
        }

        private void Dtgvbill_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           Dtgvbill.Rows[e.RowIndex].Selected = true;
        }
        void loadcategory()
        {
            categorysource.DataSource= CategoryDAO.Instance.getlistcategory();
        }

        private void Btviewcategory_Click(object sender, EventArgs e)
        {
            loadcategory();
        }
        void bindingcategory()
        {
            Tbidcategory.DataBindings.Add(new Binding("text",Dgcategory.DataSource,"id",true,DataSourceUpdateMode.Never));

            Tbnamecategory.DataBindings.Add(new Binding("text", Dgcategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        private void Dgcategory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dgcategory.Rows[e.RowIndex].Selected = true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            searchcategorybyname(Tbsearchcategory.Text);
        }

        private void searchcategorybyname(string name)
        {
            categorysource.DataSource= CategoryDAO.Instance.searchcategorybyfood(name);
        }
        
        private event EventHandler addcategory;
        public event EventHandler Addcategory
        {
            add { addcategory += value; }
            remove { addcategory -= value; }
        }
        private event EventHandler updatecategory;
        public event EventHandler Updatecategory
        {
            add { updatecategory += value; }
            remove { updatecategory -= value; }
        }
        private event EventHandler deletecategory;
        public event EventHandler Deletecategory
        {
            add { deletecategory += value; }
            remove { deletecategory -= value; }
        }
        private void Btaddcategory_Click(object sender, EventArgs e)
        {
            string name = Tbnamecategory.Text;
            
            if (CategoryDAO.Instance.insertcategory(name))
            {
                MessageBox.Show("Thêm danh mục mới thành công!");
                categorysource.DataSource = CategoryDAO.Instance.getlistcategory();
                if (addcategory != null)
                    addcategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi thêm danh mục mới!");
            }
        }

        private void Bteditfood_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Tbfoodid.Text);
            string name = Tbnamefood.Text;
            int idcategory = (int)Cbfoodcategory.SelectedValue;
            double price = (double)Nudfoodprice.Value;
            if (FoodDAO.Instance.updatefood(id, name,idcategory,price))
            {
                MessageBox.Show("sửa món ăn thành công!");
                source.DataSource = FoodDAO.Instance.getilstfood();
                if (updatefood != null)
                    updatefood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi sửa món ăn!");
            }
        }

        private void Bteditcategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Tbidcategory.Text);
            string name = Tbnamecategory.Text;
            if (CategoryDAO.Instance.updatecategory(id, name))
            {
                MessageBox.Show("sửa danh mục thành công!");
                categorysource.DataSource = CategoryDAO.Instance.getlistcategory();
                if (updatecategory != null)
                    updatecategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi thêm danh mục mới!");
            }
        }

        private void Btdeletecategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Tbidcategory.Text);
            string name = Tbnamecategory.Text;
            if (CategoryDAO.Instance.deletecategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công!");
                categorysource.DataSource = CategoryDAO.Instance.getlistcategory();
                if (deletecategory != null)
                    deletecategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi xóa danh mục!");
            }
        }
        private event EventHandler addtable;
        public event EventHandler Addtable
        {
            add { addtable += value; }
            remove { addtable -= value; }
        }
        private event EventHandler updatetable;
        public event EventHandler Updatetable
        {
            add { updatecategory += value; }
            remove { updatecategory -= value; }
        }
        private event EventHandler deletetable;
        public event EventHandler Deletetable
        {
            add { deletetable += value; }
            remove { deletetable -= value; }
        }

        private void Btaddtable_Click(object sender, EventArgs e)
        {
            string name = Tbnametable.Text;
            string status = Cbstatustable.Text;
            if (TableDAO.Instance.inserttable(name))
            {
                MessageBox.Show("Thêm bàn ăn mới thành công!");
                tablesource.DataSource = TableDAO.Instance.loadtablelist();
                if (addtable != null)
                    addtable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi thêm bàn ăn mới!");
            }
        }

        private void Btedittable_Click(object sender, EventArgs e)
        {
            string name = Tbnametable.Text;
            int id = Convert.ToInt16(Tbidtable.Text);
            if (TableDAO.Instance.updatetable(id,name))
            {
                MessageBox.Show("Sửa bàn ăn thành công!");
                tablesource.DataSource = TableDAO.Instance.loadtablelist();
                if (updatetable != null)
                    updatetable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi sửa bàn ăn!");
            }
        }

        private void Btdeletetable_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt16(Tbidtable.Text);
            
            if (TableDAO.Instance.deletetable(id))
            {
                MessageBox.Show("Xóa bàn ăn thành công!");
                tablesource.DataSource = TableDAO.Instance.loadtablelist();
                if (deletetable != null)
                    deletetable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("có lỗi khi xóa bàn ăn!");
            }
        }

        private void DGtable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DGtable.Rows[e.RowIndex].Selected = true;
        }

        private void Btviewtable_Click(object sender, EventArgs e)
        {
            loadtable();
        }
    }
}
