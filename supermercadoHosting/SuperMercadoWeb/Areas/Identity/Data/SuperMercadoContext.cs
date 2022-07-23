using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SuperMercadoWeb.Data
{
    public class SuperMercadoContext : IdentityDbContext<IdentityUser>
    {
        public SuperMercadoContext(DbContextOptions<SuperMercadoContext> options)
            : base(options)
        {
        }
        public DbSet<IdentityRole> AspNetRoles { get; set; }
        public DbSet<IdentityUser> AspNetUsers { get; set; }
        public DbSet<IdentityUserRole<string>> AspNetUserRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
