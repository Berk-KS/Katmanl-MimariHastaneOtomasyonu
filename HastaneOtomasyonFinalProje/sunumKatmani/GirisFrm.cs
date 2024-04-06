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
    public partial class GirisFrm : Form
    {
        public GirisFrm()
        {
            InitializeComponent();
        }

        private void sekreterBtn_Click(object sender, EventArgs e)
        {
            SekreterGirisEkranFrm SekreterLoginEkran = new SekreterGirisEkranFrm();
            SekreterLoginEkran.TopLevel = false;
            LoginPanel.Controls.Add(SekreterLoginEkran);
            SekreterLoginEkran.BringToFront();
            SekreterLoginEkran.Show();
        }

        private void doktorBtn_Click(object sender, EventArgs e)
        {
            var DoktorLoginEkran=new DoktorGirisEkranFrm();
            DoktorLoginEkran.TopLevel=false;
            LoginPanel.Controls.Add(DoktorLoginEkran);
            DoktorLoginEkran.BringToFront();
            DoktorLoginEkran.Show();
        }
        public void FormKapat()
        {
            this.Hide();
        }

        private void GirisFrm_Load(object sender, EventArgs e)
        {
            SekreterGirisEkranFrm SekreterLoginEkran = new SekreterGirisEkranFrm();
            SekreterLoginEkran.TopLevel = false;
            LoginPanel.Controls.Add(SekreterLoginEkran);
            SekreterLoginEkran.BringToFront();
            SekreterLoginEkran.Show();
        }
    }
}
