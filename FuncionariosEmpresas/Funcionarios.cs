using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FuncionariosEmpresas
{
    public class Funcionarios
    {
        public string Id { get; set; }
        public string IdEndereco { get; set; }
        public string IdEmpresa { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string DominioPrincipal { get; set; }
        public string EmailSecundario { get; set; }
        public string DominioSecundario { get; set; }
        public string Telefone { get; set; }
        public string CelularPrincipal { get; set; }
        public string CelularSecundario { get; set; }
        public string NumeroRegistro { get; set; }
        public string CargaHoraria { get; set; }
        public string Empregador { get; set; }
        public string Cargo { get; set; }
        public string DataAdmisao { get; set; }
        public string Salario { get; set; }
        public string ConvenioMedico { get; set; }
        public string ConvenioOdontologico { get; set; }
        public string Dependentes { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string MensagemErro { get; set; }


        public bool AutenticarFuncionario()
        {
            bool auten1, auten2, auten3, auten4, auten5, auten6, auten7, auten8, auten9, auten10, auten11;

            auten1 = AutenticarCamposVazios();
            auten2 = AutenticarSexo();
            auten3 = AutenticarRg();
            auten4 = AutenticarCpf();
            auten5 = AutenticarTelefone();
            auten6 = AutenticarCelular();
            auten7 = AutenticarApenasLetras();
            auten8 = AutenticarApenasNumeros();
            auten9 = AutenticarApenasLetrasNumerosEspacosEmBranco();
            auten10 = AutenticarEspacosEmBranco();
            auten11 = AutenticarApenasLetrasEspacosBranco();

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
                                if(auten6)
                                {
                                    if (auten7)
                                    {
                                        if (auten8)
                                        {
                                            if (auten9)
                                            {
                                                if (auten10)
                                                {
                                                    if (auten11)
                                                    {
                                                        DataAdmisao = FormatarData();
                                                        MesclarEmailDominio();
                                                        CapturarId();
                                                        return true;
                                                    }
                                                    else
                                                    {
                                                        MensagemErro = "O campo SOBRENOME não aceita números e caracteres especiais.";
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    MensagemErro = "Os campos EMAiL e EMAIL SECUNDARIO não podem conter espaços em branco.";
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                MensagemErro = "Os campos CIDADE, ESTADO, BAIRRO e RUA não podem conter caracteres especiais.";
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            MensagemErro = "Os campos IDADE, Nº DE REGISTRO, SALÁRIO, DEPENDENTES e NÚMERO não podem conter caracteres ou espaços em branco.";
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MensagemErro = "Os campos NOME e CARGO não poodem conter numeros ou espaços em branco.";
                                        return false;
                                    }
                                }
                                else
                                {
                                    MensagemErro = "Informe todos os dígitos do CELULAR.";
                                    return false;
                                }
                            }
                            else
                            {
                                MensagemErro = "Informe todos os dígitos do TELEFONE.";
                                return false;
                            }
                        }
                        else
                        {
                            MensagemErro = "Informe todos os digitos do CPF.";
                            return false;
                        }
                    }
                    else
                    {
                        MensagemErro = "Informe todos os dígitos do RG.";
                        return false;
                    }
                }
                else
                {
                    MensagemErro = "Selecione o SEXO do funcionário.";
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
            if(!string.IsNullOrEmpty(Nome) &&
            !string.IsNullOrEmpty(Sobrenome) &&
            !string.IsNullOrEmpty(Idade) &&
            !string.IsNullOrEmpty(Sexo) &&
            !string.IsNullOrEmpty(Rg) &&
            !string.IsNullOrEmpty(Cpf) &&
            !string.IsNullOrEmpty(Email) &&
            !string.IsNullOrEmpty(EmailSecundario) &&
            !string.IsNullOrEmpty(Telefone) &&
            !string.IsNullOrEmpty(CelularPrincipal) &&
            !string.IsNullOrEmpty(CelularSecundario) &&
            !string.IsNullOrEmpty(NumeroRegistro) &&
            !string.IsNullOrEmpty(CargaHoraria) &&
            //!string.IsNullOrEmpty(Empregador) &&
            !string.IsNullOrEmpty(Cargo) &&
            !string.IsNullOrEmpty(DataAdmisao) &&
            !string.IsNullOrEmpty(Salario) &&
            //!string.IsNullOrEmpty(ConvenioMedico) &&
            //!string.IsNullOrEmpty(ConvenioOdontologico) &&
            !string.IsNullOrEmpty(Dependentes) &&
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

        private bool AutenticarSexo()
        {
            if (!string.IsNullOrEmpty(Sexo)) 
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarRg()
        {
            string rgFormatado = Rg;

            rgFormatado = rgFormatado.Replace(",", "").Replace("-", "");
            if(rgFormatado.Length == 9)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarCpf()
        {
            string cpfFormatado = Cpf;

            cpfFormatado = cpfFormatado.Replace(",", "").Replace("-", "");
            if(cpfFormatado.Length == 11)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarTelefone()
        {
            string telefoneFormatado = Telefone;

            telefoneFormatado = telefoneFormatado.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if(telefoneFormatado.Length == 10)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarCelular()
        {
            string cellPrincFormatado = CelularPrincipal;
            cellPrincFormatado = cellPrincFormatado.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            string cellSecFormatado = CelularSecundario;
            cellSecFormatado = cellSecFormatado.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (cellPrincFormatado.Length == 11 &&  cellSecFormatado.Length == 11)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarApenasLetras()
        {
            if(Nome.All(char.IsLetter))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarApenasLetrasEspacosBranco()
        {
            if(Sobrenome.All(char.IsLetter) || Sobrenome.Any(char.IsWhiteSpace) && Cargo.All(char.IsLetter) || Cargo.Any(char.IsWhiteSpace))
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarApenasNumeros()
        {
            bool todosCaracteresValidos = false;
            List<string> colecaoDeDigitos = new List<string>();
            colecaoDeDigitos.Add(Idade);
            colecaoDeDigitos.Add(NumeroRegistro);
            colecaoDeDigitos.Add(CargaHoraria);
            colecaoDeDigitos.Add(Salario);
            colecaoDeDigitos.Add(Dependentes);
            colecaoDeDigitos.Add(Numero);

            foreach (string str in colecaoDeDigitos)
            {
                foreach (char c in str)
                {
                    if (char.IsDigit(c))
                    {
                        todosCaracteresValidos = true;
                    }
                }
            }

            if(todosCaracteresValidos)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarApenasLetrasNumerosEspacosEmBranco()
        {
            bool todosCaracteresValidos = false;
            List<string> colecao = new List<string>();
            colecao.Add(Cidade);
            colecao.Add(Estado);
            colecao.Add(Bairro);
            colecao.Add(Rua);

            foreach (string str in colecao)
            {
                foreach (char c in str)
                {
                    todosCaracteresValidos = true;
                    break;
                }
            }

            if (todosCaracteresValidos)
            {
                return true;
            }
            else { return false; }
        }

        private bool AutenticarEspacosEmBranco()
        {
            if(!Email.All(char.IsWhiteSpace) && !EmailSecundario.All(char.IsWhiteSpace))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string FormatarData()
        {
            string dataInvertida, autenticacaoFundacao = DataAdmisao;

            autenticacaoFundacao = autenticacaoFundacao.Trim();
            autenticacaoFundacao = autenticacaoFundacao.Replace("/", " ");
            string[] validarData = autenticacaoFundacao.Split(' ');

            string dia = validarData[0];
            string mes = validarData[1];
            string ano = validarData[2];
            dataInvertida = $"{ano}/{mes}/{dia}";
            return dataInvertida;
        }

        private void MesclarEmailDominio()
        {
            string emailPrincipalCompleto = Email + DominioPrincipal;
            string emailSecundarioCompleto = EmailSecundario + DominioSecundario;
            Email = emailPrincipalCompleto;
            EmailSecundario = emailSecundarioCompleto;
        }

        private void CapturarId()
        {
            string empregador = Empregador;
            empregador = empregador.Replace("[", "").Replace(",", " ");
            string[] divisorEmpregador = empregador.Split(' ');
            string idEmpregador = divisorEmpregador[0];
            Empregador = idEmpregador;

            string convenioMedico = ConvenioMedico;
            convenioMedico = convenioMedico.Replace("[", "").Replace(",", " ");
            string[]  divisorMedico = convenioMedico.Split(' ');
            string idMedico = divisorMedico[0];
            ConvenioMedico = idMedico;

            string convenioOdontologico = ConvenioOdontologico;
            convenioOdontologico = convenioOdontologico.Replace("[", "").Replace(",", " ");
            string[] divisorOdontologico = convenioOdontologico.Split(' ');
            string idOdontologico = divisorOdontologico[0];
            ConvenioOdontologico = idOdontologico;
        }
    }
}
