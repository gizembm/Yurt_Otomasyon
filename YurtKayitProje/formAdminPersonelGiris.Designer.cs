namespace YurtKayitProje
{
    partial class formAdminPersonelGiris
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPeronelListele = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGorevAd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeronelListele)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(180, 144);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(180, 237);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(146, 22);
            this.txtTel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(647, 409);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 29);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Görev";
            // 
            // dgvPeronelListele
            // 
            this.dgvPeronelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeronelListele.Location = new System.Drawing.Point(393, 81);
            this.dgvPeronelListele.Name = "dgvPeronelListele";
            this.dgvPeronelListele.RowHeadersWidth = 51;
            this.dgvPeronelListele.RowTemplate.Height = 24;
            this.dgvPeronelListele.Size = new System.Drawing.Size(684, 298);
            this.dgvPeronelListele.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(756, 409);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 29);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(865, 409);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 29);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(974, 409);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(103, 29);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(180, 188);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(146, 22);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ad-Soyad";
            // 
            // cmbGorevAd
            // 
            this.cmbGorevAd.FormattingEnabled = true;
            this.cmbGorevAd.Items.AddRange(new object[] {
            "TEMİZLİKÇİ",
            "BELETMEN",
            "MÜDÜR",
            "GÜVENLİK",
            "HEMŞİRE"});
            this.cmbGorevAd.Location = new System.Drawing.Point(180, 281);
            this.cmbGorevAd.Name = "cmbGorevAd";
            this.cmbGorevAd.Size = new System.Drawing.Size(146, 24);
            this.cmbGorevAd.TabIndex = 5;
            // 
            // formAdminPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 495);
            this.Controls.Add(this.cmbGorevAd);
            this.Controls.Add(this.dgvPeronelListele);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtID);
            this.Name = "formAdminPersonelGiris";
            this.Text = "formPersonelGiris";
            this.Load += new System.EventHandler(this.formAdminPersonelGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeronelListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPeronelListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGorevAd;
    }
}