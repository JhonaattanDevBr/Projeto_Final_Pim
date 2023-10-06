using ConexaoBaseDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoOdontologico
{
    public class ConvenioOdontologico
    {
        public string NomeConvOdonto { get; set; }
        public string CnpjConvOdonto { get; set; }
        public string ValorConvOdonto { get; set; }
        public string PorcentagemConvOdonto { get; set; }
        public string MensagemErro { get; set; }
        
        Crud_PlanoOdontologico conPlanoOdonto = new Crud_PlanoOdontologico();

        public bool AutenticarCadConvOdontologico()
        {
            bool teste1, teste2, teste3, teste4;

            teste1 = TesteCaixaBaixa();
            teste2 = TesteApenasLetras();
            teste3 = TesteEspacosEmBranco();
            teste4 = TesteCamposVaziosCnpjCaracteres();

            if (teste1 == true &&
                teste1 == true &&
                teste2 == true &&
                teste3 == true &&
                teste4 == true)
            {
                bool retornoCad = conPlanoOdonto.CadastrarConvOdontologico(NomeConvOdonto, CnpjConvOdonto, ValorConvOdonto, PorcentagemConvOdonto);
                return true;
            }
            else
            {
                if (teste1 == false)
                {
                    MensagemErro = "Os campos não podem conter letras em caixa alta.";
                    return false;
                }
                else if (teste2 == false)
                {
                    MensagemErro = "O campo NOME não pode conter números ou caracteres especiais.";
                    return false;
                }
                else if (teste3 == false)
                {
                    MensagemErro = "Os campos CNPJ, VALOR e DESCONTO não podem conter espaços em branco.";
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool TesteCaixaBaixa()
        {
            if (NomeConvOdonto.ToLower() == NomeConvOdonto)
            {
                return true;
            }
            else { return false; }
        }

        private bool TesteApenasLetras()
        {
            if (NomeConvOdonto.Any(char.IsLetter))
            {
                return true;
            }
            else { return false; }
        }

        private bool TesteEspacosEmBranco()
        {
            string texto1 = CnpjConvOdonto.Replace(" ", ""),
                   texto2 = ValorConvOdonto.Replace(" ", ""),
                   texto3 = PorcentagemConvOdonto.Replace(" ", "");

            if (!(ValorConvOdonto != texto2) &&
                !(PorcentagemConvOdonto != texto3))
            {
                return true;
            }
            else { return false; }
        }

        private bool TesteCamposVaziosCnpjCaracteres()
        {
            if (!string.IsNullOrEmpty(NomeConvOdonto) &&
               !string.IsNullOrEmpty(CnpjConvOdonto) &&
               !string.IsNullOrEmpty(ValorConvOdonto) &&
               !string.IsNullOrEmpty(PorcentagemConvOdonto))
            {
                string valorDeTeste = CnpjConvOdonto;
                valorDeTeste = valorDeTeste.Replace(".", "").Replace("/", "").Replace("-", "");

                double alterar = double.Parse(ValorConvOdonto);

                if (valorDeTeste.Length == 14)
                {
                    if (valorDeTeste.All(char.IsDigit) && PorcentagemConvOdonto.All(char.IsDigit))
                    {
                        return true;
                    }
                    else
                    {
                        MensagemErro = "Os campos CNPJ, VALOR e DESCONTO não podem conter letras ou caracteres.";
                        return false;
                    }
                }
                else
                {
                    MensagemErro = "Informme todos os dígitos do CNPJ.";
                    return false;
                }
            }
            else
            {
                MensagemErro = "Todos os campos devem estar preenchidos.";
                return false;
            }
        }
    }
}
