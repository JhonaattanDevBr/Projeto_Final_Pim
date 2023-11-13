using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebPIM.Models;
using System.Data.SqlClient;
using BaseDeDados;

namespace WebPIM.Controllers
{
    public class HomeController : Controller
    {
        servidoresBancoDados _servidoresBancoDados = new servidoresBancoDados();

            public IActionResult Index()
            {
                List<FuncionarioModel> ListasFuncionarios = ListaFuncionario();

                return View(ListasFuncionarios);
            }

        public List<FuncionarioModel> ListaFuncionario()
        {
            //var conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
            //SqlConnection conexaoDB = new SqlConnection(conexaoSQL);

            SqlConnection conexaoDB = new SqlConnection(_servidoresBancoDados.servidor);

            List<FuncionarioModel> lista = new List<FuncionarioModel>();

            // Agora você pode usar Session["id_funcionario"] para recuperar o ID do funcionário logado
            var id_funcionario_logado = HttpContext.Session.GetInt32("id_funcionario");

            conexaoDB.Open();

            string query = $"SELECT * FROM Funcionarios WHERE Id_funcionario = '{id_funcionario_logado}'";

            using SqlCommand command = new SqlCommand(query, conexaoDB);
            using SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                FuncionarioModel funcionario = new FuncionarioModel
                {
                    Nome = reader.GetString(1),
                    Sobrenome = reader.GetString(2),
                    Idade = reader.GetInt32(3),
                    Sexo = reader.GetString(4),
                    Id_endereco = reader.GetInt32(5),
                    Registro = reader.GetInt32(6),
                    Carga_horaria = reader.GetInt32(7),
                    Cpf = reader.GetString(8),
                    Rg = reader.GetString(9),
                    Email = reader.GetString(10),
                    Email_secundario = reader.GetString(11),
                    Telefone = reader.GetString(12),
                    Cell_principal = reader.GetString(13),
                    Cell_secundario = reader.GetString(14),
                    Num_dependentes = reader.GetInt32(15),
                    Id_planos_saude = reader.GetInt32(16),
                    Id_planos_odontologicos = reader.GetInt32(17),
                    Id_empresas = reader.GetInt32(18),
                    Cargo = reader.GetString(19),
                    Salario = reader.GetDouble(20), //  O ERRO ERA AQUI, LA NA MODEL ESTAVA COM TIPO DE DADO DOUBLE E AQUI ESTAVA GetFloat e por isso estaava dando erro.
                    Data_admissao = reader.GetDateTime(21)
                };

                lista.Add(funcionario);
            }
            return lista;
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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