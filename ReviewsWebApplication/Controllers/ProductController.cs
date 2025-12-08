using Microsoft.AspNetCore.Mvc;
using Review.Domain.Models;
using Review.Domain.Services;
using ReviewsWebApplication.Dto;

namespace ReviewsWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ProductController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        /// <summary>
        /// Получение рейтинга по запросу
        /// </summary>
        /// <returns>Рейтинг товавра по productId.</returns>
        [HttpGet("{productId}/rating")]
        public async Task<ActionResult<ProductRatingDto>> GetProductRating(int productId)
        {
            var reviews = await _reviewService.GetByProductIdAsync(productId);
            var actual = reviews.Where(r => r.Status == Status.Actual);
            return new ProductRatingDto
            {
                Rating = actual.Any() ? Math.Round(actual.Average(r => r.Grade), 2) : 0,
                ReviewCount = actual.Count()
            };
        }
    }
}
