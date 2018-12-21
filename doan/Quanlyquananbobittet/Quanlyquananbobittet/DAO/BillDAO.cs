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
        public void insert(int id)
        {
            Dataprovider.Instance.excutenonquery("usp_insert @idtable", new object[] { id });
        }
       public void checkout(int id,double totalprice,int discount)
        {
            Dataprovider.Instance.excutenonquery("update bill set status = 1,datecheckout = getdate(),totalprice = "+totalprice+",discount ="+discount+" where id = '"+id+"'");
        }
        public int getmaxbill()
        {
            try
            {
                return (int)Dataprovider.Instance.excutescalar("select max(id) from bill");
            }
            catch
            {
                return 1;
            }
        }
        public DataTable getlistbillbydate(DateTime checkin, DateTime checkout)
        {
            return Dataprovider.Instance.excutequery("usp_showallbill @datecheckin , @datecheckout", new object[] { checkin,checkout });
        }
        
    }
}
