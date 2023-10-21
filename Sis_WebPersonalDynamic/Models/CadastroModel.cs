using System.ComponentModel.DataAnnotations;

namespace Sis_WebPersonalDynamic.Models
{
    public class CadastroModel
    {
        public int Id_cadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório! informe seu nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório! informe seu sobrenome")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório! informe sua idade")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório! informe seu email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email_Secundario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório! informe sua senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Confirmacao_senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório! informe seu Empregador")]
        public string Empregador { get; set; }

        [Required(ErrorMessage = "Campo obrigatório! informe seu Cargo")]
        public string Cargo { get; set; }
        public int Id_funcionario { get; set; }
    }
}
