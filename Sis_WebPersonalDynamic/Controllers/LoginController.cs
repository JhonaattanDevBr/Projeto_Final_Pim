using Microsoft.AspNetCore.Mvc;
using Sis_WebPersonalDynamic.Models;
using System.Data.SqlClient;


namespace Sis_WebPersonalDynamic.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValidandoUsuario(LoginModel login)
        {
            if (Validacao(login))
            {
                return RedirectToAction("Index", "Home");
            }
            return View("Index"); 
        }

        protected bool Validacao(LoginModel login)
        {
            //Fazer conexão com Banco de Dadoss
            var conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_teste_dados_personal;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSQL);

            conexaoDB.Open();

            if(login.Email == null || login.Senha == null)
            {
                TempData["MensagemErro"] = "Não foi possível logar no sistema";
                return false;
            }

            string query = $"SELECT Email, Senha FROM Acesso_funcionarios WHERE Email  = { login.Email} AND Senha = {login.Senha}";
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                login.Valido = false;
                TempData["MensagemErro"] = "Email ou senha incorreta";
                return false;
            }
            else
            {
               login.Valido = true;
                return true;
            }
        }
    }
}
