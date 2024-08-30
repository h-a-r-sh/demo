using Microsoft.AspNetCore.Mvc;
using MVCPractice.Functionality;
using MVCPractice.Models;
using MVCPractice.Services;

namespace MVCPractice.Controllers
{
    public class AccountController : Controller
    { IAccountServices accountServices;
        public AccountController() { 
            accountServices=new AccountServices();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp() 
        { 
            return View(); 
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User user)
        {
            var temp=accountServices.AccountCreate(user);
            if (temp > 0)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var temp=accountServices.AccountLogin(user.UserName, user.Password);
            if (temp > 0) { 
                return RedirectToAction("Privacy","Home");
            }
            return View();
        }


    }
}
