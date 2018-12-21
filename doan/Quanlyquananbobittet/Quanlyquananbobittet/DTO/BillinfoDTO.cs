using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DTO
{
  public    class BillinfoDTO
    {
        public BillinfoDTO(int id,int billid,int foodid,int cout)
        {
            this.ID = id;
            this.Foodid = foodid;
            this.Billid = billid;
            this.Cout = cout;
        }
        public BillinfoDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Foodid = (int)row["idfood"];
            this.Billid = (int)row["idbill"];
            this.Cout = (int)row["count"];
        }
        private int iD;
        private int billid;
        private int foodid;
        private int cout;

        public int ID { get => iD; set => iD = value; }
        public int Billid { get => billid; set => billid = value; }
        public int Foodid { get => foodid; set => foodid = value; }
        public int Cout { get => cout; set => cout = value; }
        
    }
}
