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
                    string mes = _leitor.GetString(01);
                    string periodo = _leitor.GetInt32(2).ToString();
                    string diasVendidos = _leitor.GetInt32(8).ToString();
                    ferias.Add(mes);
                    ferias.Add(periodo);
                    ferias.Add(diasVendidos);
                }
                conexaoDb.Close();
                return ferias;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
