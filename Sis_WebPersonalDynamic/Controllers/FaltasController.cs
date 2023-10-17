using Microsoft.AspNetCore.Mvc;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class FaltasController : Controller
    {
        public IActionResult Falta()
        {
            return View();
        }
        public IActionResult SolicitarFaltas()
        {
            return View();
        }
        public IActionResult EnviarAtestado()
        {
            return View();
        }
    }
}
