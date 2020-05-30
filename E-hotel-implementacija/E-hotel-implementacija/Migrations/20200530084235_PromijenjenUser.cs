using Microsoft.EntityFrameworkCore.Migrations;

namespace E_hotel_implementacija.Migrations
{
    public partial class PromijenjenUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Posao",
                table: "Posao");

            migrationBuilder.RenameTable(
                name: "Posao",
                newName: "PosaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PosaoId",
                table: "PosaoId",
                column: "PosaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PosaoId",
                table: "PosaoId");

            migrationBuilder.RenameTable(
                name: "PosaoId",
                newName: "Posao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posao",
                table: "Posao",
                column: "PosaoId");
        }
    }
}
