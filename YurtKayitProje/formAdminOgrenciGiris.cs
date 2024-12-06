using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class formAdminOgrenciGiris : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public formAdminOgrenciGiris()
        {
            InitializeComponent();

            this.Size = new Size(1899, 574);

        }

        private void formAdminOgrenciGiris_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
              
            string tc = txtTcNo.Text.Trim();  //Trim() metodu string ifadenin başındaki ve sonundaki boşluk karakterlerini kaldırır.

            // TC numarasının 11 haneli ve yalnızca rakamlardan oluşup oluşmadığını kontrol et
            if (tc.Length != 11 || !tc.All(char.IsDigit))
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli ve yalnızca rakamlardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Hata durumunda işlem yapılmasın
            }


            try
            {
                baglanti.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM OGRENCI WHERE ogrTC = @ogrTC", baglanti);
                checkCmd.Parameters.AddWithValue("@ogrTC", tc);
                int mevcutSayı = (int)checkCmd.ExecuteScalar(); // Eğer 1 veya daha fazla dönerse, TC mevcut demektir.

                if (mevcutSayı > 0)
                {
                    MessageBox.Show("Bu TC numarası zaten mevcut. Lütfen başka bir TC numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // TC zaten varsa, ekleme işlemi yapılmasın
                }


                SqlCommand komut = new SqlCommand(@"INSERT INTO OGRENCI (ogrTC, ogrAd, ogrSoyad, ogrTel, ogrMail,
                                                  ogrAdres,ogrVeliTel, ogrDogumTarih, ogrKanGrup, odaNo, kullaniciID) 
                                                  VALUES (@ogrTC, @ogrAd, @ogrSoyad, @ogrTel, @ogrMail, @ogrAdres, 
                                                  @ogrVeliTel, @ogrDogumTarih, @ogrKanGrup, @odaNo, @kullaniciID)", baglanti);



                // Formdan değerleri al
                komut.Parameters.AddWithValue("@ogrTC", txtTcNo.Text);
                komut.Parameters.AddWithValue("@ogrAd", txtAd.Text);
                komut.Parameters.AddWithValue("@ogrSoyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@ogrTel", txtTelNo.Text);
                komut.Parameters.AddWithValue("@ogrMail", txtMailAdresi.Text);
                komut.Parameters.AddWithValue("@ogrVeliTel", txtVeliTelNo.Text);
                komut.Parameters.AddWithValue("@ogrAdres", txtAdres.Text);
                komut.Parameters.AddWithValue("@ogrDogumTarih", dtpDogumTarih.Value);
                komut.Parameters.AddWithValue("@ogrKanGrup", txtKanGrubu.Text);
                komut.Parameters.AddWithValue("@odaNo", txtOdaNo.Text);
                komut.Parameters.AddWithValue("@kullaniciID", int.Parse(txtKullaniciID.Text));

                komut.ExecuteNonQuery();
                MessageBox.Show("Öğrenci başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            txtAd.Clear();
            txtTelNo.Clear();   
            txtMailAdresi.Clear();
            txtVeliTelNo.Clear();
            txtTcNo.Clear();
            txtKanGrubu.Clear();
            txtOdaNo.Clear();
            txtAdres.Clear();
            dtpDogumTarih.Value = DateTime.Today;
            txtSoyad.Clear();
            txtKullaniciID.Clear();
         


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            

            try
            {
                baglanti.Open();

                // Öğrenciler tablosundaki verileri al
                SqlCommand komut = new SqlCommand(@"SELECT ogrNo, ogrTC, ogrAd, ogrSoyad, ogrTel, ogrMail, ogrAdres,
                                                 ogrVeliTel, ogrDogumTarih, ogrKanGrup, odaNo, kullaniciID FROM OGRENCI", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();


                da.Fill(dt);
                dgvOgrenciListele.DataSource = dt; // DataGridView'e verileri bağla   



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
            string tc = txtTcNo.Text.Trim(); 
            string yeniAd = txtAd.Text;
            string yeniSoyad = txtSoyad.Text;
            string yeniTelNo = txtTelNo.Text;
            string yeniMail = txtMailAdresi.Text;
            string yeniAdres = txtAdres.Text;
            string yeniVeliTel = txtVeliTelNo.Text;
            DateTime yeniDogumTarih = dtpDogumTarih.Value;
            string yeniKanGrup = txtKanGrubu.Text;
            string yeniOdaNo = txtOdaNo.Text;
            int kullaniciID = int.Parse(txtKullaniciID.Text);

            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE OGRENCI
                                                  SET ogrAd = @ogrAd, 
                                                  ogrSoyad = @ogrSoyad, 
                                                  ogrTel = @ogrTel, 
                                                  ogrMail = @ogrMail, 
                                                  ogrAdres = @ogrAdres, 
                                                  ogrVeliTel = @ogrVeliTel, 
                                                  ogrDogumTarih = @ogrDogumTarih, 
                                                  ogrKanGrup = @ogrKanGrup, 
                                                  odaNo = @odaNo,
                                                  kullaniciID = @kullaniciID
                                                  WHERE ogrTC = @ogrTC", baglanti);


                cmd.Parameters.AddWithValue("@ogrAd", yeniAd);
                cmd.Parameters.AddWithValue("@ogrSoyad", yeniSoyad);
                cmd.Parameters.AddWithValue("@ogrTel", yeniTelNo);
                cmd.Parameters.AddWithValue("@ogrMail", yeniMail);
                cmd.Parameters.AddWithValue("@ogrAdres", yeniAdres);
                cmd.Parameters.AddWithValue("@ogrVeliTel", yeniVeliTel);
                cmd.Parameters.AddWithValue("@ogrDogumTarih", yeniDogumTarih); 
                cmd.Parameters.AddWithValue("@ogrKanGrup", yeniKanGrup);
                cmd.Parameters.AddWithValue("@odaNo", yeniOdaNo);
                cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                cmd.Parameters.AddWithValue("@ogrTC", tc); 


                int result = cmd.ExecuteNonQuery(); //eklenen satır sayısını alır

                if (result > 0)
                {
                    MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
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
            txtAd.Clear();
            txtTelNo.Clear();
            txtMailAdresi.Clear();
            txtVeliTelNo.Clear();
            txtTcNo.Clear();
            txtKanGrubu.Clear();
            txtOdaNo.Clear();
            txtAdres.Clear();
            dtpDogumTarih.Value = DateTime.Today;
            txtSoyad.Clear();
            txtKullaniciID.Clear();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            string tcNo = ""; // TC numarasını string olarak tanımlıyoruz.

            // Eğer TextBox'ta geçerli bir değer varsa
            if (!string.IsNullOrWhiteSpace(txtTcNo.Text))
            {
                tcNo = txtTcNo.Text.Trim(); 
            }
            // Eğer TextBox boşsa, DataGridView'den seçilen TC'yi al
            else if (dgvOgrenciListele.SelectedRows.Count > 0)
            {
                tcNo = dgvOgrenciListele.SelectedRows[0].Cells["ogrTC"].Value.ToString(); // DataGridView'den doğru hücreyi alıyoruz
            }
            else
            {
                MessageBox.Show("Silmek için bir kullanıcı seçin veya TC numarasını girin.");
                return;
            }

            // TC numarasının geçerli formatta olup olmadığını kontrol et
            if (tcNo.Length != 11 || !tcNo.All(char.IsDigit)) // TC numarası 11 haneli ve sadece rakamlardan oluşmalı
            {
                MessageBox.Show("Geçerli bir TC kimlik numarası girin.");
                return;
            }

            // TC numarasına göre öğrenci var mı kontrol et
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Sp_TcNoAra", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TcNo", tcNo); // Parametreyi Stored Procedure'ye bağlıyoruz

                SqlDataReader reader = cmd.ExecuteReader();

                // Öğrenci bulunmadıysa, hata mesajı göster
                if (!reader.HasRows)
                {
                    MessageBox.Show("Girilen TC kimlik numarasına sahip bir öğrenci bulunamadı.");
                    reader.Close();
                    return;
                }

                reader.Close(); // Veritabanı bağlantısını kapatıyoruz, çünkü öğrenciyi bulduk.

                // Silme işlemi
                cmd = new SqlCommand(@"DELETE FROM OGRENCI
                                     WHERE ogrTC=@ogrTC", baglanti);

                cmd.Parameters.AddWithValue("@ogrTC", tcNo); 

                int result = cmd.ExecuteNonQuery(); 

                if (result > 0)
                {
                    MessageBox.Show("Öğrenci başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message); // Hata mesajını kullanıcıya gösteriyoruz
            }
            finally
            {
                baglanti.Close(); // Bağlantıyı her durumda kapatıyoruz
            }

            txtTcNo.Clear(); 
            btnListele.PerformClick(); 

            
        }

        private void btnIzinListele_Click(object sender, EventArgs e)
        {
            // Öğrenci numarasını al
            string ogrNo = txtOgrNo.Text.Trim();

            // Tarihleri al ve kontrol et
            DateTime? baslangicTarihi = dtpBaslangic.Value.Date;
            DateTime? bitisTarihi = dtpBitis.Value.Date;

            try
            {
                baglanti.Open();

          
                string query = @"SELECT baslangıcTarih, bitisTarih, kalanIzin, ogrNo 
                                 FROM IZIN 
                                 WHERE ogrNo = @ogrNo";

                // Tarih kriterlerini ekle
                if (baslangicTarihi != DateTime.Today && bitisTarihi != DateTime.Today)
                {
                    query += " AND baslangıcTarih >= @baslangıcTarih AND bitisTarih <= @bitisTarih";
                }

                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@ogrNo", ogrNo); // ogrNo parametresini sorguya ekle

                // Eğer tarih kriterleri geçerliyse parametreleri ekle
                if (baslangicTarihi != null && bitisTarihi != null)
                {
                    cmd.Parameters.AddWithValue("@baslangıcTarih", baslangicTarihi.Value.ToString("yyyy.M.d"));
                    cmd.Parameters.AddWithValue("@bitisTarih", bitisTarihi.Value.ToString("yyyy.M.d"));
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // DataGridView'e verileri bağla
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

            // Formu varsayılan duruma getir
            txtOgrNo.Clear();
            dtpBaslangic.Value = DateTime.Today;
            dtpBitis.Value = DateTime.Today;

        }

         private void btnIzinEkle_Click(object sender, EventArgs e)
        {

            try
            {
                
                int ogrenciNo = int.Parse(txtOgrNo.Text);
                

                // Öğrencinin kullanıcıID'sini almak için sorgu
                SqlCommand getKullaniciIDCommand = new SqlCommand(@"SELECT kullaniciID FROM OGRENCI WHERE ogrNo = @ogrNo", baglanti);
                getKullaniciIDCommand.Parameters.AddWithValue("@ogrNo", ogrenciNo);

                baglanti.Open();

                var kullaniciIDResult = getKullaniciIDCommand.ExecuteScalar();

                if (kullaniciIDResult == DBNull.Value)
                {
                    MessageBox.Show("Bu öğrenciye ait kullanıcı ID bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int kullaniciID = Convert.ToInt32(kullaniciIDResult);



                // Öğrencinin mevcut izin gününü almak için sorgu
                SqlCommand getCurrentLeaveCommand = new SqlCommand(@"SELECT SUM(DATEDIFF(DAY, baslangıcTarih, bitisTarih)) FROM IZIN WHERE ogrNo = @ogrNo", baglanti);
                getCurrentLeaveCommand.Parameters.AddWithValue("@ogrNo", ogrenciNo);

                

                var result = getCurrentLeaveCommand.ExecuteScalar();

                // Mevcut izin günü null ise, ilk izin ekleniyor demektir, kalan izin 45 olarak belirlenmeli
                int totalUsedLeave = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                // Öğrencinin toplam izin gününü hesaplayalım
                int maxAllowedLeave = 45; // Öğrencinin alabileceği toplam izin süresi
                int remainingLeave = maxAllowedLeave - totalUsedLeave;

                // Yeni izin günleri hesaplanır
                int yeniKalanIzin = remainingLeave - (int)(dtpBitis.Value - dtpBaslangic.Value).TotalDays;

                // Eğer kalan izin gününden fazla izin eklenmeye çalışılıyorsa
                if (yeniKalanIzin < 0)
                {
                    MessageBox.Show("İzin günü fazla. Mevcut izin miktarınızdan daha fazla izin kullanamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtpBitis.Value < dtpBaslangic.Value)
                {
                    MessageBox.Show("Bitiş tarihi, başlangıç tarihinden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Başlangıç ve bitiş tarihinin aynı olup olmadığını kontrol et
                SqlCommand checkDuplicateCommand = new SqlCommand(@"SELECT COUNT(*) 
                                                                   FROM IZIN 
                                                                   WHERE (@baslangicTarih BETWEEN baslangıcTarih AND bitisTarih 
                                                                          OR @bitisTarih BETWEEN baslangıcTarih AND bitisTarih
                                                                          OR baslangıcTarih BETWEEN @baslangicTarih AND @bitisTarih 
                                                                          OR bitisTarih BETWEEN @baslangicTarih AND @bitisTarih)
                                                                   AND ogrNo = @ogrNo", baglanti);
                checkDuplicateCommand.Parameters.AddWithValue("@baslangicTarih", dtpBaslangic.Value);
                checkDuplicateCommand.Parameters.AddWithValue("@bitisTarih", dtpBitis.Value);
                checkDuplicateCommand.Parameters.AddWithValue("@ogrNo", ogrenciNo);
               

                int yineleyenSayım = Convert.ToInt32(checkDuplicateCommand.ExecuteScalar());

                if (yineleyenSayım > 0)
                {
                    MessageBox.Show("Aynı başlangıç ve bitiş tarihine sahip bir izin zaten mevcut. Lütfen farklı bir tarih aralığı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // İzin ekleme işlemi
                SqlCommand insertCommand = new SqlCommand(@"INSERT INTO IZIN (baslangıcTarih, bitisTarih, ogrNo, kullaniciID) 
                                                            VALUES (@baslangıcTarih, @bitisTarih, @ogrNo, @kullaniciID)", baglanti);

                insertCommand.Parameters.AddWithValue("@baslangıcTarih", dtpBaslangic.Value);
                insertCommand.Parameters.AddWithValue("@bitisTarih", dtpBitis.Value);
                insertCommand.Parameters.AddWithValue("@ogrNo", ogrenciNo);
                insertCommand.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                insertCommand.ExecuteNonQuery();

                // Kalan izin gününü kullanıcıya bildirin
                MessageBox.Show("İzin başarıyla eklendi. Kalan izin gününüz: " + yeniKalanIzin, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtOgrNo.Clear();
            dtpBaslangic.Value = DateTime.Today;
            dtpBitis.Value = DateTime.Today;
            btnIzınListele.PerformClick();
        

    }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Sp_TcNoAra", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TcNo", txtTcNo.Text.Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOgrenciListele.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Sp_AdAra", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOgrenciListele.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Sp_SoyadAra", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOgrenciListele.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

    

        private void txtTcNo_Click(object sender, EventArgs e)
        {

            
        }

        private void txtSoyad_Click(object sender, EventArgs e)
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
                    string ogrNo = selectedRow.Cells["ogrNo"].Value.ToString();

                    // İzin süresini hesapla
                    int izinGunu = (int)(bitisTarihi - baslangicTarihi).TotalDays;

                    // Öğrencinin mevcut izin gününü almak için sorgu
                    SqlCommand getCurrentLeaveCommand = new SqlCommand(@"SELECT SUM(DATEDIFF(DAY, baslangıcTarih, bitisTarih)) FROM IZIN   
                                                                         WHERE ogrNo = @ogrNo", baglanti);

                    getCurrentLeaveCommand.Parameters.AddWithValue("@ogrNo", ogrNo);

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
                    SqlCommand deleteCommand = new SqlCommand(@"DELETE FROM IZIN WHERE ogrNo = @ogrNo AND 
                                                               baslangıcTarih = @baslangıcTarih AND bitisTarih = @bitisTarih", baglanti);

                    deleteCommand.Parameters.AddWithValue("@ogrNo", ogrNo);
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

            // Formu varsayılan duruma getir
            txtOgrNo.Clear();
            dtpBaslangic.Value = DateTime.Today;
            dtpBitis.Value = DateTime.Today;
            btnIzınListele.PerformClick();
        }

        private void btnOgrenciRaporla_Click(object sender, EventArgs e)
        {
            formAdminOgrenciRapor rapor = new formAdminOgrenciRapor();
            this.Hide();
            rapor.ShowDialog();
        }

        private void btnIzinRaporla_Click(object sender, EventArgs e)
        {
            formAdminOgrenciIzinRaporu rapor = new formAdminOgrenciIzinRaporu();
            this.Hide();
            rapor .ShowDialog();
        }

        private void pbgeriDon_Click(object sender, EventArgs e)
        {
            formAdminGiris adminGiris = new formAdminGiris();
            this.Hide();
            adminGiris .ShowDialog();
        }

        private void dgvOgrenciListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // TextChanged olayını geçici olarak devre dışı bırak
                txtTcNo.TextChanged -= txtTcNo_TextChanged;
                txtAd.TextChanged -= txtAd_TextChanged;
                txtSoyad.TextChanged -= txtSoyad_TextChanged;

                // Seçilen satırdaki hücrelerden verileri al
                DataGridViewRow row = dgvOgrenciListele.Rows[e.RowIndex];

                
                //TextBox'lara veri aktar
                txtOgrNo.Text = row.Cells["ogrNo"].Value.ToString();
                txtTcNo.Text = row.Cells["ogrTC"].Value.ToString();
                txtAd.Text = row.Cells["ogrAd"].Value.ToString();
                txtSoyad.Text = row.Cells["ogrSoyad"].Value.ToString();
                txtAdres.Text = row.Cells["ogrAdres"].Value.ToString();
                txtTelNo.Text = row.Cells["ogrTel"].Value.ToString();
                txtMailAdresi.Text = row.Cells["ogrMail"].Value.ToString();
                txtVeliTelNo.Text = row.Cells["ogrVeliTel"].Value.ToString();
                txtOdaNo.Text = row.Cells["odaNo"].Value.ToString();
                txtKanGrubu.Text = row.Cells["ogrKanGrup"].Value.ToString();
                txtKullaniciID.Text = row.Cells["kullaniciID"].Value.ToString();
                dtpDogumTarih.Text = row.Cells["ogrDogumTarih"].Value.ToString();

                // TextChanged olayını yeniden etkinleştir
                txtTcNo.TextChanged += txtTcNo_TextChanged;
                txtAd.TextChanged += txtAd_TextChanged;
                txtSoyad.TextChanged += txtSoyad_TextChanged;


            }
        }
    }
}
