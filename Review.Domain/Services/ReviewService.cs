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

        public async Task<List<Models.Review>> GetAllReviewsAsync()
        {
            return await _databaseContext.Reviews.Include(f => f.Rating).ToListAsync();
        }

        public async Task<List<Models.Review>> GetReviewsByProductIdAsync(int productId)
        {
            return await _databaseContext.Reviews.Where(x => x.ProductId == productId).Include(f => f.Rating).ToListAsync();
        }

        public async Task<Models.Review?> GetReviewByIdAsync(int reviewId)
        {
            return await _databaseContext.Reviews.Include(f => f.Rating).FirstOrDefaultAsync(review => review.Id == reviewId);
        }

        public async Task<bool> TryToDeleteReviewAsync(int reviewId)
        {
                var review = await _databaseContext.Reviews.FirstOrDefaultAsync(review => review.Id == reviewId);

                if(review == null)
                {
                    return false;
                }

                _databaseContext.Reviews.Remove(review);
                await _databaseContext.SaveChangesAsync();
                return true;
        }
    }
}
