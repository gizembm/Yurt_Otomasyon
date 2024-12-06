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
    public partial class formOgrenciGiris : Form
    {
        public formOgrenciGiris()
        {
            InitializeComponent();
        }

        private void btnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            formOgrenciKisiselBilgiler kisiselBilgiler = new formOgrenciKisiselBilgiler();
            this.Hide();
            kisiselBilgiler.ShowDialog();
        }

        private void btnIzinAl_Click(object sender, EventArgs e)
        {
            formOgrenciIzin izin = new formOgrenciIzin();
            this.Hide();
            izin.ShowDialog();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            formOgrenciOdeme odeme = new formOgrenciOdeme();    
            this.Hide();
            odeme.ShowDialog();
        }

        private void formOgrenciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
