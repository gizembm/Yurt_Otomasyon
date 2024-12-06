namespace YurtKayitProje
{
    partial class formAdminOgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdminOgrenciGiris));
            this.dgvOgrenciListele = new System.Windows.Forms.DataGridView();
            this.dgvIzin = new System.Windows.Forms.DataGridView();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtKanGrubu = new System.Windows.Forms.TextBox();
            this.txtMailAdresi = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtVeliTelNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnIzınListele = new System.Windows.Forms.Button();
            this.btnIzinEkle = new System.Windows.Forms.Button();
            this.btnIzinSil = new System.Windows.Forms.Button();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOgrenciRaporla = new System.Windows.Forms.Button();
            this.btnIzinRaporla = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.pbgeriDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenciListele
            // 
            this.dgvOgrenciListele.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvOgrenciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciListele.Location = new System.Drawing.Point(295, 47);
            this.dgvOgrenciListele.Name = "dgvOgrenciListele";
            this.dgvOgrenciListele.RowHeadersWidth = 51;
            this.dgvOgrenciListele.RowTemplate.Height = 24;
            this.dgvOgrenciListele.Size = new System.Drawing.Size(572, 417);
            this.dgvOgrenciListele.TabIndex = 0;
            this.dgvOgrenciListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciListele_CellClick);
            // 
            // dgvIzin
            // 
            this.dgvIzin.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvIzin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzin.Location = new System.Drawing.Point(1152, 47);
            this.dgvIzin.Name = "dgvIzin";
            this.dgvIzin.RowHeadersWidth = 51;
            this.dgvIzin.RowTemplate.Height = 24;
            this.dgvIzin.Size = new System.Drawing.Size(717, 417);
            this.dgvIzin.TabIndex = 0;
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtTcNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(116, 47);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(162, 25);
            this.txtTcNo.TabIndex = 1;
            this.txtTcNo.Click += new System.EventHandler(this.txtTcNo_Click);
            this.txtTcNo.TextChanged += new System.EventHandler(this.txtTcNo_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSoyad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(116, 131);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(162, 25);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Click += new System.EventHandler(this.txtSoyad_Click);
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtAdres.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(116, 170);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(162, 25);
            this.txtAdres.TabIndex = 1;
            this.txtAdres.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtKanGrubu
            // 
            this.txtKanGrubu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtKanGrubu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKanGrubu.Location = new System.Drawing.Point(116, 203);
            this.txtKanGrubu.Name = "txtKanGrubu";
            this.txtKanGrubu.Size = new System.Drawing.Size(162, 25);
            this.txtKanGrubu.TabIndex = 1;
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtMailAdresi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMailAdresi.Location = new System.Drawing.Point(116, 241);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(162, 25);
            this.txtMailAdresi.TabIndex = 1;
            this.txtMailAdresi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTelNo
            // 
            this.txtTelNo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtTelNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.Location = new System.Drawing.Point(116, 326);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(162, 25);
            this.txtTelNo.TabIndex = 1;
            this.txtTelNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtVeliTelNo
            // 
            this.txtVeliTelNo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtVeliTelNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliTelNo.Location = new System.Drawing.Point(116, 370);
            this.txtVeliTelNo.Name = "txtVeliTelNo";
            this.txtVeliTelNo.Size = new System.Drawing.Size(162, 25);
            this.txtVeliTelNo.TabIndex = 1;
            this.txtVeliTelNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kan Grubu";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(12, 244);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Mail Adresi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Veli Telefon No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Telefon No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Doğum Tarihi";
            // 
            // dtpDogumTarih
            // 
            this.dtpDogumTarih.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogumTarih.Location = new System.Drawing.Point(116, 284);
            this.dtpDogumTarih.Name = "dtpDogumTarih";
            this.dtpDogumTarih.Size = new System.Drawing.Size(162, 25);
            this.dtpDogumTarih.TabIndex = 3;
            this.dtpDogumTarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtOdaNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaNo.Location = new System.Drawing.Point(116, 409);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(162, 25);
            this.txtOdaNo.TabIndex = 1;
            this.txtOdaNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Oda No";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(311, 484);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 32);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(447, 484);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 32);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(583, 484);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 32);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(719, 484);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(130, 32);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CalendarMonthBackground = System.Drawing.Color.PaleTurquoise;
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangic.Location = new System.Drawing.Point(933, 239);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangic.TabIndex = 5;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitis.Location = new System.Drawing.Point(933, 300);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 22);
            this.dtpBitis.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(965, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "İzin Başlangıç Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(981, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "İzin Bitiş Tarihi";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtOgrNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrNo.Location = new System.Drawing.Point(1008, 170);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(125, 25);
            this.txtOgrNo.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(909, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Öğrenci No";
            // 
            // btnIzınListele
            // 
            this.btnIzınListele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzınListele.Location = new System.Drawing.Point(1701, 470);
            this.btnIzınListele.Name = "btnIzınListele";
            this.btnIzınListele.Size = new System.Drawing.Size(168, 32);
            this.btnIzınListele.TabIndex = 4;
            this.btnIzınListele.Text = "İZİNLERİ LİSTELE";
            this.btnIzınListele.UseVisualStyleBackColor = true;
            this.btnIzınListele.Click += new System.EventHandler(this.btnIzinListele_Click);
            // 
            // btnIzinEkle
            // 
            this.btnIzinEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinEkle.Location = new System.Drawing.Point(1577, 470);
            this.btnIzinEkle.Name = "btnIzinEkle";
            this.btnIzinEkle.Size = new System.Drawing.Size(118, 32);
            this.btnIzinEkle.TabIndex = 9;
            this.btnIzinEkle.Text = "İZİN EKLE";
            this.btnIzinEkle.UseVisualStyleBackColor = true;
            this.btnIzinEkle.Click += new System.EventHandler(this.btnIzinEkle_Click);
            // 
            // btnIzinSil
            // 
            this.btnIzinSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinSil.Location = new System.Drawing.Point(1453, 470);
            this.btnIzinSil.Name = "btnIzinSil";
            this.btnIzinSil.Size = new System.Drawing.Size(118, 32);
            this.btnIzinSil.TabIndex = 10;
            this.btnIzinSil.Text = "SİL";
            this.btnIzinSil.UseVisualStyleBackColor = true;
            this.btnIzinSil.Click += new System.EventHandler(this.btnIzinSil_Click);
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtKullaniciID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciID.Location = new System.Drawing.Point(116, 442);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(162, 25);
            this.txtKullaniciID.TabIndex = 1;
            this.txtKullaniciID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(12, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Kullanıcı ID";
            // 
            // btnOgrenciRaporla
            // 
            this.btnOgrenciRaporla.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciRaporla.Location = new System.Drawing.Point(754, 14);
            this.btnOgrenciRaporla.Name = "btnOgrenciRaporla";
            this.btnOgrenciRaporla.Size = new System.Drawing.Size(113, 29);
            this.btnOgrenciRaporla.TabIndex = 11;
            this.btnOgrenciRaporla.Text = "RAPORLA";
            this.btnOgrenciRaporla.UseVisualStyleBackColor = true;
            this.btnOgrenciRaporla.Click += new System.EventHandler(this.btnOgrenciRaporla_Click);
            // 
            // btnIzinRaporla
            // 
            this.btnIzinRaporla.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinRaporla.Location = new System.Drawing.Point(1740, 14);
            this.btnIzinRaporla.Name = "btnIzinRaporla";
            this.btnIzinRaporla.Size = new System.Drawing.Size(129, 30);
            this.btnIzinRaporla.TabIndex = 11;
            this.btnIzinRaporla.Text = "RAPORLA";
            this.btnIzinRaporla.UseVisualStyleBackColor = true;
            this.btnIzinRaporla.Click += new System.EventHandler(this.btnIzinRaporla_Click);
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(116, 94);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(162, 25);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // pbgeriDon
            // 
            this.pbgeriDon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbgeriDon.Image = ((System.Drawing.Image)(resources.GetObject("pbgeriDon.Image")));
            this.pbgeriDon.Location = new System.Drawing.Point(15, 11);
            this.pbgeriDon.Name = "pbgeriDon";
            this.pbgeriDon.Size = new System.Drawing.Size(46, 30);
            this.pbgeriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbgeriDon.TabIndex = 12;
            this.pbgeriDon.TabStop = false;
            this.pbgeriDon.Click += new System.EventHandler(this.pbgeriDon_Click);
            // 
            // formAdminOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(143)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1881, 527);
            this.Controls.Add(this.pbgeriDon);
            this.Controls.Add(this.btnIzinRaporla);
            this.Controls.Add(this.btnOgrenciRaporla);
            this.Controls.Add(this.btnIzinSil);
            this.Controls.Add(this.btnIzinEkle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.btnIzınListele);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpDogumTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.txtVeliTelNo);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMailAdresi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtKanGrubu);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.dgvIzin);
            this.Controls.Add(this.dgvOgrenciListele);
            this.Name = "formAdminOgrenciGiris";
            this.Text = "Admin Ogrenci İşlemleri";
            this.Load += new System.EventHandler(this.formAdminOgrenciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenciListele;
        private System.Windows.Forms.DataGridView dgvIzin;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtKanGrubu;
        private System.Windows.Forms.TextBox txtMailAdresi;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtVeliTelNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDogumTarih;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnIzınListele;
        private System.Windows.Forms.Button btnIzinEkle;
        private System.Windows.Forms.Button btnIzinSil;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOgrenciRaporla;
        private System.Windows.Forms.Button btnIzinRaporla;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.PictureBox pbgeriDon;
    }
}