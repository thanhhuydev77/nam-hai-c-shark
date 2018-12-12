using Quanlyquananbobittet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyquananbobittet.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        internal static MenuDAO Instance { get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }  private set => instance = value; }
        private MenuDAO() { }
        public List<menuDTO>  getmenubyid (int id)
        {
            List<menuDTO> list = new List<menuDTO>();
            DataTable data = Dataprovider.Instance.excutequery("  select f.name,f.price,bi.count,f.price*bi.count as totalprice  from food as f,Bill as b,BillInfo as bi  where f.id = bi.idFood and bi.idBill = b.id and b.id =" + id);
           foreach( DataRow item in data.Rows)
            {
                menuDTO menu = new menuDTO(item);
                list.Add(menu);

            }
                return list;
        }
    }
}
