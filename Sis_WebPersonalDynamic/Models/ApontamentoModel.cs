namespace Sis_WebPersonalDynamic.Models
{
    public class ApontamentoModel
    {
        public int Id_funcionario { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime Dia { get; set; }
        public DateTime HoraEntrada1 { get; set; }
        public DateTime HoraSaida1 { get; set; }
        public DateTime HoraEntrada2 { get; set; }
        public DateTime HoraSaida2 { get; set; }
        public DateTime HorasTrabalhadas { get; set; }
    }
}
