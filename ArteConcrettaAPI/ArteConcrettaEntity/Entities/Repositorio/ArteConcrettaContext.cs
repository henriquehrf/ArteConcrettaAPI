using ArteConcrettaEntity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArteConcrettaEntity
{
	public class ArteConcrettaContext : DbContext
	{
		public DbSet<Caixa> Caixa { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder
				.Entity<Caixa>()
				.ToTable("Caixa")
				.HasKey("ID");

			modelBuilder
				.Entity<Cliente>()
				.ToTable("Cliente")
				.HasKey("IDCliente");

			modelBuilder
				.Entity<ContaPagarReceber>()
				.ToTable("ContaPagarReceber")
				.HasKey("IDContaPagarReceber");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-5J4DB80\\SQLEXPRESS;Database=ArteConcrettaDevApp;integrated security=true;");
		}
	}
}
