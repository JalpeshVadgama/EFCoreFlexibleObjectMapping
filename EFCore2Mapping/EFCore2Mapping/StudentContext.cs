using Microsoft.EntityFrameworkCore;

namespace EFCore2Mapping
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Test;Initial Catalog=Student;User ID=sa;Password=Jalpesh@123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property<string>("Division").HasField("_division");
            modelBuilder.Entity<Student>().Property<string>("Standard").HasField("_standard");
        }
    }
}
