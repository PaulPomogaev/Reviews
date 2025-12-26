using Review.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Review.Domain.Models.Dto;

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

            if (review == null)
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

        public async Task<List<ProductRatingDtoWithId>> GetProductRatingsByProductIdsAsync(List<int> productIds)
        {
            if(productIds == null || productIds.Count == 0)
            {
                return new List<ProductRatingDtoWithId>();
            }

            var result = await _databaseContext.Reviews.Where(r => r.Status == Status.Actual && productIds.Contains(r.ProductId)).GroupBy(r => r.ProductId)
                .Select(g => new ProductRatingDtoWithId
                {
                   ProductId = g.Key,
                   Rating = Math.Round(g.Average(r => (double)r.Grade), 2),
                   ReviewCount = g.Count()
                })
                 .ToListAsync();

            var missingIds = productIds.Except(result.Select(x => x.ProductId)).ToList();
            result.AddRange(missingIds.Select(id => new ProductRatingDtoWithId
            {
                ProductId = id,
                Rating = 0,
                ReviewCount = 0
            }));

            return result.OrderBy(x => productIds.IndexOf(x.ProductId)).ToList();
        }
    }
}