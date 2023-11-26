using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDados
{
    public class Crud_FolhaDePagamento
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

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

        public DataTable ListarFuncionariosParaGerarFolha(string id)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Id_funcionario, Nome, Sobrenome, Idade, Cargo, Salario FROM Funcionarios WHERE Id_empresas = @id";

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
                dt.Columns.Add("Sobrenome", typeof(string));
                dt.Columns.Add("Idade", typeof(int));
                dt.Columns.Add("Cargo", typeof(string));
                dt.Columns.Add("Salário", typeof(double));



                // AGORA ESTA FUNCIONANDO.
                while (_leitor.Read())
                {
                    int codigo = _leitor.GetInt32(0);
                    string nome = _leitor.GetString(1);
                    string sobrenome = _leitor.GetString(2);
                    int idade = _leitor.GetInt32(3);
                    string cargo = _leitor.GetString(4);
                    double salario = _leitor.GetDouble(5);

                    dt.Rows.Add(codigo, nome, sobrenome, idade, cargo, salario);
                }
                conexaoDb.Close();
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TimeSpan> ColetarRegistroHoara(string idFuncionario, string dataHora) 
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Somatorio_dia FROM Apontamento WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                List<TimeSpan> horasParaCalculo = new List<TimeSpan>();

                dataHora = dataHora.Replace("/", " ");
                string[] data = dataHora.Split(' ');
                int diAtual = Convert.ToInt32(data[0]);
                int mesAtual = Convert.ToInt32(data[1]);
                int anoAtual = Convert.ToInt32(data[2]);
                TimeSpan  horAtual = TimeSpan.Parse(data[3]);

                while(_leitor.Read())
                {
                    string dataHoraDoBd = _leitor.GetDateTime(0).ToString();

                    dataHoraDoBd = dataHoraDoBd.Replace("/", " ");
                    string[] dataDoBd = dataHoraDoBd.Split(' ');
                    int dia = Convert.ToInt32(dataDoBd[0]);
                    int mes = Convert.ToInt32(dataDoBd[1]);
                    int ano = Convert.ToInt32(dataDoBd[2]);
                    TimeSpan horas = TimeSpan.Parse(dataDoBd[3]);

                    // ↓ ↓ ↓ Aqui eu tenhho q adicionar mais uma condição para ele não pegar registros de dois mesesanteriores pra cima,
                    // o calculo deve ser feito apenas com os registros do mes anterior, ou seja se estamos no mes 10 ele deve fazer
                    // o calculo com os registros apenas do mes 09 e não com os registros dos meses 08, 07...
                    if (anoAtual == ano && mesAtual > mes) 
                    {
                        horasParaCalculo.Add(horas);
                    }
                }
                conexaoDb.Close();
                return horasParaCalculo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TimeSpan> ColetarRegistroAdcNoturno(string idFuncionario, string dataHora)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Fim_jornada FROM Apontamento WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                List<TimeSpan> adicionalNoturno = new List<TimeSpan>();

                dataHora = dataHora.Replace("/", " ");
                string[] data = dataHora.Split(' ');
                int diAtual = Convert.ToInt32(data[0]);
                int mesAtual = Convert.ToInt32(data[1]);
                int anoAtual = Convert.ToInt32(data[2]);
                TimeSpan horAtual = TimeSpan.Parse(data[3]);

                while (_leitor.Read())
                {
                    string fim_jornada = _leitor.GetDateTime(0).ToString();
                    fim_jornada = fim_jornada.Replace("/", " ");
                    string[] dataDoBdFim = fim_jornada.Split(' ');
                    int dia = Convert.ToInt32(dataDoBdFim[0]);
                    int mes = Convert.ToInt32(dataDoBdFim[1]);
                    int ano = Convert.ToInt32(dataDoBdFim[2]);
                    TimeSpan horas = TimeSpan.Parse(dataDoBdFim[3]);

                    // ↓ ↓ ↓ Aqui eu tenhho q adicionar mais uma condição para ele não pegar registros de dois mesesanteriores pra cima,
                    // o calculo deve ser feito apenas com os registros do mes anterior, ou seja se estamos no mes 10 ele deve fazer
                    // o calculo com os registros apenas do mes 09 e não com os registros dos meses 08, 07...
                    if (anoAtual == ano && mesAtual > mes)
                    {
                        TimeSpan dezHoras = new TimeSpan(22, 0, 0);
                        TimeSpan meiaNoite = new TimeSpan(24, 0, 0);
                        TimeSpan madrugada = new TimeSpan(00, 0, 0);
                        TimeSpan fimAdcNot = new TimeSpan(5, 0, 0);

                        if (horas >= dezHoras)
                        {
                            TimeSpan adcNot = meiaNoite - horas;
                            adicionalNoturno.Add(adcNot);
                        }
                        else if (horas >= madrugada && horas <= fimAdcNot)
                        {
                            TimeSpan duasHoras = new TimeSpan(2, 0, 0);
                            TimeSpan adcNot = duasHoras + horas;
                            adicionalNoturno.Add(adcNot);
                        }
                    }
                }
                conexaoDb.Close();
                return adicionalNoturno;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TimeSpan> ColetarRegistroHorasExtras(string idFuncionario, string dataHora)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Somatorio_dia FROM Apontamento WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                List<TimeSpan> horasExtras = new List<TimeSpan>();

                dataHora = dataHora.Replace("/", " ");
                string[] data = dataHora.Split(' ');
                int diAtual = Convert.ToInt32(data[0]);
                int mesAtual = Convert.ToInt32(data[1]);
                int anoAtual = Convert.ToInt32(data[2]);
                TimeSpan horAtual = TimeSpan.Parse(data[3]);

                while (_leitor.Read())
                {
                    string somatorioDia = _leitor.GetDateTime(0).ToString();
                    somatorioDia = somatorioDia.Replace("/", " ");
                    string[] dataSomatorio = somatorioDia.Split(' ');
                    int dia = Convert.ToInt32(dataSomatorio[0]);
                    int mes = Convert.ToInt32(dataSomatorio[1]);
                    int ano = Convert.ToInt32(dataSomatorio[2]);
                    TimeSpan horas = TimeSpan.Parse(dataSomatorio[3]);

                    // ↓ ↓ ↓ Aqui eu tenhho q adicionar mais uma condição para ele não pegar registros de dois mesesanteriores pra cima,
                    // o calculo deve ser feito apenas com os registros do mes anterior, ou seja se estamos no mes 10 ele deve fazer
                    // o calculo com os registros apenas do mes 09 e não com os registros dos meses 08, 07...
                    if (anoAtual == ano && mesAtual > mes)
                    {
                        TimeSpan dezHoras = new TimeSpan(22, 0, 0);
                        TimeSpan oitoHoras = new TimeSpan(8, 0, 0);
                        TimeSpan madrugada = new TimeSpan(00, 0, 0);
                        TimeSpan fimAdcNot = new TimeSpan(5, 0, 0);

                        if (horas >= oitoHoras && horas < dezHoras)
                        {
                            TimeSpan horaExtra = horas - oitoHoras;
                            horasExtras.Add(horaExtra);
                        }
                    }
                }
                conexaoDb.Close();
                return horasExtras;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ColetarDiasUteis(string idFuncionario, string dataHora)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Somatorio_dia FROM Apontamento WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();

                dataHora = dataHora.Replace("/", " ");
                string[] data = dataHora.Split(' ');
                int diAtual = Convert.ToInt32(data[0]);
                int mesAtual = Convert.ToInt32(data[1]);
                int anoAtual = Convert.ToInt32(data[2]);

                int totalDias = 0;
                while (_leitor.Read())
                {
                    string somatorioDia = _leitor.GetDateTime(0).ToString();
                    somatorioDia = somatorioDia.Replace("/", " ");
                    string[] dataSomatorio = somatorioDia.Split(' ');
                    int dia = Convert.ToInt32(dataSomatorio[0]);
                    int mes = Convert.ToInt32(dataSomatorio[1]);
                    int ano = Convert.ToInt32(dataSomatorio[2]);
                    TimeSpan horas = TimeSpan.Parse(dataSomatorio[3]);

                    // ↓ ↓ ↓ Aqui eu tenhho q adicionar mais uma condição para ele não pegar registros de dois mesesanteriores pra cima,
                    // o calculo deve ser feito apenas com os registros do mes anterior, ou seja se estamos no mes 10 ele deve fazer
                    // o calculo com os registros apenas do mes 09 e não com os registros dos meses 08, 07...
                    if (anoAtual == ano && mesAtual > mes)
                    {
                        int inicioMes = 01, fiMes = 31;

                        if (dia >= inicioMes && dia <= fiMes)
                        {
                            totalDias++;
                        }
                    }
                }
                conexaoDb.Close();
                return totalDias;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string ColetarIdConvMedico(string idFuncionario)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Id_planos_saude FROM Funcionarios WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                string idConvMedico = null;

                while (_leitor.Read())
                {
                    idConvMedico = _leitor.GetInt32(0).ToString();
                }
                conexaoDb.Close();
                return idConvMedico;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> ColetarConvMedico(string idConvMedico)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Nome, Valor, Porcentagem FROM Planos_saude WHERE Id_saude = @idSaude";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idSaude";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idConvMedico;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                List<string> convenioMedico = new List<string>();

                while (_leitor.Read())
                {
                    string nome = _leitor.GetString(0);
                    if(_leitor.GetDouble(1) != 0)
                    {
                        string valor = _leitor.GetDouble(1).ToString();
                        string menssagem = "Valor";
                        convenioMedico.Add(nome);
                        convenioMedico.Add(valor);
                        convenioMedico.Add(menssagem);
                    }
                    else
                    {
                        string porcentagem = _leitor.GetInt32(2).ToString();
                        string menssagem = "Porcentagem";
                        convenioMedico.Add(nome);
                        convenioMedico.Add(porcentagem);
                        convenioMedico.Add(menssagem);
                    }
                }
                conexaoDb.Close();
                return convenioMedico;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string ColetarIdConvOdonto(string idFuncionario)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Id_planos_saude FROM Funcionarios WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                string idConvOdonto = null;

                while (_leitor.Read())
                {
                    idConvOdonto = _leitor.GetInt32(0).ToString();
                }
                conexaoDb.Close();
                return idConvOdonto;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> ColetarConvOdonto(string idConvOdonto)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Nome, Valor, Porcentagem FROM Planos_odontologicos WHERE Id_odonto = @idOdonto";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idOdonto";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idConvOdonto;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                List<string> convenioOdontologico = new List<string>();

                while (_leitor.Read())
                {
                    string nome = _leitor.GetString(0);
                    if (_leitor.GetDouble(1) != 0)
                    {
                        string valor = _leitor.GetDouble(1).ToString();
                        string menssagem = "Valor";
                        convenioOdontologico.Add(nome);
                        convenioOdontologico.Add(valor);
                        convenioOdontologico.Add(menssagem);
                    }
                    else
                    {
                        string porcentagem = _leitor.GetInt32(2).ToString();
                        string menssagem = "Porcentagem";
                        convenioOdontologico.Add(nome);
                        convenioOdontologico.Add(porcentagem);
                        convenioOdontologico.Add(menssagem);
                    }
                }
                conexaoDb.Close();
                return convenioOdontologico;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ColetarDependentes(string idFuncionario)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Num_dependentes FROM Funcionarios WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                int dependentes = 0;

                while (_leitor.Read())
                {
                    dependentes = _leitor.GetInt32(0);
                }
                conexaoDb.Close();
                return dependentes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ColetarJornada(string idFuncionario)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Carga_horaria FROM Funcionarios WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                int jornada = 0;

                while (_leitor.Read())
                {
                    jornada = _leitor.GetInt32(0);
                }
                conexaoDb.Close();
                return jornada;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TimeSpan> ColetarRegistroAtrasos(string idFuncionario, string dataHora)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Somatorio_dia FROM Apontamento WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                List<TimeSpan> atrasos = new List<TimeSpan>();

                dataHora = dataHora.Replace("/", " ");
                string[] data = dataHora.Split(' ');
                int diAtual = Convert.ToInt32(data[0]);
                int mesAtual = Convert.ToInt32(data[1]);
                int anoAtual = Convert.ToInt32(data[2]);
                TimeSpan horAtual = TimeSpan.Parse(data[3]);

                while (_leitor.Read())
                {
                    string somatorioDia = _leitor.GetDateTime(0).ToString();
                    somatorioDia = somatorioDia.Replace("/", " ");
                    string[] dataSomatorio = somatorioDia.Split(' ');
                    int dia = Convert.ToInt32(dataSomatorio[0]);
                    int mes = Convert.ToInt32(dataSomatorio[1]);
                    int ano = Convert.ToInt32(dataSomatorio[2]);
                    TimeSpan horas = TimeSpan.Parse(dataSomatorio[3]);

                    // ↓ ↓ ↓ Aqui eu tenhho q adicionar mais uma condição para ele não pegar registros de dois mesesanteriores pra cima,
                    // o calculo deve ser feito apenas com os registros do mes anterior, ou seja se estamos no mes 10 ele deve fazer
                    // o calculo com os registros apenas do mes 09 e não com os registros dos meses 08, 07...
                    if (anoAtual == ano && mesAtual > mes)
                    {
                        TimeSpan oitoHoras = new TimeSpan(8, 0, 0);

                        if (horas < oitoHoras)
                        {
                            TimeSpan horasEmAtraso = oitoHoras - horas;
                            atrasos.Add(horasEmAtraso);
                        }
                    }
                }
                conexaoDb.Close();
                return atrasos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<string> ColetarFerias(string idFuncionario)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT TOP 1 * FROM Agendamento_ferias where Id_funcionario = @idFuncionario ORDER BY Id_agendamento DESC;";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                List<string> ferias = new List<string>();


                while (_leitor.Read())
                {
                    string idAgendamento = _leitor.GetInt32(0).ToString();
                    string mes = _leitor.GetString(01);
                    string periodo = _leitor.GetInt32(2).ToString();
                    string diasVendidos = _leitor.GetInt32(8).ToString();
                    ferias.Add(mes);
                    ferias.Add(periodo);
                    ferias.Add(diasVendidos);
                    ferias.Add(idAgendamento);
                }

                if (ferias[0] == null)
                {
                    ferias[0] = "O período aquisitivo não foi cumprido, O funcionário ainda não possui o benefício das férias.";
                }

                conexaoDb.Close();
                return ferias;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string ColetarIdEmpresaFUnc(string idFuncionario)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Id_empresas FROM Funcionarios WHERE Id_funcionario = @idFuncionario";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = idFuncionario;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();
                string idEmpresa = null;

                while (_leitor.Read())
                {
                    idEmpresa = _leitor.GetInt32(0).ToString();
                }
                conexaoDb.Close();
                return idEmpresa;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InserirDecimoTerceiro(List<string> dadosDecimo)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "INSERT INTO Decimo_terceiro_salario (Salario_base_decimo, Primeira_parcela, Segunda_parcela, Id_funcionario) " +
                                "VALUES (@salarioBaseDecimo, @primeiraParcela, @segundaParcela, @idFuncionario)";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var _pmtSalarioBase = cmd.CreateParameter();
                _pmtSalarioBase.ParameterName = "@salarioBaseDecimo";
                _pmtSalarioBase.DbType = DbType.Double;
                _pmtSalarioBase.Value = dadosDecimo[1];
                cmd.Parameters.Add(_pmtSalarioBase);

                var _pmtPrimeiraParcela = cmd.CreateParameter();
                _pmtPrimeiraParcela.ParameterName = "@primeiraParcela";
                _pmtPrimeiraParcela.DbType = DbType.Double;
                _pmtPrimeiraParcela.Value = dadosDecimo[2];
                cmd.Parameters.Add(_pmtPrimeiraParcela);

                var _pmtSegundaPArcela = cmd.CreateParameter();
                _pmtSegundaPArcela.ParameterName = "@segundaParcela";
                _pmtSegundaPArcela.DbType = DbType.Double;
                _pmtSegundaPArcela.Value = dadosDecimo[3];
                cmd.Parameters.Add(_pmtSegundaPArcela);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idFuncionario";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = dadosDecimo[0];
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

        public bool ArmazenarFolhaDePagamento(List<string> dadosFolha, List<string> listaDeId)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho); 

            try
            {
                conexaoDb.Open();

                string querry = "INSERT INTO Folha_pagamento (Salario_base, Vl_transporte, Vl_alimentacao, Adiantamento, Horas_trabalhadas, Horas_extras, Adicional_not, Periculosidade, Insalubridade, " +
                                "Id_planos_saude, Id_planos_odontologicos, Dependentes, Pensao, Atrasos, Faltas, Inss, Irrf, Id_Decimo_terceiro, Fgts, Vencimentos, Desconto, Salario_liquido, " +
                                "Id_funcionarios, Id_empresas) " +
                                "VALUES " +
                                "(@salarioBase, @vlTransporte, @vlAlimentacao, @adiantamento, @horasTrabalhadas, @horasExtras, @adicionalNot, @periculosidade, @insalubridade, @idPlanosSaude, @idPlanosOdontologicos, " +
                                "@dependentes, @pensao, @atrasos, @faltas, @inss, @irrf, IDENT_CURRENT('Decimo_terceiro_salario'), @fgts, @vencimentos, @desconto, @salarioLiquido, @idFuncionarios, @idEmpresas)";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);



                var _pmSalarioBruto = cmd.CreateParameter();
                _pmSalarioBruto.ParameterName = "@salarioBase";
                _pmSalarioBruto.DbType = DbType.Double;
                _pmSalarioBruto.Value = dadosFolha[0];
                cmd.Parameters.Add(_pmSalarioBruto);

                var _pmtVlTransporte = cmd.CreateParameter();
                _pmtVlTransporte.ParameterName = "@vlTransporte";
                _pmtVlTransporte.DbType = DbType.Double;
                _pmtVlTransporte.Value = dadosFolha[1];
                cmd.Parameters.Add(_pmtVlTransporte);

                var _pmtVlAlimentacao = cmd.CreateParameter();
                _pmtVlAlimentacao.ParameterName = "@vlAlimentacao";
                _pmtVlAlimentacao.DbType = DbType.Double;
                _pmtVlAlimentacao.Value = dadosFolha[2];
                cmd.Parameters.Add(_pmtVlAlimentacao);

                var _pmtAdiantamento = cmd.CreateParameter();
                _pmtAdiantamento.ParameterName = "@adiantamento";
                _pmtAdiantamento.DbType = DbType.Double;
                _pmtAdiantamento.Value = dadosFolha[3];
                cmd.Parameters.Add(_pmtAdiantamento);

                var _pmtHorasTrabalhadas = cmd.CreateParameter();
                _pmtHorasTrabalhadas.ParameterName = "@horasTrabalhadas";
                _pmtHorasTrabalhadas.SqlDbType = SqlDbType.Int;
                _pmtHorasTrabalhadas.Value = dadosFolha[17];
                cmd.Parameters.Add(_pmtHorasTrabalhadas);

                var _pmtHorasExtras = cmd.CreateParameter();
                _pmtHorasExtras.ParameterName = "@horasExtras";
                _pmtHorasExtras.DbType = DbType.Double;
                _pmtHorasExtras.Value = dadosFolha[4];
                cmd.Parameters.Add(_pmtHorasExtras);

                var _pmtAdcNot = cmd.CreateParameter();
                _pmtAdcNot.ParameterName = "@adicionalNot";
                _pmtAdcNot.DbType = DbType.Double;
                _pmtAdcNot.Value = dadosFolha[5];
                cmd.Parameters.Add(_pmtAdcNot);

                var _pmtPericulosidade = cmd.CreateParameter();
                _pmtPericulosidade.ParameterName = "@periculosidade";
                _pmtPericulosidade.DbType = DbType.Double;
                _pmtPericulosidade.Value = dadosFolha[6];
                cmd.Parameters.Add(_pmtPericulosidade);

                var _pmtInsalubridade = cmd.CreateParameter();
                _pmtInsalubridade.ParameterName = "@insalubridade";
                _pmtInsalubridade.DbType = DbType.Double;
                _pmtInsalubridade.Value = 0;
                cmd.Parameters.Add(_pmtInsalubridade);

                var _pmtIdPlanoSaude = cmd.CreateParameter();
                _pmtIdPlanoSaude.ParameterName = "@idPlanosSaude";
                _pmtIdPlanoSaude.DbType = DbType.Int32;
                _pmtIdPlanoSaude.Value = listaDeId[1];
                cmd.Parameters.Add(_pmtIdPlanoSaude);

                var _pmtIdPlanoOdonto = cmd.CreateParameter();
                _pmtIdPlanoOdonto.ParameterName = "@idPlanosOdontologicos";
                _pmtIdPlanoOdonto.DbType = DbType.Int32;
                _pmtIdPlanoOdonto.Value = listaDeId[2];
                cmd.Parameters.Add(_pmtIdPlanoOdonto);

                var _pmtDependentes = cmd.CreateParameter();
                _pmtDependentes.ParameterName = "@dependentes";
                _pmtDependentes.DbType = DbType.Double;
                _pmtDependentes.Value = dadosFolha[7];
                cmd.Parameters.Add(_pmtDependentes);

                var _pmtPensao = cmd.CreateParameter();
                _pmtPensao.ParameterName = "@pensao";
                _pmtPensao.DbType = DbType.Double;
                _pmtPensao.Value = dadosFolha[8];
                cmd.Parameters.Add(_pmtPensao);

                var _pmtAtrasos = cmd.CreateParameter();
                _pmtAtrasos.ParameterName = "@atrasos";
                _pmtAtrasos.DbType = DbType.Double;
                _pmtAtrasos.Value = dadosFolha[9];
                cmd.Parameters.Add(_pmtAtrasos);

                var _pmtFaltas = cmd.CreateParameter();
                _pmtFaltas.ParameterName = "@faltas";
                _pmtFaltas.DbType = DbType.Double;
                _pmtFaltas.Value = dadosFolha[10];
                cmd.Parameters.Add(_pmtFaltas);

                var _pmtInss = cmd.CreateParameter();
                _pmtInss.ParameterName = "@inss";
                _pmtInss.DbType = DbType.Double;
                _pmtInss.Value = dadosFolha[11];
                cmd.Parameters.Add(_pmtInss);

                var _pmtIrrf = cmd.CreateParameter();
                _pmtIrrf.ParameterName = "@irrf";
                _pmtIrrf.DbType = DbType.Double;
                _pmtIrrf.Value = dadosFolha[12];
                cmd.Parameters.Add(_pmtIrrf);

                var _pmtFgts = cmd.CreateParameter();
                _pmtFgts.ParameterName = "@fgts";
                _pmtFgts.DbType = DbType.Double;
                _pmtFgts.Value = dadosFolha[13];
                cmd.Parameters.Add(_pmtFgts);

                var _pmtVencimentos = cmd.CreateParameter();
                _pmtVencimentos.ParameterName = "@vencimentos";
                _pmtVencimentos.DbType = DbType.Double;
                _pmtVencimentos.Value = dadosFolha[14];
                cmd.Parameters.Add(_pmtVencimentos);

                var _pmtDesconto = cmd.CreateParameter();
                _pmtDesconto.ParameterName = "@desconto";
                _pmtDesconto.DbType = DbType.Double;
                _pmtDesconto.Value = dadosFolha[15];
                cmd.Parameters.Add(_pmtDesconto);

                var _pmtSalarioLiquido = cmd.CreateParameter();
                _pmtSalarioLiquido.ParameterName = "@salarioLiquido";
                _pmtSalarioLiquido.DbType = DbType.Double;
                _pmtSalarioLiquido.Value = dadosFolha[16];
                cmd.Parameters.Add(_pmtSalarioLiquido);

                var _pmtIdFuncionario = cmd.CreateParameter();
                _pmtIdFuncionario.ParameterName = "idFuncionarios";
                _pmtIdFuncionario.DbType = DbType.Int32;
                _pmtIdFuncionario.Value = listaDeId[0];
                cmd.Parameters.Add(_pmtIdFuncionario);

                var _pmtIdEmpresa = cmd.CreateParameter();
                _pmtIdEmpresa.ParameterName = "@idEmpresas";
                _pmtIdEmpresa.DbType = DbType.Int32;
                _pmtIdEmpresa.Value = listaDeId[3] ;
                cmd.Parameters.Add(_pmtIdEmpresa);

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

        public bool ArmazenarFerias(List<string> dadosFerias, List<string> listaDeId)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "INSERT INTO Ferias (Dias_gozados, Saida, Retorno, Dias_vendidos, Abono_pecuniario, Um_terco_abonoP, Inss_ferias, Irrf_ferias, Bruto_ferias, " +
                                "Liquido_ferias, Id_funcionarios, Id_folha_pagamento, Id_agendamento) " +
                                "VALUES " +
                                "(@diasGozados, @saida, @retorno, @diasVendidos, @abonoPecuniario, @umTercoAbonoP, @inssFerias, @irrfFerias, @brutoFerias, @liquidoFerias, @idFuncionario, " +
                                "IDENT_CURRENT('Folha_pagamento'), IDENT_CURRENT('Agendamento_ferias'))";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);



                var _pmtDiasGozados = cmd.CreateParameter();
                _pmtDiasGozados.ParameterName = "@diasGozados";
                _pmtDiasGozados.DbType = DbType.Int32;
                _pmtDiasGozados.Value = dadosFerias[0];
                cmd.Parameters.Add(_pmtDiasGozados);

                var _pmtSaida = cmd.CreateParameter();
                _pmtSaida.ParameterName = "@saida";
                _pmtSaida.SqlDbType = SqlDbType.Date;
                _pmtSaida.Value = dadosFerias[1];
                cmd.Parameters.Add(_pmtSaida);

                var _pmtRetorno = cmd.CreateParameter();
                _pmtRetorno.ParameterName = "@retorno";
                _pmtRetorno.SqlDbType = SqlDbType.Date;
                _pmtRetorno.Value = dadosFerias[2];
                cmd.Parameters.Add(_pmtRetorno);

                var _pmtDIasVendidos = cmd.CreateParameter();
                _pmtDIasVendidos.ParameterName = "@diasVendidos";
                _pmtDIasVendidos.DbType = DbType.Int32;
                _pmtDIasVendidos.Value = dadosFerias[3];
                cmd.Parameters.Add(_pmtDIasVendidos);

                var _pmtAbonoPec = cmd.CreateParameter();
                _pmtAbonoPec.ParameterName = "@abonoPecuniario";
                _pmtAbonoPec.DbType = DbType.Double;
                _pmtAbonoPec.Value = dadosFerias[4];
                cmd.Parameters.Add(_pmtAbonoPec);

                var _pmtUmTercoAbonoP = cmd.CreateParameter();
                _pmtUmTercoAbonoP.ParameterName = "@umTercoAbonoP";
                _pmtUmTercoAbonoP.DbType = DbType.Double;
                _pmtUmTercoAbonoP.Value = dadosFerias[5];
                cmd.Parameters.Add(_pmtUmTercoAbonoP);

                var _pmtInssFerias = cmd.CreateParameter();
                _pmtInssFerias.ParameterName = "@inssFerias";
                _pmtInssFerias.DbType = DbType.Double;
                _pmtInssFerias.Value = dadosFerias[6];
                cmd.Parameters.Add(_pmtInssFerias);

                var _pmtIrrfFerias = cmd.CreateParameter();
                _pmtIrrfFerias.ParameterName = "@irrfFerias";
                _pmtIrrfFerias.DbType = DbType.Double;
                _pmtIrrfFerias.Value = dadosFerias[7];
                cmd.Parameters.Add(_pmtIrrfFerias);

                var _pmtBrutoFerias = cmd.CreateParameter();
                _pmtBrutoFerias.ParameterName = "@brutoFerias";
                _pmtBrutoFerias.DbType = DbType.Double;
                _pmtBrutoFerias.Value = dadosFerias[8];
                cmd.Parameters.Add(_pmtBrutoFerias);

                var _pmtLiquidoFerias = cmd.CreateParameter();
                _pmtLiquidoFerias.ParameterName = "@liquidoFerias";
                _pmtLiquidoFerias.DbType = DbType.Double;
                _pmtLiquidoFerias.Value = dadosFerias[9];
                cmd.Parameters.Add(_pmtLiquidoFerias);

                var _pmtIdFuncionario = cmd.CreateParameter();
                _pmtIdFuncionario.ParameterName = "@idFuncionario";
                _pmtIdFuncionario.DbType = DbType.Double;
                _pmtIdFuncionario.Value = listaDeId[0];
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
    }
}
