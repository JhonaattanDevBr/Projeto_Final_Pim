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
        
        public bool AutenticarCadConvOdontologico()
        {
            bool auten1, auten2, auten3, auten4, auten5, auten6;

            auten1 = AutenticarCamposVazios();
            auten2 = AutenticarCnpj();
            auten3 = AutenticarEspacosEmBranco();
            auten4 = AutenticarApenasLetras();
            auten5 = AutenticarApenasNumeros();
            auten6 = AutenticarCaixaBaixa();

            if (auten1 == false)
            {
                if (auten2 == false)
                {
                    if (auten3 == false)
                    {
                        if (auten4 == false)
                        {
                            if (auten5 == false)
                            {
                                if (auten6 == false)
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
            if (!string.IsNullOrEmpty(NomeConvOdonto) &&
               !string.IsNullOrEmpty(CnpjConvOdonto) &&
               !string.IsNullOrEmpty(ValorConvOdonto) &&
               !string.IsNullOrEmpty(PorcentagemConvOdonto))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarCnpj()
        {
            string autenticacaoCnpj = CnpjConvOdonto;
            autenticacaoCnpj = autenticacaoCnpj.Replace(".", "").Replace("/", "").Replace("-", "");

            if (autenticacaoCnpj.Length == 14)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarEspacosEmBranco()
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

        private bool AutenticarApenasLetras()
        {
            if (NomeConvOdonto.Any(char.IsLetter))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarApenasNumeros()
        {
            string valorDeTeste = CnpjConvOdonto;
            valorDeTeste = valorDeTeste.Replace(".", "").Replace("/", "").Replace("-", "");

            if (valorDeTeste.All(char.IsDigit) && ValorConvOdonto.All(char.IsDigit) && PorcentagemConvOdonto.All(char.IsDigit))
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
            if (NomeConvOdonto.ToLower() == NomeConvOdonto)
            {
                return true;
            }
            else { return false; }
        }

    }
}
