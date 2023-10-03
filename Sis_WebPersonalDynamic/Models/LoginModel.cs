using System.ComponentModel.DataAnnotations;

namespace Sis_WebPersonalDynamic.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Informe seu email")]
        [EmailAddress(ErrorMessage ="Email informado não valido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Informe a senha")]  
        public string Senha { get; set; }
        public bool Valido { get; internal set; }
    }
}
