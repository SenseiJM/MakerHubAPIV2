using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakerHubAPIV2.DAL.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlPhoto",
                table: "Annonce");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Annonce",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Annonce");

            migrationBuilder.AddColumn<string>(
                name: "UrlPhoto",
                table: "Annonce",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
