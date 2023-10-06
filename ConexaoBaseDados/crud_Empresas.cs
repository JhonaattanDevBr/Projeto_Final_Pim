using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
