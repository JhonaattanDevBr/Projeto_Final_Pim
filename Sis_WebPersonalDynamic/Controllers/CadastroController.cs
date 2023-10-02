using Microsoft.AspNetCore.Mvc;
using Sis_WebPersonalDynamic.Models;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult NovoCadastro()
        {
            return View();
        }

        public IActionResult CadastraUsuario(CadastroModel cadastro)
        {
            if (ValidaCadastro(cadastro))
            {
                //Criar condição de validação com os campos de cadastro e mensagem de retorno 
                //para sucessos
                return RedirectToAction("Home", "Index");
            }
            return View("Index");
        }
        protected bool ValidaCadastro(CadastroModel cadastro)
        {
            //Fazer conexão com Banco de Dadoss

            var conexaoSQL = @"Data";
            SqlConnection conexaoDB = SqlConnection(conexaoSQL);

            conexaoDB.Open();

            string query = $""; //Query para cadastrar no sistema
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();

        }
    }
}
