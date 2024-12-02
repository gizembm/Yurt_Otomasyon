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
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdenecekTutar = new System.Windows.Forms.TextBox();
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAy
            // 
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
            this.label1.Location = new System.Drawing.Point(31, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödenecek Tutar";
            // 
            // txtOdenecekTutar
            // 
            this.txtOdenecekTutar.Location = new System.Drawing.Point(156, 142);
            this.txtOdenecekTutar.Name = "txtOdenecekTutar";
            this.txtOdenecekTutar.Size = new System.Drawing.Size(100, 22);
            this.txtOdenecekTutar.TabIndex = 2;
            // 
            // dgvOdemeler
            // 
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
            this.btnOde.Location = new System.Drawing.Point(164, 242);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(92, 25);
            this.btnOde.TabIndex = 4;
            this.btnOde.Text = "ÖDE";
            this.btnOde.UseVisualStyleBackColor = true;
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.Location = new System.Drawing.Point(701, 333);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Size = new System.Drawing.Size(92, 25);
            this.btnOdemeler.TabIndex = 4;
            this.btnOdemeler.Text = "ÖDEMELER";
            this.btnOdemeler.UseVisualStyleBackColor = true;
            // 
            // formOgrenciOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 448);
            this.Controls.Add(this.btnOdemeler);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.dgvOdemeler);
            this.Controls.Add(this.txtOdenecekTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAy);
            this.Name = "formOgrenciOdeme";
            this.Text = "formOgrenciOdeme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
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
    }
}