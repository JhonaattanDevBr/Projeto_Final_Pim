namespace WebPIM.Models
{
    public class FolhaPagModel
    {
        public int Id_Folha { get; set; }
        public float Salario_base { get; set; }
        public float VL_transporte { get; set; }
        public float VL_alimentacao { get; set; }
        public float Adiantamento { get; set; }
        public float Horas_extras { get; set; }
        public float Adicional_not { get; set; }
        public float Periculosidade { get; set; }
        public float Insalubridade { get; set; }
        public int Id_planos_saude { get; set; }
        public int Id_planos_odontologicos { get; set; }
        public float Dependentes { get; set; }
        public float Pensao { get; set; }
        public float Atrasos { get; set; }
        public float Faltas { get; set; }
        public float Inss { get; set; }
        public float Irrf { get; set; }
        public float Id_Decimo_terceiro { get; set; }
        public float Fgts { get; set; }
        public float Vencimentos { get; set; }
        public float Descontos { get; set; }
        public float Salario_liquido { get; set; }
        public int Id_funcionarios { get; set; }
        public int Id_empresas { get; set; }
        public string Nome_fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Cargo { get; set; }
        public string Nome { get; set; }
        public int Registro { get; set; }


    }
}
