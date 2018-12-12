using Quanlyquananbobittet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DAO
{
    class BillDAO
    {
        private static BillDAO instance;

        internal static BillDAO Instance { get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; } private set => instance = value; }
       private BillDAO() { }
        public int getuncheckbillbyid(int id)
        {
            DataTable data = Dataprovider.Instance.excutequery("select * from bill where idtable = "+id+"and status = 0");

            if(data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
    }
}
