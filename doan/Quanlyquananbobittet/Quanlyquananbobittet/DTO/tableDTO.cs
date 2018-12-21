using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DTO
{
   public  class tableDTO
    {
        private string name;
        private string status;
        private int iD;
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int ID { get => iD; set => iD = value; }

        public tableDTO(int id,string name, string status)
        {
            this.ID = iD;
            this.Name = name;
            this.Status = status;
        }
        public tableDTO(DataRow data )
        {
            this.ID = (int)data["id"];
            this.Name = data["name"].ToString();
            this.status = data["status"].ToString();
        }
    }
}
