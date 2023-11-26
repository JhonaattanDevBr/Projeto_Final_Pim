using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaPersonal;
using FuncionariosEmpresas;

namespace BaseDeDados
{
    public class crud_AcessoPersonalD
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

        // Ainda preciso mudar o crud e para buscar os atributos ao inves de receber parametros
        public bool CadastrarFuncPersonalD(Personal _personal)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string query = "INSERT INTO Acesso_personalD (Nome, Cargo, Setor, Usuario, Senha, Confirmacao_senha) VALUES (@nome, @cargo, @setor, @usuario, @senha, @confSenha)";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _personal.Nome;
                cmd.Parameters.Add(pmtNome);

                var pmtCargo = cmd.CreateParameter();
                pmtCargo.ParameterName = "@cargo";
                pmtCargo.DbType = DbType.String;
                pmtCargo.Value = _personal.Cargo;
                cmd.Parameters.Add(pmtCargo);

                var pmtSetor = cmd.CreateParameter();
                pmtSetor.ParameterName = "@setor";
                pmtSetor.DbType = DbType.String;
                pmtSetor.Value = _personal.Setor;
                cmd.Parameters.Add(pmtSetor);

                var pmtUsuario = cmd.CreateParameter();
                pmtUsuario.ParameterName = "@usuario";
                pmtUsuario.DbType = DbType.String;
                pmtUsuario.Value = _personal.Usuario;
                cmd.Parameters.Add(pmtUsuario);

                var pmtSenha = cmd.CreateParameter();
                pmtSenha.ParameterName = "@senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = _personal.Senha;
                cmd.Parameters.Add(pmtSenha);

                var pmtConfSenha = cmd.CreateParameter();
                pmtConfSenha.ParameterName = "@confSenha";
                pmtConfSenha.DbType = DbType.String;
                pmtConfSenha.Value = _personal.ConfirmacaoSenha;
                cmd.Parameters.Add(pmtConfSenha);

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

        public string ColetarSenha(Personal _personal)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT Senha FROM Acesso_personalD";

                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                SqlDataReader _leitor = cmd.ExecuteReader();

                string senha = _personal.Senha;
                while (_leitor.Read())
                {
                    if (senha == _leitor.GetString(0))
                    {
                        _personal.Senha = _leitor.GetString(0);
                    }
                    
                }

                conexaoDb.Close();
                return _personal.Senha;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ColetarLogin(Personal _personal)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT Usuario FROM Acesso_personalD";

                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                SqlDataReader _leitor = cmd.ExecuteReader();

                string login = _personal.Usuario;
                while (_leitor.Read())
                {
                    if(login == _leitor.GetString(0))
                    {
                        _personal.Usuario = _leitor.GetString(0);
                    }
                    
                }

                conexaoDb.Close();
                return _personal.Usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ColetarNomeFuncionario(Personal _personal, string nomeUsuario)
        {
            string caminho = _servidores.servidor;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT Nome FROM Acesso_personalD WHERE Usuario = @usuario";

                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtUsuario = cmd.CreateParameter();
                _pmtUsuario.ParameterName = "@usuario";
                _pmtUsuario.DbType = DbType.String;
                _pmtUsuario.Value = nomeUsuario;
                cmd.Parameters.Add(_pmtUsuario);

                SqlDataReader _leitor = cmd.ExecuteReader();

                while (_leitor.Read())
                {
                    _personal.Nome = _leitor.GetString(0);
                }

                conexaoDb.Close();
                return _personal.Nome;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
