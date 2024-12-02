using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class formYetkilendirme : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public formYetkilendirme()
        {
            InitializeComponent();
        }

        private void formYetkilendirme_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("sp_KullaniciEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;

                // Formdan değerleri al
                komut.Parameters.AddWithValue("@kullaniciAd", txtKullanıcıAd.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut.Parameters.AddWithValue("@rol", cmbRol.SelectedItem.ToString());

                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            txtKullanıcıAd.Clear();
            txtSifre.Clear();
            cmbRol.SelectedIndex = -1;
            btnListele.PerformClick();

        }



        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // KULLANICILAR tablosundaki verileri al
                SqlCommand cmd = new SqlCommand("SELECT * FROM KULLANICI WHERE rol<> 'admin'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvYetkilendirmeListesi.DataSource = dt; // DataGridView'e verileri bağla   



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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int kullaniciID = Convert.ToInt32(txtKullanıcıId.Text); 
            string yeniKullaniciAd = txtKullanıcıAd.Text;
            string yeniSifre = txtSifre.Text;
            string yeniRol = cmbRol.SelectedItem.ToString(); // cmbRol, rol seçim kutusu

            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("sp_YetkilendirmeGuncelle", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                cmd.Parameters.AddWithValue("@yeniKullaniciAd", yeniKullaniciAd);
                cmd.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                cmd.Parameters.AddWithValue("@yeniRol", yeniRol);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            txtKullanıcıId.Clear();
            txtKullanıcıAd.Clear();
            txtSifre.Clear();   
            cmbRol.SelectedIndex = -1;
            btnListele.PerformClick();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int kullaniciID = 0;

            // TextBox'tan kullanıcı ID alınmaya çalışılır
            if (!string.IsNullOrWhiteSpace(txtKullanıcıId.Text))
            {
                if (!int.TryParse(txtKullanıcıId.Text, out kullaniciID))
                {
                    MessageBox.Show("Geçerli bir kullanıcı ID girin.");
                    return;
                }
            }
            // Eğer TextBox boşsa, DataGridView'den seçilen ID alınır
            else if (dgvYetkilendirmeListesi.SelectedRows.Count > 0)
            {
                kullaniciID = Convert.ToInt32(dgvYetkilendirmeListesi.SelectedRows[0].Cells["KullaniciID"].Value);
            }
            else
            {
                MessageBox.Show("Silmek için bir kullanıcı seçin veya ID girin.");
                return;
            }

            // Silme işlemi
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("sp_YetkilendirmeSil", baglanti)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            txtKullanıcıId.Clear();
            btnListele.PerformClick();

           
        }

        
        private void btnExport_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Dosyası|*.xlsx",
                    Title = "Excel Dosyasını Kaydet"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Kullanıcılar");

                            // Sütun başlıklarını ekle
                            for (int i = 0; i < dgvYetkilendirmeListesi.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dgvYetkilendirmeListesi.Columns[i].HeaderText;
                            }

                            // Verileri ekle
                            for (int i = 0; i < dgvYetkilendirmeListesi.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvYetkilendirmeListesi.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dgvYetkilendirmeListesi.Rows[i].Cells[j].Value?.ToString() ?? "";
                                }
                            }

                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Veriler başarıyla Excel'e aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        baglanti.Close();
                    }

                    

                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Excel Dosyasını Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Excel dosyasını aç
                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet(1); // İlk sayfayı al
                        var rows = worksheet.RowsUsed(); // Kullanılan satırları al

                        // SQL bağlantısı

                        baglanti.Open();

                        foreach (var row in rows)
                        {
                            string kullaniciAd = row.Cell(1).GetValue<string>().Trim(); // Kullanıcı Adı
                            string sifre = row.Cell(2).GetValue<string>().Trim(); // Şifre
                            string rol = row.Cell(3).GetValue<string>().Trim(); // Rol

                            // Rolün geçerli olup olmadığını kontrol et
                            if (rol != "admin" && rol != "öğrenci" && rol != "personel")
                            {
                                continue; // Geçersiz rol ile geçerli olmayan satırı atla
                            }

                            // SQL komutu oluştur
                            SqlCommand cmd = new SqlCommand("INSERT INTO KULLANICI (kullaniciAd, sifre, rol) VALUES (@kullaniciAd, @sifre, @rol)", baglanti);
                            cmd.Parameters.AddWithValue("@kullaniciAd", kullaniciAd);
                            cmd.Parameters.AddWithValue("@sifre", sifre);
                            cmd.Parameters.AddWithValue("@rol", rol);

                            // SQL komutunu çalıştır ve ekle
                            int result = cmd.ExecuteNonQuery();


                        }


                        MessageBox.Show($"Kullanıcı başarıyla eklendi!");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }

                btnListele.PerformClick();

            }

             
        }

    }
}
