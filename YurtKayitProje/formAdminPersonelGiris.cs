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
    public partial class formAdminPersonelGiris : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=YurtOtomasyonVTYS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public formAdminPersonelGiris()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                
                SqlCommand cmd = new SqlCommand(@"SELECT 
                                                   P.personelID,
                                                   P.personelAdSoyad,
                                                   P.personelTel,
                                                   P.kullaniciID,
                                                   G.gorevAd,
                                                   O.odaNo
                                               FROM 
                                                   PERSONEL P
                                               JOIN 
                                                   GOREV G ON P.gorevID = G.gorevID  
                                               JOIN 
                                                   ODALAR O ON P.personelID = O.personelID", baglanti);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvPersonelListele.DataSource = dt;    



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

        private void btnSil_Click(object sender, EventArgs e)
        {

            int personelID = 0;

            // TextBox'tan kullanıcı ID alınmaya çalışılır
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                if (!int.TryParse(txtID.Text, out personelID))
                {
                    MessageBox.Show("Geçerli bir kullanıcı ID girin.");
                    return;
                }
            }
            // Eğer TextBox boşsa, DataGridView'den seçilen ID alınır
            else if (dgvPersonelListele.SelectedRows.Count > 0)
            {
                personelID = Convert.ToInt32(dgvPersonelListele.SelectedRows[0].Cells["personelID"].Value);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM PERSONEL WHERE personelID = @personelID", baglanti);

                cmd.Parameters.AddWithValue("@personelID", personelID);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Personel başarıyla silindi.");
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

            txtID.Clear();
            btnListele.PerformClick();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string personelAdSoyad = txtAdSoyad.Text;
            string personelTel = txtTel.Text;
            int kullaniciID = int.Parse(txtKullaniciID.Text);
            string gorevAd = cmbGorevAd.Text; // Görev adı combobox'tan alınır
            string odaNo = txtSorumluOda.Text;

            try
            {
                baglanti.Open();

                SqlCommand command = new SqlCommand("Sp_GörevVeOdayıAdaGöreAta", baglanti);

                command.CommandType = CommandType.StoredProcedure;

                // Parametreleri ekle
                command.Parameters.AddWithValue("@personelAdSoyad", personelAdSoyad);
                command.Parameters.AddWithValue("@personelTel", personelTel);
                command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                command.Parameters.AddWithValue("@gorevAd", gorevAd);
                command.Parameters.AddWithValue("@odaNo", odaNo);

                // Prosedürü çalıştır
                command.ExecuteNonQuery();

                MessageBox.Show("Personel başarıyla eklendi ve görevi ile oda atandı.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }

            }

                //string adSoyad = txtAdSoyad.Text.Trim();
                //string tel = txtTel.Text.Trim();
                //string gorevAd = cmbGorevAd.SelectedItem.ToString();
                ////string oda = txtSorumluOda.Text.Trim();
                ////int kullaniciID = Convert.ToInt32(txtKullaniciID.Text);

                //try
                //{
                //    baglanti.Open();

                //    SqlCommand komut = new SqlCommand(@"INSERT INTO PERSONEL (personelAdSoyad, personelTel, gorevID)
                //                                       SELECT 
                //                                           @adSoyad AS personelAdSoyad,
                //                                           @tel AS personelTel,
                //                                           G.gorevID
                //                                       FROM 
                //                                           GOREV G
                //                                       WHERE 
                //                                           G.gorevAd = @gorevAd", baglanti);



                //    komut.Parameters.AddWithValue("@adSoyad", adSoyad);
                //    komut.Parameters.AddWithValue("@tel", tel);
                //    komut.Parameters.AddWithValue("@gorevAd", gorevAd);

                //    komut.ExecuteNonQuery();
                //    MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                //finally
                //{
                //    if (baglanti.State == ConnectionState.Open)
                //    {
                //        baglanti.Close();
                //    }
                //}
                //txtAdSoyad.Clear();
                //txtTel.Clear();
                //cmbGorevAd.SelectedIndex = -1;
                //btnListele.PerformClick();
         }

            private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                    baglanti.Open();

                SqlCommand command = new SqlCommand("Sp_GörevVeOdayıIsmeGöreGüncelle", baglanti);
                    
                        command.CommandType = CommandType.StoredProcedure;

                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@personelID", int.Parse(txtID.Text)); // Güncellenecek personelID
                        command.Parameters.AddWithValue("@personelAdSoyad", txtAdSoyad.Text);
                        command.Parameters.AddWithValue("@personelTel", txtTel.Text);
                        command.Parameters.AddWithValue("@kullaniciID", int.Parse(txtKullaniciID.Text));
                        command.Parameters.AddWithValue("@gorevAd", cmbGorevAd.Text); // Yeni görev adı
                        command.Parameters.AddWithValue("@odaNo", txtSorumluOda.Text); // Yeni odaNo

                        // Prosedürü çalıştır
                        command.ExecuteNonQuery();

                        MessageBox.Show("Personel başarıyla güncellendi, görevi ve odası güncellendi.");
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                baglanti.Close();
            }






            //txtID.Enabled = false;
            //txtAdSoyad.Enabled = false;
            //txtKullaniciID.Enabled = false;



            //string tel = txtTel.Text.Trim();
            //string gorevAd = cmbGorevAd.SelectedItem.ToString();
            //string odaNo = txtSorumluOda.Text;



            //try
            //{
            //    baglanti.Open();
            //    SqlCommand cmd = new SqlCommand(@"UPDATE P
            //                                     SET 
            //                                         P.personelAdSoyad = @adSoyad,
            //                                         P.personelTel = @tel,
            //                                         P.gorevID = G.gorevID
            //                                     FROM 
            //                                         PERSONEL P
            //                                     JOIN 
            //                                         GOREV G
            //                                     ON 
            //                                         G.gorevAd = @gorevAd
            //                                     WHERE 
            //                                         P.personelID = @personelID", baglanti);




            //    cmd.Parameters.AddWithValue("@tel", tel);
            //    cmd.Parameters.AddWithValue("@gorevAd", gorevAd);
            //    cmd.Parameters.AddWithValue("@gorevAd", gorevAd);

            //    int result = cmd.ExecuteNonQuery();

            //    if (result > 0)
            //    {
            //        MessageBox.Show("Personel bilgileri başarıyla güncellendi.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Güncelleme işlemi başarısız.");
            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hata: " + ex.Message);
            //}
            //finally
            //{
            //    baglanti.Close();
            //}
            //txtAdSoyad.Clear();
            //txtTel.Clear();
            //txtID.Clear();
            //cmbGorevAd.SelectedIndex = -1;
            //btnListele.PerformClick();
        }

        private void formAdminPersonelGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            formAdminPersonelRaporlama rapor = new formAdminPersonelRaporlama();
            this.Hide();
            rapor.ShowDialog();
        }

        

        private void pbgeriDon_Click(object sender, EventArgs e)
        {
            formAdminGiris adminGiris = new formAdminGiris();
            this.Hide();
            adminGiris.ShowDialog();
        }

        private void dgvPersonelListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void dgvPersonelListele_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer herhangi bir hücreye tıklanmışsa
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki hücrelerden verileri al
                DataGridViewRow row = dgvPersonelListele.Rows[e.RowIndex];

                // TextBox'lara veri aktar
                txtID.Text = row.Cells["personelID"].Value.ToString();
                txtAdSoyad.Text = row.Cells["PersonelAdSoyad"].Value.ToString();
                txtTel.Text = row.Cells["PersonelTel"].Value.ToString();
                txtKullaniciID.Text = row.Cells["KullaniciID"].Value.ToString();
                txtSorumluOda.Text = row.Cells["OdaNo"].Value.ToString();

                // ComboBox'a veri aktar
                cmbGorevAd.Text = row.Cells["GorevAd"].Value.ToString();

            }
        }
    }
}
