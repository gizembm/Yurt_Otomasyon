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
    public partial class formAdminYatakDurumRaporu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataTable tablo = new DataTable();
        public formAdminYatakDurumRaporu()
        {
            InitializeComponent();
        }

        private void formAdminYatakDurumRaporu_Load(object sender, EventArgs e)
        {
            SqlDataAdapter komut = new SqlDataAdapter(@"SELECT yatakNo, 
                                                              CASE 
                                                                  WHEN yatakDurum = 1 THEN 'DOLU' 
                                                                  WHEN yatakDurum = 0 THEN 'BOŞ' 
                                                              END AS yatakDurum, 
                                                              odaNo 
                                                       FROM YATAKLAR", baglanti);
            komut.Fill(tablo);
            adminYatakDurumRaporu rapor = new adminYatakDurumRaporu();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
