using Microsoft.EntityFrameworkCore;
using Repository.Data.Configurations;
using Repository.Domain.Entities;

namespace Repository.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { }

        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
        }
        
    }
}
