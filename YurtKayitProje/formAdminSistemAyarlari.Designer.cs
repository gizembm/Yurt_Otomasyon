namespace YurtKayitProje
{
    partial class formAdminSistemAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdminSistemAyarlari));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPathRestore = new System.Windows.Forms.TextBox();
            this.btnPathRestore = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbgeriDon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yedekleme Yolu\r\n";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtServer.Location = new System.Drawing.Point(132, 106);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(181, 22);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "PC\\SQLEXPRESS";
            // 
            // txtDatabase
            // 
            this.txtDatabase.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtDatabase.Location = new System.Drawing.Point(132, 134);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(181, 22);
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.Text = "YurtOtomasyonVTYS";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPath.Location = new System.Drawing.Point(133, 166);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(181, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnYedekle
            // 
            this.btnYedekle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekle.Location = new System.Drawing.Point(215, 194);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(99, 31);
            this.btnYedekle.TabIndex = 2;
            this.btnYedekle.Text = "YEDEKLE";
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPath.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPath.Location = new System.Drawing.Point(320, 166);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(39, 22);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestore.Location = new System.Drawing.Point(609, 190);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(188, 35);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "YEDEKTEN DÖN";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(405, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yedekten Dönülecek \r\n              Yol";
            // 
            // txtPathRestore
            // 
            this.txtPathRestore.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPathRestore.Location = new System.Drawing.Point(560, 157);
            this.txtPathRestore.Name = "txtPathRestore";
            this.txtPathRestore.Size = new System.Drawing.Size(181, 22);
            this.txtPathRestore.TabIndex = 1;
            // 
            // btnPathRestore
            // 
            this.btnPathRestore.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPathRestore.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPathRestore.Location = new System.Drawing.Point(747, 157);
            this.btnPathRestore.Name = "btnPathRestore";
            this.btnPathRestore.Size = new System.Drawing.Size(39, 22);
            this.btnPathRestore.TabIndex = 2;
            this.btnPathRestore.Text = "...";
            this.btnPathRestore.UseVisualStyleBackColor = false;
            this.btnPathRestore.Click += new System.EventHandler(this.btnPathRestore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.pbgeriDon.Click += new System.EventHandler(this.pbgeriDon_Click_1);
            // 
            // formAdminSistemAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(143)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(809, 452);
            this.Controls.Add(this.pbgeriDon);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnPathRestore);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPathRestore);
            this.Controls.Add(this.btnYedekle);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formAdminSistemAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİSTEM AYARLARI";
            this.Load += new System.EventHandler(this.formSistemAyarlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbgeriDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPathRestore;
        private System.Windows.Forms.Button btnPathRestore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbgeriDon;
    }
}