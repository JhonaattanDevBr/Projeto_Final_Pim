using Microsoft.AspNetCore.Mvc;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult NovoCadastro()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }
    }
}
