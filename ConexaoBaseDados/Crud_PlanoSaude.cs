using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanoSaude;

namespace ConexaoBaseDados
{
    public class crud_PlanoSaude
    {
        servidoresBancoDados _servidores = new servidoresBancoDados();

        public bool CadastrarConvMedico(ConvenioMedico _convenioMedico)
        {
            string caminho = _servidores.servidorNotebook;
            
            SqlConnection conexaoDb = new SqlConnection(caminho);

            try
            {
                conexaoDb.Open();

                string query = "INSERT INTO Planos_saude (Nome, Cnpj, Valor, Porcentagem) VALUES (@nome, @cnpj, @valor, @porcentagem)";
                SqlCommand cmd = new SqlCommand(query, conexaoDb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _convenioMedico.NomeConvMedico;
                cmd.Parameters.Add(pmtNome);

                var pmtCnpj = cmd.CreateParameter();
                pmtCnpj.ParameterName = "@cnpj";
                pmtCnpj.DbType = DbType.String;
                pmtCnpj.Value = _convenioMedico.CnpjConvMedico;
                cmd.Parameters.Add(pmtCnpj);

                var pmtValor = cmd.CreateParameter();
                pmtValor.ParameterName = "@valor";
                pmtValor.DbType = DbType.Double;
                pmtValor.Value = _convenioMedico.ValorConvMedico;
                cmd.Parameters.Add(pmtValor);

                var pmtPorcentagem = cmd.CreateParameter();
                pmtPorcentagem.ParameterName = "@porcentagem";
                pmtPorcentagem.DbType = DbType.Int32;
                pmtPorcentagem.Value = _convenioMedico.PorcentagemConvMedico;
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
