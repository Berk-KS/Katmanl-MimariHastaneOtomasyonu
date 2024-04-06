namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    partial class DoktorGirisEkranFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.drgirisBtn = new System.Windows.Forms.Button();
            this.doktorSifre = new System.Windows.Forms.RichTextBox();
            this.doktorAd = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 20);
            this.panel2.TabIndex = 14;
            // 
            // drgirisBtn
            // 
            this.drgirisBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.drgirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drgirisBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drgirisBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drgirisBtn.Location = new System.Drawing.Point(35, 250);
            this.drgirisBtn.Name = "drgirisBtn";
            this.drgirisBtn.Size = new System.Drawing.Size(378, 58);
            this.drgirisBtn.TabIndex = 17;
            this.drgirisBtn.Text = "GİRİŞ YAP";
            this.drgirisBtn.UseVisualStyleBackColor = false;
            this.drgirisBtn.Click += new System.EventHandler(this.drgirisBtn_Click);
            // 
            // doktorSifre
            // 
            this.doktorSifre.BackColor = System.Drawing.Color.LightCyan;
            this.doktorSifre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorSifre.Location = new System.Drawing.Point(200, 180);
            this.doktorSifre.Name = "doktorSifre";
            this.doktorSifre.Size = new System.Drawing.Size(230, 35);
            this.doktorSifre.TabIndex = 16;
            this.doktorSifre.Text = "";
            // 
            // doktorAd
            // 
            this.doktorAd.BackColor = System.Drawing.Color.LightCyan;
            this.doktorAd.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorAd.Location = new System.Drawing.Point(200, 125);
            this.doktorAd.Name = "doktorAd";
            this.doktorAd.Size = new System.Drawing.Size(230, 35);
            this.doktorAd.TabIndex = 15;
            this.doktorAd.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 22);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(100, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Şifre :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Doktor Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // DoktorGirisEkranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.drgirisBtn);
            this.Controls.Add(this.doktorSifre);
            this.Controls.Add(this.doktorAd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoktorGirisEkranFrm";
            this.Text = "DoktorGirisEkranFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button drgirisBtn;
        private System.Windows.Forms.RichTextBox doktorSifre;
        private System.Windows.Forms.RichTextBox doktorAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}