using Microsoft.EntityFrameworkCore;
using MA.Models; 

namespace MA.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } 
        public DbSet<PresenceViewModel> Presences { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PresenceViewModel>()
                .HasOne(p => p.Student)
                .WithMany(s => s.Presences)
                .HasForeignKey(p => p.StudentId);
        }
    }
}
