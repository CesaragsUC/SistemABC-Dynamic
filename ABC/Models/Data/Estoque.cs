using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models.Data
{
    
    public class Estoque
    {
        [Key]
        public int Id { get; set; }

        public int DepositoId { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        [ForeignKey("DepositoId")]
        public virtual Deposito Deposito { get; set; }

        [ForeignKey("ProdutoId")]
        public virtual Produto Produto { get; set; }

        public virtual ICollection<RelatorioDetalhes> RelatorioDetalhes { get; set; }
    }
}