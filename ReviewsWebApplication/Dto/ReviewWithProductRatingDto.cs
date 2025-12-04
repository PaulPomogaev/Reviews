using Review.Domain.Models;

namespace ReviewsWebApplication.Dto
{
    public class ReviewWithProductRatingDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string? Text { get; set; }
        public int Grade { get; set; }
        public DateTime CreateDate { get; set; }
        public Status Status { get; set; }
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
    }
}
