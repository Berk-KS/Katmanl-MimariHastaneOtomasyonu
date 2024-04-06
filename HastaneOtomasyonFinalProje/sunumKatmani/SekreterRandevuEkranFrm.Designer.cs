namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    partial class SekreterRandevuEkranFrm
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
            this.hastaSkrtrGeriDönBtm = new System.Windows.Forms.Button();
            this.randevuOluşturBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RandevuGridView = new System.Windows.Forms.DataGridView();
            this.Doktor_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_DbDataSet9 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet9();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_DbDataSet6 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet6();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hastaTableAdapter = new HastaneOtomasyonFinalProje.Hastane_DbDataSet6TableAdapters.HastaTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hastaIdtextBox = new System.Windows.Forms.TextBox();
            this.doktorIdtextBox = new System.Windows.Forms.TextBox();
            this.TARIHPICKER = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.hastane_DbDataSet7 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet7();
            this.randevuTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevu_TBTableAdapter = new HastaneOtomasyonFinalProje.Hastane_DbDataSet7TableAdapters.Randevu_TBTableAdapter();
            this.hastane_DbDataSet8 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet8();
            this.randevuTBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.randevu_TBTableAdapter1 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet8TableAdapters.Randevu_TBTableAdapter();
            this.randevu_TBTableAdapter2 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet9TableAdapters.Randevu_TBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RandevuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuTBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuTBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaSkrtrGeriDönBtm
            // 
            this.hastaSkrtrGeriDönBtm.Font = new System.Drawing.Font("Calibri", 12F);
            this.hastaSkrtrGeriDönBtm.Location = new System.Drawing.Point(647, 23);
            this.hastaSkrtrGeriDönBtm.Name = "hastaSkrtrGeriDönBtm";
            this.hastaSkrtrGeriDönBtm.Size = new System.Drawing.Size(161, 58);
            this.hastaSkrtrGeriDönBtm.TabIndex = 21;
            this.hastaSkrtrGeriDönBtm.Text = "GERİ DÖN";
            this.hastaSkrtrGeriDönBtm.UseVisualStyleBackColor = true;
            this.hastaSkrtrGeriDönBtm.Click += new System.EventHandler(this.hastaSkrtrGeriDönBtm_Click);
            // 
            // randevuOluşturBtn
            // 
            this.randevuOluşturBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.randevuOluşturBtn.Location = new System.Drawing.Point(26, 334);
            this.randevuOluşturBtn.Name = "randevuOluşturBtn";
            this.randevuOluşturBtn.Size = new System.Drawing.Size(266, 58);
            this.randevuOluşturBtn.TabIndex = 19;
            this.randevuOluşturBtn.Text = "RANDEVUYU OLUŞTUR";
            this.randevuOluşturBtn.UseVisualStyleBackColor = true;
            this.randevuOluşturBtn.Click += new System.EventHandler(this.randevuOluşturBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-270, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "İSTENİLEN RANDEVU SAATİ :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(396, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "RANDEVULAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // RandevuGridView
            // 
            this.RandevuGridView.AutoGenerateColumns = false;
            this.RandevuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RandevuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandevuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doktor_ID,
            this.hastaIDDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.RandevuGridView.DataSource = this.randevuTBBindingSource2;
            this.RandevuGridView.Location = new System.Drawing.Point(400, 97);
            this.RandevuGridView.Name = "RandevuGridView";
            this.RandevuGridView.Size = new System.Drawing.Size(408, 295);
            this.RandevuGridView.TabIndex = 14;
            // 
            // Doktor_ID
            // 
            this.Doktor_ID.DataPropertyName = "Doktor_ID";
            this.Doktor_ID.HeaderText = "Doktor_ID";
            this.Doktor_ID.Name = "Doktor_ID";
            // 
            // hastaIDDataGridViewTextBoxColumn
            // 
            this.hastaIDDataGridViewTextBoxColumn.DataPropertyName = "Hasta_ID";
            this.hastaIDDataGridViewTextBoxColumn.HeaderText = "Hasta_ID";
            this.hastaIDDataGridViewTextBoxColumn.Name = "hastaIDDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // randevuTBBindingSource2
            // 
            this.randevuTBBindingSource2.DataMember = "Randevu_TB";
            this.randevuTBBindingSource2.DataSource = this.hastane_DbDataSet9;
            // 
            // hastane_DbDataSet9
            // 
            this.hastane_DbDataSet9.DataSetName = "Hastane_DbDataSet9";
            this.hastane_DbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "Hasta";
            this.hastaBindingSource.DataSource = this.hastane_DbDataSet6;
            // 
            // hastane_DbDataSet6
            // 
            this.hastane_DbDataSet6.DataSetName = "Hastane_DbDataSet6";
            this.hastane_DbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 10);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 10);
            this.panel2.TabIndex = 23;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Randevu İstenilen Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(101, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Hasta ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(101, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Doktor ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hastaIdtextBox);
            this.groupBox1.Controls.Add(this.doktorIdtextBox);
            this.groupBox1.Controls.Add(this.TARIHPICKER);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 239);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Hasta Bilgileri";
            // 
            // hastaIdtextBox
            // 
            this.hastaIdtextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaIdtextBox.Location = new System.Drawing.Point(180, 41);
            this.hastaIdtextBox.Name = "hastaIdtextBox";
            this.hastaIdtextBox.Size = new System.Drawing.Size(139, 23);
            this.hastaIdtextBox.TabIndex = 33;
            // 
            // doktorIdtextBox
            // 
            this.doktorIdtextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorIdtextBox.Location = new System.Drawing.Point(180, 73);
            this.doktorIdtextBox.Name = "doktorIdtextBox";
            this.doktorIdtextBox.Size = new System.Drawing.Size(139, 23);
            this.doktorIdtextBox.TabIndex = 32;
            // 
            // TARIHPICKER
            // 
            this.TARIHPICKER.CustomFormat = "2023-01-01";
            this.TARIHPICKER.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TARIHPICKER.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TARIHPICKER.Location = new System.Drawing.Point(180, 107);
            this.TARIHPICKER.Name = "TARIHPICKER";
            this.TARIHPICKER.Size = new System.Drawing.Size(139, 23);
            this.TARIHPICKER.TabIndex = 31;
            this.TARIHPICKER.ValueChanged += new System.EventHandler(this.TARIHPICKER_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(40, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "RANDEVU İŞLEMLERİ";
            // 
            // hastane_DbDataSet7
            // 
            this.hastane_DbDataSet7.DataSetName = "Hastane_DbDataSet7";
            this.hastane_DbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevuTBBindingSource
            // 
            this.randevuTBBindingSource.DataMember = "Randevu_TB";
            this.randevuTBBindingSource.DataSource = this.hastane_DbDataSet7;
            // 
            // randevu_TBTableAdapter
            // 
            this.randevu_TBTableAdapter.ClearBeforeFill = true;
            // 
            // hastane_DbDataSet8
            // 
            this.hastane_DbDataSet8.DataSetName = "Hastane_DbDataSet8";
            this.hastane_DbDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevuTBBindingSource1
            // 
            this.randevuTBBindingSource1.DataMember = "Randevu_TB";
            this.randevuTBBindingSource1.DataSource = this.hastane_DbDataSet8;
            // 
            // randevu_TBTableAdapter1
            // 
            this.randevu_TBTableAdapter1.ClearBeforeFill = true;
            // 
            // randevu_TBTableAdapter2
            // 
            this.randevu_TBTableAdapter2.ClearBeforeFill = true;
            // 
            // SekreterRandevuEkranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 424);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hastaSkrtrGeriDönBtm);
            this.Controls.Add(this.randevuOluşturBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RandevuGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SekreterRandevuEkranFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterRandevuEkranFrm";
            this.Load += new System.EventHandler(this.SekreterRandevuEkranFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RandevuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuTBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuTBBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hastaSkrtrGeriDönBtm;
        private System.Windows.Forms.Button randevuOluşturBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RandevuGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Hastane_DbDataSet6 hastane_DbDataSet6;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private Hastane_DbDataSet6TableAdapters.HastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private Hastane_DbDataSet7 hastane_DbDataSet7;
        private System.Windows.Forms.BindingSource randevuTBBindingSource;
        private Hastane_DbDataSet7TableAdapters.Randevu_TBTableAdapter randevu_TBTableAdapter;
        private Hastane_DbDataSet8 hastane_DbDataSet8;
        private System.Windows.Forms.BindingSource randevuTBBindingSource1;
        private Hastane_DbDataSet8TableAdapters.Randevu_TBTableAdapter randevu_TBTableAdapter1;
        private System.Windows.Forms.DateTimePicker TARIHPICKER;
        private Hastane_DbDataSet9 hastane_DbDataSet9;
        private System.Windows.Forms.BindingSource randevuTBBindingSource2;
        private Hastane_DbDataSet9TableAdapters.Randevu_TBTableAdapter randevu_TBTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doktor_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox hastaIdtextBox;
        private System.Windows.Forms.TextBox doktorIdtextBox;
    }
}