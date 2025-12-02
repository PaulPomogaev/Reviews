using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Review.Domain.Helper;
using Review.Domain.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Review.Domain
{
    public class DataBaseContext: DbContext
    {

        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Models.Review> Reviews { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
            try
            {
                Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database creation warning: {ex.Message}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Review>()
                .Property(r => r.Status)
                .HasDefaultValue(Status.Actual);

            modelBuilder.Entity<Models.Review>()
                .Property(r => r.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Models.Review>()
                .HasQueryFilter(r => !r.IsDeleted);

            modelBuilder.Entity<Models.Review>()
                .HasOne(p => p.Rating)
                .WithMany(t => t.Reviews)
                .HasForeignKey(p => p.RatingId)
                .OnDelete(DeleteBehavior.Cascade);

            var Feedbacks = Initialization.SetFeedbacks();
            var Rating = Initialization.SetRatings();

            modelBuilder.Entity<Models.Review>().HasData(Feedbacks);
            modelBuilder.Entity<Rating>().HasData(Rating);

            Login[] login = Initialization.SetLogins();
            modelBuilder.Entity<Login>().HasData(login);
        }
    }
}
