namespace YurtKayitProje
{
    partial class formAdminGiris
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
            this.btnPersonelİslemleri = new System.Windows.Forms.Button();
            this.btnOgrenciIslemleri = new System.Windows.Forms.Button();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.btnSistemAyarlari = new System.Windows.Forms.Button();
            this.btnYetkilendirme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonelİslemleri
            // 
            this.btnPersonelİslemleri.Location = new System.Drawing.Point(498, 148);
            this.btnPersonelİslemleri.Name = "btnPersonelİslemleri";
            this.btnPersonelİslemleri.Size = new System.Drawing.Size(151, 59);
            this.btnPersonelİslemleri.TabIndex = 1;
            this.btnPersonelİslemleri.Text = "PERSONEL İŞLEMLERİ";
            this.btnPersonelİslemleri.UseVisualStyleBackColor = true;
            this.btnPersonelİslemleri.Click += new System.EventHandler(this.btnPersonelİslemleri_Click);
            // 
            // btnOgrenciIslemleri
            // 
            this.btnOgrenciIslemleri.Location = new System.Drawing.Point(325, 148);
            this.btnOgrenciIslemleri.Name = "btnOgrenciIslemleri";
            this.btnOgrenciIslemleri.Size = new System.Drawing.Size(151, 59);
            this.btnOgrenciIslemleri.TabIndex = 2;
            this.btnOgrenciIslemleri.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.btnOgrenciIslemleri.UseVisualStyleBackColor = true;
            this.btnOgrenciIslemleri.Click += new System.EventHandler(this.btnOgrenciIslemleri_Click);
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.Location = new System.Drawing.Point(417, 244);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(151, 59);
            this.btnRaporlama.TabIndex = 3;
            this.btnRaporlama.Text = "RAPORLAMA";
            this.btnRaporlama.UseVisualStyleBackColor = true;
            this.btnRaporlama.Click += new System.EventHandler(this.btnRaporlama_Click);
            // 
            // btnSistemAyarlari
            // 
            this.btnSistemAyarlari.Location = new System.Drawing.Point(234, 244);
            this.btnSistemAyarlari.Name = "btnSistemAyarlari";
            this.btnSistemAyarlari.Size = new System.Drawing.Size(151, 59);
            this.btnSistemAyarlari.TabIndex = 5;
            this.btnSistemAyarlari.Text = "SİSTEM AYARLARI";
            this.btnSistemAyarlari.UseVisualStyleBackColor = true;
            this.btnSistemAyarlari.Click += new System.EventHandler(this.btnSistemAyarlari_Click);
            // 
            // btnYetkilendirme
            // 
            this.btnYetkilendirme.Location = new System.Drawing.Point(151, 148);
            this.btnYetkilendirme.Name = "btnYetkilendirme";
            this.btnYetkilendirme.Size = new System.Drawing.Size(151, 59);
            this.btnYetkilendirme.TabIndex = 6;
            this.btnYetkilendirme.Text = "YETKİLENDİRME";
            this.btnYetkilendirme.UseVisualStyleBackColor = true;
            this.btnYetkilendirme.Click += new System.EventHandler(this.btnYetkilendirme_Click);
            // 
            // formAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPersonelİslemleri);
            this.Controls.Add(this.btnOgrenciIslemleri);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.btnSistemAyarlari);
            this.Controls.Add(this.btnYetkilendirme);
            this.Name = "formAdminGiris";
            this.Text = "formAdminGiris";
            this.Load += new System.EventHandler(this.formAdminGiris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelİslemleri;
        private System.Windows.Forms.Button btnOgrenciIslemleri;
        private System.Windows.Forms.Button btnRaporlama;
        private System.Windows.Forms.Button btnSistemAyarlari;
        private System.Windows.Forms.Button btnYetkilendirme;
    }
}