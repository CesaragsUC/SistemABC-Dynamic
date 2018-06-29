using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models.Data
{
    public class Cliente
    {
       [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<RelatorioDetalhes> RelatorioDetalhes { get; set; }
    }
}