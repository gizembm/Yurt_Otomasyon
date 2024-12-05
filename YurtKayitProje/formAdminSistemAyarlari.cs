using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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
//using Xamarin.Essentials;

namespace YurtKayitProje
{
    public partial class formAdminSistemAyarlari : Form
    {
        public formAdminSistemAyarlari()
        {
            InitializeComponent();
        }


        private void formSistemAyarlari_Load(object sender, EventArgs e)
        {

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Yedeklenecek Yolu Belirtiniz.";
            saveFileDialog1.Filter = "Yedeklenecek dosyaları (*.bak)|*.bak |Tüm Dosyalar(*.*) | *.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = saveFileDialog1.FileName;
            }
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            Server dbServer = new Server(new ServerConnection(txtServer.Text));
            Backup dbBackup = new Backup();
            dbBackup.Action = BackupActionType.Database;
            dbBackup.Database = txtDatabase.Text;
            dbBackup.Devices.AddDevice(txtPath.Text,DeviceType.File);
            dbBackup.Initialize = false;
            dbBackup.Complete += DbBackup_Complete;
            dbBackup.SqlBackup(dbServer);

        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            try
            {
                MessageBox.Show("Yedekleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                // Server bağlantısını oluştur
                Server dbServer = new Server(new ServerConnection(txtServer.Text));

                // Restore işlemi için nesne oluştur
                Restore dbRestore = new Restore();
                dbRestore.Action = RestoreActionType.Database;
                dbRestore.Database = txtDatabase.Text;

                // Yedek dosyasını txtPathRestore'dan al
                dbRestore.Devices.AddDevice(txtPathRestore.Text, DeviceType.File);
                dbRestore.ReplaceDatabase = true; // Var olan veritabanını değiştirmek için
                dbRestore.NoRecovery = false; // Restore işlemi tamamlandıktan sonra veritabanını erişilebilir yap

                // Restore işlemini başlat
                dbRestore.SqlRestore(dbServer);

                // İşlem tamamlandığında kullanıcıya bilgi ver
                MessageBox.Show("Veritabanı başarıyla geri yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Geri yükleme işlemi sırasında bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPathRestore_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Yedeklenecek Dönülecek Yolu Belirtiniz.";
            openFileDialog1.Filter = "Yedeklenecek dönülen dosya Tüm Dosyalar(*.*) | *.*";
            openFileDialog1.ShowDialog();
            txtPathRestore.Text = openFileDialog1.FileName;
        }

        private void pbgeriDon_Click(object sender, EventArgs e)
        {

        }

        private void pbgeriDon_Click_1(object sender, EventArgs e)
        {
            formAdminGiris giris = new formAdminGiris();
            this.Hide();
            giris.ShowDialog();

        }
    }
}
