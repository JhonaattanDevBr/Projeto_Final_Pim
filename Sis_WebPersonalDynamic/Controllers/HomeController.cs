using Microsoft.AspNetCore.Mvc;
using Sis_WebPersonalDynamic.Models;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
        /*public IActionResult Index()
        {
            List<FuncionarioModel> ListasFuncionarios = ListaFuncionario();

            return View(ListasFuncionarios);
        }

        public List<FuncionarioModel> ListaFuncionario()
        {


            var conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_teste_dados_personal;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSQL);
            FuncionarioModel funcionario = new FuncionarioModel();

            List<FuncionarioModel> lista = new List<FuncionarioModel>();

            conexaoDB.Open();

            string query = "SELECT Nome, Cargo, Data_admissao, Salario FROM Funcionario"; 

            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                funcionario.Nome = reader.GetString(0);
                funcionario.Cargo = reader.GetString(1);
                funcionario.Data_admissao = reader.GetDateTime(2);
                funcionario.Salario = reader.GetFloat(3);

                lista.Add(funcionario);
            }


            return lista;
        }

       private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}