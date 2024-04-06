namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    partial class GirisFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFrm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sekreterBtn = new System.Windows.Forms.Button();
            this.doktorBtn = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(189, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "SEKRETER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(200, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "DOKTOR";
            // 
            // sekreterBtn
            // 
            this.sekreterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sekreterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sekreterBtn.BackgroundImage")));
            this.sekreterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sekreterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sekreterBtn.Location = new System.Drawing.Point(208, 275);
            this.sekreterBtn.Name = "sekreterBtn";
            this.sekreterBtn.Size = new System.Drawing.Size(132, 133);
            this.sekreterBtn.TabIndex = 5;
            this.sekreterBtn.UseVisualStyleBackColor = false;
            this.sekreterBtn.Click += new System.EventHandler(this.sekreterBtn_Click);
            // 
            // doktorBtn
            // 
            this.doktorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.doktorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doktorBtn.BackgroundImage")));
            this.doktorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doktorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doktorBtn.Location = new System.Drawing.Point(208, 82);
            this.doktorBtn.Name = "doktorBtn";
            this.doktorBtn.Size = new System.Drawing.Size(137, 133);
            this.doktorBtn.TabIndex = 4;
            this.doktorBtn.UseVisualStyleBackColor = false;
            this.doktorBtn.Click += new System.EventHandler(this.doktorBtn_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Location = new System.Drawing.Point(366, 82);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(450, 350);
            this.LoginPanel.TabIndex = 8;
            // 
            // GirisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(839, 466);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sekreterBtn);
            this.Controls.Add(this.doktorBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GirisFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ PANELİ";
            this.Load += new System.EventHandler(this.GirisFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sekreterBtn;
        private System.Windows.Forms.Button doktorBtn;
        private System.Windows.Forms.Panel LoginPanel;
    }
}