using HastaneOtomasyonFinalProje.isKatmani;
using HastaneOtomasyonFinalProje.veriKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    public partial class SekreterGirisEkranFrm : Form
    {
        public SekreterGirisEkranFrm()
        {
            InitializeComponent();
        }

        private void sekretergirisEkranBtn_Click(object sender, EventArgs e)
        {
            SekreterYönlendirici sekreter = new SekreterYönlendirici();
            foreach (var item in sekreter.GetAllSekreter())
            {
                if(sekreterAdrichTextBox.Text==item.Ad && sekreterSifrerichTextBox.Text==item.Sifre.ToString())
                {
                    this.Hide();
                    var SekreterMainEkran= new SekreterAnaEkranFrm();
                    SekreterMainEkran.FormClosed += (s, args) => this.Close();
                    SekreterMainEkran.Show();

                }
                else if(sekreterAdrichTextBox.Text != item.Ad && sekreterSifrerichTextBox.Text != item.Sifre.ToString())
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }
            }
        }
    }
}
