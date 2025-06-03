# 🏨 Yurt Kayıt Otomasyonu

**BM309 - Veritabanı Yönetim Sistemleri Dersi Projesi**  
**Düzce Üniversitesi - Bilgisayar Mühendisliği Bölümü**  

Bu proje, bir yurtta kalan öğrencilerin tüm kayıt işlemlerini dijitalleştirmeyi amaçlayan, ilişkisel veritabanı tabanlı bir otomasyon sistemidir. Öğrenciler, personel ve yöneticiler (admin) sisteme farklı rollerle giriş yaparak kendi yetki alanlarındaki işlemleri gerçekleştirebilmektedir.



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
## 👨‍👩‍👧‍👧 Geliştirici Ekip

| Gizem Efe       | 
| Züleyha Akbaş   | 
| Hilal Şarkışla  | 
| Elif Sude Ünal  | 

---

## 📸 Ekran Görüntüleri

Proje arayüzüne ait bazı örnek ekran görüntüleri:

<p align="left">
  <img src="https://github.com/user-attachments/assets/54291a41-8e5f-46ee-8839-b2285bac2d01" width="600" />
  <img src="https://github.com/user-attachments/assets/f37a7475-ba92-49bf-85ee-6e27b6889994" width="600" />
  <img src="https://github.com/user-attachments/assets/08133c62-590a-437d-8918-74fe537c68b0" width="600" />
  <img src="https://github.com/user-attachments/assets/c972a74c-c0f0-4d7b-9c47-3ed324005cce" width="600" />
  <img src="https://github.com/user-attachments/assets/684b5ce2-5477-4836-b0c1-f578c4984b8c" width="600" />
  <img src="https://github.com/user-attachments/assets/235f1de6-1208-48c8-8218-b5befed9cc91" width="600" />
  <img src="https://github.com/user-attachments/assets/58aacf45-1511-4a46-acdf-092e9b3ff15e" width="600" />
  <img src="https://github.com/user-attachments/assets/0e85fc6b-5499-4513-adcd-8551e8ee27ce" width="600" />
  <img src="https://github.com/user-attachments/assets/e48774da-237d-4b4c-bbb9-79ed58ff051d" width="600" />
  <img src="https://github.com/user-attachments/assets/780e92d8-a0e8-48dc-a311-65890ae33bd9" width="600" />
</p>
