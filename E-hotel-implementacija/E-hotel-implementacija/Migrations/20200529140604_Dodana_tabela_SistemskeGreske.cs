using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_hotel_implementacija.Migrations
{
    public partial class Dodana_tabela_SistemskeGreske : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SistemskaGreska",
                columns: table => new
                {
                    SistemskaGreskaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KodGreske = table.Column<int>(nullable: false),
                    UcestalostGreske = table.Column<int>(nullable: false),
                    OpisGreske = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemskaGreska", x => x.SistemskaGreskaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SistemskaGreska");
        }
    }
}
