using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmpresasClientes
{
    public class Empresas
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Nascionalidade { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Dominio { get; set; }
        public string Telefone { get; set; }
        public string Ceo { get; set; }
        public string Fundacao { get; set; }
        public string Segmento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string MensagemErro { get; set; }

        public bool AutenticarCadastroEmpresas()
        {
            bool auten1, auten2, auten3, auten4, auten5, auten6, auten7;

            auten1 = AutentificarCaixaVazia();
            auten2 = AutenticarCnpj();
            auten3 = AutenticarTelefone();
            auten4 = AtenticarApenasLetras();
            auten5 = AutenticarLetraEspacoEmBrancoNumeros();
            auten6 = AutenticarApenasNumeros();
            auten7 = AutenticarCaixaBaixa();

            if (auten1 == true)
            {
                if(auten2 == true)
                {
                    if (auten3 == true)
                    {
                        if (auten4 == true)
                        {
                            if(auten5 == true)
                            {
                                if(auten6 == true)
                                {
                                    if(auten7 == true)
                                    {/* Vou comentar esse trexo para teste a forma de persistencia de dados da maneira que o professor passou se nao funcionar vou voltar para esse metodo
                                        Fundacao =  FormatarData();
                                        Email = MesclarEmailDominio();*/
                                        return true;
                                    }
                                    else
                                    {
                                        MensagemErro = "Todos os campos devem estar em caixa baixa.";
                                        return false;
                                    }
                                }
                                else
                                {
                                    MensagemErro = "O campo NUMERO não aceita valores que não sejam números.";
                                    return false;
                                }
                            } else
                            {
                                MensagemErro = "Os campos NOME FANTASIA, BAIRRO e RUA não aceitam caracteres especiais.";
                                return false;
                            }
                        } else
                        {
                            MensagemErro = "O campo NASCIONALIDADE, E-MAIL, CEO e SEGMENTO não podem conter números, caracters especiais e espaços em branco";
                            return false;
                        }
                    } else
                    {
                        MensagemErro = "O campo TEFELONE deve ser preenchido com todos os dígito do telefone incluindo DDD.";
                        return false;
                    }
                } else 
                {
                    MensagemErro = "O campo CNPJ deve ser preenchidos com todos os dígitos do CNPJ.";
                    return false; 
                }
            }
            else
            {
                MensagemErro = "Todos os campos devem ser preenchidos.";
                return false;
            }
        }

        private bool AutentificarCaixaVazia()
        {
            if (!string.IsNullOrEmpty(RazaoSocial) &&
               !string.IsNullOrEmpty(NomeFantasia) &&
               !string.IsNullOrEmpty(Nascionalidade) &&
               !string.IsNullOrEmpty(Email) &&
               !string.IsNullOrEmpty(Dominio) &&
               !string.IsNullOrEmpty(Ceo) &&
               !string.IsNullOrEmpty(Segmento) &&
               !string.IsNullOrEmpty(Fundacao) &&
               !string.IsNullOrEmpty(Cidade) &&
               !string.IsNullOrEmpty(Estado) &&
               !string.IsNullOrEmpty(Bairro) &&
               !string.IsNullOrEmpty(Rua) &&
               !string.IsNullOrEmpty(Numero))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarCnpj()
        {
            string autenticacaoCnpj = Cnpj;
            autenticacaoCnpj = autenticacaoCnpj.Replace(".", "").Replace("/", "").Replace("-", "");

            if (autenticacaoCnpj.Length == 14)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarTelefone()
        {
            string autenticacaoTelefone = Telefone;
            autenticacaoTelefone = autenticacaoTelefone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            if (autenticacaoTelefone.Length == 10)
            {
                return true;
            }
            else { return false; }
        }

        private bool AtenticarApenasLetras()
        {
            if (Nascionalidade.Any(char.IsLetter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AutenticarLetraEspacoEmBrancoNumeros()
        {
            bool todosCaracteresSaoValidos = false;

            List<string> colecaoComNumero = new List<string>();
            colecaoComNumero.Add(NomeFantasia);
            colecaoComNumero.Add(Bairro);
            colecaoComNumero.Add(Rua);

            foreach (string str in colecaoComNumero)
            {
                foreach (char c in str)
                {
                    if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                    {
                        todosCaracteresSaoValidos = true;
                        break;
                    }
                }
            }
            if(todosCaracteresSaoValidos == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AutenticarApenasNumeros()
        {
            if (Numero.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private bool AutenticarCaixaBaixa()
        {
            if (RazaoSocial.ToLower() == RazaoSocial &&
                NomeFantasia.ToLower() == NomeFantasia &&
                Nascionalidade.ToLower() == Nascionalidade &&
                Email.ToLower() == Email &&
                Ceo.ToLower() == Ceo &&
                Segmento.ToLower() == Segmento &&
                Cidade.ToLower() == Cidade &&
                Estado.ToLower() == Estado &&
                Bairro.ToLower() == Bairro &&
                Rua.ToLower() == Rua)
            {
                return true;
            }
            else { return false; }
        }

        private string FormatarData()
        {
            string dataInvertida, autenticacaoFundacao = Fundacao;

            autenticacaoFundacao = autenticacaoFundacao.Trim();
            autenticacaoFundacao = autenticacaoFundacao.Replace("/", " ");
            string[] validarData = autenticacaoFundacao.Split(' ');

            string dia = validarData[0];
            string mes = validarData[1];
            string ano = validarData[2];
            dataInvertida = $"{ano}/{mes}/{dia}";
            return dataInvertida;
        }

        private string MesclarEmailDominio()
        {
            string emailCompleto = Email + Dominio;
            return emailCompleto;
        }
    }
}
