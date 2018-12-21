using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quanlyquananbobittet.DAO
{
   public  class Dataprovider
    {
        private static Dataprovider instance;
       private string cs = @"Data Source=DESKTOP-T6PALB9;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        
        public static Dataprovider Instance { get { if (instance == null) instance = new Dataprovider(); return Dataprovider.instance; }
            private set => instance = value; }
        private Dataprovider() { }
        public DataTable  excutequery(string query,object[] obj = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);
                if (obj != null)
                {
                    int i = 0;
                    string[] list = query.Split(' ');
                    foreach (string iteam in list)
                    {
                        if (iteam.Contains('@'))
                        {
                            command.Parameters.AddWithValue(iteam, obj[i]);
                            i++;
                        }
                    }
                

                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            return data;
        }
        public int excutenonquery(string query, object[] obj = null)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);
                if (obj != null)
                {
                    int i = 0;
                    string[] list = query.Split(' ');
                    foreach (string iteam in list)
                    {
                        if (iteam.Contains('@'))
                        {
                            command.Parameters.AddWithValue(iteam, obj[i]);
                            i++;
                        }
                    }


                }
                data = command.ExecuteNonQuery();
            }
            return data;
        }
        public object excutescalar (string query, object[] obj = null)
        {
            Object data = 0;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);
                if (obj != null)
                {
                    int i = 0;
                    string[] list = query.Split(' ');
                    foreach (string iteam in list)
                    {
                        if (iteam.Contains('@'))
                        {
                            command.Parameters.AddWithValue(iteam, obj[i]);
                            i++;
                        }
                    }


                }
                data = command.ExecuteScalar();
                
            }
            return data;
        }
    }
}
