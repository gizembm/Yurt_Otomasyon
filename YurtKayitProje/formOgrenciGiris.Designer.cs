﻿namespace YurtKayitProje
{
    partial class formOgrenciGiris
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
            this.btnKisiselBilgiler = new System.Windows.Forms.Button();
            this.btnIzinAl = new System.Windows.Forms.Button();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKisiselBilgiler
            // 
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(52, 179);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(228, 85);
            this.btnKisiselBilgiler.TabIndex = 0;
            this.btnKisiselBilgiler.Text = "KİŞİSEL BİLGİLER";
            this.btnKisiselBilgiler.UseVisualStyleBackColor = true;
            this.btnKisiselBilgiler.Click += new System.EventHandler(this.btnKisiselBilgiler_Click);
            // 
            // btnIzinAl
            // 
            this.btnIzinAl.Location = new System.Drawing.Point(590, 179);
            this.btnIzinAl.Name = "btnIzinAl";
            this.btnIzinAl.Size = new System.Drawing.Size(228, 85);
            this.btnIzinAl.TabIndex = 0;
            this.btnIzinAl.Text = "İZİN AL";
            this.btnIzinAl.UseVisualStyleBackColor = true;
            this.btnIzinAl.Click += new System.EventHandler(this.btnIzinAl_Click);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(322, 179);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(228, 85);
            this.btnOdemeYap.TabIndex = 0;
            this.btnOdemeYap.Text = "ÖDEME YAP";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // formOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 468);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.btnIzinAl);
            this.Controls.Add(this.btnKisiselBilgiler);
            this.Name = "formOgrenciGiris";
            this.Text = "formOgrenciGiris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKisiselBilgiler;
        private System.Windows.Forms.Button btnIzinAl;
        private System.Windows.Forms.Button btnOdemeYap;
    }
}