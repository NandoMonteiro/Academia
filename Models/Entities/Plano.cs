namespace academia.Models
{
    public class Plano: BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public int ClientId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
