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
    }
}
