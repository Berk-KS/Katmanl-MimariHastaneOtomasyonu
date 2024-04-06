namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    partial class SekreterSekreterEkranıFrm
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
            this.sekreterSilBtn = new System.Windows.Forms.Button();
            this.sekreterGüncelleBtn = new System.Windows.Forms.Button();
            this.sekreterEkleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sekreterGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekreterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_DbDataSet4 = new HastaneOtomasyonFinalProje.Hastane_DbDataSet4();
            this.sekreterTableAdapter = new HastaneOtomasyonFinalProje.Hastane_DbDataSet4TableAdapters.SekreterTableAdapter();
            this.sekreterAdTextbox = new System.Windows.Forms.TextBox();
            this.sekreterSoyadTextbox = new System.Windows.Forms.TextBox();
            this.sekreterSifreMaskedTextbox = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // sekreterGeridonBtn
            // 
            this.sekreterGeridonBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.sekreterGeridonBtn.Location = new System.Drawing.Point(741, 16);
            this.sekreterGeridonBtn.Name = "sekreterGeridonBtn";
            this.sekreterGeridonBtn.Size = new System.Drawing.Size(93, 46);
            this.sekreterGeridonBtn.TabIndex = 27;
            this.sekreterGeridonBtn.Text = "GERİ DÖN";
            this.sekreterGeridonBtn.UseVisualStyleBackColor = true;
            this.sekreterGeridonBtn.Click += new System.EventHandler(this.sekreterGeridonBtn_Click);
            // 
            // sekreterSilBtn
            // 
            this.sekreterSilBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sekreterSilBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekreterSilBtn.Location = new System.Drawing.Point(16, 189);
            this.sekreterSilBtn.Name = "sekreterSilBtn";
            this.sekreterSilBtn.Size = new System.Drawing.Size(108, 57);
            this.sekreterSilBtn.TabIndex = 26;
            this.sekreterSilBtn.Text = "SEÇİLİ ÖĞEYİ SİL";
            this.sekreterSilBtn.UseVisualStyleBackColor = false;
            this.sekreterSilBtn.Click += new System.EventHandler(this.sekreterSilBtn_Click);
            // 
            // sekreterGüncelleBtn
            // 
            this.sekreterGüncelleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sekreterGüncelleBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekreterGüncelleBtn.Location = new System.Drawing.Point(130, 189);
            this.sekreterGüncelleBtn.Name = "sekreterGüncelleBtn";
            this.sekreterGüncelleBtn.Size = new System.Drawing.Size(108, 57);
            this.sekreterGüncelleBtn.TabIndex = 25;
            this.sekreterGüncelleBtn.Text = "GÜNCELLE";
            this.sekreterGüncelleBtn.UseVisualStyleBackColor = false;
            this.sekreterGüncelleBtn.Click += new System.EventHandler(this.sekreterGüncelleBtn_Click);
            // 
            // sekreterEkleBtn
            // 
            this.sekreterEkleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sekreterEkleBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekreterEkleBtn.Location = new System.Drawing.Point(244, 189);
            this.sekreterEkleBtn.Name = "sekreterEkleBtn";
            this.sekreterEkleBtn.Size = new System.Drawing.Size(123, 57);
            this.sekreterEkleBtn.TabIndex = 24;
            this.sekreterEkleBtn.Text = "EKLE";
            this.sekreterEkleBtn.UseVisualStyleBackColor = false;
            this.sekreterEkleBtn.Click += new System.EventHandler(this.sekreterEkleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sekreter Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sekreter Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.Location = new System.Drawing.Point(40, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sekreter Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 39);
            this.label6.TabIndex = 17;
            this.label6.Text = "SEKRETER İŞLEMLERİ";
            // 
            // sekreterGridView
            // 
            this.sekreterGridView.AutoGenerateColumns = false;
            this.sekreterGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sekreterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sekreterGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.sekreterGridView.DataSource = this.sekreterBindingSource;
            this.sekreterGridView.Location = new System.Drawing.Point(388, 73);
            this.sekreterGridView.Name = "sekreterGridView";
            this.sekreterGridView.Size = new System.Drawing.Size(446, 173);
            this.sekreterGridView.TabIndex = 28;
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
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // sekreterBindingSource
            // 
            this.sekreterBindingSource.DataMember = "Sekreter";
            this.sekreterBindingSource.DataSource = this.hastane_DbDataSet4;
            // 
            // hastane_DbDataSet4
            // 
            this.hastane_DbDataSet4.DataSetName = "Hastane_DbDataSet4";
            this.hastane_DbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sekreterTableAdapter
            // 
            this.sekreterTableAdapter.ClearBeforeFill = true;
            // 
            // sekreterAdTextbox
            // 
            this.sekreterAdTextbox.Location = new System.Drawing.Point(168, 73);
            this.sekreterAdTextbox.Multiline = true;
            this.sekreterAdTextbox.Name = "sekreterAdTextbox";
            this.sekreterAdTextbox.Size = new System.Drawing.Size(199, 26);
            this.sekreterAdTextbox.TabIndex = 29;
            // 
            // sekreterSoyadTextbox
            // 
            this.sekreterSoyadTextbox.Location = new System.Drawing.Point(168, 108);
            this.sekreterSoyadTextbox.Multiline = true;
            this.sekreterSoyadTextbox.Name = "sekreterSoyadTextbox";
            this.sekreterSoyadTextbox.Size = new System.Drawing.Size(199, 26);
            this.sekreterSoyadTextbox.TabIndex = 30;
            // 
            // sekreterSifreMaskedTextbox
            // 
            this.sekreterSifreMaskedTextbox.Location = new System.Drawing.Point(168, 149);
            this.sekreterSifreMaskedTextbox.Mask = "00000000";
            this.sekreterSifreMaskedTextbox.Name = "sekreterSifreMaskedTextbox";
            this.sekreterSifreMaskedTextbox.Size = new System.Drawing.Size(199, 21);
            this.sekreterSifreMaskedTextbox.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 10);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 10);
            this.panel2.TabIndex = 33;
            // 
            // SekreterSekreterEkranıFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 279);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sekreterSifreMaskedTextbox);
            this.Controls.Add(this.sekreterSoyadTextbox);
            this.Controls.Add(this.sekreterAdTextbox);
            this.Controls.Add(this.sekreterGridView);
            this.Controls.Add(this.sekreterGeridonBtn);
            this.Controls.Add(this.sekreterSilBtn);
            this.Controls.Add(this.sekreterGüncelleBtn);
            this.Controls.Add(this.sekreterEkleBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SekreterSekreterEkranıFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Ekle/Kaldır";
            this.Load += new System.EventHandler(this.SekreterSekreterEkranıFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sekreterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_DbDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sekreterGeridonBtn;
        private System.Windows.Forms.Button sekreterSilBtn;
        private System.Windows.Forms.Button sekreterGüncelleBtn;
        private System.Windows.Forms.Button sekreterEkleBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView sekreterGridView;
        private Hastane_DbDataSet4 hastane_DbDataSet4;
        private System.Windows.Forms.BindingSource sekreterBindingSource;
        private Hastane_DbDataSet4TableAdapters.SekreterTableAdapter sekreterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox sekreterAdTextbox;
        private System.Windows.Forms.TextBox sekreterSoyadTextbox;
        private System.Windows.Forms.MaskedTextBox sekreterSifreMaskedTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}