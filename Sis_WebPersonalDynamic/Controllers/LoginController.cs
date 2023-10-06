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

        public ActionResult Login(LoginModel login)
        {
            // Verifique se o email e a senha correspondem a um registro válido no banco de dados
            string suaConsultaSQL = "SELECT COUNT(*) FROM Acesso_funcionario WHERE Email = @email AND Senha = @senha";
            int count = 0;

            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_teste_dados_personal;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(suaConsultaSQL, connection))
                {
                    command.Parameters.AddWithValue("@email", login.Email);
                    command.Parameters.AddWithValue("@senha", login.Senha);
                    count = (int)command.ExecuteScalar();
                }
            }

            if (count == 1)
            {
                // Credenciais válidas, redirecione para a página inicial
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Credenciais inválidas, exiba uma mensagem de erro
                TempData["MensagemErro"] = "Email ou senha inválidos";
                //ModelState.AddModelError("", "Email ou senha inválidos.");
                return View(login);
            }
        }


        /* public IActionResult ValidandoUsuario(LoginModel login)
         {
             if (Validacao(login))
             {
                 return RedirectToAction("Home", "Index");
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

             string query = $"SELECT Email, Senha FROM Acesso_funcionario WHERE Email = { login.Email} AND Senha = {login.Senha}";
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
         }*/
    }
}

