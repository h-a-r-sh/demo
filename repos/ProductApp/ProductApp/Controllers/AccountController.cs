using Microsoft.AspNetCore.Mvc;
using ProductApp.Functionality;
using ProductApp.Models;
using ProductApp.Services;

namespace ProductApp.Controllers
{
    public class AccountController : Controller
    {   IAccountOperations operations;
        public AccountController() {
            operations = new AccountService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(Account account)
        {

            int temp = operations.AccountValidation(account.Username,account.Password);
            if (temp > 0)
            {
                HttpContext.Session.SetString("User",account.Username);
                return RedirectToAction("Index", "DashBoard");
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult SignIn()
        {   
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Account account)
        {
            int temp= operations.AccountCreate(account);
            if (temp > 0) {
                ViewBag.Message="Account Created";
                return RedirectToAction("SignIn", "Account");
            }

            return View();
        }

    }
}
