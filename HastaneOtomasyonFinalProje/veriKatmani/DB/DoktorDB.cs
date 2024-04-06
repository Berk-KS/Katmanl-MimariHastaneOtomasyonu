using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.veriKatmani.DB
{
    public class DoktorDB
    {
        //Doktor Ekleme:
        public static void AddDoktor(DoktorProps dp)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("insert into Doktor values(@Ad,@Soyad,@Sifre,@Brans_id,@Tel_no)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@ad", dp.Ad);
            cmd.Parameters.AddWithValue("@Soyad", dp.Soyad);
            cmd.Parameters.AddWithValue("@Sifre", dp.Sifre);
            cmd.Parameters.AddWithValue("@Brans_id", dp.Brans_id);
            cmd.Parameters.AddWithValue("@Tel_no", dp.Tel_no);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Doktor Güncelleme:
        public static void UpdateDoktor(DoktorProps dp)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("Update Doktor set Ad=@Ad, Soyad=@Soyad,Sifre=@Sifre,Brans_id=@Brans_id,Tel_no=@Tel_no where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", dp.id);
            cmd.Parameters.AddWithValue("@Ad", dp.Ad);
            cmd.Parameters.AddWithValue("@Soyad", dp.Soyad);
            cmd.Parameters.AddWithValue("@Sifre", dp.Sifre);
            cmd.Parameters.AddWithValue("@Brans_id", dp.Brans_id);
            cmd.Parameters.AddWithValue("@Tel_no", dp.Tel_no);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Doktor Silme
        public static void DeleteDoktor(int id)
        {
            SqlConnection con = new SqlConnection(ConnectionClass.DB_Connection());
            SqlCommand cmd = new SqlCommand("Delete from Doktor where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Doktorları ve Özelliklerini Listeleme
        public static List<DoktorProps> GetAllDoktor()
        {
            List<DoktorProps> Doktorlar = null;
            string constring = ConnectionClass.DB_Connection();
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Select id as id, Ad as Ad, Soyad as Soyad, Sifre as Sifre, Brans_id as Brans_id, Tel_no as Tel_no from Doktor", con);
            con.Open();
            var dataReader = cmd.ExecuteReader();
            Doktorlar = ConnectionClass.GetList<DoktorProps>(dataReader);
            con.Close();
            return Doktorlar;
        }
    }
}
