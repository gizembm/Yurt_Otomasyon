using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitProje
{
    public partial class formAdminGiris : Form
    {


        public formAdminGiris()
        {
            InitializeComponent();
        }

        private void formAdminGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void btnYetkilendirme_Click(object sender, EventArgs e)
        {
            formYetkilendirme yetkilendirme = new formYetkilendirme();
            this.Hide();
            yetkilendirme.ShowDialog();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            formAdminOgrenciGiris ogrenciGiris = new formAdminOgrenciGiris();
            this.Hide();
            ogrenciGiris.ShowDialog();
        }

        private void btnPersonelİslemleri_Click(object sender, EventArgs e)
        {
            formAdminPersonelGiris personelGiris = new formAdminPersonelGiris();
            this.Hide();
            personelGiris.ShowDialog();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            formSilinenOgrenciRaporlama raporlama = new formSilinenOgrenciRaporlama();  
            this.Hide();
            raporlama.ShowDialog();
        }

        private void btnSistemAyarlari_Click(object sender, EventArgs e)
        {
            formSistemAyarlari sistem = new formSistemAyarlari();
            this.Hide();
            sistem.ShowDialog();
        }
    }
}
