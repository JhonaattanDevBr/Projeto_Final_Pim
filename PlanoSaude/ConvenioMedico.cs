using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PlanoSaude
{
    public class ConvenioMedico
    {
        public string NomeConvMedico { get; set; }
        public string CnpjConvMedico { get; set; }
        public string ValorConvMedico { get; set; }
        public string PorcentagemConvMedico { get; set; }
        public string MensagemErro { get; set; }

        public bool AutenticarCadConvMedico()
        {
            bool auten1, auten2, auten3, auten4, auten5, auten6;

            auten1 = AutenticarCamposVazios();
            auten2 = AutenticarCnpj();
            auten3 = AutenticarEspacosEmBranco();
            auten4 = AutenticarApenasLetras();
            auten5 = AutenticarApenasNumeros();
            auten6 = AutenticarCaixaBaixa();

            if (auten1 == true)
            {
                if (auten2 == true)
                {
                    if (auten3 == true)
                    {
                        if (auten4 == true)
                        {
                            if(auten5 == true)
                            {
                                if(auten6 == true)
                                {
                                    return true;
                                }
                                else
                                {
                                    MensagemErro = "Os campos não podem conter letras em caixa alta.";
                                    return false;
                                }
                            }
                            else
                            {
                                MensagemErro = "Os campos CNPJ, VALOR e DESCONTO não podem conter letras ou caracteres.";
                                return false;
                            }
                        }
                        else
                        {
                            MensagemErro = "O campo NOME não pode conter números ou caracteres especiais.";
                            return false;
                        }
                    }
                    else
                    {
                        MensagemErro = "Os campos CNPJ, VALOR e DESCONTO não podem conter espaços em branco.";
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

        private bool AutenticarCamposVazios()
        {
            if (!string.IsNullOrEmpty(NomeConvMedico) &&
               !string.IsNullOrEmpty(CnpjConvMedico) &&
               !string.IsNullOrEmpty(ValorConvMedico) &&
               !string.IsNullOrEmpty(PorcentagemConvMedico))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarCnpj()
        {
            string autenticacaoCnpj = CnpjConvMedico;
            autenticacaoCnpj = autenticacaoCnpj.Replace(".", "").Replace("/", "").Replace("-", "");

            if (autenticacaoCnpj.Length == 14)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarEspacosEmBranco()
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

        private bool AutenticarApenasLetras()
        {
            if (NomeConvMedico.Any(char.IsLetter))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarApenasNumeros()
        {
            string valorDeTeste = CnpjConvMedico;
            valorDeTeste = valorDeTeste.Replace(".", "").Replace("/", "").Replace("-", "");

            if (valorDeTeste.All(char.IsDigit) && ValorConvMedico.All(char.IsDigit) && PorcentagemConvMedico.All(char.IsDigit)) // vou ter q permitir que usuario possa digitar . no valor
            {
                return true;
            }
            else
            {
                MensagemErro = "Os campos CNPJ, VALOR e DESCONTO não podem conter letras ou caracteres.";
                return false;
            }
        }

        private bool AutenticarCaixaBaixa()
        {
            if (NomeConvMedico.ToLower() == NomeConvMedico)
            {
                return true;
            }
            else { return false; }
        }
        
    }
}
