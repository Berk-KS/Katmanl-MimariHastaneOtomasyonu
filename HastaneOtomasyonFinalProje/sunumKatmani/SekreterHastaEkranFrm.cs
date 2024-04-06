using HastaneOtomasyonFinalProje.isKatmani;
using HastaneOtomasyonFinalProje.veriKatmani.DB;
using HastaneOtomasyonFinalProje.veriKatmani.Prop;
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
    public partial class SekreterHastaEkranFrm : Form
    {
        public SekreterHastaEkranFrm()
        {
            InitializeComponent();
        }
        private void hastaEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                HastaYönlendirici hastaEkle = new HastaYönlendirici();
                HastaProps hastaProps = new HastaProps();

                hastaProps.HastaTc = HastaTCMaskedtxt.Text;
                hastaProps.Ad = hastaAdıRichTextBox.Text;
                hastaProps.Soyad = hastaSoyadRichTextBox.Text;
                hastaProps.Mail = hastaMailRichTextBox.Text;
                hastaProps.Tel_no = HastaTelMaskedtxt.Text;
                hastaProps.Adres = hastaAdresRichTextBox.Text;

                
                if(hastaProps.HastaTc == string.Empty || hastaProps.Ad == string.Empty || hastaProps.Soyad == string.Empty || hastaProps.Mail == string.Empty || hastaProps.Tel_no == string.Empty || hastaProps.Adres == string.Empty)
                {
                    MessageBox.Show("Boş bıraktığınız alanlar var. Ekleme yapabilmek için lütfen doldurun.");
                }
                else
                {
                    hastaEkle.AddHasta(hastaProps);
                }
                
                HastalarGridVİew.DataSource = hastaEkle.GetAllHastalar();
                HastaTCMaskedtxt.Clear();
                hastaAdıRichTextBox.Clear();
                hastaMailRichTextBox.Clear();
                HastaTelMaskedtxt.Clear();
                hastaAdresRichTextBox.Clear();
                hastaSoyadRichTextBox.Clear();
            }
            catch
            {
                MessageBox.Show("HATA MEYDANA GELDİ..." + "\n\n" + "HATA KODU :" + "\n" + " BİR HATA MEYDANA GELDİ");
            }
        }
        DataGridViewCheckBoxColumn dbcc = new DataGridViewCheckBoxColumn();

        private void SekreterHastaEkranFrm_Load(object sender, EventArgs e)

        {// TODO: This line of code loads data into the 'hastane_DbDataSet3.Hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.hastane_DbDataSet3.Hasta);
            dbcc.Name = "checkBox";
            HastalarGridVİew.Columns.Add(dbcc);

            foreach (DataGridViewRow dataGridView in HastalarGridVİew.Rows) //checkbox dışındakileri readonly true yapma olayı.
            {
                for(int i = 1; i<dataGridView.Cells.Count; i++)
                {
                    dataGridView.Cells[i].ReadOnly = true;
                    if (i == 7) //checkbox indexi.
                    {
                        dataGridView.Cells[i].ReadOnly = false;
                    }
                }
            }
            HastalarGridVİew.CellContentClick += new DataGridViewCellEventHandler(HastalarGridVİew_CellContentClick); //Checkbox event oluşturma.
        }

        private void HastalarGridVİew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HastaYönlendirici hasta = new HastaYönlendirici();
            DataGridViewRow row = HastalarGridVİew.Rows[e.RowIndex];
            row.Cells["checkBox"].Value = !Convert.ToBoolean(row.Cells["checkBox"].Value);

            if (Convert.ToBoolean(row.Cells["checkBox"].Value)==true)
            {
                HastaTCMaskedtxt.Text = HastalarGridVİew.CurrentRow.Cells[1].Value.ToString();
                hastaAdıRichTextBox.Text = HastalarGridVİew.CurrentRow.Cells[2].Value.ToString();
                hastaSoyadRichTextBox.Text = HastalarGridVİew.CurrentRow.Cells[3].Value.ToString();
                hastaMailRichTextBox.Text = HastalarGridVİew.CurrentRow.Cells[4].Value.ToString();
                HastaTelMaskedtxt.Text = HastalarGridVİew.CurrentRow.Cells[5].Value.ToString();
                hastaAdresRichTextBox.Text = HastalarGridVİew.CurrentRow.Cells[6].Value.ToString();
            }
        }
        private void hastaSilBtn_Click(object sender, EventArgs e) //HASTA SİL BUTONUNA BASINCA BURA ÇALIŞACAK
        {
            HastaYönlendirici hasta = new HastaYönlendirici();
            foreach (DataGridViewRow row in HastalarGridVİew.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells[7];
                if(checkbox.Selected == true)
                {
                    hasta.DeleteHasta(Convert.ToInt32(row.Cells[0].Value));
                    HastalarGridVİew.DataSource = hasta.GetAllHastalar();
                }
            }
        }
        
        private void hastaGüncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                HastaYönlendirici hasta = new HastaYönlendirici();
                HastaProps hp = new HastaProps();

                hp.id = Convert.ToInt32(HastalarGridVİew.CurrentRow.Cells[0].Value);
                hp.Ad = hastaAdıRichTextBox.Text;
                hp.Soyad = hastaSoyadRichTextBox.Text;
                hp.HastaTc = HastaTCMaskedtxt.Text;
                hp.Mail = hastaMailRichTextBox.Text;
                hp.Tel_no = HastaTelMaskedtxt.Text;
                hp.Adres = hastaAdresRichTextBox.Text;

                hasta.UpdateHasta(hp);
                HastalarGridVİew.DataSource = hasta.GetAllHastalar();

                HastaTCMaskedtxt.Clear();
                hastaAdıRichTextBox.Clear();
                hastaMailRichTextBox.Clear();
                HastaTelMaskedtxt.Clear();
                hastaAdresRichTextBox.Clear();
                hastaSoyadRichTextBox.Clear();
            }catch
            {
                MessageBox.Show("HATA MEYDANA GELDİ..." + "\n\n" + "HATA KODU :" + "\n" + " BİR HATA MEYDANA GELDİ");
            }
        }
        private void sekreterGeridonBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SekreterAnaEkranFrm sekreterAnaEkran =new SekreterAnaEkranFrm();
            sekreterAnaEkran.FormClosed += (s, args) => this.Close();
            sekreterAnaEkran.Show();
        }

        private void HastalarGridVİew_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void HastalarGridVİew_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
