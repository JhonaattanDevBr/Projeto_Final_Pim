using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EmpresasClientes;
using FuncionariosEmpresas;

namespace ConexaoBaseDados
{
    public class crud_Funcionarios
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

        private string Query { get; set; }
        
        public bool IncluirEnderecoFuncioanario(Funcionarios _funcionario)
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
                pmtCidade.Value = _funcionario.Cidade;
                cmd.Parameters.Add(pmtCidade);

                var pmtEstado = cmd.CreateParameter();
                pmtEstado.ParameterName = "@estado";
                pmtEstado.DbType = DbType.String;
                pmtEstado.Value = _funcionario.Estado;
                cmd.Parameters.Add(pmtEstado);

                var pmtBairro = cmd.CreateParameter();
                pmtBairro.ParameterName = "@bairro";
                pmtBairro.DbType = DbType.String;
                pmtBairro.Value = _funcionario.Bairro;
                cmd.Parameters.Add(pmtBairro);

                var pmtRua = cmd.CreateParameter();
                pmtRua.ParameterName = "@rua";
                pmtRua.DbType = DbType.String;
                pmtRua.Value = _funcionario.Rua;
                cmd.Parameters.Add(pmtRua);

                var pmtNumero = cmd.CreateParameter();
                pmtNumero.ParameterName = "@numero";
                pmtNumero.DbType = DbType.Int32;
                pmtNumero.Value = _funcionario.Numero;
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

        public bool IncluirFuncionario(Funcionarios _funcionario)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            if (_funcionario.ConvenioMedico == "0")
            {
                Query = "INSERT INTO Funcionarios (Nome, Sobrenome, Idade, Sexo, Id_endereco, Registro, Carga_horaria, Cpf, Rg, Email, Email_secundario, Telefone, " +
                        "Cell_principal, Cell_secundario, Num_dependentes, Id_planos_odontologicos, Id_empresas, Cargo, Salario, Data_admissao) " +
                        "VALUES " +
                        "(@nome, @sobrenome, @idade, @sexo, IDENT_CURRENT('Endereco'), @registro, @carga_horaria, @cpf, @rg, @email, @email_secundario, @telefone, " +
                        "@cell_principal, @cell_secundario, @num_dependentes, @id_planos_odontologicos, @id_empresas, @cargo, @salario, @data_admissao)";
            }
            else if (_funcionario.ConvenioOdontologico == "0")
            {
                Query = "INSERT INTO Funcionarios (Nome, Sobrenome, Idade, Sexo, Id_endereco, Registro, Carga_horaria, Cpf, Rg, Email, Email_secundario, Telefone, " +
                        "Cell_principal, Cell_secundario, Num_dependentes, Id_planos_saude, Id_empresas, Cargo, Salario, Data_admissao) " +
                        "VALUES " +
                        "(@nome, @sobrenome, @idade, @sexo, IDENT_CURRENT('Endereco'), @registro, @carga_horaria, @cpf, @rg, @email, @email_secundario, @telefone, " +
                        "@cell_principal, @cell_secundario, @num_dependentes, @id_planos_saude, @id_empresas, @cargo, @salario, @data_admissao)";
            }
            else if(_funcionario.ConvenioMedico == "0" && _funcionario.ConvenioOdontologico == "0")
            {
                Query = "INSERT INTO Funcionarios (Nome, Sobrenome, Idade, Sexo, Id_endereco, Registro, Carga_horaria, Cpf, Rg, Email, Email_secundario, Telefone, " +
                        "Cell_principal, Cell_secundario, Num_dependentes, Id_empresas, Cargo, Salario, Data_admissao) " +
                        "VALUES " +
                        "(@nome, @sobrenome, @idade, @sexo, IDENT_CURRENT('Endereco'), @registro, @carga_horaria, @cpf, @rg, @email, @email_secundario, @telefone, " +
                        "@cell_principal, @cell_secundario, @num_dependentes, @id_empresas, @cargo, @salario, @data_admissao)";
            }
            else
            {
                Query = "INSERT INTO Funcionarios (Nome, Sobrenome, Idade, Sexo, Id_endereco, Registro, Carga_horaria, Cpf, Rg, Email, Email_secundario, Telefone, " +
                        "Cell_principal, Cell_secundario, Num_dependentes, Id_planos_saude, Id_planos_odontologicos, Id_empresas, Cargo, Salario, Data_admissao) " +
                        "VALUES " +
                        "(@nome, @sobrenome, @idade, @sexo, IDENT_CURRENT('Endereco'), @registro, @carga_horaria, @cpf, @rg, @email, @email_secundario, @telefone, " +
                        "@cell_principal, @cell_secundario, @num_dependentes, @id_planos_saude, @id_planos_odontologicos, @id_empresas, @cargo, @salario, @data_admissao)";
            }

            try
            {
                conexaoDb.Open();

                SqlCommand cmd = new SqlCommand(Query, conexaoDb);

                var _pmtNome = cmd.CreateParameter();
                _pmtNome.ParameterName = "@nome";
                _pmtNome.DbType = DbType.String;
                _pmtNome.Value = _funcionario.Nome;
                cmd.Parameters.Add( _pmtNome );

                var _pmtSobrenome = cmd.CreateParameter();
                _pmtSobrenome.ParameterName = "@sobrenome";
                _pmtSobrenome.DbType = DbType.String;
                _pmtSobrenome.Value = _funcionario.Sobrenome;
                cmd.Parameters.Add(_pmtSobrenome );

                var _pmtIdade = cmd.CreateParameter();
                _pmtIdade.ParameterName = "@idade";
                _pmtIdade.DbType = DbType.Int32;
                _pmtIdade.Value = _funcionario.Idade;
                cmd.Parameters.Add(_pmtIdade );

                var _pmtSexo = cmd.CreateParameter();
                _pmtSexo.ParameterName = "@sexo";
                _pmtSexo.SqlDbType = SqlDbType.Char;
                _pmtSexo.Value = _funcionario.Sexo;
                cmd.Parameters.Add(_pmtSexo );

                var _pmtRegistro = cmd.CreateParameter();
                _pmtRegistro.ParameterName = "@registro";
                _pmtRegistro.DbType = DbType.Int32;
                _pmtRegistro.Value = _funcionario.NumeroRegistro;
                cmd.Parameters.Add(_pmtRegistro );

                var _pmtCargaHoraria = cmd.CreateParameter();
                _pmtCargaHoraria.ParameterName = "@carga_horaria";
                _pmtCargaHoraria.DbType = DbType.Int32;
                _pmtCargaHoraria.Value = _funcionario.CargaHoraria;
                cmd.Parameters.Add( _pmtCargaHoraria );

                var _pmtCpf = cmd.CreateParameter();
                _pmtCpf.ParameterName = "@cpf";
                _pmtCpf.DbType = DbType.String;
                _pmtCpf.Value = _funcionario.Cpf;
                cmd.Parameters.Add(_pmtCpf );

                var _pmtRg = cmd.CreateParameter();
                _pmtRg.ParameterName = "@rg";
                _pmtRg.DbType = DbType.String;
                _pmtRg.Value = _funcionario.Rg;
                cmd.Parameters.Add(_pmtRg );

                var _pmtEmail = cmd.CreateParameter();
                _pmtEmail.ParameterName = "@email";
                _pmtEmail.DbType = DbType.String;
                _pmtEmail.Value = _funcionario.Email;
                cmd.Parameters.Add(_pmtEmail );

                var _pmtEmailSecundario = cmd.CreateParameter();
                _pmtEmailSecundario.ParameterName = "@email_secundario";
                _pmtEmailSecundario.DbType = DbType.String;
                _pmtEmailSecundario.Value = _funcionario.EmailSecundario;
                cmd.Parameters.Add( _pmtEmailSecundario );

                var _pmtTelefone = cmd.CreateParameter();
                _pmtTelefone.ParameterName = "@telefone";
                _pmtTelefone.DbType = DbType.String;
                _pmtTelefone.Value = _funcionario.Telefone;
                cmd.Parameters.Add(_pmtTelefone );

                var _pmtCellPrincipal = cmd.CreateParameter();
                _pmtCellPrincipal.ParameterName = "@cell_principal";
                _pmtCellPrincipal.DbType = DbType.String;
                _pmtCellPrincipal.Value = _funcionario.CelularPrincipal;
                cmd.Parameters.Add(_pmtCellPrincipal );

                var _pmtCellSecundario = cmd.CreateParameter();
                _pmtCellSecundario.ParameterName = "@cell_secundario";
                _pmtCellSecundario.DbType = DbType.String;
                _pmtCellSecundario.Value = _funcionario.CelularSecundario;
                cmd.Parameters.Add(_pmtCellSecundario);

                var _pmtNumDependentes = cmd.CreateParameter();
                _pmtNumDependentes.ParameterName = "@num_dependentes";
                _pmtNumDependentes.DbType = DbType.Int32;
                _pmtNumDependentes.Value = _funcionario.Dependentes;
                cmd.Parameters.Add( _pmtNumDependentes );

                if(_funcionario.ConvenioMedico != "0")
                {
                    var _pmtIdPlanoSaude = cmd.CreateParameter();
                    _pmtIdPlanoSaude.ParameterName = "@id_planos_saude";
                    _pmtIdPlanoSaude.DbType = DbType.Int32;
                    _pmtIdPlanoSaude.Value = _funcionario.ConvenioMedico;
                    cmd.Parameters.Add(_pmtIdPlanoSaude);
                }
                
                if(_funcionario.ConvenioOdontologico != "0")
                {
                    var _pmtIdPlanoOdontologico = cmd.CreateParameter();
                    _pmtIdPlanoOdontologico.ParameterName = "@id_planos_odontologicos";
                    _pmtIdPlanoOdontologico.SqlDbType = SqlDbType.Int;
                    _pmtIdPlanoOdontologico.Value = _funcionario.ConvenioOdontologico;
                    cmd.Parameters.Add(_pmtIdPlanoOdontologico);
                }
                
                var _pmtIdEmpresa = cmd.CreateParameter();
                _pmtIdEmpresa.ParameterName = "@id_empresas";
                _pmtIdEmpresa.DbType = DbType.Int32;
                _pmtIdEmpresa.Value = _funcionario.Empregador;
                cmd.Parameters.Add( _pmtIdEmpresa );

                var _pmtCargo = cmd.CreateParameter();
                _pmtCargo.ParameterName = "@cargo";
                _pmtCargo.DbType = DbType.String;
                _pmtCargo.Value = _funcionario.Cargo;
                cmd.Parameters.Add( _pmtCargo );

                var _pmtSalario = cmd.CreateParameter();
                _pmtSalario.ParameterName = "@salario";
                _pmtSalario.DbType = DbType.Double;
                _pmtSalario.Value = _funcionario.Salario;
                cmd.Parameters.Add(_pmtSalario);

                var _pmtDataAdmissao = cmd.CreateParameter();
                _pmtDataAdmissao.ParameterName = "@data_admissao";
                _pmtDataAdmissao.DbType = DbType.Date;
                _pmtDataAdmissao.Value = _funcionario.DataAdmisao;
                cmd.Parameters.Add(_pmtDataAdmissao);

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

        public Dictionary<int, string> PopularCaixaConvenioMedico()
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT Id_saude, Nome FROM Planos_saude ORDER BY Id_saude";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);
                SqlDataReader leitura = cmd.ExecuteReader();
                Dictionary<int, string> dados = new Dictionary<int, string>(); // Criando um Dictionary para armazenar os dados do banco de dados
                while (leitura.Read())
                {
                    int idSaude = leitura.GetInt32(0);  // Lendo o Id_saude (assume-se que é int)
                    string nome = leitura.GetString(1); // Lendo o Nome

                    dados[idSaude] = nome; // Adicionando os dados ao Dictionary
                }
                conexaoDb.Close(); // Retornando o Dictionary com os dados do banco de dados
                return dados;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Dictionary<int, string> PopularCaixaConvenioOdontologico()
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();


                string query = "SELECT id_odonto, Nome FROM Planos_odontologicos ORDER BY id_odonto";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                SqlDataReader leitura = cmd.ExecuteReader();

                // Criando um Dictionary para armazenar os dados do banco de dados
                Dictionary<int, string> dados = new Dictionary<int, string>();

                while (leitura.Read())
                {
                    int id_odonto = leitura.GetInt32(0);  // Lendo o Id_saude (assume-se que é int)
                    string nome = leitura.GetString(1); // Lendo o Nome

                    // Adicionando os dados ao Dictionary
                    dados[id_odonto] = nome;
                }

                // Retornando o Dictionary com os dados do banco de dados

                conexaoDb.Close();
                return dados;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Dictionary<int, string> PopularCaixaEmpregador()
        {
            string caminho = _servidores.servidorNotebook;
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
    }
}
