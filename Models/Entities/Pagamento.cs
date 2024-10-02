using System.ComponentModel.DataAnnotations;

namespace academia.Models
{
    public class Pagamento: BaseEntity
    {
        [Required]
        public int ReferenciaPagamento { get; set; }
        [Required]
        public string Status { get; set; }
        
        public DateTime Criacao { get; set; }
        public DateTime Alteracao { get; set; }
        

        public MetodoPagamento Metodo { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
         
    }

public enum MetodoPagamento
    {
        Boleto,
        Pix,
        Cartao
    }
}
