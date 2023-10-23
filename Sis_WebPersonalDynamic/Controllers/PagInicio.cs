using Microsoft.AspNetCore.Mvc;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class PagInicio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
