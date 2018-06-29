using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models.Data
{
    
    public class Armazem
    {
            public int Id { get; set; }

            [Required]
            [StringLength(50)]
            public string Nome { get; set; }
            public int Prazo { get; set; }

            public virtual ICollection<Deposito> Deposito { get; set; }
           public virtual ICollection<RelatorioArmazem> RelatorioDetalhes { get; set; }
    }
}