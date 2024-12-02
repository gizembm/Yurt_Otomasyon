using DocumentFormat.OpenXml.Office.Word;
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

    public partial class formOgrenciIzin : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public formOgrenciIzin()
        {
            InitializeComponent();
        }

        private void btnIzınListele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                DateTime? baslangicTarihi = dtpBaslangic.Value.Date; // '?' ifadesi null olma ihtimalini katar
                DateTime? bitisTarihi = dtpBitis.Value.Date;

 
                SqlCommand cmd = new SqlCommand(@"SELECT baslangıcTarih, bitisTarih, kalanIzin, ogrNo 
                                                  FROM IZIN 
                                                  WHERE kullaniciID = @kullaniciID", baglanti);
                                                  
                cmd.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);

                

                //Eğer tarih kriterleri geçerliyse parametreleri ekle
                if (baslangicTarihi != null && bitisTarihi != null)
                {
                    cmd.Parameters.AddWithValue("@baslangıcTarih", baslangicTarihi.Value.ToString("yyyy.M.d"));
                    cmd.Parameters.AddWithValue("@bitisTarih", bitisTarihi.Value.ToString("yyyy.M.d"));
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                dgvIzin.DataSource = dt;
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

            
            dtpBaslangic.Value = DateTime.Today;
            dtpBitis.Value = DateTime.Today;

        }

        private void btnIzinEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcının ogrNo'sunu almak için sorgu
                SqlCommand getOgrNoCommand = new SqlCommand(@"SELECT ogrNo 
                                                              FROM OGRENCI 
                                                              WHERE kullaniciID = @kullaniciID", baglanti);

                getOgrNoCommand.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);

                baglanti.Open();
                string ogrNo = getOgrNoCommand.ExecuteScalar()?.ToString();

                if (string.IsNullOrEmpty(ogrNo))
                {
                    MessageBox.Show("Öğrenci bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtpBitis.Value < dtpBaslangic.Value)
                {
                    MessageBox.Show("Bitiş tarihi, başlangıç tarihinden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Aynı başlangıç ve bitiş tarihine sahip izin kontrolü
                SqlCommand checkDuplicateCommand = new SqlCommand(@"SELECT COUNT(*)
                                                                     FROM IZIN
                                                                     WHERE(@baslangıcTarih BETWEEN baslangıcTarih AND bitisTarih
                                                                            OR @bitisTarih BETWEEN baslangıcTarih AND bitisTarih
                                                                            OR baslangıcTarih BETWEEN @baslangıcTarih AND @bitisTarih
                                                                            OR bitisTarih BETWEEN @baslangıcTarih AND @bitisTarih)
                                                                     AND ogrNo = @ogrNo", baglanti);

                checkDuplicateCommand.Parameters.AddWithValue("@baslangıcTarih", dtpBaslangic.Value);
                checkDuplicateCommand.Parameters.AddWithValue("@bitisTarih", dtpBitis.Value);
                checkDuplicateCommand.Parameters.AddWithValue("@ogrNo", ogrNo);

                int yinelenenSayım = Convert.ToInt32(checkDuplicateCommand.ExecuteScalar());

                if (yinelenenSayım > 0)
                {
                    MessageBox.Show("Aynı başlangıç ve bitiş tarihine sahip bir izin zaten mevcut. Lütfen farklı bir tarih aralığı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // İzin ekleme işlemi
                SqlCommand insertCommand = new SqlCommand(@"INSERT INTO IZIN (baslangıcTarih, bitisTarih, ogrNo, kullaniciID) 
                                                            VALUES (@baslangıcTarih, @bitisTarih, @ogrNo, @kullaniciID)", baglanti);

                insertCommand.Parameters.AddWithValue("@baslangıcTarih", dtpBaslangic.Value);
                insertCommand.Parameters.AddWithValue("@bitisTarih", dtpBitis.Value);
                insertCommand.Parameters.AddWithValue("@ogrNo", ogrNo);
                insertCommand.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("İzin başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                
                dtpBaslangic.Value = DateTime.Today;
                dtpBitis.Value = DateTime.Today;
            }

        }

        private void formOgrenciIzin_Load(object sender, EventArgs e)
        {

        }

        private void btnIzinSil_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'den seçilen satırı al
                if (dgvIzin.SelectedRows.Count > 0)
                {
                    // Seçilen satırdaki izin bilgilerini al
                    DataGridViewRow selectedRow = dgvIzin.SelectedRows[0];
                    DateTime baslangicTarihi = Convert.ToDateTime(selectedRow.Cells["baslangıcTarih"].Value);
                    DateTime bitisTarihi = Convert.ToDateTime(selectedRow.Cells["bitisTarih"].Value);
                    

                    // İzin süresini hesapla
                    int izinGunu = (int)(bitisTarihi - baslangicTarihi).TotalDays;

                    // Öğrencinin mevcut izin gününü almak için sorgu
                    SqlCommand getCurrentLeaveCommand = new SqlCommand(@"SELECT SUM(DATEDIFF(DAY, baslangıcTarih, bitisTarih)) FROM IZIN 
                                                                         WHERE kullaniciID = @kullaniciID", baglanti);

                    getCurrentLeaveCommand.Parameters.AddWithValue("@kullaniciID", formGirisEkrani.kullaniciID);


                    baglanti.Open();
                    var result = getCurrentLeaveCommand.ExecuteScalar();

                    // Mevcut izin günü null ise, 0 olarak kabul et
                    int totalUsedLeave = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    // Yeni kalan izin gününü hesapla
                    int maxAllowedLeave = 45; // Öğrencinin alabileceği toplam izin süresi
                    int remainingLeave = maxAllowedLeave - totalUsedLeave;

                    // Kalan izin gününü güncelle
                    int yeniKalanIzin = remainingLeave + izinGunu; // Silinen izin gününü geri ekle

                    // İzin kaydını sil
                    SqlCommand deleteCommand = new SqlCommand(@"DELETE FROM IZIN WHERE baslangıcTarih = @baslangıcTarih AND 
                                                                bitisTarih = @bitisTarih", baglanti);
                    
                    deleteCommand.Parameters.AddWithValue("@baslangıcTarih", baslangicTarihi);
                    deleteCommand.Parameters.AddWithValue("@bitisTarih", bitisTarihi);

                    deleteCommand.ExecuteNonQuery();

                    // Kalan izin gününü kullanıcıya bildirin
                    MessageBox.Show("İzin başarıyla silindi. Kalan izin gününüz: " + yeniKalanIzin, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz izin kaydını seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    baglanti.Close();  // Bağlantı her durumda kapatılmalı
                }
            }

            btnIzinEkle.PerformClick();
        }
    }
}
