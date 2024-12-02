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
                                                 G.gorevAd
                                                 FROM 
                                                     PERSONEL P
                                                 JOIN 
                                                     GOREV G
                                                 ON 
                                                  P.gorevID = G.gorevID;", baglanti);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvPeronelListele.DataSource = dt;    



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
            else if (dgvPeronelListele.SelectedRows.Count > 0)
            {
                personelID = Convert.ToInt32(dgvPeronelListele.SelectedRows[0].Cells["personelID"].Value);
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

            string adSoyad = txtAdSoyad.Text.Trim();
            string tel = txtTel.Text.Trim();
            string gorevAd = cmbGorevAd.SelectedItem.ToString();

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand(@"INSERT INTO PERSONEL (personelAdSoyad, personelTel, gorevID)
                                                   SELECT 
                                                       @adSoyad AS personelAdSoyad,
                                                       @tel AS personelTel,
                                                       G.gorevID
                                                   FROM 
                                                       GOREV G
                                                   WHERE 
                                                       G.gorevAd = @gorevAd", baglanti);
                                                      

                
                komut.Parameters.AddWithValue("@adSoyad", adSoyad);
                komut.Parameters.AddWithValue("@tel", tel);
                komut.Parameters.AddWithValue("@gorevAd", gorevAd);

                komut.ExecuteNonQuery();
                MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            txtAdSoyad.Clear();
            txtTel.Clear();
            cmbGorevAd.SelectedIndex = -1;
            btnListele.PerformClick();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text.Trim();
            string tel = txtTel.Text.Trim();
            string gorevAd = cmbGorevAd.SelectedItem.ToString();
            string personelIdText = txtID.Text.Trim();
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE P
                                                 SET 
                                                     P.personelAdSoyad = @adSoyad,
                                                     P.personelTel = @tel,
                                                     P.gorevID = G.gorevID
                                                 FROM 
                                                     PERSONEL P
                                                 JOIN 
                                                     GOREV G
                                                 ON 
                                                     G.gorevAd = @gorevAd
                                                 WHERE 
                                                     P.personelID = @personelID", baglanti);
                

                cmd.Parameters.AddWithValue("@personelID", personelIdText);
                cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@gorevAd", gorevAd);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Personel bilgileri başarıyla güncellendi.");
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
            txtAdSoyad.Clear();
            txtTel.Clear();
            txtID.Clear();
            cmbGorevAd.SelectedIndex = -1;
            btnListele.PerformClick();
        }

        private void formAdminPersonelGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
