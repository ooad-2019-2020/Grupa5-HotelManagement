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
                table: "Osoba");

            /*migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Osoba",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");*/

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Osoba",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Osoba",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Osoba",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Osoba",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Osoba",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Osoba",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Osoba",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Osoba",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Osoba",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Osoba",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Osoba",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Osoba",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Osoba");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Osoba");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Osoba",
                type: "int",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Osoba",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
