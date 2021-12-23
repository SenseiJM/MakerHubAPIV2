using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakerHubAPIV2.DAL.Migrations
{
    public partial class M5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlPhoto",
                table: "Souper");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Souper",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Souper");

            migrationBuilder.AddColumn<string>(
                name: "UrlPhoto",
                table: "Souper",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
