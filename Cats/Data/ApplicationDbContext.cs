using Cats.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cats.Data
{
    public class ApplicationDbContext : DbContext
    {
        private const string ConnectionString
            = @"Server=DESKTOP-13RHP0M\SQLEXPRESS;Database=Cats;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Cat> Cats{ get; set; }
        public DbSet<Owner> Owners{ get; set; }
    }
}
