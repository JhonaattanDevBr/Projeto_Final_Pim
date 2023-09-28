using Microsoft.AspNetCore.Mvc;
using Sis_WebPersonalDynamic.Models;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValidaUsuario (LoginModel login)
        {
            if (Validacao(login))
            {
                return RedirectToAction("AcessoUsuario", "AcessoUsuario");
            }
            return View("Index");  
        }

        protected bool Validacao(LoginModel login)
        {
            var conexaoSQL = @"Data";

        }

    }
}
