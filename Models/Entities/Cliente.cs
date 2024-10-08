﻿using System.ComponentModel.DataAnnotations;
    namespace academia.Models
{
    public class Cliente: BaseEntity
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Telefone { get; set; }

        public int PlanoId { get; set; }
        public Plano Plano { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
    }
}
