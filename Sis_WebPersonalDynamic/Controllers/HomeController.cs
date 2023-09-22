using Microsoft.AspNetCore.Mvc;
using Sis_WebPersonalDynamic.Models;
using System.Diagnostics;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class HomeController : Controller
    {/*
      *  ESTA SÃO AS FORMATAÇÕES NORMAIS QUE O ARQUIVO CRIOU, COMO NÃO SEI SEI PRECISA COMENTEI E COLEI O CÓFIGO QUE ESTAVA NO SEU PROJETO.
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}