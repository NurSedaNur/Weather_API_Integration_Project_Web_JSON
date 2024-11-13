using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherApi2.Models;
using WeatherApi2.Services;

namespace WeatherApi2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WeatherService _weatherService;

        public HomeController(ILogger<HomeController> logger, WeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index2()
        {
            var city = HttpContext.Request.Form["ilSecim"].ToString();

            // API çaðrýsýný gerçekleþtirirken city parametresini geçiriyoruz
            var weatherData = await _weatherService.GetWeatherAsync(city);

            return RedirectToAction("Index", "Weather", new { city });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
