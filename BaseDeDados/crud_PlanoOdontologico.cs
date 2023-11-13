using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanoOdontologico;
using PlanoSaude;

namespace BaseDeDados
{
    public class crud_PlanoOdontologico
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

        public string Id { get; set; }

        public bool CadastrarConvOdontologico(ConvenioOdontologico _convenioOdontologico)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string query = "INSERT INTO Planos_odontologicos (Nome, Cnpj, Valor, Porcentagem) VALUES (@nome, @cnpj, @valor, @porcentagem)";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _convenioOdontologico.NomeConvOdonto;
                cmd.Parameters.Add(pmtNome);

                var pmtCnpj = cmd.CreateParameter();
                pmtCnpj.ParameterName = "@cnpj";
                pmtCnpj.DbType = DbType.String;
                pmtCnpj.Value = _convenioOdontologico.CnpjConvOdonto;
                cmd.Parameters.Add(pmtCnpj);

                var pmtValor = cmd.CreateParameter();
                pmtValor.ParameterName = "@valor";
                pmtValor.DbType = DbType.Double;
                pmtValor.Value = _convenioOdontologico.ValorConvOdonto;
                cmd.Parameters.Add(pmtValor);

                var pmtPorcentagem = cmd.CreateParameter();
                pmtPorcentagem.ParameterName = "@porcentagem";
                pmtPorcentagem.DbType = DbType.Int32;
                pmtPorcentagem.Value = _convenioOdontologico.PorcentagemConvOdonto;
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

        public DataTable BuscarConveniOdontologico()
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT * FROM Planos_odontologicos";
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

        public bool AlterarConvOdontologico(ConvenioOdontologico _convenioOdontologico)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "UPDATE Planos_odontologicos SET Nome = @nome, " +
                               "Cnpj = @cnpj, " +
                               "Valor = @valor, " +
                               "Porcentagem = @porcentagem" +
                               " WHERE Id_odonto = @id";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtNome = cmd.CreateParameter();
                _pmtNome.ParameterName = "@nome";
                _pmtNome.DbType = DbType.String;
                _pmtNome.Value = _convenioOdontologico.NomeConvOdonto;
                cmd.Parameters.Add(_pmtNome);

                var _pmtCpf = cmd.CreateParameter();
                _pmtCpf.ParameterName = "@cnpj";
                _pmtCpf.DbType = DbType.String;
                _pmtCpf.Value = _convenioOdontologico.CnpjConvOdonto;
                cmd.Parameters.Add(_pmtCpf);

                var _pmtValor = cmd.CreateParameter();
                _pmtValor.ParameterName = "@valor";
                _pmtValor.SqlDbType = SqlDbType.Float;
                _pmtValor.Value = _convenioOdontologico.ValorConvOdonto;
                cmd.Parameters.Add(_pmtValor);

                var _pmtPorcentagem = cmd.CreateParameter();
                _pmtPorcentagem.ParameterName = "@porcentagem";
                _pmtPorcentagem.DbType = DbType.Int32;
                _pmtPorcentagem.Value = _convenioOdontologico.PorcentagemConvOdonto;
                cmd.Parameters.Add(_pmtPorcentagem);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "id";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = _convenioOdontologico.Id;
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
            finally
            {
                conexaoDb.Close();
                Id = "";
            }
        }

        public bool ExcluirConvOdontologico(string id)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "DELETE FROM Planos_odontologicos WHERE Id_odonto = @id";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@id";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = id;
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

        public List<ConvenioOdontologico> BuscarConvMedicoEspecifico(ConvenioOdontologico _convenioOdontologico)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT * FROM Planos_odontologicos WHERE Id_odonto = @id";

                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                List<ConvenioOdontologico> _registro = new List<ConvenioOdontologico>();

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@id";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = _convenioOdontologico.Id;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();

                while (_leitor.Read())
                {
                    _convenioOdontologico.NomeConvOdonto = _leitor.GetString(1);
                    _convenioOdontologico.CnpjConvOdonto = _leitor.GetString(2);
                    _convenioOdontologico.ValorConvOdonto = _leitor.GetDouble(3).ToString();
                    _convenioOdontologico.PorcentagemConvOdonto = _leitor.GetInt32(4).ToString();
                    _registro.Add(_convenioOdontologico);

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
    }
}
