﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class NasContext:DbContext
    {
        public NasContext(DbContextOptions<NasContext> options): base(options)
        {
        }

        public DbSet<Korisnik> Korisnici { get; set; }
        //public DbSet<Zaposlenik> Zaposlnici { get; set; }
        public DbSet<Posao> Poslovi { get; set; }
        public DbSet<Soba> Sobe { get; set; }
        public DbSet<SistemskaGreska> SistemskeGreske { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            //modelBuilder.Entity<Zaposlenik>().ToTable("Zaposlenik");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Posao>().ToTable("PosaoId");
            modelBuilder.Entity<Soba>().ToTable("Soba");
            modelBuilder.Entity<SistemskaGreska>().ToTable("SistemskaGreska");

        }



    }
}

//Add-Migration InitialMigration -Context E_hotel_implementacija.Models.NasContext
//Update-Database -Context E_hotel_implementacija.Models.NasContext