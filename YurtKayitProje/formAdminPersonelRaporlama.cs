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

   
    public partial class formAdminPersonelRaporlama : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        DataTable tablo = new DataTable();
        public formAdminPersonelRaporlama()
        {
            InitializeComponent();
        }

        private void formAdminPersonelRaporlama_Load(object sender, EventArgs e)
        {
            SqlDataAdapter komut = new SqlDataAdapter(@"SELECT 
                                                 P.personelID, 
                                                 P.personelAdSoyad, 
                                                 P.personelTel, 
                                                 G.gorevAd,
                                                 P.gorevID, 
                                                 P.kullaniciID
                                                 FROM 
                                                     PERSONEL P
                                                 JOIN 
                                                     GOREV G
                                                 ON 
                                                     P.gorevID = G.gorevID;", baglanti);
            komut.Fill(tablo);
            adminPersonelRaporlama rapor = new adminPersonelRaporlama();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
    
}
