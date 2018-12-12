using Quanlyquananbobittet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquananbobittet.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static int btnwidth = 87;
        public static int btnheight = 87;

        public static TableDAO Instance { get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; } private set => instance = value; }
        private TableDAO() { }
        public List<tableDTO> loadtablelist()
        {
            List<tableDTO> listtable = new List<tableDTO>();
            DataTable data = Dataprovider.Instance.excutequery("select * from tablefood"); 
            foreach(DataRow item in data.Rows)
            {
                tableDTO table = new tableDTO(item);
                listtable.Add(table);
            }
            return listtable;
        }
    }
}
