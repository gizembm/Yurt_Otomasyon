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
    public partial class formAdminYetkilendirmeRaporlama : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        DataTable tablo = new DataTable();
        public formAdminYetkilendirmeRaporlama()
        {
            InitializeComponent();
        }

        private void formAdminYetkilendirmeRaporlama_Load(object sender, EventArgs e)
        {
            SqlDataAdapter komut = new SqlDataAdapter(@"SELECT * FROM KULLANICI WHERE rol<> 'admin'", baglanti);
            komut.Fill(tablo);
            adminYetkilendirmeRapor rapor = new adminYetkilendirmeRapor();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
