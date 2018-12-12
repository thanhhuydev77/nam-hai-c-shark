using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DTO
{
   public class BillDTO
    {
        public BillDTO(int id, DateTime? daycheckin,DateTime? daycheckout,int status)
        {
            this.ID = id;
            this.Status = status;
            this.Daycheckin = daycheckin;
            this.Daycheckout = daycheckout;
        }
        public BillDTO(DataRow row)
        {

            this.ID = (int)row["id"];
            this.Status = (int)row["status"];
            this.Daycheckin = (DateTime?)row["datecheckin"];
            var daycheckouttemp = (DateTime?)row["datecheckin"];
            if(daycheckouttemp.ToString() != "")
            
            this.Daycheckout = daycheckouttemp;
        }
        private int iD;
        private DateTime? daycheckin;
        private DateTime? daycheckout;
        private int status;

        public int ID { get => iD; set => iD = value; }
        public DateTime? Daycheckin { get => daycheckin; set => daycheckin = value; }
        public DateTime? Daycheckout { get => daycheckout; set => daycheckout = value; }
        public int Status { get => status; set => status = value; }
    }
}
