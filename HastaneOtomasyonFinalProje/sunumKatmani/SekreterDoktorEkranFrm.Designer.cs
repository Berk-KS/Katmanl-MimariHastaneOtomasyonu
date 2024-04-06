namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    partial class SekreterDoktorEkranFrm
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
            this.geriDonBtn = new System.Windows.Forms.Button();
            this.doktorSilBtn = new System.Windows.Forms.Button();
            this.doktorGüncelleBtn = new System.Windows.Forms.Button();
            this.doktorEkleBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_DbDataSet5 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet5();
            this.label7 = new System.Windows.Forms.Label();
            this.doktorAdıTextbox = new System.Windows.Forms.TextBox();
            this.doktorSoyadıTextbox = new System.Windows.Forms.TextBox();
            this.bransBox = new System.Windows.Forms.ComboBox();
            this.sıfreMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.doktorTableAdapter = new HastaneOtomasyonFinalProje.Hastane_DbDataSet5TableAdapters.DoktorTableAdapter();
            this.doktorTelNoTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDonBtn
            // 
            this.geriDonBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.geriDonBtn.Location = new System.Drawing.Point(927, 23);
            this.geriDonBtn.Name = "geriDonBtn";
            this.geriDonBtn.Size = new System.Drawing.Size(86, 46);
            this.geriDonBtn.TabIndex = 27;
            this.geriDonBtn.Text = "GERİ DÖN";
            this.geriDonBtn.UseVisualStyleBackColor = true;
            this.geriDonBtn.Click += new System.EventHandler(this.geriDonBtn_Click);
            // 
            // doktorSilBtn
            // 
            this.doktorSilBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorSilBtn.Location = new System.Drawing.Point(13, 299);
            this.doktorSilBtn.Name = "doktorSilBtn";
            this.doktorSilBtn.Size = new System.Drawing.Size(108, 57);
            this.doktorSilBtn.TabIndex = 24;
            this.doktorSilBtn.Text = "SİL";
            this.doktorSilBtn.UseVisualStyleBackColor = true;
            this.doktorSilBtn.Click += new System.EventHandler(this.doktorSilBtn_Click);
            // 
            // doktorGüncelleBtn
            // 
            this.doktorGüncelleBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorGüncelleBtn.Location = new System.Drawing.Point(127, 299);
            this.doktorGüncelleBtn.Name = "doktorGüncelleBtn";
            this.doktorGüncelleBtn.Size = new System.Drawing.Size(108, 57);
            this.doktorGüncelleBtn.TabIndex = 25;
            this.doktorGüncelleBtn.Text = "GÜNCELLE";
            this.doktorGüncelleBtn.UseVisualStyleBackColor = true;
            this.doktorGüncelleBtn.Click += new System.EventHandler(this.doktorGüncelleBtn_Click);
            // 
            // doktorEkleBtn
            // 
            this.doktorEkleBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorEkleBtn.Location = new System.Drawing.Point(241, 299);
            this.doktorEkleBtn.Name = "doktorEkleBtn";
            this.doktorEkleBtn.Size = new System.Drawing.Size(140, 57);
            this.doktorEkleBtn.TabIndex = 26;
            this.doktorEkleBtn.Text = "EKLE";
            this.doktorEkleBtn.UseVisualStyleBackColor = true;
            this.doktorEkleBtn.Click += new System.EventHandler(this.doktorEkleBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label5.Location = new System.Drawing.Point(22, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Doktor Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label4.Location = new System.Drawing.Point(8, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Doktor Tel No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Doktor Branş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Doktor Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Doktor Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "DOKTOR İŞLEMLERİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.bransidDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doktorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(400, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 279);
            this.dataGridView1.TabIndex = 28;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // bransidDataGridViewTextBoxColumn
            // 
            this.bransidDataGridViewTextBoxColumn.DataPropertyName = "Brans_id";
            this.bransidDataGridViewTextBoxColumn.HeaderText = "Brans_id";
            this.bransidDataGridViewTextBoxColumn.Name = "bransidDataGridViewTextBoxColumn";
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "Tel_no";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "Tel_no";
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            // 
            // doktorBindingSource
            // 
            this.doktorBindingSource.DataMember = "Doktor";
            this.doktorBindingSource.DataSource = this.hastane_DbDataSet5;
            // 
            // hastane_DbDataSet5
            // 
            this.hastane_DbDataSet5.DataSetName = "Hastane_DbDataSet5";
            this.hastane_DbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(400, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "DOKTORLAR";
            // 
            // doktorAdıTextbox
            // 
            this.doktorAdıTextbox.Location = new System.Drawing.Point(138, 77);
            this.doktorAdıTextbox.Multiline = true;
            this.doktorAdıTextbox.Name = "doktorAdıTextbox";
            this.doktorAdıTextbox.Size = new System.Drawing.Size(243, 25);
            this.doktorAdıTextbox.TabIndex = 30;
            // 
            // doktorSoyadıTextbox
            // 
            this.doktorSoyadıTextbox.Location = new System.Drawing.Point(138, 113);
            this.doktorSoyadıTextbox.Multiline = true;
            this.doktorSoyadıTextbox.Name = "doktorSoyadıTextbox";
            this.doktorSoyadıTextbox.Size = new System.Drawing.Size(243, 25);
            this.doktorSoyadıTextbox.TabIndex = 31;
            // 
            // bransBox
            // 
            this.bransBox.FormattingEnabled = true;
            this.bransBox.Location = new System.Drawing.Point(138, 154);
            this.bransBox.Name = "bransBox";
            this.bransBox.Size = new System.Drawing.Size(243, 21);
            this.bransBox.TabIndex = 32;
            // 
            // sıfreMaskedTextBox
            // 
            this.sıfreMaskedTextBox.Location = new System.Drawing.Point(138, 232);
            this.sıfreMaskedTextBox.Mask = "0000000000";
            this.sıfreMaskedTextBox.Name = "sıfreMaskedTextBox";
            this.sıfreMaskedTextBox.Size = new System.Drawing.Size(122, 20);
            this.sıfreMaskedTextBox.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 10);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 10);
            this.panel2.TabIndex = 36;
            // 
            // doktorTableAdapter
            // 
            this.doktorTableAdapter.ClearBeforeFill = true;
            // 
            // doktorTelNoTextBox
            // 
            this.doktorTelNoTextBox.Location = new System.Drawing.Point(138, 197);
            this.doktorTelNoTextBox.Mask = "00000000000";
            this.doktorTelNoTextBox.Name = "doktorTelNoTextBox";
            this.doktorTelNoTextBox.Size = new System.Drawing.Size(122, 20);
            this.doktorTelNoTextBox.TabIndex = 37;
            // 
            // SekreterDoktorEkranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 380);
            this.Controls.Add(this.doktorTelNoTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sıfreMaskedTextBox);
            this.Controls.Add(this.bransBox);
            this.Controls.Add(this.doktorSoyadıTextbox);
            this.Controls.Add(this.doktorAdıTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geriDonBtn);
            this.Controls.Add(this.doktorSilBtn);
            this.Controls.Add(this.doktorGüncelleBtn);
            this.Controls.Add(this.doktorEkleBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SekreterDoktorEkranFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterDoktorEkranFrm";
            this.Load += new System.EventHandler(this.SekreterDoktorEkranFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriDonBtn;
        private System.Windows.Forms.Button doktorSilBtn;
        private System.Windows.Forms.Button doktorGüncelleBtn;
        private System.Windows.Forms.Button doktorEkleBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox doktorAdıTextbox;
        private System.Windows.Forms.TextBox doktorSoyadıTextbox;
        private System.Windows.Forms.ComboBox bransBox;
        private System.Windows.Forms.MaskedTextBox sıfreMaskedTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Hastane_DbDataSet5 hastane_DbDataSet5;
        private System.Windows.Forms.BindingSource doktorBindingSource;
        private Hastane_DbDataSet5TableAdapters.DoktorTableAdapter doktorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox doktorTelNoTextBox;
    }
}