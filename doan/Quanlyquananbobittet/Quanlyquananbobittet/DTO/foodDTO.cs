using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DTO
{
   public  class foodDTO
    {
        public foodDTO(int id, string name, int idcategory, float price)
        {
            this.ID = id;
            this.Name = name;
            this.Idcategory = idcategory;
            this.Price = price;
        }
        public foodDTO(DataRow row)

        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString() ;
            this.Idcategory = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        int iD;
        string name;
        int idcategory;
        float price;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Idcategory { get => idcategory; set => idcategory = value; }
        public float Price { get => price; set => price = value; }
    }
}
