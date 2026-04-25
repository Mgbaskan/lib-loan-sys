# Kütüphane Ödünç Sistemi

.NET Framework 4.7.2 ile oluşturulmuş, kütüphane operasyonlarını (kitaplar, üyeler, ödünçler ve iadeler) yönetmek için Windows Forms masaüstü uygulaması.

## Genel Bakış

Kütüphane Ödünç Sistemi, kütüphane operasyonlarını kolaylaştırmak için tasarlanmış kapsamlı bir yönetim aracıdır. Kütüphane envanterini, üye kayıtlarını ve ödünç/iade işlemlerini yönetmek için sezgisel bir grafik arayüz sağlar.

## Özellikler

- **Kitap Yönetimi** - Kütüphane kataloğuna kitap ekleme, düzenleme ve yönetim
- **Üye Yönetimi** - Kütüphane üyelerini kayıt etme ve yönetme
- **Yazar Yönetimi** - Kitap yazarlarını ve bilgilerini yönetme
- **Kategori Yönetimi** - Kitapları kategorilere göre düzenleme
- **Ödünç Yönetimi** - Üyelere kitap ödünç verme kayıtları
- **Aktif Ödünçler İzleme** - Devam eden ödünçleri görüntüleme ve izleme
- **İade Yönetimi** - Kitap iadelerini işleme ve kayıtları güncelleme
- **Girdi Doğrulama** - Tüm kullanıcı girdileri için kapsamlı doğrulama
- **Modern UI Teması** - Tutarlı temalandırma ile tasarlanmış Windows Forms arayüzü

## Teknoloji Yığını

- **Platform**: .NET Framework 4.7.2
- **UI Framework**: Windows Forms
- **Veritabanı**: SQL Server (SqlClient aracılığıyla)
- **Dil**: C#

## Proje Yapısı

```
LibraryLoanSystem/
├── Forms/                          # Kullanıcı Arayüzü formları
│   ├── MainForm.cs                 # Ana uygulama penceresi
│   ├── BooksForm.cs                # Kitap yönetimi arayüzü
│   ├── MembersForm.cs              # Üye yönetimi arayüzü
│   ├── AuthorsForm.cs              # Yazar yönetimi arayüzü
│   ├── CategoriesForm.cs           # Kategori yönetimi arayüzü
│   ├── LoansForm.cs                # Ödünç oluşturma arayüzü
│   ├── ActiveLoansForm.cs          # Aktif ödünçler izleme arayüzü
│   ├── ReturnsForm.cs              # İade işleme arayüzü
│   ├── BaseForm.cs                 # Ortak işlevlere sahip temel form sınıfı
│   ├── ControlStyler.cs            # UI şekillendirme ve temalandırma
│   ├── Theme.cs                    # Tema yapılandırması
│   ├── InputValidationHelper.cs    # Girdi doğrulama yardımcıları
│   └── DesignTimeHelper.cs         # Tasarım zamanı yardımcı yardımcıları
├── DataAccess/                     # Veri erişim katmanı
│   ├── Database.cs                 # Veritabanı bağlantı yapılandırması
│   └── DbHelper.cs                 # Veritabanı işlem yardımcıları
├── Properties/                     # Derleme özellikleri ve kaynaklar
├── Program.cs                      # Uygulama giriş noktası
└── LibraryLoanSystem.csproj        # Proje dosyası
```

## Başlangıç

### Gereksinimler

- .NET Framework 4.7.2 veya üstü
- SQL Server (SQLEXPRESS veya eşdeğeri)
- Visual Studio 2017 veya üstü (geliştirme için)

### Kurulum

1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/Mgbaskan/LibraryLoanSystem.git
   ```

2. Visual Studio'da `LibraryLoanSystem.sln` dosyasını açın

3. `DataAccess/Database.cs` dosyasında veritabanı bağlantı dizesini yapılandırın:
   ```csharp
   public static string ConnectionString = 
       "Server=SERVERİNİZ\\SQLEXPRESS;Database=KutuphaneDB;Trusted_Connection=True;TrustServerCertificate=True;";
   ```

4. SQL Server'da `KutuphaneDB` veritabanını gerekli tablolarla oluşturun

5. Uygulamayı derleyin ve çalıştırın

### Uygulamayı Çalıştırma

Visual Studio'da `F5` tuşuna basın veya Başlat düğmesine tıklayarak uygulamayı başlatın.

## Çekirdek Bileşenler

### Forms Katmanı
- **MainForm**: Tüm yönetim modüllerine gezinme özelliğine sahip uygulamanın giriş noktası
- **Entity Forms**: Kitaplar, üyeler, yazarlar ve kategorileri yönetmek için ayrı formlar
- **Transaction Forms**: Ödünç oluşturma, aktif ödünçleri izleme ve iade işleme
- **Styling System**: `ControlStyler` ve `Theme` aracılığıyla merkezi kontrol şekillendirmesi

### Veri Erişim Katmanı
- **Database**: SQL Server bağlantı dizesini yöneten statik sınıf
- **DbHelper**: Veritabanı işlemleri için yardımcı araçlar

### Yardımcı Araçlar
- **InputValidationHelper**: Tüm formlarda kullanıcı girdilerini doğrular
- **DesignTimeHelper**: Visual Studio tasarımcısında tasarım zamanı renderingini işler

## Özelliklerin Detayları

### Kitap Yönetimi
- Kitap detaylarıyla yeni kitaplar ekleme (başlık, ISBN, kategori, yazar)
- Mevcut kitap bilgilerini düzenleme
- Katalogdaki tüm kitapları görüntüleme
- Kitap envanter durumunu yönetme

### Üye Yönetimi
- Yeni kütüphane üyelerini kayıt etme
- Üye iletişim bilgilerini saklama
- Üye detaylarını ve geçmişini görüntüleme
- Üye durumunu yönetme

### Ödünç İşlemi
- Üyelere yeni ödünçler oluşturma
- Aktif ödünçleri gerçek zamanlı izleme
- Ödünç geçmişini ve son tarihlerini görüntüleme
- Otomatik son tarih hesaplaması

### İade İşlemi
- Üyelerden kitap iadelerini işleme
- İade sonrasında envanteri güncelleme
- İade makbuzları oluşturma
- İade geçmişini izleme

## Kullanıcı Arayüzü / Deneyim

Uygulama aşağıdaki özellikleri içerir:
- Temiz, modern Windows Forms arayüzü
- Tüm formlarda tutarlı temalandırma
- Kullanıcı dostu hata mesajları ile girdi doğrulama
- Modüller arasında sezgisel gezinti
- Duyarlı kontroller ve iletişim kutuları

## Geliştirme

### Geliştirme için Gereksinimler
- Visual Studio 2017 veya 2019+
- .NET Framework 4.7.2 SDK

### Derleme
```bash
dotnet build
```

### Veritabanı Kurulumu
Uygulama, aşağıdaki tablolara sahip `KutuphaneDB` adında bir SQL Server veritabanı gerektirir:
- Kitaplar
- Üyeler
- Yazarlar
- Kategoriler
- Ödünçler
- İadeler

## Lisans

Bu proje eğitim ve kütüphane yönetimi amaçları için olduğu gibi sağlanmaktadır.

## Depo

- **GitHub**: [https://github.com/Mgbaskan/LibraryLoanSystem](https://github.com/Mgbaskan/LibraryLoanSystem)
- **Branch**: master

## Yazar

Mgbaskan

---

Sorunlar, özellik istekleri veya katkılar için lütfen GitHub deposunu ziyaret edin.
