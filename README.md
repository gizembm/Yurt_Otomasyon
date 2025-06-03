<h1 align="center">🏨 Yurt Kayıt Otomasyonu</h1>

<p align="center">
  Düzce Üniversitesi Bilgisayar Mühendisliği Bölümü<br>
  BM309 - Veritabanı Yönetim Sistemleri Dersi Projesi
</p>

---

## 👩‍💻 Geliştiriciler

| Öğrenci Adı       | Öğrenci Numarası |
|------------------|------------------|
| Gizem Efe        | 221001015         |
| Züleyha Akbaş    | 221001003         |
| Hilal Şarkışla   | 221001054         |
| Elif Sude Ünal   | 221001058         |

---

## 🎯 Projenin Amacı

Bu proje, yurtta kalan öğrencilerin kayıtlarını yönetmek amacıyla geliştirilmiş bir **veritabanı otomasyon sistemidir**. Öğrenciler, personel ve admin kullanıcıları farklı yetkilerle sisteme giriş yapabilir ve kendilerine özel işlemleri gerçekleştirebilirler.

---

## 🛠️ Kullanılan Teknolojiler

- ✅ C# (Windows Forms)
- ✅ Microsoft SQL Server
- ✅ ADO.NET
- ✅ SQL Trigger ve Procedure’ler
- ✅ Crystal Reports
- ✅ Excel Aktarımı

---

## 🗃️ Veritabanı Tasarımı

**Ana Tablolar:**
- `GOREV`
- `PERSONEL`
- `ODALAR`
- `YATAKLAR`
- `OGRENCI`
- `KULLANICI`

Veritabanı ilişkisel şekilde tasarlanmış olup birincil ve yabancı anahtarlar kullanılmıştır.  
ER Diyagramı ve tablo ilişkileri için `docs/ERDiagram.png` dosyasına bakabilirsiniz. *(Bu dosyayı GitHub’a ekran görüntüsü olarak eklersen harika olur.)*

---

## 🔐 Kullanıcı Rolleri ve Yetkiler

| Rol      | Yetkiler |
|----------|----------|
| 👩‍💼 Admin | Kullanıcı yönetimi, öğrenci/personel işlemleri, yatak durumu, Crystal Reports, Excel aktarımı, yedekleme |
| 🎓 Öğrenci | Kişisel bilgi güncelleme, ödeme yapma, izin alma |
| 🧑‍🔧 Personel | Görevli olduğu odaları ve öğrencileri görme, kişisel bilgi güncelleme |

---

## 🧪 Öne Çıkan Özellikler

- 📌 **SQL Trigger**: Otomatik veri işleme
- 📌 **Stored Procedures**: Fonksiyonel veri işlemleri
- 📌 **Excel Entegrasyonu**: Verileri dışa ve içe aktarma
- 📌 **Crystal Reports**: Görsel raporlamalar (Silinen Öğrenci Raporu, Yatak Durum Raporu vb.)

---

## 🖥️ Ekran Görüntüleri

<img src="docs/giris-formu.png" alt="Giriş Formu" width="600"/>
<img src="docs/admin-paneli.png" alt="Admin Paneli" width="600"/>
<img src="docs/ogrenci-izin-formu.png" alt="İzin Alma Formu" width="600"/>

*📸 Ekran görüntüleri klasörüne `docs/` adlı bir klasör oluşturup görselleri ekleyebilirsin.*

---

## 🚀 Kurulum ve Çalıştırma

1. Bu projeyi bilgisayarınıza klonlayın:
```bash
git clone https://github.com/kullaniciAdi/YurtKayitOtomasyonu.git
