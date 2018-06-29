using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ABC.Models;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ABC.Models.Data
{
    public class Db : DbContext
    {

        public Db() : base("Conexao")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Armazem> Armazem { get; set; }
        public virtual DbSet<Deposito> Deposito { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<RelatorioDeposito> RelatorioDepositosDetalhes { get; set; }
        public virtual DbSet<RelatorioArmazem> RelatorioArmazemDetalhes { get; set; }
    }
}