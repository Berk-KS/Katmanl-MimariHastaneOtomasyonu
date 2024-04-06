namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    partial class DoktorAnaEkranFrm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.çıkışYapBtn = new System.Windows.Forms.Button();
            this.hastaRandevuSilBtn = new System.Windows.Forms.Button();
            this.hastaBilgiDüzenleBtn = new System.Windows.Forms.Button();
            this.randevularDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_DbDataSet10 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet10();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hastaTableAdapter = new HastaneOtomasyonFinalProje.Hastane_DbDataSet10TableAdapters.HastaTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevularDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(291, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "HASTALARINIZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(291, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.çıkışYapBtn);
            this.groupBox2.Controls.Add(this.hastaRandevuSilBtn);
            this.groupBox2.Controls.Add(this.hastaBilgiDüzenleBtn);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 382);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMİ SEÇİN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Analiz İşlemi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // çıkışYapBtn
            // 
            this.çıkışYapBtn.Location = new System.Drawing.Point(10, 337);
            this.çıkışYapBtn.Name = "çıkışYapBtn";
            this.çıkışYapBtn.Size = new System.Drawing.Size(223, 39);
            this.çıkışYapBtn.TabIndex = 4;
            this.çıkışYapBtn.Text = "Sistemden Çıkış Yap";
            this.çıkışYapBtn.UseVisualStyleBackColor = true;
            this.çıkışYapBtn.Click += new System.EventHandler(this.çıkışYapBtn_Click);
            // 
            // hastaRandevuSilBtn
            // 
            this.hastaRandevuSilBtn.Location = new System.Drawing.Point(10, 158);
            this.hastaRandevuSilBtn.Name = "hastaRandevuSilBtn";
            this.hastaRandevuSilBtn.Size = new System.Drawing.Size(223, 42);
            this.hastaRandevuSilBtn.TabIndex = 1;
            this.hastaRandevuSilBtn.Text = "Seçili Randevuyu Sil";
            this.hastaRandevuSilBtn.UseVisualStyleBackColor = true;
            // 
            // hastaBilgiDüzenleBtn
            // 
            this.hastaBilgiDüzenleBtn.Location = new System.Drawing.Point(10, 68);
            this.hastaBilgiDüzenleBtn.Name = "hastaBilgiDüzenleBtn";
            this.hastaBilgiDüzenleBtn.Size = new System.Drawing.Size(223, 39);
            this.hastaBilgiDüzenleBtn.TabIndex = 0;
            this.hastaBilgiDüzenleBtn.Text = "Hasta İşlemleri";
            this.hastaBilgiDüzenleBtn.UseVisualStyleBackColor = true;
            this.hastaBilgiDüzenleBtn.Click += new System.EventHandler(this.hastaBilgiDüzenleBtn_Click);
            // 
            // randevularDataGridView
            // 
            this.randevularDataGridView.AutoGenerateColumns = false;
            this.randevularDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.randevularDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevularDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hastaTcDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.randevularDataGridView.DataSource = this.hastaBindingSource;
            this.randevularDataGridView.Location = new System.Drawing.Point(295, 57);
            this.randevularDataGridView.Name = "randevularDataGridView";
            this.randevularDataGridView.Size = new System.Drawing.Size(741, 358);
            this.randevularDataGridView.TabIndex = 8;
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
            this.hastaBindingSource.DataSource = this.hastane_DbDataSet10;
            // 
            // hastane_DbDataSet10
            // 
            this.hastane_DbDataSet10.DataSetName = "Hastane_DbDataSet10";
            this.hastane_DbDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 10);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 10);
            this.panel2.TabIndex = 13;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // DoktorAnaEkranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.randevularDataGridView);
            this.MaximizeBox = false;
            this.Name = "DoktorAnaEkranFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorAnaEkran";
            this.Load += new System.EventHandler(this.DoktorAnaEkranFrm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.randevularDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button çıkışYapBtn;
        private System.Windows.Forms.Button hastaRandevuSilBtn;
        private System.Windows.Forms.Button hastaBilgiDüzenleBtn;
        private System.Windows.Forms.DataGridView randevularDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Hastane_DbDataSet10 hastane_DbDataSet10;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private Hastane_DbDataSet10TableAdapters.HastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}