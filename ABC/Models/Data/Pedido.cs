using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models.Data
{
    
    public class Pedido
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoUnidade { get; set; }

        [ForeignKey("ProdutoId")]
        public virtual Produto Produto { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<RelatorioDetalhes> RelatorioDetalhes { get; set; }
    }
}