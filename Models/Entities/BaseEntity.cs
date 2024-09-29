using System.ComponentModel.DataAnnotations;

namespace academia.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}