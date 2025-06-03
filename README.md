# 🏨 Yurt Kayıt Otomasyonu

**BM309 - Veritabanı Yönetim Sistemleri Dersi Projesi**  
**Düzce Üniversitesi - Bilgisayar Mühendisliği Bölümü**  

Bu proje, bir yurtta kalan öğrencilerin tüm kayıt işlemlerini dijitalleştirmeyi amaçlayan, ilişkisel veritabanı tabanlı bir otomasyon sistemidir. Öğrenciler, personel ve yöneticiler (admin) sisteme farklı rollerle giriş yaparak kendi yetki alanlarındaki işlemleri gerçekleştirebilmektedir.

---

## 👨‍👩‍👧‍👧 Geliştirici Ekip

| Ad Soyad        | 
|-----------------|
| Gizem Efe       | 
| Züleyha Akbaş   | 
| Hilal Şarkışla  | 
| Elif Sude Ünal  | 

---

## 🎯 Projenin Amacı

Yurtlarda tutulan öğrenci, personel ve oda kayıtlarının manuel olarak değil, veritabanı destekli bir uygulama ile **daha güvenli, hızlı ve doğru şekilde yönetilmesini sağlamak**. Ayrıca, kullanıcıların sistemde rol bazlı yetkilere göre işlem yapabilmesini ve veri güvenliğini ön planda tutan bir yapı kurmak hedeflenmiştir.

---

## 🛠️ Kullanılan Teknolojiler

- **C# (Windows Forms):** Arayüz geliştirme
- **Microsoft SQL Server:** Veritabanı yönetimi
- **ADO.NET:** Veritabanı bağlantısı ve işlemleri
- **SQL Trigger ve Stored Procedure'ler:** Otomatik veri kontrolü ve işlem yönetimi
- **Crystal Reports:** Raporlama ve çıktı alma
- **Excel Entegrasyonu:** Veri dışa/içe aktarımı

---

## 🗃️ Veritabanı Yapısı

### Tablolar ve İlişkiler:

- `GOREV`: Personelin görev tanımları
- `PERSONEL`: Personel bilgileri (görev ile ilişkili)
- `ODALAR`: Oda bilgileri (personel ile ilişkili)
- `YATAKLAR`: Odaya ait yatak bilgileri
- `OGRENCI`: Öğrenci kayıt bilgileri (odalarla ilişkili)
- `KULLANICI`: Tüm kullanıcıların sistem erişim bilgileri (admin, öğrenci, personel)

📌 **ER Diyagramı** ve şema detayları için `docs/ERDiagram.png` dosyasını inceleyebilirsiniz.

---

## 🔐 Kullanıcı Rolleri ve Yetkileri

### 👩‍💼 Admin
- Kullanıcı işlemleri (ekle, sil, güncelle, listele)
- Öğrenci, personel ve yatak işlemleri
- Raporlama (Crystal Reports)
- Excel ile veri aktarımı
- Yedek alma/yedekten geri yükleme

### 🎓 Öğrenci
- Kişisel bilgi görüntüleme ve güncelleme
- Ödeme yapma ve geçmiş ödemeleri görüntüleme
- İzin alma ve izni görüntüleme/silme

### 🧑‍🔧 Personel
- Görevli olduğu odaları ve öğrenci bilgilerini görüntüleme
- Kişisel bilgileri güncelleme

---

## 📌 Uygulama Özellikleri

- ✅ Kullanıcı giriş sistemi (Rol bazlı)
- ✅ SQL Trigger ile otomatik veri tetikleyicileri
- ✅ Stored Procedure'lerle işlem kolaylığı
- ✅ Crystal Reports ile şık rapor çıktıları
- ✅ Excel dosyası ile veri aktarımı
- ✅ Tablolar arası ilişkisel yapı ve veri bütünlüğü
- ✅ Veri yedekleme ve geri yükleme modülü

---

## 📸 Ekran Görüntüleri

Proje arayüzüne ait bazı örnek görüntüler:

- Giriş Formu  
- Admin Paneli  
- Öğrenci Kayıt ve İzin Alma Formu  
- Crystal Reports Rapor Ekranları  

🗂️ Görseller `docs/` klasörüne eklendiğinde buraya entegre edebilirsin:

```html
<img src="docs/giris-formu.png" width="600"/>
<img src="docs/admin-paneli.png" width="600"/>
<img src="docs/izin-formu.png" width="600"/>
