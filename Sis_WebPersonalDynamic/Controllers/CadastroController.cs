using Microsoft.AspNetCore.Mvc;
using Sis_WebPersonalDynamic.Models;
using System.Data.SqlClient;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult NovoCadastro()
        {
            return View();
        }

        /*public IActionResult CadastraUsuario(CadastroModel cadastro)
        {
            if (Cadastra(cadastro))
            {
                //Criar condição de validação com os campos de cadastro e mensagem de retorno 
                //para sucessos
                return RedirectToAction("Login", "Index");
            }
            return View("Index");
        }
        protected bool Cadastra (CadastroModel cadastro)
        {
            //Fazer conexão com Banco de Dadoss

            var conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_teste_dados_personal;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSQL);

            conexaoDB.Open();

            string query = $""; //Query para cadastrar no sistema
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();

        }
    }*/
    }
}
