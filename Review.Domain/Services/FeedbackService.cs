using Review.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Review.Domain.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly DataBaseContext _databaseContext;

        public FeedbackService(DataBaseContext databaseContext)
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
                var review = await databaseContext.Feedbacks.FirstOrDefaultAsync(feedback => feedback.Id == feedbackId);

                if(feedback == null)
                {
                    return false;
                }

                databaseContext.Feedbacks.Remove(review);
                await databaseContext.SaveChangesAsync();
                return true;
        }

    }
}
