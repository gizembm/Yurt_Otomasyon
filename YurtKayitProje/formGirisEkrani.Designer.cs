namespace YurtKayitProje
{
    partial class formGirisEkrani
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
            this.cbSifreGoster = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSifreGoster
            // 
            this.cbSifreGoster.AutoSize = true;
            this.cbSifreGoster.Location = new System.Drawing.Point(460, 218);
            this.cbSifreGoster.Name = "cbSifreGoster";
            this.cbSifreGoster.Size = new System.Drawing.Size(140, 20);
            this.cbSifreGoster.TabIndex = 16;
            this.cbSifreGoster.Text = "ŞİFREYİ GÖSTER";
            this.cbSifreGoster.UseVisualStyleBackColor = true;
            this.cbSifreGoster.CheckedChanged += new System.EventHandler(this.cbSifreGoster_CheckedChanged_1);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(344, 258);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(98, 32);
            this.btnGiris.TabIndex = 15;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click_1);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(304, 216);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(138, 22);
            this.txtSifre.TabIndex = 13;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged_1);
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(304, 161);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(138, 22);
            this.txtKullanıcıAdı.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "ŞİFRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "KULLANICI ADI";
            // 
            // formGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSifreGoster);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formGirisEkrani";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSifreGoster;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

