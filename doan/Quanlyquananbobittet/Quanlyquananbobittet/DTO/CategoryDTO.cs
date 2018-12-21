using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DTO
{
   public class CategoryDTO
    {
        public CategoryDTO(int id,string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public CategoryDTO(DataRow datarow)
        {
            this.ID = (int)datarow["id"];
            this.Name = datarow["name"].ToString();
        }
        private int iD;
        private string name;
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
