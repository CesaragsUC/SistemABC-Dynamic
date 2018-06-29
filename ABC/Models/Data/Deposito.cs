using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models.Data
{
   
    public class Deposito
    {

        public int Id { get; set; }

        public int ArmazemId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }


        [ForeignKey("ArmazemId")]
        public virtual Armazem Armazem { get; set; }

        public virtual ICollection<Estoque> Estoque { get; set; }
        public virtual ICollection<RelatorioDeposito> RelatorioDetalhes { get; set; }
    }
}