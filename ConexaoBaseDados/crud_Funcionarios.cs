using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBaseDados
{
    public class crud_Funcionarios
    {

        public Dictionary<int, string> PopularCaixaConvenioMedico()
        {
            string caminho = @"Data Source=DESKTOP-AF6EDUF\SQLEXPRESSS;Initial Catalog=Base_Dados_Personal_Teste;Integrated Security=True";
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string query = "SELECT Id_saude, Nome FROM Planos_saude ORDER BY Id_saude";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                SqlDataReader leitura = cmd.ExecuteReader();

                // Criando um Dictionary para armazenar os dados do banco de dados
                Dictionary<int, string> dados = new Dictionary<int, string>();

                while (leitura.Read())
                {
                    int idSaude = leitura.GetInt32(0);  // Lendo o Id_saude (assume-se que é int)
                    string nome = leitura.GetString(1); // Lendo o Nome

                    // Adicionando os dados ao Dictionary
                    dados[idSaude] = nome;
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

        public Dictionary<int, string> PopularCaixaConvenioOdontologico()
        {
            string caminho = @"Data Source=DESKTOP-AF6EDUF\SQLEXPRESSS;Initial Catalog=Base_Dados_Personal_Teste;Integrated Security=True";
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
    
    }
}
