# Hava Durumu API Projesi

Bu proje, CollectAPI kullanarak hava durumu verilerini çeken ve görüntüleyen bir ASP.NET MVC web uygulamasıdır. Kullanıcılar, bir şehir seçerek o şehir için hava durumu bilgilerini görüntüleyebilirler. Bu bilgiler arasında sıcaklık, nem ve hava koşullarını simgeleyen bir ikon bulunmaktadır.

## Özellikler

- **Şehir Seçimi:** Kullanıcılar bir şehir ismi girerek o şehre ait hava durumu verilerini alabilir.
- **Hava Durumu Detayları:** Görüntülenen veriler arasında tarih, gün, sıcaklık (şu anki, minimum, maksimum), nem oranı ve hava durumu ikonu bulunur.
- **Yerelleştirilmiş İçerik:** Uygulama, hava durumu verilerini Türkçe olarak alır.

## Proje Yapısı

```plaintext
├── Controllers
│   ├── HomeController.cs       // Ana sayfa ve şehir giriş formu gönderisini işler
│   └── WeatherController.cs    // Hava durumu verisi çekme ve görüntüleme işlemlerini yapar
├── Models
│   ├── WeatherResult.cs        // Bireysel hava durumu verisi modelini temsil eder
│   └── WeatherResponse.cs      // WeatherResult listesi içerir
├── Services
│   └── WeatherService.cs       // RestSharp kullanarak dış hava durumu API'si ile etkileşim kurar
├── Views
│   ├── Home
│   │   └── Index.cshtml        // Şehir seçme formunun görünümü
│   └── Weather
│       └── Index.cshtml        // Seçilen şehir için hava durumu verilerini gösterir
└── wwwroot                     // Statik dosyalar ve bağımlılıklar
```
## Bağımlılıklar

- **ASP.NET Core MVC:** Web uygulamasının geliştirilmesi için kullanılan framework.
- **RestSharp:** CollectAPI hava durumu servisine HTTP istekleri yapmak için kullanılan kütüphane.
- **Newtonsoft.Json:** JSON veri serileştirme ve serileştirmeyi gerçekleştiren kütüphane.

## Kullanım

### API Anahtarını Ayarlama:

1. CollectAPI adresinden bir API anahtarı alın.
2. `WeatherService.cs` dosyasındaki `ApiKey` sabitine anahtarınızı ekleyin:
   ```csharp
   private const string ApiKey = "API_ANAHTARINIZ";
   ```



![Adsız tasarım](https://github.com/user-attachments/assets/88cd6b55-4213-4753-b901-ceba1af0c0c9)
