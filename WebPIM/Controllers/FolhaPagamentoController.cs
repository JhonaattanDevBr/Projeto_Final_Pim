using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebPIM.Models;
using BaseDeDados;

namespace WebPIM.Controllers
{
    public class FolhaPagamentoController : Controller
    {
        servidoresBancoDados _servidoresBancoDados = new servidoresBancoDados();

        public IActionResult FolhaPagamento()
        {
            List<FolhaPagModel> listaFolhaPag = listaFolhaPagamento();
            return View(listaFolhaPag);
        }
        public List<FolhaPagModel> listaFolhaPagamento()
        {
            //var conexaoSQL = @"Data Source=LAPTOP-TJ6127TR;Initial Catalog=Base_teste_dados_personal;Integrated Security=True";
            List<FolhaPagModel> lista = new List<FolhaPagModel>();

            //using (SqlConnection conexaoDB = new SqlConnection(conexaoSQL))
            using (SqlConnection conexaoDB = new SqlConnection(_servidoresBancoDados.servidor))
            {
                conexaoDB.Open();

                string query = @"
                    SELECT Folha_pagamento.*, 
                    Funcionarios.Cargo AS cargo,Funcionarios.Registro AS registro, 
                    Funcionarios.Nome AS nome,
                    Empresas.Nome_fantasia AS nome_fantasia, Empresas.Cnpj AS cnpj, 
                    Decimo_terceiro_salario.Salario_base_decimo AS decimo_salario
                    FROM Folha_pagamento
                    INNER JOIN Funcionarios ON Folha_pagamento.Id_funcionarios = Funcionarios.Id_funcionario
                    INNER JOIN Empresas ON Folha_pagamento.Id_empresas = Empresas.Id_empresa
                    INNER JOIN Decimo_terceiro_salario ON Folha_pagamento.Id_Decimo_terceiro = Decimo_terceiro_salario.Id_decimo;";
                    

                using (SqlCommand command = new SqlCommand(query, conexaoDB))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FolhaPagModel folha = new FolhaPagModel();

                        folha.Salario_base = reader.GetFloat(1);
                        folha.VL_transporte = reader.GetFloat(2);
                        folha.VL_alimentacao = reader.GetFloat(3);
                        folha.Adiantamento = reader.GetFloat(4);
                        folha.Horas_extras = reader.GetFloat(5);
                        folha.Adicional_not = reader.GetFloat(6);
                        folha.Periculosidade = reader.GetFloat(7);
                        folha.Insalubridade = reader.GetFloat(8);
                        folha.Id_planos_saude = reader.GetInt32(9);
                        folha.Id_planos_odontologicos = reader.GetInt32(10);
                        folha.Dependentes = reader.GetFloat(11);
                        folha.Pensao = reader.GetFloat(12);
                        folha.Atrasos = reader.GetFloat(13);
                        folha.Faltas = reader.GetFloat(14);
                        folha.Inss = reader.GetFloat(15);
                        folha.Irrf = reader.GetFloat(16);
                        folha.Id_Decimo_terceiro = reader.GetInt32(17);
                        folha.Fgts = reader.GetFloat(18);
                        folha.Vencimentos = reader.GetFloat(19);
                        folha.Descontos = reader.GetFloat(20);
                        folha.Salario_liquido = reader.GetFloat(21);
                        folha.Id_funcionarios = reader.GetInt32(22);
                        folha.Id_empresas = reader.GetInt32(23);
                        folha.Nome_fantasia = reader.GetString(reader.GetOrdinal("nome_fantasia"));
                        folha.Cnpj = reader.GetString(reader.GetOrdinal("cnpj"));
                        folha.Cargo = reader.GetString(reader.GetOrdinal("cargo"));
                        folha.Nome = reader.GetString(reader.GetOrdinal("nome"));
                        folha.Registro = reader.GetInt32(reader.GetOrdinal("registro"));


                        lista.Add(folha);
                    }
                    return lista;
                }
            }
        }
    }
}


