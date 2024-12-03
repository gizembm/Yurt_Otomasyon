using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitProje
{
    public partial class formAdminOgrenciRapor : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        DataTable tablo = new DataTable();
        public formAdminOgrenciRapor()
        {
            InitializeComponent();
        }

        private void formAdminOgrenciRapor_Load(object sender, EventArgs e)
        {
            SqlDataAdapter komut = new SqlDataAdapter(@"SELECT ogrNo, ogrTC, ogrAd, ogrSoyad, ogrTel, ogrMail, ogrAdres,
                                                 ogrVeliTel,ogrDogumTarih, ogrKanGrup, odaNo, kullaniciID FROM OGRENCI", baglanti);
            komut.Fill(tablo);
            adminOgrenciRaporu rapor = new adminOgrenciRaporu();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;

        }
    }
}
