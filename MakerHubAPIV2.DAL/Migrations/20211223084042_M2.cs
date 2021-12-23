using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakerHubAPIV2.DAL.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureDebut = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    HeureFin = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PrixAffilies = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrixExternes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Entraineur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombreMax = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    ClassementMaximum = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ClassementMinimum = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stage");
        }
    }
}
