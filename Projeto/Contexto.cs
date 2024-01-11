using Microsoft.EntityFrameworkCore;
using Projeto.Models;

namespace Projeto
{
	public class Contexto : DbContext 
	{
		public DbSet<Cliente> Clientes { get; set; }

		public DbSet<Produto> Produtos { get; set; }	
		public DbSet<Venda> Vendas { get; set; }
		public DbSet<ItemVenda> ItemVendas { get; set; }
		      
        public Contexto()
		{

		}
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venda>()
                        .HasOne(nf => nf.Cliente)
                        .WithMany(c => c.Vendas)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venda>()
                        .HasMany(nf => nf.Itens)
                        .WithOne(nfi => nfi.Venda);

            modelBuilder.Entity<ItemVenda>()
                        .HasOne(nfi => nfi.Produto);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=IrmaosApple;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
			optionsBuilder.UseLazyLoadingProxies();
		}

		public DbSet<Projeto.Models.Venda>? Venda { get; set; }
	}
}
