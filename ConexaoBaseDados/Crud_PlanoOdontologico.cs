using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBaseDados
{
    public class Crud_PlanoOdontologico
    {
        public bool CadastrarConvOdontologico(string nome, string cnpj, string valor, string porcentagem)
        {
            string caminho = @"Data Source=DESKTOP-AF6EDUF\SQLEXPRESSS;Initial Catalog=Base_Dados_Personal_Teste;Integrated Security=True";
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string query = "INSERT INTO Planos_odontologicos (Nome, Cnpj, Valor, Porcentagem) VALUES (@nome, @cnpj, @valor, @porcentagem)";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = nome;
                cmd.Parameters.Add(pmtNome);

                var pmtCnpj = cmd.CreateParameter();
                pmtCnpj.ParameterName = "@cnpj";
                pmtCnpj.DbType = DbType.String;
                pmtCnpj.Value = cnpj;
                cmd.Parameters.Add(pmtCnpj);

                var pmtValor = cmd.CreateParameter();
                pmtValor.ParameterName = "@valor";
                pmtValor.DbType = DbType.Double;
                pmtValor.Value = valor;
                cmd.Parameters.Add(pmtValor);

                var pmtPorcentagem = cmd.CreateParameter();
                pmtPorcentagem.ParameterName = "@porcentagem";
                pmtPorcentagem.DbType = DbType.Int32;
                pmtPorcentagem.Value = porcentagem;
                cmd.Parameters.Add(pmtPorcentagem);

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
