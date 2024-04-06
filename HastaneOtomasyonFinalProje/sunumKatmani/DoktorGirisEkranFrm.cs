using HastaneOtomasyonFinalProje.isKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    public partial class DoktorGirisEkranFrm : Form
    {
        public DoktorGirisEkranFrm()
        {
            InitializeComponent();
        }

        private void drgirisBtn_Click(object sender, EventArgs e)
        {
            DoktorYönlendirici doktor=new DoktorYönlendirici();
            foreach (var item in doktor.GetAllDoktorlar())
            {
                if(doktorAd.Text==item.Ad && doktorSifre.Text == item.Sifre.ToString())
                {
                    this.Hide();    
                    var DoktorMainEkran = new DoktorAnaEkranFrm();
                    DoktorMainEkran.FormClosed += (s, args) => this.Close();
                    DoktorMainEkran.Show();
                }
                else if (doktorAd.Text != item.Ad && doktorSifre.Text != item.Sifre.ToString())
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
