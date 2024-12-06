namespace YurtKayitProje
{
    partial class formOgrenciIzin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOgrenciIzin));
            this.btnIzinSil = new System.Windows.Forms.Button();
            this.btnIzinEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnIzınListele = new System.Windows.Forms.Button();
            this.dgvIzin = new System.Windows.Forms.DataGridView();
            this.pbgeriDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzinSil
            // 
            this.btnIzinSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinSil.Location = new System.Drawing.Point(466, 448);
            this.btnIzinSil.Name = "btnIzinSil";
            this.btnIzinSil.Size = new System.Drawing.Size(154, 32);
            this.btnIzinSil.TabIndex = 20;
            this.btnIzinSil.Text = "İZİN SİL";
            this.btnIzinSil.UseVisualStyleBackColor = true;
            this.btnIzinSil.Click += new System.EventHandler(this.btnIzinSil_Click);
            // 
            // btnIzinEkle
            // 
            this.btnIzinEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinEkle.Location = new System.Drawing.Point(626, 448);
            this.btnIzinEkle.Name = "btnIzinEkle";
            this.btnIzinEkle.Size = new System.Drawing.Size(154, 32);
            this.btnIzinEkle.TabIndex = 19;
            this.btnIzinEkle.Text = "İZİN EKLE";
            this.btnIzinEkle.UseVisualStyleBackColor = true;
            this.btnIzinEkle.Click += new System.EventHandler(this.btnIzinEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(113, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "İzin Bitiş Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(97, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "İzin Başlangıç Tarihi";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitis.Location = new System.Drawing.Point(65, 264);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 25);
            this.dtpBitis.TabIndex = 13;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangic.Location = new System.Drawing.Point(65, 203);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 25);
            this.dtpBaslangic.TabIndex = 14;
            // 
            // btnIzınListele
            // 
            this.btnIzınListele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzınListele.Location = new System.Drawing.Point(786, 448);
            this.btnIzınListele.Name = "btnIzınListele";
            this.btnIzınListele.Size = new System.Drawing.Size(166, 32);
            this.btnIzınListele.TabIndex = 12;
            this.btnIzınListele.Text = "İZİNLERİ LİSTELE\r\n";
            this.btnIzınListele.UseVisualStyleBackColor = true;
            this.btnIzınListele.Click += new System.EventHandler(this.btnIzınListele_Click);
            // 
            // dgvIzin
            // 
            this.dgvIzin.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvIzin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzin.Location = new System.Drawing.Point(314, 58);
            this.dgvIzin.Name = "dgvIzin";
            this.dgvIzin.RowHeadersWidth = 51;
            this.dgvIzin.RowTemplate.Height = 24;
            this.dgvIzin.Size = new System.Drawing.Size(650, 384);
            this.dgvIzin.TabIndex = 11;
            // 
            // pbgeriDon
            // 
            this.pbgeriDon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbgeriDon.Image = ((System.Drawing.Image)(resources.GetObject("pbgeriDon.Image")));
            this.pbgeriDon.Location = new System.Drawing.Point(12, 12);
            this.pbgeriDon.Name = "pbgeriDon";
            this.pbgeriDon.Size = new System.Drawing.Size(46, 30);
            this.pbgeriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbgeriDon.TabIndex = 21;
            this.pbgeriDon.TabStop = false;
            this.pbgeriDon.Click += new System.EventHandler(this.pbgeriDon_Click);
            // 
            // formOgrenciIzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(143)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1157, 546);
            this.Controls.Add(this.pbgeriDon);
            this.Controls.Add(this.btnIzinSil);
            this.Controls.Add(this.btnIzinEkle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.btnIzınListele);
            this.Controls.Add(this.dgvIzin);
            this.Name = "formOgrenciIzin";
            this.Text = "formOgrenciIzin";
            this.Load += new System.EventHandler(this.formOgrenciIzin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzinSil;
        private System.Windows.Forms.Button btnIzinEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Button btnIzınListele;
        private System.Windows.Forms.DataGridView dgvIzin;
        private System.Windows.Forms.PictureBox pbgeriDon;
    }
}