namespace WebPIM.Models
{
    public class FeriasModel
    {
        public int Id_ferias { get; set; }
        public int Dias_gozados { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Retorno { get; set; }
        public int Dias_vendidos { get; set; }
        public float Abono_pecuniario { get; set; }
        public float Um_terco_abonoP { get; set; }
        public float Inss_ferias { get; set; }
        public float Irrf_ferias { get; set; }
        public float Bruto_ferias { get; set; }
        public float Liquido_ferias { get; set; }
        public int Id_funcionario { get; set; }
        public int Id_folha_pagamento { get; set; }
        public int Id_agendamento_ferias { get; set; }
    }
}
