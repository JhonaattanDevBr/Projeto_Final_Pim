using System.ComponentModel.DataAnnotations;

namespace WebPIM.Models
{
    public class AgendamentoFeriasModel
    {
        public int Id_agendamento { get; set; }
        [Required]
        public int PrimeiroPeriodo { get; set; }
        [Required]
        public int PrimeiroMes { get; set; }
        public int SegundoPeriodo { get; set; }
        public int SegundoMes { get; set; }
        public int TerceiroPeriodo { get; set; }
        public int TerceiroMes { get; set; }
        public int Dias_restantes { get; set; }
        public bool VenderFerias { get; set; }                                              
        public int Dias_vendidos { get; set; }
        public int Primeira_parcela_decimo { get; set; }

    }
}
