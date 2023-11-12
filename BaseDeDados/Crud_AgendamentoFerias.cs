using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeneficioDasFerias;
using System.Globalization;

namespace BaseDeDados
{
    public class Crud_AgendamentoFerias
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

        public bool AgendarFerias(AgendamentoFerias _agendamentoFerias)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "INSERT INTO Agendamento_ferias (Primeiro_mes, Primeiro_periodo, Segundo_mes, Segundo_periodo, Terceiro_mes, Terceiro_periodo, Dias_restantes, " +
                               "Dias_vendidos, Primeira_parcela_decimo, Id_funcionario) " +
                               "VALUES (@primeiroMes, @primeiroPeriodo, @segundoMes, @segundoPeriodo, @terceiroMes, @terceiroPeriodo, @diasRestantes, @diasVendidos, @primeiraParcelaDecimo, @idFuncionario)";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtPrimeiroMes = cmd.CreateParameter();
                _pmtPrimeiroMes.ParameterName = "@primeiroMes";
                _pmtPrimeiroMes.DbType = DbType.String;
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

                var _pmtIdFuncionario = cmd.CreateParameter();
                _pmtIdFuncionario.ParameterName = "@idFuncionario";
                _pmtIdFuncionario.DbType = DbType.Int32;
                _pmtIdFuncionario.Value = _agendamentoFerias.IdFuncionario;
                cmd.Parameters.Add(_pmtIdFuncionario);

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

        public bool AtualizarFerias(AgendamentoFerias _agendamentoFerias)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {

                // DE DUAS UMA, OU EU FAÇO UM METODO PARA ELE NAO AGENDAR FÉRIAS PARA UM FUNCIONARIO SE ELA JA ESTIVER AGENDADA,
                // OU EU CRIO UMA COLUNA ONDE EU PEGO O ID DO AGENDAMENTO E UTILIZO ELE NO LUGAR DO ID_FUNCIONARIO QUANDO FOR ATUALIZAR O REGISTRO DAS FÉRIAS.
                conexaoDb.Open();
                string query = "UPDATE Agendamento_ferias SET Primeiro_mes = @primeiroMes, " +
                               "Primeiro_periodo = @primeiroPeriodo, " +
                               "Segundo_mes = @segundoMes, " +
                               "Segundo_periodo = @segundoPeriodo, " +
                               "Terceiro_mes = @terceiroMes, " +
                               "Terceiro_periodo = @terceiroPeriodo, " +
                               "Dias_restantes = @diasRestantes, " +
                               "Dias_vendidos = @diasVendidos, " +
                               "Primeira_parcela_decimo = @primeiraParcelaDecimo " +
                               "WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtPrimeiroMes = cmd.CreateParameter();
                _pmtPrimeiroMes.ParameterName = "@primeiroMes";
                _pmtPrimeiroMes.DbType = DbType.String;
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

                var _pmtIdFuncionario = cmd.CreateParameter();
                _pmtIdFuncionario.ParameterName = "@idFuncionario";
                _pmtIdFuncionario.DbType = DbType.Int32;
                _pmtIdFuncionario.Value = _agendamentoFerias.IdFuncionario;
                cmd.Parameters.Add(_pmtIdFuncionario);

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

        public DataTable ListarFuncionariosParaAgendarFerias(string id)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Funcionarios.Id_funcionario, " +
                                "Nome, " +
                                "Data_admissao as 'Data admissao'," +
                                "Agendamento_ferias.Primeiro_mes as '1º Mes'," +
                                "Agendamento_ferias.Primeiro_periodo as '1º Periodo'," +
                                "Agendamento_ferias.Segundo_mes as '2º Mes'," +
                                "Agendamento_ferias.Segundo_periodo as '2º Periodo'," +
                                "Agendamento_ferias.Terceiro_mes as '3º Mes'," +
                                "Agendamento_ferias.Terceiro_periodo as '3º Periodo'," +
                                "Agendamento_ferias.Dias_vendidos as 'Dias vendidos'," +
                                "Agendamento_ferias.Dias_restantes as 'Dias restantes' FROM Funcionarios " +
                                "LEFT JOIN Agendamento_ferias ON Funcionarios.Id_funcionario = Agendamento_ferias.Id_funcionario WHERE Funcionarios.Id_empresas = @id";

                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@id";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = id;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Código", typeof(int));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Data admissao", typeof(DateTime));
                dt.Columns.Add("1º Mes", typeof(string));
                dt.Columns.Add("1º Periodo", typeof(int));
                dt.Columns.Add("2º Mes", typeof(string));
                dt.Columns.Add("2º Periodo", typeof(int));
                dt.Columns.Add("3º Mes", typeof(string));
                dt.Columns.Add("3º Periodo", typeof(int));
                dt.Columns.Add("Dias vendidos", typeof(int));
                dt.Columns.Add("Dias restantes", typeof(int));


                DateTime dataAtual = DateTime.Now;
                string dataAtualParaFormatar = dataAtual.ToString();
                dataAtualParaFormatar = dataAtualParaFormatar.Replace("/", " ");
                string[] dataDivisor = dataAtualParaFormatar.Split(' ');

                int dia = Convert.ToInt32(dataDivisor[0]);
                int mes = Convert.ToInt32(dataDivisor[1]);
                int ano = Convert.ToInt32(dataDivisor[2]);

                string primeiroMes = "n";
                int primeiroMesDias = 0;
                string segundoMes = "n";
                int segundoMesDias = 0;
                string terceiroMes = "n";
                int terceiroMesDias = 0;
                int diasVendidos = 0;
                int diasRestantes = 0;

                // AGORA ESTA FUNCIONANDO.
                while (_leitor.Read())
                {
                    int codigo = _leitor.GetInt32(0);
                    string nome = _leitor.GetString(1);
                    DateTime admissao = _leitor.GetDateTime(2);
                    if (_leitor.IsDBNull(3))
                    {
                        primeiroMes = "Nao agendado";
                        primeiroMesDias = 0;
                        segundoMes = "Nao agendado";
                        segundoMesDias = 0;
                        terceiroMes = "Nao agendado";
                        terceiroMesDias = 0;
                        diasVendidos = 0;
                        diasRestantes = 0;
                    }
                    else
                    {
                        primeiroMes = _leitor.GetString(3);
                        primeiroMesDias = _leitor.GetInt32(4);
                        segundoMes = _leitor.GetString(5);
                        segundoMesDias = _leitor.GetInt32(6);
                        terceiroMes = _leitor.GetString(7);
                        terceiroMesDias = _leitor.GetInt32(8);
                        diasVendidos = _leitor.GetInt32(9);
                        diasRestantes = _leitor.GetInt32(10);
                    }
                    
                    
                    string dataAdmissaoParaFormatar = admissao.ToString();
                    dataAdmissaoParaFormatar = dataAdmissaoParaFormatar.Replace("/", " ");
                    string[] dataParaValidar = dataAdmissaoParaFormatar.Split(' ');
                    int diAdimissao = Convert.ToInt32(dataParaValidar[0]);
                    int mesAdmissao = Convert.ToInt32(dataParaValidar[1]);
                    int anoAdmissao = Convert.ToInt32(dataParaValidar[2]);

                    if(mesAdmissao == mes)
                    {
                        dt.Rows.Add(codigo, nome, admissao, primeiroMes, primeiroMesDias, segundoMes, segundoMesDias, terceiroMes, terceiroMesDias, diasVendidos, diasRestantes);
                    }

                }
                conexaoDb.Close();
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Dictionary<int, string> PopularCaixaListarEmpresas()
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT Id_empresa, Nome_fantasia FROM Empresas ORDER BY Id_empresa";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);
                SqlDataReader leitura = cmd.ExecuteReader();
                Dictionary<int, string> dados = new Dictionary<int, string>();

                while (leitura.Read())
                {
                    int idEmpresa = leitura.GetInt32(0);
                    string nomeFantasia = leitura.GetString(1);

                    dados[idEmpresa] = nomeFantasia;
                }
                conexaoDb.Close();
                return dados;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
