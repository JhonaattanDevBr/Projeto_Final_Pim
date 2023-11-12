using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresasClientes;
using PlanoSaude;

namespace BaseDeDados
{
    public class crud_Empresas
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

        public bool IncluirEnderecoEmpresa(Empresas _empresa)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "INSERT INTO ENDERECO (Cidade, Estado, Bairro, Rua, Numero) VALUES (@cidade, @estado, @bairro, @rua, @numero)";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var pmtCidade = cmd.CreateParameter();
                pmtCidade.ParameterName = "@cidade";
                pmtCidade.DbType = DbType.String;
                pmtCidade.Value = _empresa.Cidade;
                cmd.Parameters.Add(pmtCidade);

                var pmtEstado = cmd.CreateParameter();
                pmtEstado.ParameterName = "@estado";
                pmtEstado.DbType = DbType.String;
                pmtEstado.Value = _empresa.Estado;
                cmd.Parameters.Add(pmtEstado);

                var pmtBairro = cmd.CreateParameter();
                pmtBairro.ParameterName = "@bairro";
                pmtBairro.DbType = DbType.String;
                pmtBairro.Value = _empresa.Bairro;
                cmd.Parameters.Add(pmtBairro);

                var pmtRua = cmd.CreateParameter();
                pmtRua.ParameterName = "@rua";
                pmtRua.DbType = DbType.String;
                pmtRua.Value = _empresa.Rua;
                cmd.Parameters.Add(pmtRua);

                var pmtNumero = cmd.CreateParameter();
                pmtNumero.ParameterName = "@numero";
                pmtNumero.DbType = DbType.Int32;
                pmtNumero.Value = _empresa.Numero;
                cmd.Parameters.Add(pmtNumero);

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

        public bool IncluirEmpresa(Empresas _empresa)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {// vou ter que rodar esse codigo de novo para descobri o pq da erro na segunda vez em q vou execultar.
                conexaoDb.Open();

                string querry = "INSERT INTO EMPRESAS (Razao_social, Nome_fantasia, Nacionalidade, Cnpj, Email, Telefone, Ceo, Fundacao, Segmento, Id_endereco)" +
                    "VALUES (@razao_social, @nome_Fantasia, @nacionalidade, @cnpj, @email, @telefone, @ceo, @fundacao, @segmento, IDENT_CURRENT('Endereco'))";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);

                var pmtRazao_Social = cmd.CreateParameter();
                pmtRazao_Social.ParameterName = "@razao_social";
                pmtRazao_Social.DbType = DbType.String;
                pmtRazao_Social.Value = _empresa.RazaoSocial;
                cmd.Parameters.Add(pmtRazao_Social);

                var pmtNome_Fantasia = cmd.CreateParameter();
                pmtNome_Fantasia.ParameterName = "@nome_Fantasia";
                pmtNome_Fantasia.DbType = DbType.String;
                pmtNome_Fantasia.Value = _empresa.NomeFantasia;
                cmd.Parameters.Add(pmtNome_Fantasia);

                var pmtNacionalidade = cmd.CreateParameter();
                pmtNacionalidade.ParameterName = "@nacionalidade";
                pmtNacionalidade.DbType = DbType.String;
                pmtNacionalidade.Value = _empresa.Nascionalidade;
                cmd.Parameters.Add(pmtNacionalidade);

                var pmtCnpj = cmd.CreateParameter();
                pmtCnpj.ParameterName = "@cnpj";
                pmtCnpj.DbType = DbType.String;
                pmtCnpj.Value = _empresa.Cnpj;
                cmd.Parameters.Add(pmtCnpj);

                var pmtEmail = cmd.CreateParameter();
                pmtEmail.ParameterName = "@email";
                pmtEmail.DbType = DbType.String;
                pmtEmail.Value = _empresa.Email;
                cmd.Parameters.Add(pmtEmail);

                var pmtTelefone = cmd.CreateParameter();
                pmtTelefone.ParameterName = "@telefone";
                pmtTelefone.DbType = DbType.String;
                pmtTelefone.Value = _empresa.Telefone;
                cmd.Parameters.Add(pmtTelefone);

                var pmtCeo = cmd.CreateParameter();
                pmtCeo.ParameterName = "@ceo";
                pmtCeo.DbType = DbType.String;
                pmtCeo.Value = _empresa.Ceo;
                cmd.Parameters.Add(pmtCeo);

                var pmtFundacao = cmd.CreateParameter();
                pmtFundacao.ParameterName = "@fundacao";
                pmtFundacao.DbType = DbType.Date;
                pmtFundacao.Value = _empresa.Fundacao;
                cmd.Parameters.Add(pmtFundacao);

                var pmtSegmento = cmd.CreateParameter();
                pmtSegmento.ParameterName = "@segmento";
                pmtSegmento.DbType = DbType.String;
                pmtSegmento.Value = _empresa.Segmento;
                cmd.Parameters.Add(pmtSegmento);

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

        public bool AtualizarEnderecoEmpresas(Empresas _empresa)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "UPDATE Endereco SET " +
                               "Cidade = @cidade, Estado = @estado, Bairro = @bairro, Rua = @rua, Numero = @numero WHERE Id_endereco = @idEndereco";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtCidade = cmd.CreateParameter();
                _pmtCidade.ParameterName = "@cidade";
                _pmtCidade.DbType = DbType.String;
                _pmtCidade.Value = _empresa.Cidade;
                cmd.Parameters.Add(_pmtCidade);

                var _pmtEstado = cmd.CreateParameter();
                _pmtEstado.ParameterName = "@estado";
                _pmtEstado.DbType = DbType.String;
                _pmtEstado.Value = _empresa.Estado;
                cmd.Parameters.Add(_pmtEstado);

                var _pmtBairro = cmd.CreateParameter();
                _pmtBairro.ParameterName = "@bairro";
                _pmtBairro.DbType = DbType.String;
                _pmtBairro.Value = _empresa.Bairro;
                cmd.Parameters.Add(_pmtBairro);

                var _pmtRua = cmd.CreateParameter();
                _pmtRua.ParameterName = "@rua";
                _pmtRua.DbType = DbType.String;
                _pmtRua.Value = _empresa.Rua;
                cmd.Parameters.Add(_pmtRua);

                var _pmtNumero = cmd.CreateParameter();
                _pmtNumero.ParameterName = "@numero";
                _pmtNumero.DbType = DbType.Int32;
                _pmtNumero.Value = _empresa.Numero;
                cmd.Parameters.Add(_pmtNumero);

                var _pmtIdEndereco = cmd.CreateParameter();
                _pmtIdEndereco.ParameterName = "@idEndereco";
                _pmtIdEndereco.DbType = DbType.Int32;
                _pmtIdEndereco.Value = _empresa.IdEndereco;
                cmd.Parameters.Add(_pmtIdEndereco);

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
            }
        }

        public bool AtualizarRegistroEmpresas(Empresas _empresa)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "UPDATE Empresas SET " +
                               "Razao_social = @razaoSocial, Nome_fantasia = @nomeFantaia, Nacionalidade = @nascionalidade, Cnpj = @cnpj, " +
                               "Email = @email, Telefone = @telefone, Ceo = @ceo, Fundacao = @fundacao, Segmento = @segmento, Id_endereco = @idEndereco WHERE Id_empresa = @idEmpresa";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtRazaoSocial = cmd.CreateParameter();
                _pmtRazaoSocial.ParameterName = "@razaoSocial";
                _pmtRazaoSocial.DbType = DbType.String;
                _pmtRazaoSocial.Value = _empresa.RazaoSocial;
                cmd.Parameters.Add(_pmtRazaoSocial);

                var _pmtNomeFantasia = cmd.CreateParameter();
                _pmtNomeFantasia.ParameterName = "@nomeFantaia";
                _pmtNomeFantasia.DbType = DbType.String;
                _pmtNomeFantasia.Value = _empresa.NomeFantasia;
                cmd.Parameters.Add(_pmtNomeFantasia);

                var _pmtNascionalidade = cmd.CreateParameter();
                _pmtNascionalidade.ParameterName = "@nascionalidade";
                _pmtNascionalidade.DbType = DbType.String;
                _pmtNascionalidade.Value = _empresa.Nascionalidade;
                cmd.Parameters.Add(_pmtNascionalidade);

                var _pmtCnpj = cmd.CreateParameter();
                _pmtCnpj.ParameterName = "@cnpj";
                _pmtCnpj.DbType = DbType.String;
                _pmtCnpj.Value = _empresa.Cnpj;
                cmd.Parameters.Add(_pmtCnpj);

                var _pmtEmail = cmd.CreateParameter();
                _pmtEmail.ParameterName = "@email";
                _pmtEmail.DbType = DbType.String;
                _pmtEmail.Value = _empresa.Email;
                cmd.Parameters.Add(_pmtEmail);

                var _pmtTelefone = cmd.CreateParameter();
                _pmtTelefone.ParameterName = "@telefone";
                _pmtTelefone.DbType = DbType.String;
                _pmtTelefone.Value = _empresa.Telefone;
                cmd.Parameters.Add(_pmtTelefone);

                var _pmtCeo = cmd.CreateParameter();
                _pmtCeo.ParameterName = "@ceo";
                _pmtCeo.DbType = DbType.String;
                _pmtCeo.Value = _empresa.Ceo;
                cmd.Parameters.Add(_pmtCeo);

                var _pmtFundacao = cmd.CreateParameter();
                _pmtFundacao.ParameterName = "@fundacao";
                _pmtFundacao.DbType = DbType.Date;
                _pmtFundacao.Value = _empresa.Fundacao;
                cmd.Parameters.Add(_pmtFundacao);

                var _pmtSegmento = cmd.CreateParameter();
                _pmtSegmento.ParameterName = "@segmento";
                _pmtSegmento.DbType = DbType.String;
                _pmtSegmento.Value = _empresa.Segmento;
                cmd.Parameters.Add(_pmtSegmento);

                var _pmtIdEndereco = cmd.CreateParameter();
                _pmtIdEndereco.ParameterName = "@idEndereco";
                _pmtIdEndereco.DbType = DbType.Int32;
                _pmtIdEndereco.Value = _empresa.IdEndereco;
                cmd.Parameters.Add( _pmtIdEndereco);

                var _pmtIdEmpresa = cmd.CreateParameter();
                _pmtIdEmpresa.ParameterName = "@idEmpresa";
                _pmtIdEmpresa.DbType = DbType.Int32;
                _pmtIdEmpresa.Value = _empresa.Id;
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
            finally
            {
                conexaoDb.Close();
            }
        }

        public bool ExcluirEmpresa(string id)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "DELETE FROM Empresas WHERE id_empresa = @id";
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

        public DataTable BuscarEmpresas()
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Id_empresa, Razao_social, Nome_fantasia, Nacionalidade, Cnpj, Email, Telefone, Ceo, Fundacao, Segmento, Empresas.Id_endereco, " +
                                "Cidade, Estado, Bairro, Rua, Numero FROM Empresas " +
                                "INNER JOIN Endereco " +
                                "ON Empresas.Id_endereco = Endereco.Id_endereco";
                SqlCommand cmd = new SqlCommand(querry, conexaoDb);
                SqlDataReader _leitor = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Código", typeof(int));
                dt.Columns.Add("Razão Social", typeof(string));
                dt.Columns.Add("Nome Fantasia", typeof(string));
                dt.Columns.Add("Nascionalidade", typeof(string));
                dt.Columns.Add("Cnpj", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Telefone", typeof(string));
                dt.Columns.Add("Ceo", typeof(string));
                dt.Columns.Add("Fundação", typeof(DateTime));
                dt.Columns.Add("Segmento", typeof(string));
                dt.Columns.Add("Cód. Endereco", typeof(int));
                dt.Columns.Add("Cidade", typeof(string));
                dt.Columns.Add("Estado", typeof(string));
                dt.Columns.Add("Bairro", typeof(string));
                dt.Columns.Add("Rua", typeof(string));
                dt.Columns.Add("Numero", typeof(int));

                while (_leitor.Read())
                {
                    int id = _leitor.GetInt32(0);
                    string razaoSocial = _leitor.GetString(1);
                    string nomeFantasia = _leitor.GetString(2);
                    string nascionalidade = _leitor.GetString(3);
                    string cnpj = _leitor.GetString(4);
                    string email = _leitor.GetString(5);
                    string telefone = _leitor.GetString(6);
                    string ceo = _leitor.GetString(7);
                    DateTime fundacao = _leitor.GetDateTime(8);
                    string segmento = _leitor.GetString(9);
                    int codEndereco = _leitor.GetInt32(10);
                    string cidade = _leitor.GetString(11);
                    string estado = _leitor.GetString(12);
                    string bairro = _leitor.GetString(13);
                    string rua = _leitor.GetString(14);
                    int numero = _leitor.GetInt32(15);

                    dt.Rows.Add(id, razaoSocial, nomeFantasia, nascionalidade, cnpj, email, telefone, ceo, fundacao, segmento, codEndereco, cidade, estado, bairro, rua, numero);
                }
                conexaoDb.Close();
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Empresas> BuscarInfoEmpresarialEmpresas(Empresas _empresas)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT * FROM Empresas WHERE Id_Empresa = @id";

                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                List<Empresas> _registro = new List<Empresas>();

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@id";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = _empresas.Id;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();

                while (_leitor.Read())
                {
                    _empresas.RazaoSocial = _leitor.GetString(1);
                    _empresas.NomeFantasia = _leitor.GetString(2);
                    _empresas.Nascionalidade = _leitor.GetString(3);
                    _empresas.Cnpj = _leitor.GetString(4).ToString();
                    _empresas.Email = _leitor.GetString(5);
                    _empresas.Telefone = _leitor.GetString(6);
                    _empresas.Ceo = _leitor.GetString(7);
                    _empresas.Fundacao = _leitor.GetDateTime(8).ToString();
                    _empresas.Segmento = _leitor.GetString(9);
                    _registro.Add(_empresas);

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

        public List<Empresas> BuscarEnderecoEmpresas(Empresas _empresas)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT * FROM Endereco WHERE Id_endereco = @idEndereco";

                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                List<Empresas> _registro = new List<Empresas>();

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@idEndereco";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = _empresas.IdEndereco;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();

                while (_leitor.Read())
                {
                    _empresas.Cidade = _leitor.GetString(1);
                    _empresas.Estado = _leitor.GetString(2);
                    _empresas.Bairro = _leitor.GetString(3);
                    _empresas.Rua = _leitor.GetString(4);
                    _empresas.Numero = _leitor.GetInt32(5).ToString();
                    _registro.Add(_empresas);

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
