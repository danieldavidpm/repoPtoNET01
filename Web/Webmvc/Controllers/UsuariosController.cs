using Microsoft.AspNetCore.Mvc;

namespace Webmvc.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Usuarios()
        {
            return View();
        }
    }
}
