using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DTO
{
   public  class AccountDTO
    {
        public AccountDTO(string username,string disphayname, int type, string password = null)
        {
            this.Password = password;
            this.Username = username;
            this.Type = type;
            this.Displayname = disphayname;
        }
        public AccountDTO(DataRow row)
        {
            this.Password = row["password"].ToString();
            this.Username = row["username"].ToString() ;
            this.Type = (int)row["type"];
            this.Displayname = row["displayname"].ToString();
        }
        private string username;
        private string displayname;
        private string password;
        private int type;
        

        public string Username { get => username; set => username = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
