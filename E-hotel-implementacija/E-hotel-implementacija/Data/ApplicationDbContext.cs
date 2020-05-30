using System;
using System.Collections.Generic;
using System.Text;
using E_hotel_implementacija.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_hotel_implementacija.Data
{
    public class ApplicationDbContext : IdentityDbContext<Korisnik>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
//Add-Migration PromijenjenUser -Context E_hotel_implementacija.Data.ApplicationDbContext