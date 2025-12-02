using Microsoft.EntityFrameworkCore;
using Review.Domain.Helper;
using Review.Domain.Models;

namespace Review.Domain
{
    public class DataBaseContext: DbContext
    {

        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Models.Review> Reviews { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Review>()
                 .HasQueryFilter(r => r.Status == Status.Actual);

            modelBuilder.Entity<Models.Review>()
                .HasOne(p => p.Rating)
                .WithMany(t => t.Reviews)
                .HasForeignKey(p => p.RatingId)
                .OnDelete(DeleteBehavior.Cascade);

            var reviews = Initialization.SetReviews();
            var rating = Initialization.SetRatings();

            modelBuilder.Entity<Models.Review>().HasData(reviews);
            modelBuilder.Entity<Rating>().HasData(rating);

            Login[] login = Initialization.SetLogins();
            modelBuilder.Entity<Login>().HasData(login);
        }
    }
}
