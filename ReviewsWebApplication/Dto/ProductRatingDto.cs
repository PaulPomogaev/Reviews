using Review.Domain.Models;

namespace ReviewsWebApplication.Dto
{
    public class ProductRatingDto
    {
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
    }
}
