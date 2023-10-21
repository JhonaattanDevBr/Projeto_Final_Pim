using Microsoft.AspNetCore.Mvc;
using Sis_WebPersonalDynamic.Models;
using System.Data.SqlClient;
using System.Data;


namespace Sis_WebPersonalDynamic.Controllers
{
    public class PontoController : Controller
    {
        public int TotalHorasTrabalhadas { get; set; }
        public int HorasFaltantes { get; set; }
        public int HorasACompensar { get; set; }

        public IActionResult Index()
        {
            List<ApontamentoModel> listaPonto = ListarPontoEletronico();
            return View(listaPonto);
        }
        public List<ApontamentoModel> ListarPontoEletronico()
            {
            var conexaoSql = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);

            List<ApontamentoModel> lista = new List<ApontamentoModel>();

            var NRegistro = HttpContext.Session.GetInt32("Registro");

            conexaoDB.Open();

            string query = $"SELECT * FROM Apontamento WHERE Registro = '{NRegistro}'";
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ApontamentoModel ponto = new ApontamentoModel();

                ponto.Dia = reader.GetDateTime(0).Date;
                ponto.Inicio_jornada = reader.IsDBNull(1) ? TimeSpan.Zero : reader.GetTimeSpan(1);
                ponto.Saida_almoco = reader.IsDBNull(2) ? TimeSpan.Zero : reader.GetTimeSpan(2);
                ponto.Retorno_almoco = reader.IsDBNull(3) ? TimeSpan.Zero : reader.GetTimeSpan(3);
                ponto.Fim_jornada = reader.IsDBNull(4) ? TimeSpan.Zero : reader.GetTimeSpan(4);
                ponto.Somatorio_dia = reader.IsDBNull(5) ? TimeSpan.Zero : reader.GetTimeSpan(5);
                ponto.Id_funcionario = reader.GetInt32(6);

                lista.Add(ponto);
            }
            conexaoDB.Close();

            CalculoHoras(lista);

            return lista;
        }
        public void CalculoHoras(List<ApontamentoModel> lista)
        {
            var horasReportar = 0.0;
            var horasTotais = TimeSpan.Zero;
            var horasNoMes = 176.00;
            foreach (var item in lista)
            {
                var horasDia = item.Somatorio_dia;
                horasTotais = horasTotais + horasDia;
            }
            horasReportar = horasNoMes - horasTotais.TotalHours;
            ViewBag.reportar = horasReportar.ToString("N2");
            ViewBag.data = $"{horasTotais.Hours}:{horasTotais.Minutes}";
        }
        public IActionResult BaterPonto()
        {
            var conexaoSql = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);
            ApontamentoModel ponto = new ApontamentoModel();

            List<ApontamentoModel> lista = new List<ApontamentoModel>();

            var NRegistro = HttpContext.Session.GetInt32("Registro");

            DateTime dataHora = DateTime.Now;

            string HorasFormatada = dataHora.ToString("T");
            string dataFormatada = dataHora.ToString("dd/MM/yyyy");

            conexaoDB.Open();

            string query = "UPDATE Apontamento " +
                            $"SET Fim_jornada = '{HorasFormatada}' " +
                            $"WHERE Registro = '{NRegistro}' AND Dia = '{dataFormatada}' AND Inicio_jornada is not null AND Saida_almoco is not null AND Retorno_almoco is not null " +
                            "UPDATE Apontamento  " +
                            $"SET Retorno_almoco = '{HorasFormatada}' " +
                            $"WHERE Registro = '{NRegistro}' AND Dia = '{dataFormatada}' AND Inicio_jornada is not null AND Saida_almoco is not null " +
                            "UPDATE Apontamento  " +
                            $"SET Saida_almoco = '{HorasFormatada}' " +
                            $"WHERE Registro = '{NRegistro}' AND Dia = '{dataFormatada}' AND Inicio_jornada is not null " +
                            $"IF NOT EXISTS(SELECT 1 FROM Apontamento  WHERE Registro = '{NRegistro}' AND Dia = '{dataFormatada}' AND Inicio_jornada is not null) " +
                            "BEGIN " +
                            "INSERT INTO Apontamento (Registro, Dia, Inicio_jornada) " +
                            $"Values('{NRegistro}', '{dataFormatada}', '{HorasFormatada}') " +
                            "END " +
                            $"SELECT * FROM Apontamento WHERE Registro = '{NRegistro}' AND Dia = '{dataFormatada}'";
            SqlCommand command = new SqlCommand(query, conexaoDB);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ponto.Dia = reader.GetDateTime(0).Date;
                ponto.Inicio_jornada = reader.IsDBNull(1) ? TimeSpan.Zero : reader.GetTimeSpan(1);
                ponto.Saida_almoco = reader.IsDBNull(2) ? TimeSpan.Zero : reader.GetTimeSpan(2);
                ponto.Retorno_almoco = reader.IsDBNull(3) ? TimeSpan.Zero : reader.GetTimeSpan(3);
                ponto.Fim_jornada = reader.IsDBNull(4) ? TimeSpan.Zero : reader.GetTimeSpan(4);
                ponto.Somatorio_dia = reader.IsDBNull(5) ? TimeSpan.Zero : reader.GetTimeSpan(5);
                ponto.Id_funcionario = reader.GetInt32(6);

             lista.Add(ponto);
            }

            var horastrabalhadas = CalcularHorasTrabalhadas(lista);

            iserirHoras(dataFormatada, horastrabalhadas);
            conexaoDB.Close();

            return RedirectToAction("Index", "Home");
        }

        public void iserirHoras(string dataFormatada, TimeSpan horasTrabalhadas)
        {
            var conexaoSql = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);

            conexaoDB.Open();
            var NRegistro = HttpContext.Session.GetInt32("Registro");

            string query = "UPDATE Apontamento " +
                $"SET Somatorio_dia = '{horasTrabalhadas}' " +
                $"WHERE Registro = '{NRegistro}' AND dia = '{dataFormatada}'";
            
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();
        }

        private TimeSpan CalcularHorasTrabalhadas(List<ApontamentoModel> lista)
        {
            foreach (var item in lista)
            {
                var horasPrimeiroPeriodo = item.Saida_almoco - item.Inicio_jornada;
                var horasSegundoPeriodo = item.Fim_jornada - item.Retorno_almoco;
                var horaTrabalhadaTotal = horasPrimeiroPeriodo + horasSegundoPeriodo;
                return horaTrabalhadaTotal;
            }
            return TimeSpan.Zero;
        }
    }
}  