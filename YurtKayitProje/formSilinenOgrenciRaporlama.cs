using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitProje
{
    public partial class formSilinenOgrenciRaporlama : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        DataTable tablo = new DataTable();
        public formSilinenOgrenciRaporlama()
        {
            InitializeComponent();
        }

        private void formRaporlama_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from SILINEN_OGRENCILER", baglanti);
            adtr.Fill(tablo);
            silinenOgrencilerRaporu rapor = new silinenOgrencilerRaporu();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;

        }
    }
}
