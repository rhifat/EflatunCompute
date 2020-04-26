using System;
using System.Collections.Generic;
using System.Text;
using EflatunCompute.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EflatunCompute.Persistence
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OdemeKaydi> OdemeKaydis { get; set; }
        public DbSet<Personel> Personels { get; set; }        



    }
}
