namespace YurtKayitProje
{
    partial class formOgrenciOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOgrenciOdeme));
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdenecekTutar = new System.Windows.Forms.TextBox();
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.pbgeriDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAy
            // 
            this.cmbAy.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Items.AddRange(new object[] {
            "EYLÜL",
            "EKİM",
            "KASIM",
            "ARALIK",
            "OCAK",
            "ŞUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN"});
            this.cmbAy.Location = new System.Drawing.Point(102, 195);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(154, 24);
            this.cmbAy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödenecek Tutar";
            // 
            // txtOdenecekTutar
            // 
            this.txtOdenecekTutar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtOdenecekTutar.Location = new System.Drawing.Point(156, 142);
            this.txtOdenecekTutar.Name = "txtOdenecekTutar";
            this.txtOdenecekTutar.Size = new System.Drawing.Size(100, 22);
            this.txtOdenecekTutar.TabIndex = 2;
            this.txtOdenecekTutar.Text = "550";
            // 
            // dgvOdemeler
            // 
            this.dgvOdemeler.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeler.Location = new System.Drawing.Point(317, 67);
            this.dgvOdemeler.Name = "dgvOdemeler";
            this.dgvOdemeler.RowHeadersWidth = 51;
            this.dgvOdemeler.RowTemplate.Height = 24;
            this.dgvOdemeler.Size = new System.Drawing.Size(476, 247);
            this.dgvOdemeler.TabIndex = 3;
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(164, 242);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(92, 25);
            this.btnOde.TabIndex = 4;
            this.btnOde.Text = "ÖDE";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeler.Location = new System.Drawing.Point(660, 320);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Size = new System.Drawing.Size(133, 25);
            this.btnOdemeler.TabIndex = 4;
            this.btnOdemeler.Text = "ÖDEMELER";
            this.btnOdemeler.UseVisualStyleBackColor = true;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);
            // 
            // pbgeriDon
            // 
            this.pbgeriDon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbgeriDon.Image = ((System.Drawing.Image)(resources.GetObject("pbgeriDon.Image")));
            this.pbgeriDon.Location = new System.Drawing.Point(12, 12);
            this.pbgeriDon.Name = "pbgeriDon";
            this.pbgeriDon.Size = new System.Drawing.Size(46, 30);
            this.pbgeriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbgeriDon.TabIndex = 13;
            this.pbgeriDon.TabStop = false;
            this.pbgeriDon.Click += new System.EventHandler(this.pbgeriDon_Click);
            // 
            // formOgrenciOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(143)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(834, 448);
            this.Controls.Add(this.pbgeriDon);
            this.Controls.Add(this.btnOdemeler);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.dgvOdemeler);
            this.Controls.Add(this.txtOdenecekTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAy);
            this.Name = "formOgrenciOdeme";
            this.Text = "formOgrenciOdeme";
            this.Load += new System.EventHandler(this.formOgrenciOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdenecekTutar;
        private System.Windows.Forms.DataGridView dgvOdemeler;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Button btnOdemeler;
        private System.Windows.Forms.PictureBox pbgeriDon;
    }
}