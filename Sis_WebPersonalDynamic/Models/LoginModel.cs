using System.ComponentModel.DataAnnotations;

namespace Sis_WebPersonalDynamic.Models
{
    public class LoginModel
    {
        public int Id_acesso { get; set; }
        public int Id_funcionario { get; set; }
        public string Usuario { get; set; }

        [Required(ErrorMessage ="Informe seu email")]
        [EmailAddress(ErrorMessage ="Email informado não valido")]
        public string Email { get; set; }
        public string Email_verificacao { get; set; }

        [Required(ErrorMessage ="Informe a senha")]  
        public string Senha { get; set; }
        public string Confirmacao_Senha { get; set; }
        public bool Valido { get; internal set; }
    }
}
