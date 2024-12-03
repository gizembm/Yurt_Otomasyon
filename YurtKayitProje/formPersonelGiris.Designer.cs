namespace YurtKayitProje
{
    partial class formPersonelGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.dgvSorumluOdalar = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGorevliOdalar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorumluOdalar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tel No";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(133, 100);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(165, 22);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(133, 146);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(165, 22);
            this.txtTelNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Görev";
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(133, 190);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(165, 22);
            this.txtGorev.TabIndex = 2;
            // 
            // dgvSorumluOdalar
            // 
            this.dgvSorumluOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorumluOdalar.Location = new System.Drawing.Point(345, 59);
            this.dgvSorumluOdalar.Name = "dgvSorumluOdalar";
            this.dgvSorumluOdalar.RowHeadersWidth = 51;
            this.dgvSorumluOdalar.RowTemplate.Height = 24;
            this.dgvSorumluOdalar.Size = new System.Drawing.Size(422, 216);
            this.dgvSorumluOdalar.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(158, 245);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(140, 30);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGorevliOdalar
            // 
            this.btnGorevliOdalar.Location = new System.Drawing.Point(486, 293);
            this.btnGorevliOdalar.Name = "btnGorevliOdalar";
            this.btnGorevliOdalar.Size = new System.Drawing.Size(281, 28);
            this.btnGorevliOdalar.TabIndex = 4;
            this.btnGorevliOdalar.Text = "GÖREVLİ OLUNAN ODALARI LİSTELE\r\n\r\n";
            this.btnGorevliOdalar.UseVisualStyleBackColor = true;
            this.btnGorevliOdalar.Click += new System.EventHandler(this.btnGorevliOdalar_Click);
            // 
            // formPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGorevliOdalar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvSorumluOdalar);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formPersonelGiris";
            this.Text = "formPersonelGiris";
            this.Load += new System.EventHandler(this.formPersonelGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorumluOdalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.DataGridView dgvSorumluOdalar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGorevliOdalar;
    }
}