using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models.Data
{
    public class RelatorioDeposito
    {
        [Key]
        public int relatorioId { get; set; }
        public int DepositoId { get; set; }
        public decimal valor { get; set; }
        public string Nome { get; set; }

        [ForeignKey("DepositoId")]
        public virtual Deposito Deposito { get; set; }
    }
}