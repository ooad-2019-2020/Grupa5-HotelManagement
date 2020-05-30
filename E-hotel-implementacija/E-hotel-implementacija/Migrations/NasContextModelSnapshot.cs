﻿// <auto-generated />
using System;
using E_hotel_implementacija.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_hotel_implementacija.Migrations
{
    [DbContext(typeof(NasContext))]
    partial class NasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_hotel_implementacija.Models.Korisnik", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("E_hotel_implementacija.Models.Posao", b =>
                {
                    b.Property<int>("PosaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Plata")
                        .HasColumnType("float");

                    b.HasKey("PosaoId");

                    b.ToTable("PosaoId");
                });

            modelBuilder.Entity("E_hotel_implementacija.Models.SistemskaGreska", b =>
                {
                    b.Property<int>("SistemskaGreskaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("OpisGreske")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UcestalostGreske")
                        .HasColumnType("int");

                    b.HasKey("SistemskaGreskaId");

                    b.ToTable("SistemskaGreska");
                });

            modelBuilder.Entity("E_hotel_implementacija.Models.Soba", b =>
                {
                    b.Property<int>("SobaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brojsobe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CijenaSobe")
                        .HasColumnType("float");

                    b.Property<double>("OcjenaSobe")
                        .HasColumnType("float");

                    b.Property<string>("OpisSobe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlikaSobe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatePatternStatePaternId")
                        .HasColumnType("int");

                    b.HasKey("SobaId");

                    b.HasIndex("StatePatternStatePaternId");

                    b.ToTable("Soba");
                });

            modelBuilder.Entity("E_hotel_implementacija.Models.StatePattern", b =>
                {
                    b.Property<int>("StatePaternId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("StatePaternId");

                    b.ToTable("StatePattern");
                });

            modelBuilder.Entity("E_hotel_implementacija.Models.Soba", b =>
                {
                    b.HasOne("E_hotel_implementacija.Models.StatePattern", "StatePattern")
                        .WithMany()
                        .HasForeignKey("StatePatternStatePaternId");
                });
#pragma warning restore 612, 618
        }
    }
}
