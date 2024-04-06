using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.veriKatmani.DB
{
    public class SekreterDB
    {
        //Bütün Sekreterleri ve özelliklerini listeler:
        public static List<SekreterProps> GetAllSekreter()
        {
            List<SekreterProps> Sekreterler = null;
            string connect = ConnectionClass.DB_Connection();
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(@"Select id as id, ad as Ad, soyad as Soyad,sifre as Sifre from Sekreter", con);
            con.Open();
            var dataReader = cmd.ExecuteReader();
            Sekreterler = ConnectionClass.GetList<SekreterProps>(dataReader);
            con.Close();

            return Sekreterler;
        }
        //Sekreter Ekleme:
        public static void AddSekreter(SekreterProps sp)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("insert into Sekreter values(@ad,@soyad,@sifre)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@ad", sp.Ad);
            cmd.Parameters.AddWithValue("@soyad", sp.Soyad);
            cmd.Parameters.AddWithValue("@sifre", sp.Sifre);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Sekreter Güncelleme:
        public static void UpdateSekreter(SekreterProps sp)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("Update Sekreter set ad=@Ad,soyad=@Soyad,sifre=@Sifre where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", sp.id);
            cmd.Parameters.AddWithValue("@ad", sp.Ad);
            cmd.Parameters.AddWithValue("@soyad", sp.Soyad);
            cmd.Parameters.AddWithValue("@sifre", sp.Sifre);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Sekreter Silme:
        public static void DeleteSekreter(int id)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("Delete from Sekreter where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
