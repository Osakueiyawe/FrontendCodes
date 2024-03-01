using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class PortfolioController : Controller
    {               
        public IActionResult Index(PortfolioResponse response)
        {
            try
            {
                if (!response.loginSuccessful || !GetRedirectedResponse())
                {
                    TempData.Clear();
                    return RedirectToAction("Index", "Login", response);
                }
                return View();
            }
            catch(Exception ex) 
            {
                return RedirectToAction("Index", "Login");
            }
            
        }

        public IActionResult PortfolioDetails()
        {
            var portfolioResponse = new PortfolioResponse();
            var portfolioDetails = new List<PortfolioDetails>()
            {
                new PortfolioDetails() {id = 1, name = "Osaks", skillset = "Programming", skillStrength = "Advanced"},
                new PortfolioDetails() {id = 2, name = "Efos", skillset = "Medicine", skillStrength = "Skilled"},
                new PortfolioDetails() {id = 3, name = "Sharon", skillset = "Escavation", skillStrength = "Beginner"}
            };
            portfolioResponse.portfolioDetails = portfolioDetails;
            return View(portfolioResponse);
        }
        [HttpPost]
        public IActionResult PortfolioDetailView(string portfolioId)
        {
            return RedirectToAction("PortfolioDetails", "Portfolio");
        }
        public IActionResult ReturnToLoginPage()
        {
            return RedirectToAction("Index", "Login");
        }
        private bool GetRedirectedResponse()
        {
            var redirected = TempData["Redirected"] as bool? ?? false;
            TempData.Clear();
            return redirected;
        }
    }
}
