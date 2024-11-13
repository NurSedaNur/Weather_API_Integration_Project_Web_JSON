namespace WeatherApi2.Services
{
    using RestSharp;// API çağrıları yapmak için kullanılır.
    using System.Threading.Tasks;//Asenkron işlemleri gerçekleştirmek için Task yapısını sağlar.
    using Newtonsoft.Json;//JSON formatındaki veriyi C# nesnelerine dönüştürmeyi sağlar.
    using WeatherApi2.Models;

    public class WeatherService
    {
        //Bu sınıf, hava durumu verilerini almak için API çağrısı yapar.
        private const string ApiUrl = "https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=";
        private const string ApiKey = "";  // Kendi API anahtarınızı buraya koyun

        public async Task<WeatherResponse> GetWeatherAsync(string city)
        {
            var client = new RestClient("https://api.collectapi.com");
            var request = new RestRequest("weather/getWeather", Method.Get);

            // Sorgu parametrelerini buraya ekliyoruz
            request.AddQueryParameter("data.lang", "tr");
            request.AddQueryParameter("data.city", city); // Dinamik olarak 'city' ekleniyor

            request.AddHeader("authorization", $"apikey {ApiKey}");
            request.AddHeader("content-type", "application/json");

            var response = await client.ExecuteAsync(request); // API çağrısını asenkron olarak gerçekleştirir

            // JSON yanıtını model nesnesine dönüştürme
            WeatherResponse weatherData = JsonConvert.DeserializeObject<WeatherResponse>(response.Content);

            return weatherData;
        }

    }

}

