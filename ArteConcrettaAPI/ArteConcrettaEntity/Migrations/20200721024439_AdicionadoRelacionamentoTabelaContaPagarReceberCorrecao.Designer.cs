﻿// <auto-generated />
using System;
using ArteConcrettaEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArteConcrettaEntity.Migrations
{
    [DbContext(typeof(ArteConcrettaContext))]
    [Migration("20200721024439_AdicionadoRelacionamentoTabelaContaPagarReceberCorrecao")]
    partial class AdicionadoRelacionamentoTabelaContaPagarReceberCorrecao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArteConcrettaEntity.Caixa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Caixa");
                });

            modelBuilder.Entity("ArteConcrettaEntity.Entities.Cliente", b =>
                {
                    b.Property<int>("IDCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IDCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ArteConcrettaEntity.Entities.ContaPagarReceber", b =>
                {
                    b.Property<int>("IDContaPagarReceber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("IDCaixa")
                        .HasColumnType("int");

                    b.Property<int>("IDCliente")
                        .HasColumnType("int");

                    b.Property<string>("TipoOperacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IDContaPagarReceber");

                    b.HasIndex("IDCaixa");

                    b.HasIndex("IDCliente");

                    b.ToTable("ContaPagarReceber");
                });

            modelBuilder.Entity("ArteConcrettaEntity.Entities.ContaPagarReceber", b =>
                {
                    b.HasOne("ArteConcrettaEntity.Caixa", "Caixa")
                        .WithMany("ContaPagarRecebe")
                        .HasForeignKey("IDCaixa");

                    b.HasOne("ArteConcrettaEntity.Entities.Cliente", "Cliente")
                        .WithMany("ContaPagarRecebe")
                        .HasForeignKey("IDCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
