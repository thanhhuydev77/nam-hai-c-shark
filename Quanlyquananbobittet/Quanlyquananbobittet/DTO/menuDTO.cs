using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DTO
{
   public class menuDTO
    {

        menuDTO(string name,int count,float price,float totalprice = 0)
        {
            this.Name = name;
            this.Count = count;
            this.Price = price;
            this.Totalprice = totalprice;
        }
       public menuDTO(DataRow row)
        {
            this.Name = (string)row["name"];
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Totalprice = (float)Convert.ToDouble(row["totalprice"].ToString());
        }
        private string name;
        private int count;
        private float price;
        private float totalprice;

        
        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }
    }
}
