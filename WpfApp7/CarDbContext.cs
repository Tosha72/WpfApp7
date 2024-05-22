using Microsoft.EntityFrameworkCore;

namespace AutoSalon
{
    public class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=AutoSalonDb;Trusted_Connection=True;");
        }
    }
}