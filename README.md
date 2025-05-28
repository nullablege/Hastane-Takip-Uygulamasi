# 🏥 Hastane Takip Uygulaması - Kapsamlı C# Yönetim Paneli

![Screenshot_9](https://github.com/user-attachments/assets/d7437685-12ab-4d6c-9662-3a194597d193)!-- Buraya uygulamanızın genel bir tanıtım ekran görüntüsünü yükleyip linkini ekleyebilirsiniz. Şimdilik yer tutucu olarak bırakıyorum. -->

**Hastane Takip Uygulaması**, C# programlama dili ve .NET Framework kullanılarak geliştirilmiş, **Windows Forms tabanlı kapsamlı bir hastane yönetim sistemidir.** Bu uygulama, hastane operasyonlarını dijitalleştirerek Hasta, Doktor ve Sekreter rolleri için özel olarak tasarlanmış, kullanıcı dostu arayüzler ve zengin işlevler sunar. SQL Server veritabanı ile entegre çalışarak veri bütünlüğünü ve güvenliğini sağlar.

Bu proje, kullanıcıların sisteme güvenli bir şekilde giriş yapmalarını, randevu almalarını, doktorların hastalarını takip etmelerini ve sekreterlerin tüm organizasyonu yönetmelerini mümkün kılan **detaylı ve etkileşimli modüller** içermektedir. Uygulamanın amacı, hastane iş akışlarını optimize etmek, veri erişimini kolaylaştırmak ve genel verimliliği artırmaktır.

---

## 🌟 Temel Özellikler ve Fonksiyonlar

*   **Rol Bazlı Güvenli Giriş Sistemi:**
    *   **Hasta Girişi (`HastaGiris.cs`):** Hastaların TC Kimlik Numarası ve şifreleri ile sisteme giriş yapabilmesi.
    *   **Doktor Girişi (`DoktorGiris.cs`):** Doktorların kendi hesaplarına erişimi. (Not: Ekran görüntülerinde doğrudan Doktor Detay paneline geçiş görülüyor, ayrı bir giriş formu olabilir.)
    *   **Sekreter Girişi (`SekreterGiris.cs`):** Sekreterlerin TC Kimlik Numarası ve şifreleri ile yetkili panellerine erişimi.
    *   Tüm girişler SQL Server veritabanındaki `Tbl_Hastalar`, `Tbl_Doktorlar`, `Tbl_Sekreter` tabloları üzerinden **SQL Komutları (`SqlCommand`)** ve **Parametreli Sorgular (`Parameters.AddWithValue`)** kullanılarak doğrulanır, bu da SQL Injection saldırılarına karşı temel bir koruma sağlar.
*   **Hasta Paneli (`HastaDetay.cs`):**
    *   Kişisel bilgileri (TC, Ad Soyad) görüntüleme.
    *   **Randevu Geçmişi:** Daha önce aldığı tüm randevuları bir `DataGridView` üzerinde listeleme.
    *   **Yeni Randevu Alma:**
        *   Branş (`ComboBox`) seçimi (veritabanındaki `Tbl_Branslar` tablosundan dinamik olarak yüklenir).
        *   Seçilen branşa göre uygun doktorların (`ComboBox`) listelenmesi (veritabanındaki `Tbl_Doktorlar` tablosundan dinamik filtreleme).
        *   Seçilen doktorun **müsait randevularını (`RandevuDurum='False'`)** bir `DataGridView` üzerinde görüntüleme.
        *   Müsait bir randevu slotuna tıklayarak ve şikayetini girerek (`RichTextBox`) randevu alma. Alınan randevu veritabanında güncellenir (`RandevuDurum='True'`, `HastaTC`, `HastaSikayet`).
    *   **Bilgi Güncelleme (`BilgiDuzenle.cs`):** Hastanın kendi profil bilgilerini (Ad, Soyad, TC, Telefon, Şifre, Cinsiyet) güncellemesine olanak tanıyan ayrı bir form.
*   **Doktor Paneli (`DoktorDetay.cs`):**
    *   Doktorun kişisel bilgilerini (TC, Ad Soyad) görüntüleme.
    *   **Kendisine Atanmış Randevular:** Kendi adına alınmış tüm randevuları bir `DataGridView` üzerinde listeleme.
    *   **Hasta Şikayetini Görüntüleme:** `DataGridView`'deki bir randevuya çift tıklandığında, hastanın o randevu için girdiği şikayeti bir `RichTextBox` üzerinde görüntüleme.
    *   **Duyuruları Görüntüleme (`Duyurular.cs`):** Sekreter tarafından yayınlanan genel duyuruları görme.
    *   Sistemden güvenli çıkış yapabilme.
*   **Sekreter Paneli (`SekreterDetay.cs`):** Kapsamlı yönetim işlevleri sunar:
    *   Kişisel bilgileri (TC, Ad Soyad) görüntüleme.
    *   **Duyuru Oluşturma:** Hastane personeline veya hastalara yönelik duyuruları bir `RichTextBox` aracılığıyla oluşturup `Tbl_Duyurular` tablosuna kaydetme.
    *   **Branş Yönetimi (`Brans.cs`):**
        *   Mevcut tüm branşları bir `DataGridView`'de listeleme.
        *   Yeni branş ekleme (`insert into Tbl_Branslar`).
        *   Mevcut bir branşı silme (`delete from Tbl_Branslar`).
        *   Mevcut bir branşın adını güncelleme (`update Tbl_Branslar`).
        *   Formlar arasında geçiş yapılarak (örn: `Brans fr = new Brans(); this.Hide(); fr.Show();`) modüler bir yapı hedeflenmiştir.
    *   **Doktor Yönetimi (`DoktorPaneli.cs`):**
        *   Mevcut tüm doktorları bir `DataGridView`'de listeleme.
        *   Yeni doktor ekleme (Ad, Soyad, Branş, TC, Şifre bilgileriyle). Branşlar, `Tbl_Branslar` tablosundan bir `ComboBox`'a yüklenir.
        *   Mevcut bir doktoru silme.
        *   Mevcut bir doktorun bilgilerini güncelleme.
    *   **Randevu Oluşturma ve Yönetimi:**
        *   Belirli bir tarih, saat, branş ve doktor için manuel randevu oluşturma ve `Tbl_Randevular` tablosuna kaydetme.
        *   Seçilen branşa göre doktorların `ComboBox`'a dinamik olarak yüklenmesi.
    *   **Genel Randevu Listesi (`RandevuListesi.cs`):** Sistemdeki tüm randevuları (hasta atanmış, atanmamış, geçmiş, gelecek) bir `DataGridView`'de görüntüleme.
*   **Veritabanı Etkileşimi:**
    *   Tüm veritabanı işlemleri (SELECT, INSERT, UPDATE, DELETE) için **ADO.NET** (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`, `SqlDataReader`, `DataTable`) teknolojileri kullanılır.
    *   Bağlantı dizisi (`sqlbaglanti.cs` sınıfı içinde) merkezi bir yerden yönetilir.
    *   Parametreli sorgular kullanılarak SQL Injection riskine karşı önlem alınmıştır (`komut.Parameters.AddWithValue`).
*   **Kullanıcı Arayüzü:**
    *   Standart Windows Forms kontrolleri (`Button`, `TextBox`, `Label`, `ComboBox`, `DataGridView`, `MaskedTextBox`, `RichTextBox`) ile kullanıcı dostu arayüzler.
    *   Verilerin `DataGridView` üzerinde listelenmesi ile kolay okunabilirlik ve yönetim.
    *   Formlar arası geçişler ve bilgi aktarımı (örn: `public string tcno;`).

---

## 🛠️ Kullanılan Teknolojiler ve Kütüphaneler

*   **Programlama Dili:** C#
*   **Platform:** .NET Framework
*   **Arayüz Teknolojisi:** Windows Forms
*   **Veritabanı:** Microsoft SQL Server
*   **Veri Erişim Teknolojisi:** ADO.NET
    *   `System.Data.SqlClient` namespace'i.
*   **Proje Yönetimi:** Visual Studio (`.sln`, `.csproj` dosyaları)

---

## 📁 Proje Dosya Yapısı (GitHub Görüntüsüne Göre)

```
Hastane-Takip-Uygulamasi/
├── .vs/Proje_Hastane/ # Visual Studio ile ilgili konfigürasyon dosyaları (genellikle .gitignore ile göz ardı edilir)
├── Proje_Hastane/ # Ana C# proje klasörü
│ ├── BilgiDuzenle.cs # Hasta bilgi düzenleme formu kodu
│ ├── Brans.cs # Branş yönetim formu kodu
│ ├── DoktorDetay.cs # Doktor detay paneli formu kodu
│ ├── DoktorGiris.cs # Doktor giriş formu (muhtemelen arayüz kodu)
│ ├── DoktorPaneli.cs # Sekreter için doktor yönetim paneli formu kodu
│ ├── Duyurular.cs # Duyuruları gösterme formu kodu
│ ├── HastaDetay.cs # Hasta detay ve randevu alma formu kodu
│ ├── HastaGiris.cs # Hasta giriş formu kodu
│ ├── HastaKayit.cs # Yeni hasta kayıt formu kodu
│ ├── Program.cs # Uygulamanın ana başlangıç noktası
│ ├── RandevuListesi.cs # Tüm randevuları listeleme formu kodu
│ ├── SekreterDetay.cs # Sekreter ana paneli formu kodu
│ ├── SekreterGiris.cs # Sekreter giriş formu kodu
│ ├── girisler.cs # Ana giriş seçim formu (Hasta, Doktor, Sekreter butonları)
│ ├── Properties/
│ │ └── AssemblyInfo.cs
│ ├── App.config
│ ├── Proje_Hastane.csproj
│ ├── sqlbaglanti.cs # SQL Server bağlantı sınıfı
│ └── ... (Formların .Designer.cs ve .resx dosyaları)
├── HastaneProje.bacpac # SQL Server veritabanı yedek dosyası
├── Proje_Hastane.sln # Visual Studio çözüm dosyası
└── README.md # Bu dosya
```


## ⚙️ Kurulum ve Çalıştırma

1.  **Microsoft SQL Server Kurulumu:**
    *   Sisteminizde Microsoft SQL Server (Express sürümü de olabilir) ve SQL Server Management Studio (SSMS) kurulu olmalıdır.
2.  **Veritabanı Geri Yükleme:**
    *   SSMS kullanarak `HastaneProje.bacpac` dosyasını yeni bir veritabanı olarak geri yükleyin (Import Data-tier Application).
3.  **Bağlantı Dizesi (Connection String) Ayarı:**
    *   `Proje_Hastane/sqlbaglanti.cs` dosyasını açın.
    *   `baglanti()` metodundaki bağlantı dizesini kendi SQL Server yapılandırmanıza göre düzenleyin:
        ```csharp
        // sqlbaglanti.cs içinde örnek:
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=YOUR_SERVER_NAME;Initial Catalog=HastaneProje;Integrated Security=True;"); // Veya SQL Auth kullanıyorsanız: User ID=your_user;Password=your_password;
            baglan.Open();
            return baglan;
        }
        ```
        `YOUR_SERVER_NAME` kısmını kendi SQL Server sunucu adınızla değiştirin (örn: `.\SQLEXPRESS`, `localhost`, `SUNUCU_ADI\INSTANCE_ADI`).
4.  **Projeyi Visual Studio'da Açma:**
    *   `Proje_Hastane.sln` dosyasını Visual Studio ile açın.
5.  **Projeyi Derleme ve Çalıştırma:**
    *   Visual Studio'da Projeyi Derleyin (Build Solution).
    *   Başlat (Start) butonuna basarak uygulamayı çalıştırın. Ana giriş ekranı (`girisler.cs`) açılacaktır.

---

## 🧠 Kod Akışı ve Mimarisi (Örnek Form: `HastaDetay.cs`)

*   **`HastaDetay_Load` Event'i:**
    *   Giriş yapan hastanın TC'si (`public string hastaTc;`) kullanılarak `Tbl_Hastalar` tablosundan hastanın adı ve soyadı çekilir ve ilgili `Label`'lara yazılır.
    *   Hastanın randevu geçmişi (`Tbl_Randevular`) `SqlDataAdapter` ve `DataTable` kullanılarak `DataGridView1`'e yüklenir.
    *   Tüm branşlar (`Tbl_Branslar`) `ComboBox1`'e yüklenir.
*   **`comboBox1_SelectedIndexChanged` Event'i (Branş Seçimi):**
    *   Hasta bir branş seçtiğinde, `ComboBox2` (Doktorlar) temizlenir.
    *   Seçilen branşa ait doktorlar (`Tbl_Doktorlar`) veritabanından çekilerek `ComboBox2`'ye yüklenir.
*   **`comboBox2_SelectedIndexChanged` Event'i (Doktor Seçimi):**
    *   Hasta bir doktor seçtiğinde, seçilen branş ve doktora ait, durumu 'False' (müsait) olan randevular (`Tbl_Randevular`) `DataGridView2`'ye yüklenir.
*   **`dataGridView2_CellClick` Event'i (Müsait Randevu Seçimi):**
    *   Kullanıcı `DataGridView2`'den bir randevu seçtiğinde, o randevunun `Randevuid`'si saklanır.
*   **`button1_Click` Event'i (Randevu Al Butonu):**
    *   Seçilen randevunun `RandevuDurum`'unu 'True' olarak günceller.
    *   Hastanın TC'sini (`HastaTC`) ve girdiği şikayeti (`richTextBox1.Text`) randevu kaydına ekler.
    *   İşlem sonrası `DataGridView2` güncellenerek alınan randevunun listeden kalkması sağlanır (artık `RandevuDurum='True'` olduğu için).
*   **`linkLabel1_LinkClicked` Event'i (Bilgilerimi Düzenle):**
    *   `BilgiDuzenle` formunu açar ve hastanın TC numarasını bu forma aktarır.
*   **SQL Bağlantısı:** Tüm veritabanı işlemleri için `sqlbaglanti` sınıfından bir nesne (`bgl`) oluşturulur ve `bgl.baglanti()` metodu ile bağlantı açılır. Bağlantıların kullanıldıktan sonra kapatılması (`bgl.baglanti().Close();`) önemlidir, ancak `SqlDataAdapter` gibi bazı ADO.NET bileşenleri bağlantıyı kendi yönetebilir. `using` bloğu içinde bağlantı açmak, otomatik kapatma için daha güvenli bir yoldur (`HastaDetay_Load` içinde örneklenmiş).

---

## 🚀 Gelecekteki Geliştirmeler ve İyileştirmeler

*   **Şifreleme:** Hasta ve personel şifreleri veritabanında `plain text` olarak saklanmak yerine, C# tarafında güvenli hash algoritmaları (örn: ASP.NET Identity'nin kullandığı gibi PBKDF2) ile hashlenerek saklanmalıdır. Giriş sırasında da bu hash'ler karşılaştırılmalıdır.
*   **Hata Yönetimi:** `try-catch` blokları ile daha robust hata yakalama ve kullanıcıya daha anlamlı hata mesajları sunma. Veritabanı bağlantı hataları, sorgu hataları vb.
*   **Veri Doğrulama (Validation):** Kullanıcı girdilerinin (TC formatı, telefon numarası formatı, boş bırakılamaz alanlar vb.) hem istemci (form kontrolleri) hem de sunucu (C# kodu) tarafında detaylı doğrulanması.
*   **Kullanıcı Arayüzü (UI/UX) Geliştirmeleri:** Daha modern ve estetik bir tasarım, daha sezgisel bir kullanıcı deneyimi. Belki WPF veya MAUI gibi daha yeni UI teknolojilerine geçiş.
*   **Raporlama:** Doktor ve branş bazlı hasta sayısı, en sık görülen şikayetler, aylık randevu istatistikleri gibi çeşitli raporlama modülleri eklenebilir.
*   **Performans Optimizasyonu:** Büyük veri setlerinde daha hızlı çalışması için veritabanı sorgularının ve C# kodunun optimize edilmesi. `SqlDataAdapter` yerine `SqlDataReader` ile daha verimli veri okuma (özellikle tek kayıt okuma veya listeleme için).
*   **Günlükleme (Logging):** Uygulamadaki önemli olayların (giriş denemeleri, kritik hatalar, veri değişiklikleri) bir log dosyasına veya veritabanına kaydedilmesi.
*   **Çoklu Dil Desteği.**
*   **Web veya Mobil Versiyon:** Uygulamanın web tabanlı bir versiyonu veya mobil uygulamalar geliştirilerek erişilebilirliği artırılabilir.
*   **Kod Tekrarının Azaltılması:** Benzer veritabanı işlemlerini (CRUD) yapan kod blokları için genel yardımcı sınıflar veya metotlar oluşturulabilir.

---

**Hastane Takip Uygulaması**, C# Windows Forms ile nelerin başarılabileceğine dair **etkileyici bir örnektir.** Kapsamlı modülleri, rol bazlı erişim kontrolü ve veritabanı etkileşimleri ile gerçek dünya problemlerine pratik çözümler sunmaktadır. Murat Yücedağ hocanızın rehberliğinde ortaya çıkardığınız bu çalışma, takdiri hak ediyor. **Elinize sağlık!**

**UYGULAMA İÇİ GÖRÜNTÜLER :**


![Screenshot_9](https://github.com/user-attachments/assets/d7437685-12ab-4d6c-9662-3a194597d193)
![Screenshot_8](https://github.com/user-attachments/assets/2ebfc13c-9278-43b8-90c9-e77bff5a98be)
![Screenshot_7](https://github.com/user-attachments/assets/38dfa9cb-b07f-4c21-a200-41bee16b136f)
![Screenshot_6](https://github.com/user-attachments/assets/ef9c3eaf-f6d6-4f26-a32c-019c19324cbc)
![Screenshot_5](https://github.com/user-attachments/assets/f273dec7-0393-41cf-a416-63a401b3f276)
![Screenshot_4](https://github.com/user-attachments/assets/869d537b-c0bf-4e65-8181-f85a74cd19cb)
![Screenshot_3](https://github.com/user-attachments/assets/201c3639-f896-4408-8f69-51df848ea8d7)
![Screenshot_2](https://github.com/user-attachments/assets/c501c433-b596-4f91-97d8-cceda6bd76e9)
![Screenshot_1](https://github.com/user-attachments/assets/102c3fb6-a863-4ddf-be49-4409a962547d)
![Screenshot_10](https://github.com/user-attachments/assets/afd09152-0fbb-4cd3-9c3a-a5cf29d8d6dc)
