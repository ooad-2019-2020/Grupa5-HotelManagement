using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_hotel_implementacija.Migrations
{
    public partial class DodanaRezervacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GostId = table.Column<string>(nullable: true),
                    SobaId = table.Column<int>(nullable: true),
                    DatumPocetka = table.Column<DateTime>(nullable: false),
                    DatumKraja = table.Column<DateTime>(nullable: false),
                    Popust = table.Column<int>(nullable: false),
                    DatumRezervacije = table.Column<DateTime>(nullable: false),
                    Parking = table.Column<int>(nullable: false),
                    Validnost = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Korisnik_GostId",
                        column: x => x.GostId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Soba_SobaId",
                        column: x => x.SobaId,
                        principalTable: "Soba",
                        principalColumn: "SobaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_GostId",
                table: "Rezervacija",
                column: "GostId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_SobaId",
                table: "Rezervacija",
                column: "SobaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervacija");
        }
    }
}
