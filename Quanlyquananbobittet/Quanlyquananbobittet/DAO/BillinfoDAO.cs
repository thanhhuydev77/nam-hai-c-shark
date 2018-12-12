using Quanlyquananbobittet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DAO
{
    class BillinfoDAO
    {
        private static BillinfoDAO instance;

        internal static BillinfoDAO Instance { get { if (instance == null) instance = new BillinfoDAO(); return BillinfoDAO.instance; }  private set => instance = value; }
        private BillinfoDAO() { }
        public List<BillinfoDTO> listbillinfo(int id)
        {
            List<BillinfoDTO> listbillinfo = new List<BillinfoDTO>();
            DataTable list = Dataprovider.Instance.excutequery("select * from billinfo where idbill = "+id);
            foreach (DataRow item in list.Rows)
            {
                BillinfoDTO billinfo = new BillinfoDTO(item);
                listbillinfo.Add(billinfo);
            }
{
                return listbillinfo;
            }
        }
    }
}
