using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
