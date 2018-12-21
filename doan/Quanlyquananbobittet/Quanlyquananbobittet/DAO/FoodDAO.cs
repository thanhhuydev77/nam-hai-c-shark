using Quanlyquananbobittet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance { get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; } private set => instance = value; }
        FoodDAO() { }
        public List<foodDTO> getfoodbyidcategory(int id)
        {
            List<foodDTO> list = new List<foodDTO>();
            DataTable data = Dataprovider.Instance.excutequery("select * from food where idcategory ='"+id+"'");
            foreach(DataRow item in data.Rows)
            {
                foodDTO food = new foodDTO(item);
                list.Add(food);
            }
            return list;
        }
        public List<foodDTO> searchfoodbyname(string name)
        {
            List<foodDTO> list = new List<foodDTO>();
            DataTable data = Dataprovider.Instance.excutequery(string.Format("select * from food where [dbo].[fuConvertToUnsign1](name) like  '%' +[dbo].[fuConvertToUnsign1](N'{0}') +'%'", name));
            foreach (DataRow item in data.Rows)
            {
                foodDTO food = new foodDTO(item);
                list.Add(food);
            }
            return list;
        }
        public List<foodDTO> getilstfood()
        {
            List<foodDTO> list = new List<foodDTO>();
            DataTable data = Dataprovider.Instance.excutequery("select * from food ");
            foreach (DataRow item in data.Rows)
            {
                foodDTO food = new foodDTO(item);
                list.Add(food);
            }
            return list;
        }
        public bool insertfood(string name,int idcategory,double price)
        {
            int i =Dataprovider.Instance.excutenonquery("insert into food values( @name , @idcategory , @price )",new object[] {name,idcategory,price});
            return i > 0;
        }
        public bool updatefood(int id,string name, int idcategory, double price)
        {
            string query = string.Format("update food set name = N'{0}' , idcategory = {1}, price = {2} where id = {3}",name,idcategory,price,id);
            int i = Dataprovider.Instance.excutenonquery(query);
            return i > 0;
        }
        public bool deletefood(int id)
        {
            BillinfoDAO.Instance.deletebillinfobyfoodid(id);
            string query = string.Format("delete from food where id = "+id);
            int i = Dataprovider.Instance.excutenonquery(query);
            return i > 0;
        }
    }
}
