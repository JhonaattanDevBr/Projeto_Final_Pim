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
    }
}
