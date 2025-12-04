using Review.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Review.Domain.Services
{
    public class ReviewService : IReviewService
    {
        private readonly DataBaseContext _databaseContext;

        public ReviewService(DataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<Models.Review>> GetAllAsync()
        {
            return await _databaseContext.Reviews.ToListAsync();
        }

        public async Task<List<Models.Review>> GetByProductIdAsync(int productId)
        {
            return await _databaseContext.Reviews.Where(x => x.ProductId == productId).ToListAsync();
        }

        public async Task<Models.Review?> GetByIdAsync(int reviewId)
        {
            return await _databaseContext.Reviews.FirstOrDefaultAsync(review => review.Id == reviewId);
        }

        public async Task<bool> DeleteAsync(int reviewId, string deletedBy = "system", string? reason = null)
        {
                var review = await _databaseContext.Reviews.FirstOrDefaultAsync(review => review.Id == reviewId);

                if(review == null)
                {
                    return false;
                }

            review.Status = Status.Deleted;
            review.DeletedAt = DateTime.UtcNow;
            review.DeletedBy = deletedBy;
            review.DeleteReason = reason;

            await _databaseContext.SaveChangesAsync();
                return true;
        }

        public async Task<(double Rating, int ReviewCount)> GetProductRatingAsync(int productId)
        {
            var actualReviews = await _databaseContext.Reviews.Where(r => r.ProductId == productId && r.Status == Status.Actual).ToListAsync();

            var count = actualReviews.Count;

            var rating = count > 0 ? Math.Round(actualReviews.Average(r => r.Grade), 2) : 0.0;

            return (rating, count);
        }
    }
}
