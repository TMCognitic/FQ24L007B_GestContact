using FQ24L007B_GestContact.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FQ24L007B_GestContact.Controllers
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

        public IActionResult Contact()
        {
            return View();
        }

    }
}
