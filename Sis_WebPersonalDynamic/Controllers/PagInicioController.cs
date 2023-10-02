using Microsoft.AspNetCore.Mvc;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class PagInicioController : Controller
    {
        public IActionResult Inicio() 
        //Aqui temos uma view da primeira página quando se acessa o sistema  
        {
            return View();
        }

    }
}
