using Microsoft.AspNetCore.Mvc;
using WebPIM.Models;
using System.Data.SqlClient;
using System.Data;

namespace WebPIM.Controllers
{
    public class FeriasController : Controller
    {
        private string conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
        public IActionResult Ferias()
        {
            try
            {
                List<FeriasModel> ferias = ObterListaFerias();
                ViewBag.StatusFerias = CalcularStatusFerias(ferias);

                return View(ferias);
            }
            catch (Exception ex)
            {
                // Lide com a exceção de forma adequada, talvez exibindo uma mensagem de erro na View
                ViewBag.ErrorMessage = "Ocorreu um erro ao obter as informações de férias.";
                return View(new List<FeriasModel>());
            }
        }

        private string CalcularStatusFerias(List<FeriasModel> ferias)
        {
            bool todasLiberadas = ferias.All(f => f.ObterStatusFerias() == "Liberada");
            bool todasNaoAgendadas = ferias.All(f => f.ObterStatusFerias() == "Não Agendada");

            if (todasLiberadas)
            {
                return "Férias liberada";
            }
            else if (todasNaoAgendadas)
            {
                return "Férias nãp agendada";
            }
            else
            {
                return "Suas férias não está liberada ou agendada";
            }
        }

        public List<FeriasModel> ObterListaFerias()
        {
            List<FeriasModel> lista = new List<FeriasModel>();

            using (SqlConnection conexaoDB = new SqlConnection(conexaoSQL))
            {
                conexaoDB.Open();
                string query = $"SELECT Ferias.*," +
                    $"Funcionarios.Nome AS nome, Funcionarios.Sobrenome AS sobrenome, Funcionarios.Registro AS registro " +
                    $"FROM Ferias " +
                    $"INNER JOIN Funcionarios ON Ferias.Id_funcionarios = Funcionarios.Id_funcionario";

                using (SqlCommand command = new SqlCommand(query, conexaoDB))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FeriasModel ferias = new FeriasModel();

                            ferias.Dias_gozados = reader.GetInt32(1);
                            ferias.Saida = reader.GetDateTime(2);
                            ferias.Retorno = reader.GetDateTime(3);
                            ferias.Nome = reader.GetString(reader.GetOrdinal("nome"));
                            ferias.Sobrenome = reader.GetString(reader.GetOrdinal("sobrenome"));
                            ferias.Registro = reader.GetInt32(reader.GetOrdinal("registro"));

                            lista.Add(ferias);
                        }
                        return lista;
                    }
                }
            }
        }
    }
}
