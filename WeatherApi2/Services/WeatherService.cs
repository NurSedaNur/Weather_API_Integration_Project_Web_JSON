namespace WeatherApi2.Services
{
    using RestSharp;// API çağrıları yapmak için kullanılır.
    using System.Threading.Tasks;//Asenkron işlemleri gerçekleştirmek için Task yapısını sağlar.
    using Newtonsoft.Json;//JSON formatındaki veriyi C# nesnelerine dönüştürmeyi sağlar.
    using WeatherApi2.Models;

    public class WeatherService
    {
        //Bu sınıf, hava durumu verilerini almak için API çağrısı yapar.

        private const string ApiUrl = "https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=ankara";
        private const string ApiKey = "";  // Kendi API anahtarınızı buraya koyun

        public async Task<WeatherResponse> GetWeatherAsync()
        {
            var client = new RestClient(ApiUrl);//RestClient sınıfını kullanarak, ApiUrl URL’sine erişim sağlayacak bir client nesnesi oluşturur. 
            var request = new RestRequest(ApiUrl, Method.Get);//API’ye gönderilen isteklerin tüm detaylarını (URL, parametreler, başlıklar vb.) tanımlar.

            request.AddHeader("authorization", $"apikey {ApiKey}");
            request.AddHeader("content-type", "application/json");

            var response = await client.ExecuteAsync(request);//API çağrısını asenkron olarak gerçekleştirir. 

            // JSON yanıtını model nesnelerine dönüştür--> Deserialization işlemi: JSON yapısına uygun olarak model sınıflarında (WeatherResponse ve WeatherResult) tanımladığımız özelliklere verileri aktarır
            WeatherResponse weatherData = JsonConvert.DeserializeObject<WeatherResponse>(response.Content);

            return weatherData;
        }
    }

}

