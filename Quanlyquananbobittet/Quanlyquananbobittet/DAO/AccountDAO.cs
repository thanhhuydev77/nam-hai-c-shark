using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance { get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; } set => instance = value; }
        private AccountDAO() { }
        public bool login(string username, string password)
        {
            string query = "usp_account @username , @password";
            DataTable a = Dataprovider.Instance.excutequery(query, new object[] { username,password});
            return a.Rows.Count > 0;
        }
    }
}
