using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebPIM.Models;

namespace WebPIM.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Login(CadastroModel login)//
        {
            if (string.IsNullOrEmpty(login.Email) || string.IsNullOrEmpty(login.Senha))
            {
                TempData["MensagemErro"] = "Email e senha são obrigatórios";
                return View("Index", login);
            }

            //string query = "SELECT COUNT(*) FROM Cadastro WHERE Email = @email AND Senha = @senha";
            string query = "SELECT Id_funcionario FROM Cadastro WHERE Email = @email AND Senha = @senha";

            //int count = 0;
            int idFuncionario = 0;

            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", login.Email);
                    command.Parameters.AddWithValue("@senha", login.Senha);

                    var result = command.ExecuteScalar();
                    //count = (int)command.ExecuteScalar();
                    if (result != null)
                    {
                        idFuncionario = (int)result;

                        // Criando a sessão
                        HttpContext.Session.SetInt32("id_funcionario", idFuncionario);

                        // Credenciais válidas, redirecione para a página Index
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        // Credenciais inválidas, exiba uma mensagem de erro
                        TempData["MensagemErro"] = "Email ou senha inválidos";
                        //ModelState.AddModelError("", "Email ou senha inválidos.");
                        return View("Index", login);
                    }
                }
            }

                //if (count == 1)
                //{
                // Credenciais válidas, redirecione para a página Index
                //   return RedirectToAction("Index", "Home");
                // }
                
        }
    }
}

