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
    public partial class formPersonelGiris : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public formPersonelGiris()
        {
            InitializeComponent();
        }

        private void formPersonelGiris_Load(object sender, EventArgs e)
        {
            txtAdSoyad.Enabled = false;
            txtGorev.Enabled = false;


            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(@"SELECT 
                                                  
                                                 P.personelAdSoyad, 
                                                 P.personelTel, 
                                                 G.gorevAd
                                                 FROM 
                                                     PERSONEL P
                                                 JOIN 
                                                     GOREV G
                                                 ON 
                                                  P.gorevID = G.gorevID
												  where P.kullaniciID = @kullaniciID", baglanti);

                komut.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);


                SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    txtAdSoyad.Text = reader["personelAdSoyad"].ToString();
                    txtTelNo.Text = reader["personelTel"].ToString();
                    txtGorev.Text = reader["gorevAd"].ToString();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (txtTelNo.Text.Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 hane olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // İşlem devam etmesin
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(@"UPDATE PERSONEL SET personelTel = @personelTel
                                                  WHERE kullaniciID = @kullaniciID", baglanti);


                komut.Parameters.AddWithValue("@personelTel", txtTelNo.Text);
               
                komut.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);

                komut.ExecuteNonQuery();
                MessageBox.Show("Bilgiler başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnGorevliOdalar_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();


                SqlCommand cmd = new SqlCommand(@"SELECT 
                                                 O.odaNo,
                                                 O.odaKapasite,
                                                 P.personelID
                                                 FROM ODALAR O 
                                                 JOIN
                                                 PERSONEL P 
                                                 ON O.PersonelID = P.PersonelID
												 WHERE P.kullaniciID  = @kullaniciID;", baglanti);

                cmd.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvSorumluOdalar.DataSource = dt;



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Listeleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
    }
}
