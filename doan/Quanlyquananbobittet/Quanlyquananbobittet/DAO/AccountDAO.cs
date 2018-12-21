using Quanlyquananbobittet.DTO;
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
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasdata = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(temp);
            //var list = hasdata.ToString();

            //list.Reverse();
            string haspass = "";
            foreach (byte item in hasdata)
            {
                haspass += item;
            }
            string query = "usp_account @username , @password";
            
            DataTable a = Dataprovider.Instance.excutequery(query, new object[] { username,haspass});
            return a.Rows.Count > 0;
        }
        public AccountDTO getaccountbyusername (string username )
        {
           DataTable data = Dataprovider.Instance.excutequery("select * from account where username = '" + username + "'");
           foreach(DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }
        public bool resetacc(string username )
        {
            return Dataprovider.Instance.excutenonquery("update account set password = '20720532132149213101239102231223249249135100218' where username = '" + username+"'") > 0;
        }
        public bool updates(string username,string displayname,string password,string newpassword)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasdata = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(temp);
            //var list = hasdata.ToString();

            //list.Reverse();
            string haspass = "";
            foreach (byte item in hasdata)
            {
                haspass += item;
            }
            byte[] temp2 = ASCIIEncoding.ASCII.GetBytes(newpassword);
            byte[] hasdata2 = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(temp2);
            //var list = hasdata.ToString();

            //list.Reverse();
            string haspass2 = "";
            foreach (byte item in hasdata2)
            {
                haspass2 += item;
            }

            int result = Dataprovider.Instance.excutenonquery("usp_updateaccount @username , @displayname , @password , @newpassword ", new object[] { username, displayname,haspass,haspass2 });
            return result > 0;
        }
        public DataTable getlistaccount()
        {
            return Dataprovider.Instance.excutequery("select username,displayname,type from account");
        }
        public bool insertaccount(string name, string displayname, int type)
        {
            int i = Dataprovider.Instance.excutenonquery("usp_addaccount @username , @displayname , @password , @type ", new object[] { name, displayname,"", type });
            return i > 0;
        }
        public bool updateaccount(string name, string displayname , int type )
        {
            string query = string.Format("update account set displayname = N'{0}', type = {1} where username  = N'{2}'", displayname, type, name);
            int i = Dataprovider.Instance.excutenonquery(query);
            return i > 0;
        }
        public bool deleteaccount(string name)
        {
           
            string query = string.Format("delete from account where username  = '" + name +"'");
            int i = Dataprovider.Instance.excutenonquery(query);
            return i > 0;
        }
    }
}
