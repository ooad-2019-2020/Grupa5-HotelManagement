using Microsoft.EntityFrameworkCore.Migrations;

namespace E_hotel_implementacija.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PosaoId",
                columns: table => new
                {
                    PosaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Plata = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posao", x => x.PosaoId);
                });

            migrationBuilder.CreateTable(
                name: "StatePattern",
                columns: table => new
                {
                    StatePaternId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatePattern", x => x.StatePaternId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    EMail = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    PosaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Osoba_Posao_PosaoId",
                        column: x => x.PosaoId,
                        principalTable: "PosaoId",
                        principalColumn: "PosaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Soba",
                columns: table => new
                {
                    SobaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brojsobe = table.Column<string>(nullable: true),
                    CijenaSobe = table.Column<double>(nullable: false),
                    OcjenaSobe = table.Column<double>(nullable: false),
                    OpisSobe = table.Column<string>(nullable: true),
                    SlikaSobe = table.Column<string>(nullable: true),
                    StatePatternStatePaternId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soba", x => x.SobaId);
                    table.ForeignKey(
                        name: "FK_Soba_StatePattern_StatePatternStatePaternId",
                        column: x => x.StatePatternStatePaternId,
                        principalTable: "StatePattern",
                        principalColumn: "StatePaternId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Osoba_PosaoId",
                table: "Korisnik",
                column: "PosaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Soba_StatePatternStatePaternId",
                table: "Soba",
                column: "StatePatternStatePaternId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Soba");

            migrationBuilder.DropTable(
                name: "PosaoId");

            migrationBuilder.DropTable(
                name: "StatePattern");
        }
    }
}
