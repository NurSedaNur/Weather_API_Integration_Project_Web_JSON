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

### Uygulamayı Çalıştırma:

1. Uygulamayı derleyin ve çalıştırın.
2. Ana sayfaya gidin ve bir şehir adı girerek o şehir için hava durumu verilerini görüntüleyin.

---
# Weather API Project

This project is an ASP.NET MVC web application that fetches and displays weather data using the CollectAPI. Users can select a city and view the weather information for that city, which includes temperature, humidity, and an icon representing the weather conditions.

## Features

- **City Selection:** Users can enter a city name to retrieve weather data for that city.
- **Weather Details:** The displayed data includes date, day, current temperature, minimum and maximum temperatures, humidity, and a weather icon.
- **Localized Content:** The application retrieves weather data in Turkish.

## Project Structure

```plaintext
├── Controllers
│   ├── HomeController.cs       // Handles the home page and city input form submission
│   └── WeatherController.cs    // Fetches and displays weather data
├── Models
│   ├── WeatherResult.cs        // Represents individual weather data
│   └── WeatherResponse.cs      // Contains a list of WeatherResult
├── Services
│   └── WeatherService.cs       // Interacts with the external weather API using RestSharp
├── Views
│   ├── Home
│   │   └── Index.cshtml        // View for the city selection form
│   └── Weather
│       └── Index.cshtml        // Displays weather data for the selected city
└── wwwroot                     // Static files and dependencies
```









## Ekran Görüntüleri


![Adsız tasarım](https://github.com/user-attachments/assets/88cd6b55-4213-4753-b901-ceba1af0c0c9)
