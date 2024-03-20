using Microsoft.EntityFrameworkCore;

namespace TheWaterProject.Models
{
    public class WaterProjectContext : DbContext
    {
        public WaterProjectContext(DbContextOptions<WaterProjectContext> options) : base(options)      //constructor   liaison from app to database
        {
        }

        public DbSet<Project> Projects { get; set; }

    }
}
