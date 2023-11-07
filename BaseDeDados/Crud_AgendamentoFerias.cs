using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeneficioDasFerias;

namespace BaseDeDados
{
    public class Crud_AgendamentoFerias
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

        public bool AgendarFerias(AgendamentoFerias _agendamentoFerias)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string query = "INSERT INTO Agendamento_ferias (Primeiro_mes, Primeiro_periodo, Segundo_mes, Segundo_periodo, Terceiro_mes, Terceiro_periodo, Dias_restantes, " +
                               "Dias_vendidos, Primeira_parcela_decimo) " +
                               "VALUES (@primeiroMes, @primeiroPeriodo, @segundoMes, @segundoPeriodo, @terceiroMes, @terceiroPeriodo, @diasRestantes, @diasVendidos, @primeiraParcelaDecimo)";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtPrimeiroMes = cmd.CreateParameter();
                _pmtPrimeiroMes.ParameterName = "@primeiroMes";
                _pmtPrimeiroMes.DbType = DbType.Int32;
                _pmtPrimeiroMes.Value = _agendamentoFerias.PrimeiroMes;
                cmd.Parameters.Add(_pmtPrimeiroMes);

                var _pmtPrimeiroPeriodo = cmd.CreateParameter();
                _pmtPrimeiroPeriodo.ParameterName = "@primeiroPeriodo";
                _pmtPrimeiroPeriodo.DbType = DbType.Int32;
                _pmtPrimeiroPeriodo.Value = _agendamentoFerias.PrimeiroPeriodo;
                cmd.Parameters.Add(_pmtPrimeiroPeriodo);

                var _pmtSegundoMes = cmd.CreateParameter();
                _pmtSegundoMes.ParameterName = "@segundoMes";
                _pmtSegundoMes.DbType = DbType.String;
                _pmtSegundoMes.Value = _agendamentoFerias.SegundoMes;
                cmd.Parameters.Add(_pmtSegundoMes);

                var _pmtSegundoPeriodo = cmd.CreateParameter();
                _pmtSegundoPeriodo.ParameterName = "@segundoPeriodo";
                _pmtSegundoPeriodo.DbType = DbType.Int32;
                _pmtSegundoPeriodo.Value = _agendamentoFerias.SegundoPeriodo;
                cmd.Parameters.Add(_pmtSegundoPeriodo);

                var _pmtTerceiroMes = cmd.CreateParameter();
                _pmtTerceiroMes.ParameterName = "@terceiroMes";
                _pmtTerceiroMes.DbType = DbType.String;
                _pmtTerceiroMes.Value = _agendamentoFerias.TerceiroMes;
                cmd.Parameters.Add(_pmtTerceiroMes);

                var _pmtTerceiroPeriodo = cmd.CreateParameter();
                _pmtTerceiroPeriodo.ParameterName = "@terceiroPeriodo";
                _pmtTerceiroPeriodo.DbType = DbType.Int32;
                _pmtTerceiroPeriodo.Value = _agendamentoFerias.TerceiroPeriodo;
                cmd.Parameters.Add(_pmtTerceiroPeriodo);

                var _pmtDiasRestantes = cmd.CreateParameter();
                _pmtDiasRestantes.ParameterName = "@diasRestantes";
                _pmtDiasRestantes.DbType = DbType.Int32;
                _pmtDiasRestantes.Value = _agendamentoFerias.DiasRestantes;
                cmd.Parameters.Add(_pmtDiasRestantes);

                var _pmtDiasVendidos = cmd.CreateParameter();
                _pmtDiasVendidos.ParameterName = "@diasVendidos";
                _pmtDiasVendidos.DbType = DbType.Int32;
                _pmtDiasVendidos.Value = _agendamentoFerias.DiasVendidos;
                cmd.Parameters.Add(_pmtDiasVendidos);

                var _pmtPrimeiraParcelaDecimo = cmd.CreateParameter();
                _pmtPrimeiraParcelaDecimo.ParameterName = "@primeiraParcelaDecimo";
                _pmtPrimeiraParcelaDecimo.DbType = DbType.String;
                _pmtPrimeiraParcelaDecimo.Value = _agendamentoFerias.PrimeiraParcelaDecimo;
                cmd.Parameters.Add(_pmtPrimeiraParcelaDecimo);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaoDb.Close();
                    return true;
                }
                else
                {
                    conexaoDb.Close();
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
