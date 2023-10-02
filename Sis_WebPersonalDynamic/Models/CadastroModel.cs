namespace Sis_WebPersonalDynamic.Models
{
    public class CadastroModel
    {
        public int Id_funcionario { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get;}

        public int Idade { get; set; }
        public string Email { get; set; }

        public string EmailSecundario { get; set; }

        public string Senha { get; set; }

        public string Empregador { get; set; }

        public string Cargo { get; set; }
    }
}
