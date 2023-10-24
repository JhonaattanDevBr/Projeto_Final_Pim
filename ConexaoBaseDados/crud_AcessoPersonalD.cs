using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBaseDados
{
    public class crud_AcessoPersonalD
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();
        // Ainda preciso mudar o crud e para buscar os atributos ao inves de receber parametros
        public bool CadastrarFuncPersonalD(string nome,
                                           string cargo,
                                           string setor,
                                           string usuario,
                                           string senha,
                                           string confirmacaoSenha)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string query = "INSERT INTO Acesso_personalD (Nome, Cargo, Setor, Usuario, Senha, Confirmacao_senha) VALUES (@nome, @cargo, @setor, @usuario, @senha, @confSenha)";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = nome;
                cmd.Parameters.Add(pmtNome);

                var pmtCargo = cmd.CreateParameter();
                pmtCargo.ParameterName = "@cargo";
                pmtCargo.DbType = DbType.String;
                pmtCargo.Value = cargo;
                cmd.Parameters.Add(pmtCargo);

                var pmtSetor = cmd.CreateParameter();
                pmtSetor.ParameterName = "@setor";
                pmtSetor.DbType = DbType.String;
                pmtSetor.Value = setor;
                cmd.Parameters.Add(pmtSetor);

                var pmtUsuario = cmd.CreateParameter();
                pmtUsuario.ParameterName = "@usuario";
                pmtUsuario.DbType = DbType.String;
                pmtUsuario.Value = usuario;
                cmd.Parameters.Add(pmtUsuario);

                var pmtSenha = cmd.CreateParameter();
                pmtSenha.ParameterName = "@senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = senha;
                cmd.Parameters.Add(pmtSenha);

                var pmtConfSenha = cmd.CreateParameter();
                pmtConfSenha.ParameterName = "@confSenha";
                pmtConfSenha.DbType= DbType.String;
                pmtConfSenha.Value = confirmacaoSenha;
                cmd.Parameters.Add(pmtConfSenha);

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
           
        }servidoresBancoDados _servidores = new servidoresBancoDados();
        // Ainda preciso mudar o crud e para buscar os atributos ao inves de receber parametros
        public bool CadastrarFuncPersonalD(string nome,
                                           string cargo,
                                           string setor,
                                           string usuario,
                                           string senha,
                                           string confirmacaoSenha)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string query = "INSERT INTO Acesso_personalD (Nome, Cargo, Setor, Usuario, Senha, Confirmacao_senha) VALUES (@nome, @cargo, @setor, @usuario, @senha, @confSenha)";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = nome;
                cmd.Parameters.Add(pmtNome);

                var pmtCargo = cmd.CreateParameter();
                pmtCargo.ParameterName = "@cargo";
                pmtCargo.DbType = DbType.String;
                pmtCargo.Value = cargo;
                cmd.Parameters.Add(pmtCargo);

                var pmtSetor = cmd.CreateParameter();
                pmtSetor.ParameterName = "@setor";
                pmtSetor.DbType = DbType.String;
                pmtSetor.Value = setor;
                cmd.Parameters.Add(pmtSetor);

                var pmtUsuario = cmd.CreateParameter();
                pmtUsuario.ParameterName = "@usuario";
                pmtUsuario.DbType = DbType.String;
                pmtUsuario.Value = usuario;
                cmd.Parameters.Add(pmtUsuario);

                var pmtSenha = cmd.CreateParameter();
                pmtSenha.ParameterName = "@senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = senha;
                cmd.Parameters.Add(pmtSenha);

                var pmtConfSenha = cmd.CreateParameter();
                pmtConfSenha.ParameterName = "@confSenha";
                pmtConfSenha.DbType= DbType.String;
                pmtConfSenha.Value = confirmacaoSenha;
                cmd.Parameters.Add(pmtConfSenha);

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
    }
}
