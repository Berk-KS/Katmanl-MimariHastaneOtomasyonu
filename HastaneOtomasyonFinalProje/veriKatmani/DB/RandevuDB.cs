using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.veriKatmani.DB
{
    public class RandevuDB
    {
        public static void addRandevu(RandevuProps rp)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("insert into Randevu_TB values (@Doktor_ID,@Hasta_ID,@DoktorTani,@Durum,@Tarih) ", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Doktor_ID", rp.Doktor_id);
            cmd.Parameters.AddWithValue("@Hasta_ID", rp.Hasta_id);
            cmd.Parameters.AddWithValue("@DoktorTani", rp.DoktorTani);
            cmd.Parameters.AddWithValue("@Durum", rp.Durum);
            cmd.Parameters.AddWithValue("@Tarih", rp.Tarih);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void updateRandevu(RandevuProps rp)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("update Randevu_TB set Doktor_id=@Doktor_id, Hasta_id=@Hasta_id, DoktorTani=@DoktorTani, Durum=@Durum, Tarih=@Tarih where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", rp.id);
            cmd.Parameters.AddWithValue("@Doktor_id", rp.Doktor_id);
            cmd.Parameters.AddWithValue("@Hasta_id", rp.Hasta_id);
            cmd.Parameters.AddWithValue("@Doktor_tani", rp.DoktorTani);
            cmd.Parameters.AddWithValue("@Durum", rp.Durum);
            cmd.Parameters.AddWithValue("@Tarih", rp.Tarih);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void deleteRandevu(int id)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("Delete * from Randevu_TB where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static List<RandevuProps> GettAllRandevu()
        {
            List<RandevuProps> Randevular = null;
            string constring = ConnectionClass.DB_Connection();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Select id as id, Doktor_ID as Doktor_ID, Hasta_ID as Hasta_ID, DoktorTani as DoktorTani, Durum as Durum, Tarih as Tarih from Randevu_TB", con);
            con.Open();
            var dataReader = cmd.ExecuteReader();
            Randevular = ConnectionClass.GetList<RandevuProps>(dataReader);
            con.Close();

            return Randevular;
        }
    }
}
