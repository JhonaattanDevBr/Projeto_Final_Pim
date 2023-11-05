using Microsoft.AspNetCore.Mvc;
using WebPIM.Models;
using System.Data.SqlClient;

namespace WebPIM.Controllers
{
    public class FeriasController : Controller
    {
        public IActionResult Ferias()
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

            string query = "$SELECT * FROM Agendamento_ferias";
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
        }
    }
}
