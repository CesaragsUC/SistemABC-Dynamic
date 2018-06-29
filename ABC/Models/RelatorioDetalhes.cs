using ABC.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models
{
    public class RelatorioDetalhes
    {
        [Key]
        public int relatorioId { get; set; }

        public int ArmazemId { get; set; }

        public int DepositoId { get; set; }

        [ForeignKey("DepositoId")]
        public virtual Deposito Deposito { get; set; }

        [ForeignKey("ArmazemId")]
        public virtual Armazem Armazem { get; set; }
    }
}