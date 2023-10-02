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
                return RedirectToAction("PagInicio", "Inicio");
            }
            return View("Index");  
        }

        protected bool Validacao(LoginModel login)
        {
            //Fazer conexão com Banco de Dadoss
            var conexaoSQL = @"Data";
            SqlConnection conexaoDB = SqlConnection(conexaoSQL);

            conexaoDB.Open();

            if(login.Email == null || login.Senha == null)
            {
                TempData["MensagemErro"] = "Não foi possível logar no sistema";
                return false;
            }

            string query = $"";//Query para logar no sistema
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                login.Valido = false;
                TempData["MensagemErro"] = "Email ou senha incorreta";
                return false;
            }



        }

    }
}
