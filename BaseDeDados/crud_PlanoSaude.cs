using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanoSaude;
using System.ComponentModel.Design;

namespace BaseDeDados
{
    public class crud_PlanoSaude
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

        public bool CadastrarConvMedico(ConvenioMedico _convenioMedico)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string query = "INSERT INTO Planos_saude (Nome, Cnpj, Valor, Porcentagem) VALUES (@nome, @cnpj, @valor, @porcentagem)";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _convenioMedico.NomeConvMedico;
                cmd.Parameters.Add(pmtNome);

                var pmtCnpj = cmd.CreateParameter();
                pmtCnpj.ParameterName = "@cnpj";
                pmtCnpj.DbType = DbType.String;
                pmtCnpj.Value = _convenioMedico.CnpjConvMedico;
                cmd.Parameters.Add(pmtCnpj);

                var pmtValor = cmd.CreateParameter();
                pmtValor.ParameterName = "@valor";
                pmtValor.DbType = DbType.Double;
                pmtValor.Value = _convenioMedico.ValorConvMedico;
                cmd.Parameters.Add(pmtValor);

                var pmtPorcentagem = cmd.CreateParameter();
                pmtPorcentagem.ParameterName = "@porcentagem";
                pmtPorcentagem.DbType = DbType.Int32;
                pmtPorcentagem.Value = _convenioMedico.PorcentagemConvMedico;
                cmd.Parameters.Add(pmtPorcentagem);

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

        public bool ExcluirConvMedico(string id)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "DELETE FROM Planos_saude WHERE id_saude = @id";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@id";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = id;
                cmd.Parameters.Add( _pmtId);

                if(cmd.ExecuteNonQuery() > 0)
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

        public DataTable buscarConvenioMedico()
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT * FROM Planos_saude";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);
                SqlDataReader _leitor = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Código", typeof(int));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Cnpj", typeof(string));
                dt.Columns.Add("Valor", typeof(decimal));
                dt.Columns.Add("Porcentagem", typeof(decimal));

                while (_leitor.Read())
                {
                    int id = _leitor.GetInt32(0);
                    string nome = _leitor.GetString(1);
                    string cnpj = _leitor.GetString(2);
                    double valor = _leitor.GetDouble(3);
                    int porcentagem = _leitor.GetInt32(4);
                    dt.Rows.Add(id, nome, cnpj, valor, porcentagem);
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
