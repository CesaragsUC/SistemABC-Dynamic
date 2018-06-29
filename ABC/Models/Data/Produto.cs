using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models.Data
{
    
    public class Produto
    {

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descrição { get; set; }

        [StringLength(200)]
        public string Imagem { get; set; }
        
        public decimal Preco { get; set; }


        public virtual ICollection<Estoque> Estoque { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<RelatorioDetalhes> RelatorioDetalhes { get; set; }
    }
}