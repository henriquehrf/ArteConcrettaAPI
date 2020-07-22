using ArteConcrettaCore.Models;
using ArteConcrettaEntity.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArteConcrettaEntity
{
	public class ArteConcrettaContext : DbContext
	{
		public DbSet<CaixaMapping> Caixa { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder
				.Entity<CaixaMapping>()
				.ToTable("Caixa")
				.HasKey("ID");

			modelBuilder
				.Entity<ClienteMapping>()
				.ToTable("Cliente")
				.HasKey("IDCliente");

			modelBuilder
				.Entity<ContaPagarReceberMapping>()
				.ToTable("ContaPagarReceber")
				.HasKey("IDContaPagarReceber");

			modelBuilder
				.Entity<TipoLancamentoMapping>()
				.ToTable("TipoLancamento")
				.HasKey("IDTipoLancamento");

			modelBuilder
				.Entity<LancamentoMapping>()
				.ToTable("Lancamento")
				.HasKey("IDLancamento");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-5J4DB80\\SQLEXPRESS;Database=ArteConcrettaDevApp;integrated security=true;");
		}
	}
}
