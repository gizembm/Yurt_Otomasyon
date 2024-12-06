namespace YurtKayitProje
{
    partial class formAdminYetkilendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdminYetkilendirme));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvYetkilendirmeListesi = new System.Windows.Forms.DataGridView();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıId = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAd = new System.Windows.Forms.TextBox();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.pbgeriDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkilendirmeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExport.Location = new System.Drawing.Point(639, 374);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(140, 41);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "VERİYİ ÇEK";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnImport.Location = new System.Drawing.Point(493, 374);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(140, 41);
            this.btnImport.TabIndex = 15;
            this.btnImport.Text = "VERİYİ AL";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(157, 280);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(140, 41);
            this.btnListele.TabIndex = 16;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(157, 232);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(140, 42);
            this.btnGüncelle.TabIndex = 17;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(11, 280);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(140, 41);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(11, 232);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 42);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvYetkilendirmeListesi
            // 
            this.dgvYetkilendirmeListesi.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvYetkilendirmeListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYetkilendirmeListesi.Location = new System.Drawing.Point(324, 46);
            this.dgvYetkilendirmeListesi.Name = "dgvYetkilendirmeListesi";
            this.dgvYetkilendirmeListesi.RowHeadersWidth = 51;
            this.dgvYetkilendirmeListesi.RowTemplate.Height = 24;
            this.dgvYetkilendirmeListesi.Size = new System.Drawing.Size(455, 311);
            this.dgvYetkilendirmeListesi.TabIndex = 13;
            this.dgvYetkilendirmeListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYetkilendirmeListesi_CellClick);
            this.dgvYetkilendirmeListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYetkilendirmeListesi_CellContentClick);
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmbRol.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "personel",
            "öğrenci",
            "admin"});
            this.cmbRol.Location = new System.Drawing.Point(110, 168);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(187, 29);
            this.cmbRol.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-2, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kullanıcı ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-2, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kullanıcı adı";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSifre.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(110, 125);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(187, 28);
            this.txtSifre.TabIndex = 5;
            // 
            // txtKullanıcıId
            // 
            this.txtKullanıcıId.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtKullanıcıId.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıId.Location = new System.Drawing.Point(110, 46);
            this.txtKullanıcıId.Name = "txtKullanıcıId";
            this.txtKullanıcıId.Size = new System.Drawing.Size(187, 28);
            this.txtKullanıcıId.TabIndex = 6;
            // 
            // txtKullanıcıAd
            // 
            this.txtKullanıcıAd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtKullanıcıAd.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAd.Location = new System.Drawing.Point(110, 87);
            this.txtKullanıcıAd.Name = "txtKullanıcıAd";
            this.txtKullanıcıAd.Size = new System.Drawing.Size(187, 28);
            this.txtKullanıcıAd.TabIndex = 7;
            // 
            // btnRaporla
            // 
            this.btnRaporla.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporla.Location = new System.Drawing.Point(676, 12);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(103, 28);
            this.btnRaporla.TabIndex = 20;
            this.btnRaporla.Text = "RAPORLA";
            this.btnRaporla.UseVisualStyleBackColor = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // pbgeriDon
            // 
            this.pbgeriDon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbgeriDon.Image = ((System.Drawing.Image)(resources.GetObject("pbgeriDon.Image")));
            this.pbgeriDon.Location = new System.Drawing.Point(15, 12);
            this.pbgeriDon.Name = "pbgeriDon";
            this.pbgeriDon.Size = new System.Drawing.Size(46, 30);
            this.pbgeriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbgeriDon.TabIndex = 21;
            this.pbgeriDon.TabStop = false;
            this.pbgeriDon.Click += new System.EventHandler(this.pbgeriDon_Click);
            // 
            // formAdminYetkilendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(143)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.pbgeriDon);
            this.Controls.Add(this.btnRaporla);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvYetkilendirmeListesi);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcıId);
            this.Controls.Add(this.txtKullanıcıAd);
            this.Name = "formAdminYetkilendirme";
            this.Text = "YETKİLENDİRME";
            this.Load += new System.EventHandler(this.formYetkilendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkilendirmeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvYetkilendirmeListesi;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanıcıId;
        private System.Windows.Forms.TextBox txtKullanıcıAd;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.PictureBox pbgeriDon;
    }
}