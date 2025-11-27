using Review.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Review.Domain.Services
{
    public class ReviewService : IReviewService
    {
        private readonly DataBaseContext databaseContext;

        public ReviewService(DataBaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public async Task<List<Feedback>> GetAllReviewsAsync()
        {
            return await databaseContext.Feedbacks.ToListAsync();
        }

        public async Task<List<Feedback>> GetFeedbacksByProductIdAsync(int productId)
        {
            return await databaseContext.Feedbacks.Where(x => x.ProductId == productId).ToListAsync();
        }

        public async Task<Feedback?> GetReviewByIdAsync(int feedbackId)
        {
            return await databaseContext.Feedbacks.FirstOrDefaultAsync(feedback => feedback.Id == feedbackId);
        }

        public async Task<bool> TryToDeleteReviewAsync(int feedbackId)
        {
                var review = await databaseContext.Feedbacks.FirstOrDefaultAsync(feedback => feedback.Id == feedbackId);

                if(review == null)
                {
                    return false;
                }

                databaseContext.Feedbacks.Remove(review);
                await databaseContext.SaveChangesAsync();
                return true;
        }
    }
}
