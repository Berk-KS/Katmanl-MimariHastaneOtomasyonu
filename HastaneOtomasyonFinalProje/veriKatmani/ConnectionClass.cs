using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HastaneOtomasyonFinalProje.veriKatmani
{
    public class ConnectionClass
    {
        public static string DB_Connection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=BERKHP\\SQLEXPRESS;Initial Catalog=Hastane_Db;Integrated Security=True";
            return connection.ConnectionString.ToString();
        }
        public static List<T> GetList<T>(IDataReader reader)
        {
            List<T> list = new List<T>();

            while (reader.Read())
            {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties())
                {
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(reader[prop.Name].ToString(), propType));
                }

                list.Add(obj);
            }

            return list;
        }
    }
}
