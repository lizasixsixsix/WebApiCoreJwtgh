using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiCoreJwt.Models;

namespace WebApiCoreJwt.Entities
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }

        private static string GetConnectionString()
        {
            return @"Server=(localdb)\v11.0;Database=WebApiCoreJwt;Trusted_Connection=True;";
        }

        public DbSet<Fruit> Fruits { get; set; }
    }
}
