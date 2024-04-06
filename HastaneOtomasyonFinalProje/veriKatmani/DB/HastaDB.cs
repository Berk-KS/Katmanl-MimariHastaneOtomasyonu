using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.veriKatmani.DB
{
    public class HastaDB
    {
        //Hasta Kaydı ekleme
        public static void addHasta(HastaProps hp)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("insert into Hasta values(@HastaTc,@Ad,@Soyad,@Mail,@Tel_no,@Adres)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@HastaTc", hp.HastaTc);
            cmd.Parameters.AddWithValue("@Ad", hp.Ad);
            cmd.Parameters.AddWithValue("@Soyad", hp.Soyad);
            cmd.Parameters.AddWithValue("@Mail", hp.Mail);
            cmd.Parameters.AddWithValue("@Tel_no", hp.Tel_no);
            cmd.Parameters.AddWithValue("@Adres", hp.Adres);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Hasta Kaydı güncelleme
        public static void updateHasta(HastaProps hp)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("Update Hasta set HastaTc=@HastaTc,Ad=@Ad,Soyad=@Soyad,Mail=@Mail,Tel_no=@Tel_no,Adres=@Adres where @id=id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", hp.id);
            cmd.Parameters.AddWithValue("@HastaTc", hp.HastaTc);
            cmd.Parameters.AddWithValue("@Ad", hp.Ad);
            cmd.Parameters.AddWithValue("@Soyad", hp.Soyad);
            cmd.Parameters.AddWithValue("@Mail", hp.Mail);
            cmd.Parameters.AddWithValue("@Tel_no", hp.Tel_no);
            cmd.Parameters.AddWithValue("@Adres", hp.Adres);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Hasta Kaydı Silme
        public static void deleteHasta(int id)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("Delete from Hasta where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Hasta Kaydı Listeleme
        public static List<HastaProps> GetAllHasta()
        {
            List<HastaProps> Hastalar = null;
            string constring = ConnectionClass.DB_Connection();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Select id as id,HastaTc as HastaTc, Ad as Ad, Soyad as Soyad, Mail as Mail, Tel_no as Tel_no, Adres as Adres from Hasta", con);
            con.Open();
            var dataReader = cmd.ExecuteReader();
            Hastalar = ConnectionClass.GetList<HastaProps>(dataReader);
            con.Close();
            return Hastalar;
        }
    }
}
