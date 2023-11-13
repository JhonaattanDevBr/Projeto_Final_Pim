using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaPersonal
{
    public class Personal
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string ConfirmacaoSenha { get; set; }
        public string MensagemErro { get; set; }

        public bool PegarValoresParaValidarCadastro()
        {
            bool auten1, auten2, auten3, auten4, auten5, auten6;

            auten1 = AutenticarCamposVazios();
            auten2 = AutenticarOitoDigitos();
            auten3 = AutenticarCompatibilidadeSenhas();
            auten4 = AutenticarCaixaBaixa();
            auten5 = AutenticarApenasLetras();
            auten6 = AutenticarEspacosEmBranco();



            if (auten1)
            {
                if (auten2)
                {
                    if (auten3)
                    {
                        if (auten4)
                        {
                            if (auten5)
                            {
                                if (auten6)
                                {
                                    return true;
                                }
                                else
                                {
                                    MensagemErro = "Nenhum dos campos pode conter espaços em branco.";
                                    return false;
                                }
                            }
                            else
                            {
                                MensagemErro = "Os campos NOME, CARGO, SETOR e USÚARIO não podem conter números ou caracteres especiais.";
                                return false;
                            }
                        }
                        else
                        {
                            MensagemErro = "Os campos NOME, CARGO, SETOR e USÚARIO não podem conter letras em caixa alta.";
                            return false;
                        }
                    }
                    else
                    {
                        MensagemErro = "As SENHAS devem ser identicas entre si.";
                        return false;
                    }
                }
                else
                {
                    MensagemErro = "A SENHA deve possuir no mínimo 8 dígitos.";
                    return false;
                }
            }
            else
            {
                MensagemErro = "Todos os campos devem ser preenchidos.";
                return false;
            }
        }

        private bool AutenticarCamposVazios()
        {
            if (!string.IsNullOrEmpty(Nome) &&
                !string.IsNullOrEmpty(Cargo) &&
                !string.IsNullOrEmpty(Setor) &&
                !string.IsNullOrEmpty(Usuario) &&
                !string.IsNullOrEmpty(Senha) &&
                !string.IsNullOrEmpty(ConfirmacaoSenha))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarOitoDigitos()
        {
            if (Senha.Length >= 8 && ConfirmacaoSenha.Length >= 8)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarCompatibilidadeSenhas()
        {
            if (Senha.Equals(ConfirmacaoSenha))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarCaixaBaixa()
        {
            if (Nome.ToLower() == Nome &&
                Cargo.ToLower() == Cargo &&
                Setor.ToLower() == Setor &&
                Usuario.ToLower() == Usuario)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarApenasLetras()
        {
            if (Nome.All(char.IsLetter) &&
                Cargo.All(char.IsLetter) &&
                Setor.All(char.IsLetter) &&
                Usuario.All(char.IsLetter))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarEspacosEmBranco()
        {
            string texto1 = Nome.Replace(" ", ""),
                   texto2 = Cargo.Replace(" ", ""),
                   texto3 = Setor.Replace(" ", ""),
                   texto4 = Usuario.Replace(" ", ""),
                   texto5 = Senha.Replace(" ", ""),
                   texto6 = ConfirmacaoSenha.Replace(" ", "");

            if (!(Nome != texto1) &&
               !(Cargo != texto2) &&
               !(Setor != texto3) &&
               !(Usuario != texto4) &&
               !(Senha != texto5) &&
               !(ConfirmacaoSenha != texto6))
            {
                return true;
            }
            else { return false; }
        }

        

        
    }
}
