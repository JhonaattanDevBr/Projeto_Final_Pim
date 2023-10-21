namespace Sis_WebPersonalDynamic.Models
{
    public class FuncionarioModel
    {
        public int Id_funcionario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public int Id_endereco { get; set; }
        public int Registro { get; set; }
        public int Carga_horaria { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string Email_secundario { get; set; }
        public string Telefone { get; set; }
        public string Cell_principal { get; set; }
        public string Cell_secundario { get; set; }
        public int Num_dependentes { get; set; }
        public int Id_planos_saude { get; set; }
        public int Id_planos_odontologicos { get; set; }
        public int Id_empresas { get; set; }
        public string Cargo { get; set; }
        public double Salario  { get; set; }
        public DateTime Data_admissao { get; set; }


    }
}
