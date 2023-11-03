using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncionariosEmpresas;
using System.Globalization;
using EmpresasClientes;

namespace BaseDeDados
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
            else if (_funcionario.ConvenioMedico == "0" && _funcionario.ConvenioOdontologico == "0")
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
                cmd.Parameters.Add(_pmtNome);

                var _pmtSobrenome = cmd.CreateParameter();
                _pmtSobrenome.ParameterName = "@sobrenome";
                _pmtSobrenome.DbType = DbType.String;
                _pmtSobrenome.Value = _funcionario.Sobrenome;
                cmd.Parameters.Add(_pmtSobrenome);

                var _pmtIdade = cmd.CreateParameter();
                _pmtIdade.ParameterName = "@idade";
                _pmtIdade.DbType = DbType.Int32;
                _pmtIdade.Value = _funcionario.Idade;
                cmd.Parameters.Add(_pmtIdade);

                var _pmtSexo = cmd.CreateParameter();
                _pmtSexo.ParameterName = "@sexo";
                _pmtSexo.SqlDbType = SqlDbType.Char;
                _pmtSexo.Value = _funcionario.Sexo;
                cmd.Parameters.Add(_pmtSexo);

                var _pmtRegistro = cmd.CreateParameter();
                _pmtRegistro.ParameterName = "@registro";
                _pmtRegistro.DbType = DbType.Int32;
                _pmtRegistro.Value = _funcionario.NumeroRegistro;
                cmd.Parameters.Add(_pmtRegistro);

                var _pmtCargaHoraria = cmd.CreateParameter();
                _pmtCargaHoraria.ParameterName = "@carga_horaria";
                _pmtCargaHoraria.DbType = DbType.Int32;
                _pmtCargaHoraria.Value = _funcionario.CargaHoraria;
                cmd.Parameters.Add(_pmtCargaHoraria);

                var _pmtCpf = cmd.CreateParameter();
                _pmtCpf.ParameterName = "@cpf";
                _pmtCpf.DbType = DbType.String;
                _pmtCpf.Value = _funcionario.Cpf;
                cmd.Parameters.Add(_pmtCpf);

                var _pmtRg = cmd.CreateParameter();
                _pmtRg.ParameterName = "@rg";
                _pmtRg.DbType = DbType.String;
                _pmtRg.Value = _funcionario.Rg;
                cmd.Parameters.Add(_pmtRg);

                var _pmtEmail = cmd.CreateParameter();
                _pmtEmail.ParameterName = "@email";
                _pmtEmail.DbType = DbType.String;
                _pmtEmail.Value = _funcionario.Email;
                cmd.Parameters.Add(_pmtEmail);

                var _pmtEmailSecundario = cmd.CreateParameter();
                _pmtEmailSecundario.ParameterName = "@email_secundario";
                _pmtEmailSecundario.DbType = DbType.String;
                _pmtEmailSecundario.Value = _funcionario.EmailSecundario;
                cmd.Parameters.Add(_pmtEmailSecundario);

                var _pmtTelefone = cmd.CreateParameter();
                _pmtTelefone.ParameterName = "@telefone";
                _pmtTelefone.DbType = DbType.String;
                _pmtTelefone.Value = _funcionario.Telefone;
                cmd.Parameters.Add(_pmtTelefone);

                var _pmtCellPrincipal = cmd.CreateParameter();
                _pmtCellPrincipal.ParameterName = "@cell_principal";
                _pmtCellPrincipal.DbType = DbType.String;
                _pmtCellPrincipal.Value = _funcionario.CelularPrincipal;
                cmd.Parameters.Add(_pmtCellPrincipal);

                var _pmtCellSecundario = cmd.CreateParameter();
                _pmtCellSecundario.ParameterName = "@cell_secundario";
                _pmtCellSecundario.DbType = DbType.String;
                _pmtCellSecundario.Value = _funcionario.CelularSecundario;
                cmd.Parameters.Add(_pmtCellSecundario);

                var _pmtNumDependentes = cmd.CreateParameter();
                _pmtNumDependentes.ParameterName = "@num_dependentes";
                _pmtNumDependentes.DbType = DbType.Int32;
                _pmtNumDependentes.Value = _funcionario.Dependentes;
                cmd.Parameters.Add(_pmtNumDependentes);

                if (_funcionario.ConvenioMedico != "0")
                {
                    var _pmtIdPlanoSaude = cmd.CreateParameter();
                    _pmtIdPlanoSaude.ParameterName = "@id_planos_saude";
                    _pmtIdPlanoSaude.DbType = DbType.Int32;
                    _pmtIdPlanoSaude.Value = _funcionario.ConvenioMedico;
                    cmd.Parameters.Add(_pmtIdPlanoSaude);
                }

                if (_funcionario.ConvenioOdontologico != "0")
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
                cmd.Parameters.Add(_pmtIdEmpresa);

                var _pmtCargo = cmd.CreateParameter();
                _pmtCargo.ParameterName = "@cargo";
                _pmtCargo.DbType = DbType.String;
                _pmtCargo.Value = _funcionario.Cargo;
                cmd.Parameters.Add(_pmtCargo);

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

        public bool AtualizarEnderecoFuncionario(Funcionarios _funcionario)
        {
            string caminho = _servidores.servidorNotebook;
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
                _pmtCidade.Value = _funcionario.Cidade;
                cmd.Parameters.Add(_pmtCidade);

                var _pmtEstado = cmd.CreateParameter();
                _pmtEstado.ParameterName = "@estado";
                _pmtEstado.DbType = DbType.String;
                _pmtEstado.Value = _funcionario.Estado;
                cmd.Parameters.Add(_pmtEstado);

                var _pmtBairro = cmd.CreateParameter();
                _pmtBairro.ParameterName = "@bairro";
                _pmtBairro.DbType = DbType.String;
                _pmtBairro.Value = _funcionario.Bairro;
                cmd.Parameters.Add(_pmtBairro);

                var _pmtRua = cmd.CreateParameter();
                _pmtRua.ParameterName = "@rua";
                _pmtRua.DbType = DbType.String;
                _pmtRua.Value = _funcionario.Rua;
                cmd.Parameters.Add(_pmtRua);

                var _pmtNumero = cmd.CreateParameter();
                _pmtNumero.ParameterName = "@numero";
                _pmtNumero.DbType = DbType.Int32;
                _pmtNumero.Value = _funcionario.Numero;
                cmd.Parameters.Add(_pmtNumero);

                var _pmtIdEndereco = cmd.CreateParameter();
                _pmtIdEndereco.ParameterName = "@idEndereco";
                _pmtIdEndereco.DbType = DbType.Int32;
                _pmtIdEndereco.Value = _funcionario.IdEndereco;
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
        
        public bool AtualizarRegistroFuncionario(Funcionarios _funcionario)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "UPDATE Funcionarios SET " +
                               "Nome = @nome, Sobrenome = @sobrenome, Idade = @idade, Sexo = @sexo, " +
                               "Registro = @registro, Carga_horaria = @cargaHoraria, " +
                               "Cpf = @cpf, Rg = @rg, Email = @email, Email_secundario = @emailSecundario, Telefone = @telefone, " +
                               "Cell_principal = @celularPrincipal, Cell_secundario = @celularSecundario, Num_dependentes = @numeroDependentes, " +
                               "Id_planos_saude = @idConvMedico, Id_planos_odontologicos = @idConvOdonto, Id_empresas = @idEmpresa, Cargo = @cargo, " +
                               "Salario = @salario, Data_admissao = @datAdmissao " +
                               "WHERE Id_funcionario = @id";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var _pmtNome = cmd.CreateParameter();
                _pmtNome.ParameterName = "@nome";
                _pmtNome.DbType = DbType.String;
                _pmtNome.Value = _funcionario.Nome;
                cmd.Parameters.Add(_pmtNome);

                var _pmtSobrenome = cmd.CreateParameter();
                _pmtSobrenome.ParameterName = "@sobrenome";
                _pmtSobrenome.DbType = DbType.String;
                _pmtSobrenome.Value = _funcionario.Sobrenome;
                cmd.Parameters.Add(_pmtSobrenome);

                var _pmtIdade = cmd.CreateParameter();
                _pmtIdade.ParameterName = "@idade";
                _pmtIdade.DbType = DbType.Int32;
                _pmtIdade.Value = _funcionario.Idade;
                cmd.Parameters.Add(_pmtIdade);

                var _pmtSexo = cmd.CreateParameter();
                _pmtSexo.ParameterName = "@sexo";
                _pmtSexo.SqlDbType = SqlDbType.Char;
                _pmtSexo.Value = _funcionario.Sexo;
                cmd.Parameters.Add(_pmtSexo);

                var _pmtIdEndereco = cmd.CreateParameter();
                _pmtIdEndereco.ParameterName = "@idEndereco";
                _pmtIdEndereco.DbType = DbType.Int32;
                _pmtIdEndereco.Value = _funcionario.IdEndereco;
                cmd.Parameters.Add(_pmtIdEndereco);

                var _pmtRegistro = cmd.CreateParameter();
                _pmtRegistro.ParameterName = "@registro";
                _pmtRegistro.DbType = DbType.Int32;
                _pmtRegistro.Value = _funcionario.NumeroRegistro;
                cmd.Parameters.Add(_pmtRegistro);

                var _pmtCargaHoraria = cmd.CreateParameter();
                _pmtCargaHoraria.ParameterName = "@cargaHoraria";
                _pmtCargaHoraria.DbType = DbType.Int32;
                _pmtCargaHoraria.Value = _funcionario.CargaHoraria;
                cmd.Parameters.Add(_pmtCargaHoraria);

                var _pmtCpf = cmd.CreateParameter();
                _pmtCpf.ParameterName = "@cpf";
                _pmtCpf.DbType = DbType.String;
                _pmtCpf.Value = _funcionario.Cpf;
                cmd.Parameters.Add(_pmtCpf);

                var _pmtRg = cmd.CreateParameter();
                _pmtRg.ParameterName = "@rg";
                _pmtRg.DbType = DbType.String;
                _pmtRg.Value = _funcionario.Rg;
                cmd.Parameters.Add(_pmtRg);

                var _pmtEmail = cmd.CreateParameter();
                _pmtEmail.ParameterName = "@email";
                _pmtEmail.DbType = DbType.String;
                _pmtEmail.Value = _funcionario.Email;
                cmd.Parameters.Add(_pmtEmail);

                var _pmtEmailSecundario = cmd.CreateParameter();
                _pmtEmailSecundario.ParameterName = "@emailSecundario";
                _pmtEmailSecundario.DbType = DbType.String;
                _pmtEmailSecundario.Value = _funcionario.EmailSecundario;
                cmd.Parameters.Add( _pmtEmailSecundario);

                var _telefone = cmd.CreateParameter();
                _telefone.ParameterName = "@telefone";
                _telefone.DbType = DbType.String;
                _telefone.Value = _funcionario.Telefone;
                cmd.Parameters.Add(_telefone);

                var _pmtCellPrincipal = cmd.CreateParameter();
                _pmtCellPrincipal.ParameterName = "@celularPrincipal";
                _pmtCellPrincipal.DbType = DbType.String;
                _pmtCellPrincipal.Value = _funcionario.CelularPrincipal;
                cmd.Parameters.Add(_pmtCellPrincipal);

                var _pmtCellSecundario = cmd.CreateParameter();
                _pmtCellSecundario.ParameterName = "@celularSecundario";
                _pmtCellSecundario.DbType = DbType.String;
                _pmtCellSecundario.Value = _funcionario.CelularSecundario;
                cmd.Parameters.Add( _pmtCellSecundario);

                var _pmtDependentes = cmd.CreateParameter();
                _pmtDependentes.ParameterName = "@numeroDependentes";
                _pmtDependentes.DbType = DbType.Int32;
                _pmtDependentes.Value = _funcionario.Dependentes;
                cmd.Parameters.Add(_pmtDependentes);

                var _pmtConvMedico = cmd.CreateParameter();
                _pmtConvMedico.ParameterName = "@idConvMedico";
                _pmtConvMedico.DbType = DbType.Int32;
                _pmtConvMedico.Value = _funcionario.ConvenioMedico;
                cmd.Parameters.Add(_pmtConvMedico);

                var _pmtConvOdonto = cmd.CreateParameter();
                _pmtConvOdonto.ParameterName = "@idConvOdonto";
                _pmtConvOdonto.DbType = DbType.Int32;
                _pmtConvOdonto.Value = _funcionario.ConvenioOdontologico;
                cmd.Parameters.Add(_pmtConvOdonto);

                var _pmtEmpregador = cmd.CreateParameter();
                _pmtEmpregador.ParameterName = "@idEmpresa";
                _pmtEmpregador.DbType = DbType.Int32;
                _pmtEmpregador.Value = _funcionario.Empregador;
                cmd.Parameters.Add( _pmtEmpregador );

                var _pmtCargo = cmd.CreateParameter();
                _pmtCargo.ParameterName = "@cargo";
                _pmtCargo.DbType = DbType.String;
                _pmtCargo.Value = _funcionario.Cargo;
                cmd.Parameters.Add(_pmtCargo );

                var _pmtSalario = cmd.CreateParameter();
                _pmtSalario.ParameterName = "@salario";
                _pmtSalario.DbType = DbType.Double;
                _pmtSalario.Value = _funcionario.Salario;
                cmd.Parameters.Add(_pmtSalario);

                var _pmtDatAdmissao = cmd.CreateParameter();
                _pmtDatAdmissao.ParameterName = "@datAdmissao";
                _pmtDatAdmissao.DbType = DbType.Date;
                _pmtDatAdmissao.Value = _funcionario.DataAdmisao;
                cmd.Parameters.Add(_pmtDatAdmissao);

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@id";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = _funcionario.Id;
                cmd.Parameters.Add(_pmtId );

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

        public bool ExcluirFuncionario(string id)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "DELETE FROM Funcionarios WHERE Id_funcionario = @id";
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

        public DataTable BuscarFuncionarios(string codEmpresa)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string querry = "SELECT Id_funcionario, Funcionarios.Nome, Sobrenome, Idade, Sexo, " +
                                "Funcionarios.Id_endereco, Cidade, Estado, Bairro, Rua, Numero, " +
                                "Registro, Carga_horaria, Cpf, Rg, Funcionarios.Email, Email_secundario, " +
                                "Funcionarios.Telefone, Cell_principal, Cell_secundario, Num_dependentes, " +
                                "Id_planos_saude, Planos_saude.Nome, " +
                                "Id_planos_odontologicos, Planos_odontologicos.Nome, " +
                                "Id_empresas, Empresas.Razao_social, Cargo, Salario, Data_admissao FROM Funcionarios " +
                                "WHERE Id_empresa = @idEmpresa " + // ja declarei mas ainda não esta funcionando, esta dandi erro de declaração da variavel idEmpresa.
                                "INNER JOIN Endereco ON Funcionarios.Id_endereco = Endereco.Id_endereco " +
                                "LEFT JOIN Planos_saude ON Funcionarios.Id_planos_saude = Planos_saude.Id_saude " +
                                "LEFT JOIN Planos_odontologicos ON Funcionarios.Id_planos_odontologicos = Planos_odontologicos.Id_odonto " +
                                "INNER JOIN Empresas ON Funcionarios.Id_empresas = Empresas.Id_empresa";



                SqlCommand cmd = new SqlCommand(querry, conexaoDb);
                SqlDataReader _leitor = cmd.ExecuteReader();

                var _pmtCodEmpresa = cmd.CreateParameter();
                _pmtCodEmpresa.ParameterName = "@idEmpresa";
                _pmtCodEmpresa.DbType = DbType.Int32;
                _pmtCodEmpresa.Value = codEmpresa;
                cmd.Parameters.Add(_pmtCodEmpresa);

                DataTable dt = new DataTable();
                dt.Columns.Add("Código", typeof(int));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Sobrenome", typeof(string));
                dt.Columns.Add("Idade", typeof(int));
                dt.Columns.Add("Sexo", typeof(string));
                dt.Columns.Add("Cód. Endereco", typeof(int)); // Vou tentar jogar esse código na cidade ↓
                dt.Columns.Add("Cidade", typeof(string));
                dt.Columns.Add("Estado", typeof(string));
                dt.Columns.Add("Bairro", typeof(string));
                dt.Columns.Add("Rua", typeof(string));
                dt.Columns.Add("Numero", typeof(int));
                dt.Columns.Add("Registro", typeof(int));
                dt.Columns.Add("Carga H.", typeof(int));
                dt.Columns.Add("CPF", typeof(string));
                dt.Columns.Add("RG", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Email Secundario", typeof(string));
                dt.Columns.Add("Telefone", typeof(string));
                dt.Columns.Add("Cell Princ.", typeof(string));
                dt.Columns.Add("Cell Secun.", typeof(string));
                dt.Columns.Add("Dependentes", typeof(int));
                dt.Columns.Add("Cód. ConMed.", typeof(string));  // Vou tentar jogar esse código no nome do conv medico ↓
                dt.Columns.Add("Convênio Médico", typeof(string));
                dt.Columns.Add("Cód ConOdon.", typeof(string)); // Vou tentar jogar esse código no nome do conv odonto ↓
                dt.Columns.Add("Convênio Odonto", typeof(string));
                dt.Columns.Add("Cód. Empresa", typeof(int)); // Vou tentar jogar esse código no empregador ↓
                dt.Columns.Add("Empregador", typeof(string));
                dt.Columns.Add("Cargo", typeof(string));
                dt.Columns.Add("Salário", typeof(decimal));
                dt.Columns.Add("Data Admissão", typeof(DateTime));

                

                string idConvMedico = "0";
                string convMedico = "NULL";
                string idConvOdonto = "0";
                string convOdonto = "NULL";
                while (_leitor.Read())
                {
                    int id = _leitor.GetInt32(0);
                    string nome = _leitor.GetString(1);
                    string sobrenome = _leitor.GetString(2);
                    int idade = _leitor.GetInt32(3);
                    string sexo = _leitor.GetString(4);
                    int codEndereco = _leitor.GetInt32(5);
                    string cidade = _leitor.GetString(6);
                    string estado = _leitor.GetString(7);
                    string bairro = _leitor.GetString(8);
                    string rua = _leitor.GetString(9);
                    int numero = _leitor.GetInt32(10);
                    int registro = _leitor.GetInt32(11);
                    int cargaHoraria = _leitor.GetInt32(12);
                    string cpf = _leitor.GetString(13);
                    string rg = _leitor.GetString(14);
                    string email = _leitor.GetString(15);
                    string emailSecundario = _leitor.GetString(16);
                    string telefone = _leitor.GetString(17);
                    string cellPrinc = _leitor.GetString(18);
                    string cellSecun = _leitor.GetString(19);
                    int dependentes = _leitor.GetInt32(20);

                    if (_leitor.IsDBNull(21))
                    {
                        idConvMedico = "0";
                        convMedico = "NULL";
                    }
                    else
                    {
                        idConvMedico = _leitor.GetInt32(21).ToString();
                        convMedico = _leitor.GetString(22);
                    }
                    if(_leitor.IsDBNull(23)) // O metodo IsDBNull é um metodo que testa quando um dado vem do banco de dados e sua coluna é nula
                    {
                        idConvOdonto = "0";
                        convOdonto = "NULL";
                    }
                    else
                    {
                        idConvOdonto = _leitor.GetInt32(23).ToString();
                        convOdonto = _leitor.GetString(24);
                    }
                    
                    int idEmpresa = _leitor.GetInt32(25);
                    string empregador = _leitor.GetString(26);
                    string cargo = _leitor.GetString(27);
                    double salario = _leitor.GetDouble(28);
                    DateTime dataAdmissao = _leitor.GetDateTime(29);


                    dt.Rows.Add(id, nome, sobrenome, idade, sexo, codEndereco, cidade, estado, bairro, rua, numero, registro, cargaHoraria, cpf, rg, email, emailSecundario,
                                telefone, cellPrinc, cellSecun, dependentes, idConvMedico, convMedico, idConvOdonto, convOdonto, idEmpresa, empregador, cargo, salario, dataAdmissao);
                }
                conexaoDb.Close();
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Funcionarios> BuscarInfoFuncionario(Funcionarios _funcionario)
        {
            string caminho = _servidores.servidorNotebook;
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();
                string query = "SELECT Nome, Sobrenome, Idade, Sexo, Registro, Carga_horaria, Cpf, Rg, Email, Email_secundario, " +
                               "Telefone, Cell_principal, Cell_secundario, Num_dependentes, Cargo, Salario, Data_admissao, " +
                               "Cidade, Estado, Bairro, Rua, Numero from Funcionarios " +
                               "JOIN Endereco On Funcionarios.Id_endereco = Endereco.Id_endereco " +
                               "WHERE Id_funcionario = @id";

                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                List<Funcionarios> _registro = new List<Funcionarios>();

                var _pmtId = cmd.CreateParameter();
                _pmtId.ParameterName = "@id";
                _pmtId.DbType = DbType.Int32;
                _pmtId.Value = _funcionario.Id;
                cmd.Parameters.Add(_pmtId);

                SqlDataReader _leitor = cmd.ExecuteReader();

                while (_leitor.Read())
                {
                    _funcionario.Nome = _leitor.GetString(0);
                    _funcionario.Sobrenome = _leitor.GetString(1);
                    _funcionario.Idade = _leitor.GetInt32(2).ToString();
                    _funcionario.Sexo = _leitor.GetString(3);
                    _funcionario.NumeroRegistro = _leitor.GetInt32(4).ToString();
                    _funcionario.CargaHoraria = _leitor.GetInt32(5).ToString();
                    _funcionario.Cpf = _leitor.GetString(6);
                    _funcionario.Rg = _leitor.GetString(7);
                    _funcionario.Email = _leitor.GetString(8);
                    _funcionario.EmailSecundario = _leitor.GetString(9);
                    _funcionario.Telefone = _leitor.GetString(10);
                    _funcionario.CelularPrincipal = _leitor.GetString(11);
                    _funcionario.CelularSecundario = _leitor.GetString(12);
                    _funcionario.Dependentes = _leitor.GetInt32(13).ToString();
                    _funcionario.Cargo = _leitor.GetString(14);
                    _funcionario.Salario = _leitor.GetDouble(15).ToString();
                    _funcionario.DataAdmisao = _leitor.GetDateTime(16).ToString();
                    _funcionario.Cidade = _leitor.GetString(17);
                    _funcionario.Estado = _leitor.GetString(18);
                    _funcionario.Bairro = _leitor.GetString(19);
                    _funcionario.Rua = _leitor.GetString(20);
                    _funcionario.Numero = _leitor.GetInt32(21).ToString();
                    _registro.Add(_funcionario);
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

        public Dictionary<int, string> PopularCaixaListarEmpresas()
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
