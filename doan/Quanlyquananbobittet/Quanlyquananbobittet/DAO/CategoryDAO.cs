using Quanlyquananbobittet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DAO
{
     public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance { get {
                if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance;
            } private set => instance = value; }
        private CategoryDAO() { }
       public  List<CategoryDTO>  getlistcategory ()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            DataTable data = Dataprovider.Instance.excutequery("select * from foodcategory");
            foreach(DataRow item in data.Rows)
            {
                CategoryDTO category = new CategoryDTO(item);
                list.Add(category);
            }
            return list;
        }
        public DataTable searchcategorybyfood (string name)
        {
            DataTable list = Dataprovider.Instance.excutequery(string.Format("select * from FoodCategory where [dbo].[fuConvertToUnsign1](name) like  '%' +[dbo].[fuConvertToUnsign1]( '{0}') +'%'",name)) ;
            return list;
        }
        public bool insertcategory(string name)
        {
            int i = Dataprovider.Instance.excutenonquery("insert into foodcategory(name) values( @name )", new object[] { name });
            return i > 0;
        }
        public bool updatecategory(int id,string name)
        {
            int i = Dataprovider.Instance.excutenonquery(string.Format("update foodcategory set name = '{0}' where id ={1}",name,id));
            return i > 0;
        }
        public bool deletecategory(int id)
        {
            int i = Dataprovider.Instance.excutenonquery(string.Format("delete from foodcategory where id ={0} ", id));
            return i > 0;
        }
    }
}
