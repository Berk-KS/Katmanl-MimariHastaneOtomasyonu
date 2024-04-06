namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    partial class SekreterHastaEkranFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sekreterGeridonBtn = new System.Windows.Forms.Button();
            this.hastaGüncelleBtn = new System.Windows.Forms.Button();
            this.hastaSilBtn = new System.Windows.Forms.Button();
            this.hastaEkleBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.hastaAdresRichTextBox = new System.Windows.Forms.RichTextBox();
            this.hastaMailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.hastaSoyadRichTextBox = new System.Windows.Forms.RichTextBox();
            this.hastaAdıRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HastaTCMaskedtxt = new System.Windows.Forms.MaskedTextBox();
            this.HastaTelMaskedtxt = new System.Windows.Forms.MaskedTextBox();
            this.HastalarGridVİew = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_DbDataSet3 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet3();
            this.hastaTableAdapter = new HastaneOtomasyonFinalProje.Hastane_DbDataSet3TableAdapters.HastaTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.HastalarGridVİew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // sekreterGeridonBtn
            // 
            this.sekreterGeridonBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.sekreterGeridonBtn.Location = new System.Drawing.Point(994, 33);
            this.sekreterGeridonBtn.Name = "sekreterGeridonBtn";
            this.sekreterGeridonBtn.Size = new System.Drawing.Size(95, 46);
            this.sekreterGeridonBtn.TabIndex = 30;
            this.sekreterGeridonBtn.Text = "GERİ DÖN";
            this.sekreterGeridonBtn.UseVisualStyleBackColor = true;
            this.sekreterGeridonBtn.Click += new System.EventHandler(this.sekreterGeridonBtn_Click);
            // 
            // hastaGüncelleBtn
            // 
            this.hastaGüncelleBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.hastaGüncelleBtn.Location = new System.Drawing.Point(9, 380);
            this.hastaGüncelleBtn.Name = "hastaGüncelleBtn";
            this.hastaGüncelleBtn.Size = new System.Drawing.Size(109, 59);
            this.hastaGüncelleBtn.TabIndex = 29;
            this.hastaGüncelleBtn.Text = "GÜNCELLE";
            this.hastaGüncelleBtn.UseVisualStyleBackColor = true;
            this.hastaGüncelleBtn.Click += new System.EventHandler(this.hastaGüncelleBtn_Click);
            // 
            // hastaSilBtn
            // 
            this.hastaSilBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.hastaSilBtn.Location = new System.Drawing.Point(124, 380);
            this.hastaSilBtn.Name = "hastaSilBtn";
            this.hastaSilBtn.Size = new System.Drawing.Size(109, 59);
            this.hastaSilBtn.TabIndex = 28;
            this.hastaSilBtn.Text = "SEÇİLİ HASTAYI SİL";
            this.hastaSilBtn.UseVisualStyleBackColor = true;
            this.hastaSilBtn.Click += new System.EventHandler(this.hastaSilBtn_Click);
            // 
            // hastaEkleBtn
            // 
            this.hastaEkleBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaEkleBtn.Location = new System.Drawing.Point(239, 380);
            this.hastaEkleBtn.Name = "hastaEkleBtn";
            this.hastaEkleBtn.Size = new System.Drawing.Size(168, 59);
            this.hastaEkleBtn.TabIndex = 27;
            this.hastaEkleBtn.Text = "EKLE";
            this.hastaEkleBtn.UseVisualStyleBackColor = true;
            this.hastaEkleBtn.Click += new System.EventHandler(this.hastaEkleBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label7.Location = new System.Drawing.Point(40, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Hasta TC:";
            // 
            // hastaAdresRichTextBox
            // 
            this.hastaAdresRichTextBox.Location = new System.Drawing.Point(145, 284);
            this.hastaAdresRichTextBox.Name = "hastaAdresRichTextBox";
            this.hastaAdresRichTextBox.Size = new System.Drawing.Size(262, 77);
            this.hastaAdresRichTextBox.TabIndex = 24;
            this.hastaAdresRichTextBox.Text = "";
            // 
            // hastaMailRichTextBox
            // 
            this.hastaMailRichTextBox.Location = new System.Drawing.Point(145, 208);
            this.hastaMailRichTextBox.Name = "hastaMailRichTextBox";
            this.hastaMailRichTextBox.Size = new System.Drawing.Size(262, 26);
            this.hastaMailRichTextBox.TabIndex = 23;
            this.hastaMailRichTextBox.Text = "";
            // 
            // hastaSoyadRichTextBox
            // 
            this.hastaSoyadRichTextBox.Location = new System.Drawing.Point(145, 134);
            this.hastaSoyadRichTextBox.Name = "hastaSoyadRichTextBox";
            this.hastaSoyadRichTextBox.Size = new System.Drawing.Size(262, 26);
            this.hastaSoyadRichTextBox.TabIndex = 21;
            this.hastaSoyadRichTextBox.Text = "";
            // 
            // hastaAdıRichTextBox
            // 
            this.hastaAdıRichTextBox.Location = new System.Drawing.Point(145, 93);
            this.hastaAdıRichTextBox.Name = "hastaAdıRichTextBox";
            this.hastaAdıRichTextBox.Size = new System.Drawing.Size(262, 26);
            this.hastaAdıRichTextBox.TabIndex = 20;
            this.hastaAdıRichTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 39);
            this.label6.TabIndex = 19;
            this.label6.Text = "HASTA İŞLEMLERİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.Location = new System.Drawing.Point(4, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hasta Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label5.Location = new System.Drawing.Point(4, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hasta Tel No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hasta Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.Location = new System.Drawing.Point(19, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hasta Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.Location = new System.Drawing.Point(29, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hasta Adı:";
            // 
            // HastaTCMaskedtxt
            // 
            this.HastaTCMaskedtxt.Location = new System.Drawing.Point(145, 178);
            this.HastaTCMaskedtxt.Mask = "00000000000";
            this.HastaTCMaskedtxt.Name = "HastaTCMaskedtxt";
            this.HastaTCMaskedtxt.Size = new System.Drawing.Size(262, 20);
            this.HastaTCMaskedtxt.TabIndex = 31;
            // 
            // HastaTelMaskedtxt
            // 
            this.HastaTelMaskedtxt.Location = new System.Drawing.Point(145, 249);
            this.HastaTelMaskedtxt.Mask = "00000000000";
            this.HastaTelMaskedtxt.Name = "HastaTelMaskedtxt";
            this.HastaTelMaskedtxt.Size = new System.Drawing.Size(262, 20);
            this.HastaTelMaskedtxt.TabIndex = 32;
            // 
            // HastalarGridVİew
            // 
            this.HastalarGridVİew.AutoGenerateColumns = false;
            this.HastalarGridVİew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HastalarGridVİew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastalarGridVİew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hastaTcDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.HastalarGridVİew.DataSource = this.hastaBindingSource;
            this.HastalarGridVİew.Location = new System.Drawing.Point(434, 93);
            this.HastalarGridVİew.Name = "HastalarGridVİew";
            this.HastalarGridVİew.Size = new System.Drawing.Size(655, 345);
            this.HastalarGridVİew.TabIndex = 33;
            this.HastalarGridVİew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HastalarGridVİew_CellContentClick_1);
            this.HastalarGridVİew.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.HastalarGridVİew_CellValueChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaTcDataGridViewTextBoxColumn
            // 
            this.hastaTcDataGridViewTextBoxColumn.DataPropertyName = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.HeaderText = "HastaTc";
            this.hastaTcDataGridViewTextBoxColumn.Name = "hastaTcDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "Tel_no";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "Tel_no";
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "Hasta";
            this.hastaBindingSource.DataSource = this.hastane_DbDataSet3;
            // 
            // hastane_DbDataSet3
            // 
            this.hastane_DbDataSet3.DataSetName = "Hastane_DbDataSet3";
            this.hastane_DbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(430, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "HASTA LİSTESİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 10);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 10);
            this.panel2.TabIndex = 36;
            // 
            // SekreterHastaEkranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HastalarGridVİew);
            this.Controls.Add(this.HastaTelMaskedtxt);
            this.Controls.Add(this.HastaTCMaskedtxt);
            this.Controls.Add(this.sekreterGeridonBtn);
            this.Controls.Add(this.hastaGüncelleBtn);
            this.Controls.Add(this.hastaSilBtn);
            this.Controls.Add(this.hastaEkleBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hastaAdresRichTextBox);
            this.Controls.Add(this.hastaMailRichTextBox);
            this.Controls.Add(this.hastaSoyadRichTextBox);
            this.Controls.Add(this.hastaAdıRichTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SekreterHastaEkranFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterHastaEkranFrm";
            this.Load += new System.EventHandler(this.SekreterHastaEkranFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HastalarGridVİew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sekreterGeridonBtn;
        private System.Windows.Forms.Button hastaGüncelleBtn;
        private System.Windows.Forms.Button hastaSilBtn;
        private System.Windows.Forms.Button hastaEkleBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox hastaAdresRichTextBox;
        private System.Windows.Forms.RichTextBox hastaMailRichTextBox;
        private System.Windows.Forms.RichTextBox hastaSoyadRichTextBox;
        private System.Windows.Forms.RichTextBox hastaAdıRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox HastaTCMaskedtxt;
        private System.Windows.Forms.MaskedTextBox HastaTelMaskedtxt;
        private System.Windows.Forms.DataGridView HastalarGridVİew;
        private Hastane_DbDataSet3 hastane_DbDataSet3;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private Hastane_DbDataSet3TableAdapters.HastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}