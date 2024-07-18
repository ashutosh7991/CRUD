using Microsoft.EntityFrameworkCore;
namespace FirstApp.Entities
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor that takes DbContextOptions as a parameter
        // DbSet property for Employees entity
        public DbSet<Employee> Employees { get; set; }

        // Primary constructor that initializes the base DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
    
}
