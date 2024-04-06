namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    partial class DoktorHastaBilgiEkranFrm
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_DbDataSet11 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet11();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hastaTableAdapter = new HastaneOtomasyonFinalProje.Hastane_DbDataSet11TableAdapters.HastaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F);
            this.button5.Location = new System.Drawing.Point(12, 548);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 57);
            this.button5.TabIndex = 25;
            this.button5.Text = "ÖNCEKİ MENÜ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F);
            this.button4.Location = new System.Drawing.Point(557, 548);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 57);
            this.button4.TabIndex = 24;
            this.button4.Text = "MAİL YOLLA";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F);
            this.button3.Location = new System.Drawing.Point(701, 548);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 57);
            this.button3.TabIndex = 23;
            this.button3.Text = "PDF DOSYALA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F);
            this.button2.Location = new System.Drawing.Point(845, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 57);
            this.button2.TabIndex = 22;
            this.button2.Text = "KAYDI GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(989, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 57);
            this.button1.TabIndex = 21;
            this.button1.Text = "KAYDI EKLE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(493, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "HASTANIN TÜM RANDEVULARI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastaTcDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(497, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 470);
            this.dataGridView1.TabIndex = 19;
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
            this.hastaBindingSource.DataSource = this.hastane_DbDataSet11;
            // 
            // hastane_DbDataSet11
            // 
            this.hastane_DbDataSet11.DataSetName = "Hastane_DbDataSet11";
            this.hastane_DbDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(20, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "TAHLİL VE TEŞHİS BURAYA YAZIN";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(443, 470);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 10);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 617);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 10);
            this.panel2.TabIndex = 27;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // DoktorHastaBilgiEkranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoktorHastaBilgiEkranFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorHastaBilgiEkranFrm";
            this.Load += new System.EventHandler(this.DoktorHastaBilgiEkranFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Hastane_DbDataSet11 hastane_DbDataSet11;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private Hastane_DbDataSet11TableAdapters.HastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}