using Mandala.Models;
using Microsoft.EntityFrameworkCore;

namespace Mandala.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Computer> Computers { get; set; } = null!;
        public DbSet<Classroom> Classrooms { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Subject> Subjects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Mandala;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(d => d.Role)
                .WithOne(p => p.User)
                .HasForeignKey<User>(d => d.RoleId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(d => d.Computer)
                .WithOne(p => p.User)
                .HasForeignKey<User>(d => d.ComputerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Computer>()
                .HasOne(d => d.Classroom)
                .WithMany(p => p.Computers)
                .HasForeignKey(d => d.ClassroomId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Subject>()
                .HasOne(d => d.Computer)
                .WithMany(p => p.Subjects)
                .HasForeignKey(d => d.ComputerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}