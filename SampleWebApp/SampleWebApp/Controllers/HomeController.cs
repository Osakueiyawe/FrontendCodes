using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;
using System.Diagnostics;

namespace SampleWebApp.Controllers
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

        public IActionResult Notification(string emailAddress)
        {            
            return RedirectToAction("Index");
        }
        
        public IActionResult Login()
        {
            return RedirectToAction("Index","Login");
        }

        public IActionResult CreateAccount()
        {
            return RedirectToAction("Index", "CreateAccount");
        }
    }
}