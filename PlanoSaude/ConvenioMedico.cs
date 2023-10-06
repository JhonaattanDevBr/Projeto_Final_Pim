using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexaoBaseDados;

namespace PlanoSaude
{
    public class ConvenioMedico
    {
        public string NomeConvMedico { get; set; }
        public string CnpjConvMedico { get; set; }
        public string ValorConvMedico { get; set; }
        public string PorcentagemConvMedico { get; set; }
        public string MensagemErro { get; set; }

        Crud_PlanoSaude cnnPlanoSaude = new Crud_PlanoSaude();

        public bool AutenticarCadConvMedico()
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
                bool retornoCad = cnnPlanoSaude.CadastrarConvMedico(NomeConvMedico, CnpjConvMedico, ValorConvMedico, PorcentagemConvMedico);
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
            if (NomeConvMedico.ToLower() == NomeConvMedico)
            {
                return true;
            }
            else { return false; }
        }

        private bool TesteApenasLetras()
        {
            if (NomeConvMedico.Any(char.IsLetter))
            {
                return true;
            }
            else { return false; }
        }

        private bool TesteEspacosEmBranco()
        {
            string texto1 = CnpjConvMedico.Replace(" ", ""),
                   texto2 = ValorConvMedico.Replace(" ", ""),
                   texto3 = PorcentagemConvMedico.Replace(" ", "");

            if (!(ValorConvMedico != texto2) &&
                !(PorcentagemConvMedico != texto3))
            {
                return true;
            }
            else { return false; }
        }

        private bool TesteCamposVaziosCnpjCaracteres()
        {
            if(!string.IsNullOrEmpty(NomeConvMedico) &&
               !string.IsNullOrEmpty(CnpjConvMedico) &&
               !string.IsNullOrEmpty(ValorConvMedico) &&
               !string.IsNullOrEmpty(PorcentagemConvMedico))
            {
                string valorDeTeste = CnpjConvMedico;
                valorDeTeste = valorDeTeste.Replace(".", "").Replace("/", "").Replace("-", "");
               
                double alterar = double.Parse(ValorConvMedico);

                if (valorDeTeste.Length == 14)
                {
                    if (valorDeTeste.All(char.IsDigit) && PorcentagemConvMedico.All(char.IsDigit))
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
