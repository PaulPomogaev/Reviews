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
                var feedback = await databaseContext.Feedbacks.FirstOrDefaultAsync(feedback => feedback.Id == feedbackId);

                if(feedback == null)
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

        public async Task<Models.Review> AddAsync(AddReviewRequest request)
        {
            var review = new Models.Review
            {
                ProductId = request.ProductId,
                UserId = request.UserId,
                Text = request.Text,
                Grade = request.Grade,
                CreateDate = DateTime.UtcNow,
                Status = Status.Actual
            };

            _databaseContext.Reviews.Add(review);
            await _databaseContext.SaveChangesAsync();

            return review;
        }
    }
}