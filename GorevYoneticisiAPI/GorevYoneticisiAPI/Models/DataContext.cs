using Microsoft.EntityFrameworkCore;

namespace GorevYoneticisiAPI.Models
{
    public class DataContext:DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Server=DESKTOP-NP35580;Database=TaskManager;Trusted_Connection=true");
        }
    }
}
