using Microsoft.EntityFrameworkCore;
using Projeto.Models;

namespace Projeto
{
	public class Contexto : DbContext 
	{
		public DbSet<Cliente> Clientes { get; set; }

		public DbSet<Produto> Produtos { get; set; }
		public Contexto()
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=IrmaosApple;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
			optionsBuilder.UseLazyLoadingProxies();
		}
	}
}
