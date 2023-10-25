using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresasClientes;

namespace BaseDeDados
{
    public class crud_Empresas
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

        public bool incluirEnderecoEmpresa(Empresas _empresa)
        {
            string caminho = _servidores.servidorNotebook;
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

        public bool incluirEmpresa(Empresas _empresa)
        {
            string caminho = _servidores.servidorNotebook;
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
                pmtTelefone.DbType = DbType.Int32;
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
    }
}
