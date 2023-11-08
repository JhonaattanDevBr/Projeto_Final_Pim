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
            return View();
        }

        [HttpPost]
        public IActionResult AgendandoFerias(AgendamentoFeriasModel ferias)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (AgendaFerias(ferias))
                    {
                        TempData["MensagemSucesso"] = "Agendamento feito com Sucesso";
                        return RedirectToAction("Ferias", "Ferias");
                    }
                    TempData["MensagemErro"] = "Falha no agendamento";
                }
                catch(Exception ex)
                {
                    TempData["MensagemErro"] = "Erro no agendamento" + ex.Message;
                }
            }
            return View("Ferias", ferias);
        }
        private bool AgendaFerias(AgendamentoFeriasModel ferias)
        {
            using (SqlConnection conexaoDB = new SqlConnection(conexaoSQL))
            {
                conexaoDB.Open();

                string query = $"INSERT INTO Agendamento_ferias (Primeiro_mes, Primeiro_periodo, Segundo_mes, Segundo_periodo, Terceiro_mes, Terceiro_periodo, Dias_restantes, Dias_vendidos, primeira_parcela_decimo)" +
                        $"VALUES(@primeiroMes, @primeiroPeriodo, @segundoMes, @segundoPeriodo, @terceiroMes, @terceiroPeriodo, @diasRestantes, @diasVendidos, @primeira_parcela_decimo)";

                using (SqlCommand command = new SqlCommand(query, conexaoDB))
                {
                    command.Parameters.AddWithValue("@primeiroMes", ferias.PrimeiroMes);
                    command.Parameters.AddWithValue("@primeiroPeriodo", ferias.PrimeiroPeriodo);
                    command.Parameters.AddWithValue("@segundoMes", ferias.SegundoMes);
                    command.Parameters.AddWithValue("@segundoPeriodo", ferias.SegundoPeriodo);
                    command.Parameters.AddWithValue("@terceiroMes", ferias.TerceiroMes);
                    command.Parameters.AddWithValue("@terceiroPeriodo", ferias.TerceiroPeriodo);
                    command.Parameters.AddWithValue("@diasRestantes", ferias.Dias_restantes);
                    command.Parameters.AddWithValue("@diasVendidos", ferias.Dias_vendidos);
                    command.Parameters.AddWithValue("@primeira_parcela_decimo", ferias.Primeira_parcela_decimo);
                    
                    int agendamento = command.ExecuteNonQuery();

                    return agendamento > 0;
                }
            }
        }

        /*public ActionResult Agendar (FeriasModel ferias)
        {
            if (ModelState.IsValid)
            {
                if (VerficaTempoTrabalhado(ferias.Id_funcionario, ferias.Saida))
                {
                    string conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
                    SqlConnection conexaoDB = new SqlConnection(conexaoSQL);

                    return RedirectToAction("Index", "Home"); // Inserção bem-sucedida
                }
                else
                {
                    ModelState.AddModelError("", "Erro"); // Falha na inserção
                }
            }
            return View("Ferias", ferias);
        }*/

        /*private bool VerficaTempoTrabalhado (int Id_funcionario, DateTime Saida)
        {
            List<FeriasModel> ListaFuncionario = new List<FeriasModel> ();

            var funcionario = ListaFuncionario.FirstOrDefault(e => e.Id_funcionario == Id_funcionario);
            if (funcionario != null) {
                TimeSpan tempoTrabalhado = DateTime.Now - Saida;

                if(tempoTrabalhado.TotalDays >= 365 && Saida.AddYears(1)<= DateTime.Now)
                {
                    return true;
                }
            }
            return false;
        }*/
    }




























        /*public IActionResult Ferias()
        {
            List<AgendamentoFeriasModel> SolicitacaoFerias = RecebeFerias();
            List<FeriasModel> ferias = Feriasmodel();
            return View();
        }

        public IActionResult AgendarFerias()
        {
            var conexaoSql = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
            
            
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);
            AgendamentoFeriasModel agendamento = new AgendamentoFeriasModel();

            List<AgendamentoFeriasModel> lista = new List<AgendamentoFeriasModel>();

            conexaoDB.Open();

            string query = $"INSERT INTO Agendamento_ferias " +
                $"WHERE Agendamento_ferias.Id_agendamento = Ferias.Id_agendamento_ferias" +
                $"(PrimeiroPeriodo, PrimeiroMes, SegundoPeriodo, SegundoMes, TerceiroPeriodo,TerceiroMes, Dias_restantes, Dias_vendidos,Primeira_parcela_decimo)" +
                $"VALUES" +
                $"(@primeiroPeriodo,@primeiroMes,@segundoPeriodo,@segundoMes,@terceiroPeriodo,@terceiroMes,@primeira_parcela_decimo)";
            SqlCommand command = new SqlCommand(query, conexaoDB);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AgendamentoFeriasModel agendamentoferias = new AgendamentoFeriasModel();

                agendamentoferias.PrimeiroPeriodo = reader.GetInt32(1);
                agendamentoferias.PrimeiroMes = reader.GetInt32(2);
                agendamentoferias.SegundoPeriodo = reader.GetInt32(3);
                agendamentoferias.SegundoMes = reader.GetInt32(4);
                agendamentoferias.TerceiroPeriodo = reader.GetInt32(5);
                agendamentoferias.TerceiroMes = reader.GetInt32(6);
                agendamentoferias.Dias_restantes = reader.GetInt32(7);
                agendamentoferias.Dias_vendidos = reader.GetInt32(8);
                agendamentoferias.Primeira_parcela_decimo = reader.GetInt32(9);

                lista.Add(agendamentoferias);
            }
            conexaoDB.Close();

            return RedirectToAction("Index", "Home");
        }

        public List<AgendamentoFeriasModel> RecebeFerias()
        {
            var conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSQL);

            List<AgendamentoFeriasModel> agendamento = new List<AgendamentoFeriasModel>();

            conexaoDB.Open();

            string query = $"SELECT * FROM Agendamento_ferias";
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AgendamentoFeriasModel agendamentoferias = new AgendamentoFeriasModel();

                agendamentoferias.PrimeiroPeriodo = reader.GetInt32(1);
                agendamentoferias.PrimeiroMes = reader.GetInt32(2);
                agendamentoferias.SegundoPeriodo = reader.GetInt32(3);
                agendamentoferias.SegundoMes = reader.GetInt32(4);
                agendamentoferias.TerceiroPeriodo = reader.GetInt32(5);
                agendamentoferias.TerceiroMes = reader.GetInt32(6);
                agendamentoferias.Dias_restantes = reader.GetInt32(7);
                agendamentoferias.Dias_vendidos = reader.GetInt32(8);
                agendamentoferias.Primeira_parcela_decimo = reader.GetInt32(9);

                agendamento.Add(agendamentoferias);
            }

            return agendamento;
        }
        public List<FeriasModel> Feriasmodel()
        {
            var conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSQL);

            List<FeriasModel> Ferias = new List<FeriasModel>();

            conexaoDB.Open();

            string query = $"SELECT * FROM Ferias";
            SqlCommand command = new SqlCommand(query, conexaoDB);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FeriasModel ferias = new FeriasModel();

                ferias.Dias_gozados = reader.GetInt32(1);
                ferias.Saida = reader.GetDateTime(2);
                ferias.Retorno = reader.GetDateTime(3);
                ferias.Dias_vendidos = reader.GetInt32(4);
                ferias.Abono_pecuniario = reader.GetFloat(5);
                ferias.Um_terco_abonoP = reader.GetFloat(6);
                ferias.Id_funcionario = reader.GetInt32(11);
                ferias.Id_folha_pagamento = reader.GetInt32(12);
                ferias.Id_agendamento_ferias = reader.GetInt32(13);

                Ferias.Add(ferias);
            }

            return Ferias;
        }*/
    }
