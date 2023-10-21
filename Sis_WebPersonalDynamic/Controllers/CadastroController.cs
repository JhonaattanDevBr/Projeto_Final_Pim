using Microsoft.AspNetCore.Mvc;
using Sis_WebPersonalDynamic.Models;
using System.Data;
using System.Data.SqlClient;

namespace Sis_WebPersonalDynamic.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult NovoCadastro()
        {
            return View();
        }
        public IActionResult CadastrandoFuncionario(CadastroModel cadastro)
         {
             if (CadastraFuncionario(cadastro))
             {
                 TempData["MensagemSucesso"] = "Cadastro concluido com sucesso, acesse o sistema";
                 return RedirectToAction("Index", "Login");
             }
             return View("NovoCadastro");
         }
        protected bool CadastraFuncionario(CadastroModel cadastro)
        {
            string conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_Dados_Personal_Dynamic;Integrated Security=True";
            
            SqlConnection conexaoDB = new SqlConnection(conexaoSQL);
            try
            {
                conexaoDB.Open();

                string query = $"INSERT INTO Cadastro (Nome, Sobrenome, Idade, Email,Email_secundario,Senha, Confirmacao_senha, Empregador, Cargo) " +
                    "VALUES (@nome,@sobrenome, @idade, @email, @email_secundario, @senha, @confirmacao_senha, @empregador, @cargo)"; 
                SqlCommand command = new SqlCommand(query, conexaoDB);

                //SqlDataReader reader = command.ExecuteReader();

                var parametroNome = command.CreateParameter();
                parametroNome.ParameterName = "@nome";
                parametroNome.DbType = DbType.String;
                parametroNome.Value = cadastro.Nome;
                command.Parameters.Add(parametroNome);

                var parametroSobrenome = command.CreateParameter();
                parametroSobrenome.ParameterName = "@sobrenome";
                parametroSobrenome.DbType = DbType.String;
                parametroSobrenome.Value = cadastro.Sobrenome;
                command.Parameters.Add(parametroSobrenome);

                var parametroIdade = command.CreateParameter();
                parametroIdade.ParameterName = "@idade";
                parametroIdade.DbType = DbType.Int16;
                parametroIdade.Value = cadastro.Idade;
                command.Parameters.Add(parametroIdade);

                var parametroEmail = command.CreateParameter();
                parametroEmail.ParameterName = "@email";
                parametroEmail.DbType = DbType.String;
                parametroEmail.Value = cadastro.Email;
                command.Parameters.Add(parametroEmail);

                var parametroEmail_secundario = command.CreateParameter();
                parametroEmail_secundario.ParameterName = "@email_secundario";
                parametroEmail_secundario.DbType = DbType.String;
                parametroEmail_secundario.Value = cadastro.Email_Secundario;
                command.Parameters.Add(parametroEmail_secundario);

                var parametroSenha = command.CreateParameter();
                parametroSenha.ParameterName = "@senha";
                parametroSenha.DbType = DbType.String;
                parametroSenha.Value = cadastro.Senha;
                command.Parameters.Add(parametroSenha);

                var parametroconfirmacao_Senha = command.CreateParameter();
                parametroconfirmacao_Senha.ParameterName = "@confirmacao_senha";
                parametroconfirmacao_Senha.DbType = DbType.String;
                parametroconfirmacao_Senha.Value = cadastro.Confirmacao_senha;
                command.Parameters.Add(parametroconfirmacao_Senha);

                var parametroEmpregador = command.CreateParameter();
                parametroEmpregador.ParameterName = "@empregador";
                parametroEmpregador.DbType = DbType.String;
                parametroEmpregador.Value = cadastro.Empregador;
                command.Parameters.Add(parametroEmpregador);

                var parametroCargo = command.CreateParameter();
                parametroCargo.ParameterName = "@cargo";
                parametroCargo.DbType = DbType.String;
                parametroCargo.Value = cadastro.Cargo;
                command.Parameters.Add(parametroCargo);

                if (command.ExecuteNonQuery()>0)
                {
                    conexaoDB.Close();
                    return false;

                }
                else
                {
                    conexaoDB.Close();
                    return true;
                }
            }
            catch(Exception)
            {
                conexaoDB.Close();
                throw;
            }
        }
    }
}
