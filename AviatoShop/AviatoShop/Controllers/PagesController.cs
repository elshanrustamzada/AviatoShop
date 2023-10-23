using Microsoft.AspNetCore.Mvc;

namespace AviatoShop.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
