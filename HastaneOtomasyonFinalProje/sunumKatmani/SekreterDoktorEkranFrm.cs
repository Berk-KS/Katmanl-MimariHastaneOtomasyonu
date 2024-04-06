using HastaneOtomasyonFinalProje.isKatmani;
using HastaneOtomasyonFinalProje.veriKatmani;
using HastaneOtomasyonFinalProje.veriKatmani.DB;
using HastaneOtomasyonFinalProje.veriKatmani.Prop;
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
    public partial class SekreterDoktorEkranFrm : Form
    {
        public SekreterDoktorEkranFrm()
        {
            InitializeComponent();
        }

        private void doktorEkleBtn_Click(object sender, EventArgs e) //doktor ekle butonu 
        {
            try
            {
                DoktorYönlendirici dr = new DoktorYönlendirici();
                DoktorProps drp = new DoktorProps();
                drp.Ad = doktorAdıTextbox.Text;
                drp.Soyad = doktorSoyadıTextbox.Text;
                drp.Brans_id = bransBox.SelectedIndex + 1;
                drp.Tel_no = doktorTelNoTextBox.Text;
                drp.Sifre = Convert.ToInt32(sıfreMaskedTextBox.Text);

                dr.AddDoktor(drp);
                dataGridView1.DataSource = dr.GetAllDoktorlar();
                doktorAdıTextbox.Clear();
                doktorSoyadıTextbox.Clear();
                doktorTelNoTextBox.Clear();
                sıfreMaskedTextBox.Clear();
                dr.AddDoktor(drp);
            }catch
            {
             MessageBox.Show("HATA MEYDANA GELDİ..." + "\n\n" + "HATA KODU :" + "\n" + "Ekle işlemi yapılamadı!");
            }
        }

        private void BransGetir()//brans getir metodu
        {
            BransYönlendirici br = new BransYönlendirici();
            foreach (var item in br.GetAllBrans()) 
            {
                bransBox.Items.Add(item.Brans_Ad);
            }
        }
        DataGridViewCheckBoxColumn dbcc = new DataGridViewCheckBoxColumn();
        private void SekreterDoktorEkranFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastane_DbDataSet5.Doktor' table. You can move, or remove it, as needed.
            this.doktorTableAdapter.Fill(this.hastane_DbDataSet5.Doktor);
            dbcc.Name = "checkBox";
            dataGridView1.Columns.Add(dbcc);

            foreach (DataGridViewRow dataGridView in dataGridView1.Rows) //checkbox dışındakileri readonly true yapma olayı.
            {
                for (int i = 1; i < dataGridView.Cells.Count; i++)
                {
                    dataGridView.Cells[i].ReadOnly = true;
                    if (i == 6) //checkbox indexi.
                    {
                        dataGridView.Cells[i].ReadOnly = false;
                    }
                }
            }
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick); //Checkbox event oluşturma.
            BransGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DoktorYönlendirici dr = new DoktorYönlendirici();
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Cells["checkBox"].Value = !Convert.ToBoolean(row.Cells["checkBox"].Value);

                if (Convert.ToBoolean(row.Cells["checkBox"].Value) == true)
                {
                    doktorAdıTextbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    doktorSoyadıTextbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    sıfreMaskedTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                    doktorTelNoTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                }
            }catch
            { MessageBox.Show("HATA MEYDANA GELDİ..." + "\n\n" + "HATA KODU :" + "\n" + "Güncelleme yapılacak doktor seçilmedi!"); 
            }
        }

        private void doktorSilBtn_Click(object sender, EventArgs e)//sil butonuna basıldığında gerçekleşir
        {
            DoktorYönlendirici dr = new DoktorYönlendirici();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells[6];
                if (checkbox.Selected == true)
                {
                    dr.DeleteDoktor(Convert.ToInt32(row.Cells[0].Value));
                    dataGridView1.DataSource = dr.GetAllDoktorlar();
                }
            }
        }

        private void doktorGüncelleBtn_Click(object sender, EventArgs e)  //güncelle butonuna basıldığında gerçekleşir
        {
            try         //try catch olası hata durumuna karşı kullanıcıyı bilgilendirir
            {
                DoktorYönlendirici dr = new DoktorYönlendirici();
                DoktorProps dp = new DoktorProps();

                dp.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                dp.Ad = doktorAdıTextbox.Text;
                dp.Soyad = doktorSoyadıTextbox.Text;
                dp.Tel_no = doktorTelNoTextBox.Text;
                dp.Brans_id = bransBox.SelectedIndex;
                dp.Sifre = Convert.ToInt32(sıfreMaskedTextBox.Text);

                dr.UpdateDoktor(dp);
                dataGridView1.DataSource = dr.GetAllDoktorlar();
                doktorAdıTextbox.Clear();
                doktorSoyadıTextbox.Clear();
                doktorTelNoTextBox.Clear();
                sıfreMaskedTextBox.Clear();
            }
            catch 
            {
                MessageBox.Show("HATA MEYDANA GELDİ..." + "\n\n" + "HATA KODU :" + "\n" +"Güncelleme yapılacak doktor seçilmedi!" );
            }
        }

        private void geriDonBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SekreterAnaEkranFrm sekreterAnaEkran =new SekreterAnaEkranFrm();
            sekreterAnaEkran.FormClosed += (s, args) => this.Close();
            sekreterAnaEkran.Show();
        }
    }
}
