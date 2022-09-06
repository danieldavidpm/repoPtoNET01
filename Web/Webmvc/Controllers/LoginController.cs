using Microsoft.AspNetCore.Mvc;

namespace Webmvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
