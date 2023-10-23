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
            List<FuncionarioModel> ListasFuncionarios = ListaFuncionario();

            return View(ListasFuncionarios);
        }

        public List<FuncionarioModel> ListaFuncionario()
        {


            var conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSQL);
            FuncionarioModel funcionario = new FuncionarioModel();

            List<FuncionarioModel> lista = new List<FuncionarioModel>();

            conexaoDB.Open();

            string query = "SELECT * FROM Funcionarios"; 

            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                funcionario.Nome = reader.GetString(1);
                funcionario.Sobrenome = reader.GetString(2);
                funcionario.Idade = reader.GetInt32(3);
                funcionario.Sexo = reader.GetString(4);               
                funcionario.Id_endereco = reader.GetInt32(5);
                funcionario.Registro = reader.GetInt32(6);
                funcionario.Carga_horaria = reader.GetInt32(7);
                funcionario.Cpf = reader.GetString(8);
                funcionario.Rg = reader.GetString(9);
                funcionario.Email = reader.GetString(10);
                funcionario.Email_secundario= reader.GetString(11);
                funcionario.Telefone = reader.GetString(12);
                funcionario.Cell_principal = reader.GetString(13);
                funcionario.Cell_secundario = reader.GetString(14);
                funcionario.Num_dependentes = reader.GetInt32(15);
                funcionario.Id_planos_saude = reader.GetInt32(16);
                funcionario.Id_planos_odontologicos = reader.GetInt32(17);
                funcionario.Id_empresas = reader.GetInt32(18);
                funcionario.Cargo = reader.GetString(19);
                funcionario.Salario = reader.GetFloat(20);
                funcionario.Data_admissao = reader.GetDateTime(21);

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
        }
    }
}