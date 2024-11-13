namespace WeatherApi2.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using WeatherApi2.Services;

    public class WeatherController : Controller
    {
        //Bu sınıf; Hava durumu verisini almak ve View'a göndermek içindir.
        private readonly WeatherService _weatherService;

        public WeatherController()
        {
            // WeatherService sınıfını başlatıyoruz
            _weatherService = new WeatherService();
        }

        // Hava durumu verilerini almak için bir action
        public async Task<IActionResult> Index(string city = "ankara")
        {
            var weather = await _weatherService.GetWeatherAsync(city);// API'den hava durumu verilerini alıyoruz
            ViewBag.il = city;
            return View(weather);
        }
    }
}
