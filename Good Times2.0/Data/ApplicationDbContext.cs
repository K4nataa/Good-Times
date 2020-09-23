using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Good_Times2._0.Models;

namespace Good_Times2._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Good_Times2._0.Models.Reservering> Reservering { get; set; }
        public DbSet<Good_Times2._0.Models.Menukaart> Menukaart { get; set; }
        public DbSet<Good_Times2._0.Models.Product> Product { get; set; }
        public DbSet<Good_Times2._0.Models.MenuCategory> MenuCategory { get; set; }
    }
}
