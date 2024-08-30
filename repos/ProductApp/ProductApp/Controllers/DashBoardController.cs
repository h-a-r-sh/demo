using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            var res = HttpContext.Session.GetString("User");
            ViewBag.Title = res;
            return View();
        }
    }
}
