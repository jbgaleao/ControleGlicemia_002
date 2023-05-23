using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleGlicemia_002.Migrations
{
    public partial class CriacaoBancoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GLICEMIAS",
                columns: table => new
                {
                    GlicemiaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlicemiaMedida = table.Column<int>(type: "int", nullable: false),
                    DataMedicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraMedicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoseRegular = table.Column<int>(type: "int", nullable: true),
                    DoseAjuste = table.Column<int>(type: "int", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLICEMIAS", x => x.GlicemiaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GLICEMIAS");
        }
    }
}
