using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeneficioDasFerias;
using System.Globalization;
using FuncionariosEmpresas;
using System.Runtime.InteropServices;
using FolhaDePagamento;

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

        public bool ExcluirRegistroFerias(string idAgendamento)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "DELETE FROM Agendamento_ferias WHERE Id_agendamento = @idAgendamento";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idAgendamento";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idAgendamento;
                cmd.Parameters.Add(_pmtId);

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

                string querry = "SELECT Id_agendamento, " +
                                "Primeiro_mes, " +
                                "Primeiro_periodo, " +
                                "Segundo_mes, " +
                                "Segundo_periodo, " +
                                "Terceiro_mes, " +
                                "Terceiro_periodo, " +
                                "Dias_restantes, " +
                                "Dias_vendidos, " +
                                "Primeira_parcela_decimo,  " +
                                "Funcionarios.Nome, " +
                                "Agendamento_ferias.Id_funcionario, " +
                                "Funcionarios.Data_admissao, " +
                                "Id_folha FROM Agendamento_ferias " +
                                "LEFT JOIN Funcionarios ON Funcionarios.Id_funcionario = Agendamento_ferias.Id_funcionario WHERE Funcionarios.Id_empresas = @id";

                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@id";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = id;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Cód. Férias", typeof(int));
                dt.Columns.Add("1º Mes", typeof(string));
                dt.Columns.Add("1º Periodo", typeof(int));
                dt.Columns.Add("2º Mes", typeof(string));
                dt.Columns.Add("2º Periodo", typeof(int));
                dt.Columns.Add("3º Mes", typeof(string));
                dt.Columns.Add("3º Periodo", typeof(int));
                dt.Columns.Add("Dias restantes", typeof(int));
                dt.Columns.Add("Dias vendidos", typeof(int));
                dt.Columns.Add("1º Parcela décimo", typeof(string));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Cód. Funcionário", typeof(int));
                dt.Columns.Add("Data admissao", typeof(DateTime));
                dt.Columns.Add("Cód. Folha");

                DateTime dataAtual = DateTime.Now;
                string dataAtualParaFormatar = dataAtual.ToString();
                dataAtualParaFormatar = dataAtualParaFormatar.Replace("/", " ");
                string[] dataDivisor = dataAtualParaFormatar.Split(' ');

                int dia = Convert.ToInt32(dataDivisor[0]);
                int mes = Convert.ToInt32(dataDivisor[1]);
                int ano = Convert.ToInt32(dataDivisor[2]);

                string primeiroMes = "Nao agendado";
                int primeiroMesDias = 0;
                string segundoMes = "Nao agendado";
                int segundoMesDias = 0;
                string terceiroMes = "Nao agendado";
                int terceiroMesDias = 0;
                int diasVendidos = 0;
                int diasRestantes = 0;
                string primeiraParcela = "Não";
                int folha = 0;

                // AGORA ESTA FUNCIONANDO.
                while (_leitor.Read())
                {
                    int agendamento = _leitor.GetInt32(0);
                    
                    if (!_leitor.IsDBNull(1))
                    {
                        primeiroMes = _leitor.GetString(1);
                        primeiroMesDias = _leitor.GetInt32(2);
                        segundoMes = _leitor.GetString(3);
                        segundoMesDias = _leitor.GetInt32(4);
                        terceiroMes = _leitor.GetString(5);
                        terceiroMesDias = _leitor.GetInt32(6);
                        diasRestantes = _leitor.GetInt32(7);
                        diasVendidos = _leitor.GetInt32(8);
                        primeiraParcela = _leitor.GetString(9);
                    }
                    string nome = _leitor.GetString(10);
                    int codigoFuncionario = _leitor.GetInt32(11);
                    DateTime admissao = _leitor.GetDateTime(12);
                    if (!_leitor.IsDBNull(13))
                    {
                        folha = _leitor.GetInt32(13);
                    }
                   

                    string dataAdmissaoParaFormatar = admissao.ToString();
                    dataAdmissaoParaFormatar = dataAdmissaoParaFormatar.Replace("/", " ");
                    string[] dataParaValidar = dataAdmissaoParaFormatar.Split(' ');
                    int diAdimissao = Convert.ToInt32(dataParaValidar[0]);
                    int mesAdmissao = Convert.ToInt32(dataParaValidar[1]);
                    int anoAdmissao = Convert.ToInt32(dataParaValidar[2]);

                    if(mesAdmissao == mes)
                    {
                        dt.Rows.Add(agendamento, primeiroMes, primeiroMesDias, segundoMes, segundoMesDias, terceiroMes, terceiroMesDias, diasRestantes, diasVendidos, primeiraParcela, nome, codigoFuncionario, admissao, folha);
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

        public List<AgendamentoFerias> BuscarRegistroFerias(AgendamentoFerias _agendamentoFerias)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT * FROM Agendamento_ferias WHERE Id_funcionario = @idFuncionario";

                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                List<AgendamentoFerias> _registro = new List<AgendamentoFerias>();

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = _agendamentoFerias.IdFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();

                while (_leitor.Read())
                {
                    _agendamentoFerias.IdAgendamento = _leitor.GetInt32(0).ToString();
                    _agendamentoFerias.PrimeiroMes = _leitor.GetString(1);
                    _agendamentoFerias.PrimeiroPeriodo = _leitor.GetInt32(2).ToString();
                    _agendamentoFerias.SegundoMes = _leitor.GetString(3);
                    _agendamentoFerias.SegundoPeriodo = _leitor.GetInt32(4).ToString();
                    _agendamentoFerias.TerceiroMes = _leitor.GetString(5);
                    _agendamentoFerias.TerceiroPeriodo = _leitor.GetInt32(6).ToString();
                    _agendamentoFerias.DiasRestantes = _leitor.GetInt32(7).ToString();
                    _agendamentoFerias.DiasVendidos = _leitor.GetInt32(8).ToString();
                    _agendamentoFerias.PrimeiraParcelaDecimo = _leitor.GetString(9);
                    if (!_leitor.IsDBNull(10))
                    {
                        _agendamentoFerias.IdFolha = _leitor.GetInt32(10).ToString();
                    }
                    if (!_leitor.IsDBNull(11))
                    {
                        _agendamentoFerias.IdFuncionario = _leitor.GetInt32(11).ToString();
                    }
                    
                    _registro.Add(_agendamentoFerias);
                }
                conexaoDb.Close();
                return _registro;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            { conexaoDb.Close(); }
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
