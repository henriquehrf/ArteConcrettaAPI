using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArteConcrettaEntity.Migrations
{
    public partial class AdicionadoRelacionamentoTabelaContaPagarReceber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaPagarReceber",
                columns: table => new
                {
                    IDContaPagarReceber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCliente = table.Column<int>(nullable: false),
                    TipoOperacao = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    DataPagamento = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    ValorPago = table.Column<decimal>(nullable: false),
                    IDCaixa = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaPagarReceber", x => x.IDContaPagarReceber);
                    table.ForeignKey(
                        name: "FK_ContaPagarReceber_Caixa_IDCaixa",
                        column: x => x.IDCaixa,
                        principalTable: "Caixa",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContaPagarReceber_Cliente_IDCliente",
                        column: x => x.IDCliente,
                        principalTable: "Cliente",
                        principalColumn: "IDCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaPagarReceber_IDCaixa",
                table: "ContaPagarReceber",
                column: "IDCaixa");

            migrationBuilder.CreateIndex(
                name: "IX_ContaPagarReceber_IDCliente",
                table: "ContaPagarReceber",
                column: "IDCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaPagarReceber");
        }
    }
}
