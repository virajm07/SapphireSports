using Microsoft.AspNetCore.Mvc;
using SapphireSports.Models;
using System.Diagnostics;

namespace SapphireSports.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contactus()
        {
            return View();
        }

        public IActionResult Cricket()
        {
            return View();
        }

        public IActionResult Football()
        {
            return View();
        }

        public IActionResult Tennis()
        {
            return View();
        }

        public IActionResult Rugby()
        {
            return View();
        }

        public IActionResult Basketball()
        {
            return View();
        }

        public IActionResult Shoes()
        {
            return View();
        }

        public IActionResult Delivery()
        {
            return View();
        }

        public IActionResult Cart()
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
