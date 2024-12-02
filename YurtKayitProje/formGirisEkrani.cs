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
     public partial class formGirisEkrani : Form
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


            
            internal static object kullaniciID;
            public formGirisEkrani()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private string KullaniciGirisi(string kullaniciAd, string sifre)
            {
                try
                {

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT kullaniciID, rol FROM KULLANICI WHERE kullaniciAd = @kullaniciAd AND sifre = @sifre", baglanti);
                    komut.Parameters.AddWithValue("@kullaniciAd", kullaniciAd);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    SqlDataReader reader = komut.ExecuteReader();

                    if (reader.Read()) // Veri var mı kontrol et
                    {
                        kullaniciID = reader.GetInt32(0); // kullaniciID'yi al
                        return reader["rol"].ToString(); // Rolü döndür
                    }
                    else
                    {
                        return null; // Kullanıcı bulunamadı
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Veritabanı bağlantısı sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                finally
                {
                    baglanti.Close();
                }
            }

         

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            string kullaniciAd = txtKullanıcıAdı.Text;
            string sifre = txtSifre.Text;

            //giriş alanları boş mu kontrolu
            if (string.IsNullOrWhiteSpace(kullaniciAd) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rol = KullaniciGirisi(kullaniciAd, sifre); // Kullanıcı girişini kontrol et

            if (rol == "Admin" || rol == "admin")
            {
                MessageBox.Show("Hoş geldiniz, Admin!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formAdminGiris adminForm = new formAdminGiris();
                this.Hide();
                adminForm.ShowDialog();
            }
            else if (rol == "öğrenci" || rol == "Öğrenci")
            {
                MessageBox.Show($"Hoş geldiniz, {txtKullanıcıAdı.Text}!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formOgrenciGiris kullanıcıForm = new formOgrenciGiris();
                this.Hide();
                kullanıcıForm.ShowDialog();
            }
            else if (rol == "Personel" || rol == "personel")
            {
                MessageBox.Show($"Hoş geldiniz, {txtKullanıcıAdı.Text}!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formPersonelGiris personelForm = new formPersonelGiris();
                this.Hide();
                personelForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSifreGoster_CheckedChanged_1(object sender, EventArgs e)
        {

            if (cbSifreGoster.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                // cbGoster.Text = "Göster";
            }
            else if (cbSifreGoster.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = true;
                //cbGoster.Text = "Gizle";
            }
        }

        private void txtSifre_TextChanged_1(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }
    }
    }

