using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.veriKatmani.DB
{
    public class BransDB
    {
        public static List<BransProps> GetBranslar()
        {
            List<BransProps> Branslar = null;
            string constring = ConnectionClass.DB_Connection();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Select id as id, Brans_Ad as Brans_ad from Brans", con);
            con.Open();
            var dataReader = cmd.ExecuteReader();
            Branslar = ConnectionClass.GetList<BransProps>(dataReader);
            con.Close();

            return Branslar;
        }
    }
}
