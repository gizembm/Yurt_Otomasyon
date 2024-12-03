namespace YurtKayitProje
{
    partial class formSistemAyarlari
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Path";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(117, 115);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(181, 22);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "PC\\SQLEXPRESS";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(117, 143);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(181, 22);
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.Text = "YurtOtomasyonVTYS";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(118, 175);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(181, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnYedekle
            // 
            this.btnYedekle.Location = new System.Drawing.Point(219, 199);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(79, 31);
            this.btnYedekle.TabIndex = 2;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(305, 175);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(39, 22);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(595, 162);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(141, 35);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "YEDEKTEN DÖN";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Path";
            // 
            // txtPathRestore
            // 
            this.txtPathRestore.Location = new System.Drawing.Point(510, 134);
            this.txtPathRestore.Name = "txtPathRestore";
            this.txtPathRestore.Size = new System.Drawing.Size(181, 22);
            this.txtPathRestore.TabIndex = 1;
            // 
            // btnPathRestore
            // 
            this.btnPathRestore.Location = new System.Drawing.Point(697, 134);
            this.btnPathRestore.Name = "btnPathRestore";
            this.btnPathRestore.Size = new System.Drawing.Size(39, 22);
            this.btnPathRestore.TabIndex = 2;
            this.btnPathRestore.Text = "...";
            this.btnPathRestore.UseVisualStyleBackColor = true;
            this.btnPathRestore.Click += new System.EventHandler(this.btnPathRestore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // formSistemAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 452);
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
            this.Name = "formSistemAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formSistemAyarlari";
            this.Load += new System.EventHandler(this.formSistemAyarlari_Load);
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
    }
}