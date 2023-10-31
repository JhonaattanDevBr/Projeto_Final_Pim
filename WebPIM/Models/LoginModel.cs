using System.ComponentModel.DataAnnotations;

namespace WebPIM.Models
{
    public class LoginModel
    {
        public int Id_funcionario { get; set; }
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Informe seu email")]
        [EmailAddress(ErrorMessage = "Email informado não valido")]
        public string Email { get; set; }
        public string Email_verificacao { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }
        public string Confirmacao_Senha { get; set; }

    }
}
