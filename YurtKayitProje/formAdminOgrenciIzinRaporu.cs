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
    public partial class formAdminOgrenciIzinRaporu : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        DataTable tablo = new DataTable();
        public formAdminOgrenciIzinRaporu()
        {
            InitializeComponent();
        }

        private void formAdminOgrenciIzinRaporu_Load(object sender, EventArgs e)
        {
            SqlDataAdapter komut = new SqlDataAdapter(@"SELECT baslangıcTarih, bitisTarih, kalanIzin, ogrNo 
                                                       FROM IZIN", baglanti);
            komut.Fill(tablo);
            adminOgrenciIzinRaporu rapor = new adminOgrenciIzinRaporu();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
