using Microsoft.AspNetCore.Mvc;
using MVCRevision.Functionality;
using MVCRevision.Models;
using MVCRevision.Services;

namespace MVCRevision.Controllers
{
    public class AccountController : Controller
    {
        IAccountOperation AccountOperation;
        public AccountController() 
        {
            AccountOperation = new AccountServices();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AccountCreate()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AccountCreates()
        {
            return View("AccountCreates");
        }
        [HttpPost]
        public IActionResult AccountCreate(Account account)
        {   var temp = AccountOperation.createAccount(account);
            if (temp > 0)
            {
                ViewBag.Message = "Account Created";
            }
            return View();
        }
    }
}
