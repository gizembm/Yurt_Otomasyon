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
    public partial class formOgrenciKisiselBilgiler : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public formOgrenciKisiselBilgiler()
        {
            InitializeComponent();
        }


        private void formOgrenciKisiselBilgiler_Load(object sender, EventArgs e)
        {

            txtTcNo.Enabled = false;
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtOdaNo.Enabled = false;
            dtpDogumTarih.Enabled = false;


            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT ogrTC, ogrAd, ogrSoyad, ogrTel, ogrMail, ogrAdres, ogrVeliTel, ogrKanGrup, odaNo, ogrDogumTarih  FROM OGRENCI WHERE kullaniciID = @kullaniciID", baglanti);

                komut.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);


                SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    txtTcNo.Text = reader["ogrTC"].ToString();
                    txtAd.Text = reader["ogrAd"].ToString();
                    txtSoyad.Text = reader["ogrSoyad"].ToString();
                    txtKanGrup.Text = reader["ogrKanGrup"].ToString();
                    txtMail.Text = reader["ogrMail"].ToString();
                    txtTelNo.Text = reader["ogrTel"].ToString();
                    txtVeliTel.Text = reader["ogrVeliTel"].ToString();
                    txtAdres.Text = reader["ogrAdres"].ToString();
                    txtOdaNo.Text = reader["odaNo"].ToString();
                    dtpDogumTarih.Value = Convert.ToDateTime(reader["ogrDogumTarih"]);

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
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(@"UPDATE OGRENCI SET ogrTel = @ogrTel, ogrMail = @ogrMail,
                                                  ogrAdres = @ogrAdres, ogrVeliTel = @ogrVeliTel, ogrKanGrup = @ogrKanGrup
                                                  WHERE kullaniciID = @kullaniciID", baglanti);


                komut.Parameters.AddWithValue("@ogrTel", txtTelNo.Text);
                komut.Parameters.AddWithValue("@ogrMail", txtMail.Text);
                komut.Parameters.AddWithValue("@ogrAdres", txtAdres.Text);
                komut.Parameters.AddWithValue("@ogrVeliTel", txtVeliTel.Text);
                komut.Parameters.AddWithValue("@ogrKanGrup", txtKanGrup.Text);
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

        private void pbgeriDon_Click(object sender, EventArgs e)
        {
            formOgrenciGiris giris = new formOgrenciGiris();
            this.Hide();
            giris.ShowDialog();
        }
    }

    
}

