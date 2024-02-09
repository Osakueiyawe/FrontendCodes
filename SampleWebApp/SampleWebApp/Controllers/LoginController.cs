using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Interfaces;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public IActionResult Index(LoginResponse request)
        {
            return View();
        }

        public IActionResult Home()
        {
            return RedirectToAction("Index","Home");
        }

        public IActionResult Login(LoginRequest loginRequest)
        {
            var loginResponse = _loginService.Login(loginRequest);
            if(loginResponse == null)
            {
                return View(new LoginResponse
                {
                    loginSuccessful = false
                });
            }
            else
            {
                if(!loginResponse.loginSuccessful)
                {
                    return RedirectToAction("Index","Login",loginResponse);
                }
                else
                {
                    return RedirectToAction("Index","Portfolio");
                }
            }
        }
    }
}
