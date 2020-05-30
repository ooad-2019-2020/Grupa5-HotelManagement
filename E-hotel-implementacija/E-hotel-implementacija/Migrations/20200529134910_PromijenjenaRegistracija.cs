using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_hotel_implementacija.Migrations
{
    public partial class PromijenjenaRegistracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Korisnik");

            /*migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Korisnik",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");*/

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Korisnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Korisnik");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Korisnik",
                type: "int",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
