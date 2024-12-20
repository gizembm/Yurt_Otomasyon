﻿using System;
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
    public partial class formOgrenciOdeme : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public formOgrenciOdeme()
        {
            InitializeComponent();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {

            try
            {

                baglanti.Open();



                SqlCommand komut = new SqlCommand(@"SELECT 
                                                            o.odemeID, 
                                                            o.odenecekTutar, 
                                                            o.odemeAy, 
                                                            o.odemeTarih, 
                                                            o.ogrNo
                                                        FROM ODEME o
                                                        INNER JOIN OGRENCI g ON o.ogrNo = g.ogrNo
                                                        WHERE g.kullaniciID = @kullaniciID", baglanti);

                komut.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();

                // Verileri DataTable içine dolduruyoruz
                da.Fill(dt);

                // DataGridView'e DataTable'ı bağlıyoruz
                dgvOdemeler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {

                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();  // Bağlantı her durumda kapatılmalı
                }
            }


        } 

        private void btnOde_Click(object sender, EventArgs e)
        {


            int odenecekTutar = Convert.ToInt32(txtOdenecekTutar.Text);
            string odenenAy = cmbAy.Text.Trim();
            DateTime odemeTarih = DateTime.Today;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                

                SqlCommand kontrolKomut = new SqlCommand(@"SELECT COUNT(*) 
                                                            FROM ODEME 
                                                            WHERE odemeAy = @odemeAy AND ogrNo = 
                                                            (SELECT ogrNo FROM OGRENCI WHERE kullaniciID = @kullaniciID)", baglanti);

                kontrolKomut.Parameters.AddWithValue("@odemeAy", odenenAy);
                kontrolKomut.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);

                int odemeVarMi = (int)kontrolKomut.ExecuteScalar();

                if (odemeVarMi > 0)
                {
                    MessageBox.Show("Bu ay için ödeme zaten yapılmış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // İşlem durduruluyor
                }

               

                SqlCommand komut = new SqlCommand(@"INSERT INTO ODEME (odenecekTutar, odemeAy, odemeTarih, ogrNo)
                                                    SELECT @odenecekTutar, @odemeAy, @odemeTarih, ogrNo
                                                    FROM OGRENCI
                                                    WHERE kullaniciID = @kullaniciID", baglanti);

                komut.Parameters.AddWithValue("@odenecekTutar", odenecekTutar);
                komut.Parameters.AddWithValue("@odemeAy", odenenAy);
                komut.Parameters.AddWithValue("@odemeTarih", odemeTarih);
                komut.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);

                int result = komut.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Ödeme başarıyla alındı!");
                }
                else
                {
                    MessageBox.Show("Ödeme işlemi başarısız. Öğrenci numarası bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();  
                }
            }

        }

        private void formOgrenciOdeme_Load(object sender, EventArgs e)
        {
            txtOdenecekTutar.Enabled = false;

        }

        private void pbgeriDon_Click(object sender, EventArgs e)
        {
            formOgrenciGiris giris = new formOgrenciGiris();
            this.Hide();
            giris.ShowDialog();
        }
    }
}
