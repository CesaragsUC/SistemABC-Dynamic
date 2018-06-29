using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models.Data
{
    public class RelatorioArmazem
    {
        [Key]
        public int relatorioId { get; set; }
        public int ArmazemId { get; set; }
        public decimal valor { get; set; }
        public string Nome { get; set; }


        [ForeignKey("ArmazemId")]
        public virtual Armazem Armazem { get; set; }
    }
}