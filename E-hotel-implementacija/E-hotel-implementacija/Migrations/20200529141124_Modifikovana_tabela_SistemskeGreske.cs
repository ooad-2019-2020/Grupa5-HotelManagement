using Microsoft.EntityFrameworkCore.Migrations;

namespace E_hotel_implementacija.Migrations
{
    public partial class Modifikovana_tabela_SistemskeGreske : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KodGreske",
                table: "SistemskaGreska");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KodGreske",
                table: "SistemskaGreska",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
