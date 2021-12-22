using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakerHubAPIV2.DAL.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joueur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAFTT = table.Column<int>(type: "int", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentifiantConnexion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEquipeHommes = table.Column<int>(type: "int", nullable: true),
                    IdEquipeDames = table.Column<int>(type: "int", nullable: true),
                    HeureDepartHommes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeureDepartDames = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Souper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeSouper = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixAffilies = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrixExternes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    UrlPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreMax = table.Column<int>(type: "int", nullable: false),
                    Titre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Souper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JoueurSouper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSouper = table.Column<int>(type: "int", nullable: false),
                    IdJoueur = table.Column<int>(type: "int", nullable: false),
                    NbReservations = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoueurSouper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoueurSouper_Joueur_IdJoueur",
                        column: x => x.IdJoueur,
                        principalTable: "Joueur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoueurSouper_Souper_IdSouper",
                        column: x => x.IdSouper,
                        principalTable: "Souper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoueurSouper_IdJoueur",
                table: "JoueurSouper",
                column: "IdJoueur");

            migrationBuilder.CreateIndex(
                name: "IX_JoueurSouper_IdSouper",
                table: "JoueurSouper",
                column: "IdSouper");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoueurSouper");

            migrationBuilder.DropTable(
                name: "Joueur");

            migrationBuilder.DropTable(
                name: "Souper");
        }
    }
}
