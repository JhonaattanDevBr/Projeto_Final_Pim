using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresasClientes;

namespace ConexaoBaseDados
{
    public class crud_Empresas
    {
        public bool CadastrarEmpresa(string razaoSocia, string nomeFantasia, string nascionalidade, string cnpj, string email, string telefone, string ceo, string fundacao,
            string segmento, string cidade, string estado, string bairro, string rua, string numero)
        {
            string caminho = @"Data Source=DESKTOP-AF6EDUF\SQLEXPRESSS;Initial Catalog=Base_Dados_Personal_Teste;Integrated Security=True";
            SqlConnection conexaoDb = new SqlConnection(caminho);

            // Amanha vou incluir o codigo do crud
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }



        public bool incluirEmpresa (Empresas _empresa)
        {
            string caminho = @"Data Source=DESKTOP-AF6EDUF\SQLEXPRESSS;Initial Catalog=Base_Dados_Personal_Teste;Integrated Security=True";
            SqlConnection conexaoDb = new SqlConnection(caminho);

            // Amanha vou incluir o codigo do crud
            try
            {
                conexaoDb.Open();

                string querry = "INSERT INTO EMPRESAS (Razao_social, Nome_fantasia, Nacionalidade, Cnpj, Email, Telefone, Ceo, Fundacao, Segmento)" +
                    "VALUES (@razao_social, @nome_Fantasia, @nacionalidade, @cnpj, @email, @telefone, @ceo, @fundacao, @segmento)";
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
                pmtCnpj.ParameterName = "cnpj";
                pmtCnpj.DbType = DbType.String;

            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
    }
}
