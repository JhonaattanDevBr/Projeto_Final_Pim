namespace WebPIM.Models
{
    public class ApontamentoModel
    {
        
        public DateTime Dia { get; set; }
        public TimeSpan Inicio_jornada { get; set; } = TimeSpan.Zero;
        public TimeSpan Saida_almoco { get; set; } = TimeSpan.Zero;
        public TimeSpan Retorno_almoco { get; set; } = TimeSpan.Zero;
        public TimeSpan Fim_jornada { get; set; } = TimeSpan.Zero;
        public TimeSpan Somatorio_dia { get; set; } = TimeSpan.Zero;
        public int Id_funcionario { get; set; }
        
    }
}
