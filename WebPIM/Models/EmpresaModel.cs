namespace WebPIM.Models
{
    public class EmpresaModel
    {
        public int Id_empresa { get; set; }
        public string Razao_social { get; set; }
        public string Nome_fantasia { get; set; }
        public string Nacionalidade { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Ceo { get; set; }
        public DateTime Fundacao { get; set; }
        public string Segmento { get; set; }
        public int Id_endereco { get; set; }


    }
}
