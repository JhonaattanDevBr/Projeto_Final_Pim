using ConexaoBaseDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoPersonalD
{
    public class ContaPersonalD
    {
        crud_AcessoPersonalD cnnDados = new crud_AcessoPersonalD();

        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string ConfirmacaoSenha { get; set; }
        public string MensagemErro { get; set; }

        public bool PegarValoresParaValidarCadastro()
        {
            bool teste1, teste2, teste3, teste4;

            teste1 = TesteCaixaBaixa();
            teste2 = TesteApenasLetras();
            teste3 = TesteEspacosEmBranco();
            teste4 = TesteAutenticacaoSenha();
            

            if (teste1 == true &&
               teste2 == true &&
               teste3 == true &&
               teste4 == true)
            {
                bool retornoCad = cnnDados.CadastrarFuncPersonalD(Nome, Cargo, Setor, Usuario, Senha, ConfirmacaoSenha);
                return true;
            }
            else
            {
                if (teste1 == false)
                {
                    MensagemErro = "Os campos nome, cargo, setor e usuario não podem conter letras em caixa alta.";
                    return false;
                }
                else if (teste2 == false)
                {
                    MensagemErro = "Os campos nome, cargo, setor e usuario não podem conter números ou caracteres especiais.";
                    return false;
                }
                else if (teste3 == false)
                {
                    MensagemErro = "Nenhum dos campos pode conter espaços em branco.";
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
            if (Nome.ToLower() == Nome &&
                Cargo.ToLower() == Cargo &&
                Setor.ToLower() == Setor &&
                Usuario.ToLower() == Usuario)
            {
                return true;
            }
            else { return false; }
        }

        private bool TesteApenasLetras()
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

        private bool TesteEspacosEmBranco()
        {
            string texto1 = Nome.Replace(" ", ""),
                   texto2 = Cargo.Replace(" ", ""),
                   texto3 = Setor.Replace(" ", ""),
                   texto4 = Usuario.Replace(" ", ""),
                   texto5 = Senha.Replace(" ", ""),
                   texto6 = ConfirmacaoSenha.Replace(" ", "");
           
            if(!(Nome != texto1) &&
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

        private bool TesteAutenticacaoSenha()
        {
            if (!string.IsNullOrEmpty(Nome) &&
                !string.IsNullOrEmpty(Cargo) &&
                !string.IsNullOrEmpty(Setor) &&
                !string.IsNullOrEmpty(Usuario) &&
                !string.IsNullOrEmpty(Senha) &&
                !string.IsNullOrEmpty(ConfirmacaoSenha))
            {
                if (Senha.Length >= 8 && ConfirmacaoSenha.Length >= 8)
                {
                    if (Senha.Equals(ConfirmacaoSenha))
                    {
                        return true;
                    }else { MensagemErro = "As senhas devem ser identicas entre si."; return false; }

                }else { MensagemErro = "A senha deve possuir no mínimo 8 dígitos."; return false; }

            }else { MensagemErro = "Todos os campos devem ser preenchidos."; return false; }
            
        }
    }
}
