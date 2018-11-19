using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Produto")]
    public class Produtos
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(2000)]
        public string Descricao { get; set; }
        [Range(-999999999999.99, 999999999999.99)]
        [Required]
        public decimal valor { get; set; }
        
        [ForeignKey("Loja")]
        public int LojaId { get; set; }
        public virtual Loja Loja { get; set; }
    }
}
