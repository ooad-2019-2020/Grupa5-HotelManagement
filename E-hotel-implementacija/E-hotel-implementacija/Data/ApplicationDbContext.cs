using System;
using System.Collections.Generic;
using System.Text;
using E_hotel_implementacija.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_hotel_implementacija.Data
{
    public class ApplicationDbContext : IdentityDbContext<Osoba>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
