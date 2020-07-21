using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArteConcrettaEntity.Migrations
{
    public partial class AdicionadoTabelaDeLancamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoLancamento",
                columns: table => new
                {
                    IDTipoLancamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    EntradaSaida = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoLancamento", x => x.IDTipoLancamento);
                });

            migrationBuilder.CreateTable(
                name: "Lancamento",
                columns: table => new
                {
                    IDLancamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCaixa = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    IDTipoLancamento = table.Column<int>(nullable: false),
                    DataLancamento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamento", x => x.IDLancamento);
                    table.ForeignKey(
                        name: "FK_Lancamento_Caixa_IDCaixa",
                        column: x => x.IDCaixa,
                        principalTable: "Caixa",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lancamento_TipoLancamento_IDTipoLancamento",
                        column: x => x.IDTipoLancamento,
                        principalTable: "TipoLancamento",
                        principalColumn: "IDTipoLancamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_IDCaixa",
                table: "Lancamento",
                column: "IDCaixa");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_IDTipoLancamento",
                table: "Lancamento",
                column: "IDTipoLancamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamento");

            migrationBuilder.DropTable(
                name: "TipoLancamento");
        }
    }
}
