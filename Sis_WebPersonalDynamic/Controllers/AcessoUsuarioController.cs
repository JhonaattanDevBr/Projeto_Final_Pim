using Microsoft.AspNetCore.Mvc;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class AcessoUsuarioController : Controller
    {
        public IActionResult Inicio() //Aqui temos uma view da primeira página quando se acessa o sistema  
        {
            return View();
        }

        public IActionResult Salario()
        {
            return View();
        }
        public IActionResult FolhaPag() //Criar view (andamento)
        {
            return View();
        }

        public IActionResult Holerite()
        {
            return View();
        }
         

        public IActionResult SolicitaFerias()
        {
            return View();  
        }

    }
}
