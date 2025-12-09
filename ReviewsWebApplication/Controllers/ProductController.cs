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

        /// <summary>
        /// Получение рейтингов нескольких товаров по списку ID
        /// </summary>
        /// <returns>Список рейтингов с ProductId</returns>
        [HttpGet("ratings")]
        public async Task<ActionResult<List<ProductRatingDtoWithId>>> GetProductRatings([FromQuery] string ids)
        {
            if(string.IsNullOrWhiteSpace(ids))
            {
                return BadRequest("Параметр запроса не содержит 'ids'");
            }

            var idStrings = ids.Split(',', StringSplitOptions.RemoveEmptyEntries);
            var productIds = new List<int>();

            foreach(var idString in idStrings)
            {
                if (int.TryParse(idString.Trim(), out var id) && id > 0)
                {
                    productIds.Add(id);
                }
            }

            if (productIds.Count == 0)
            {
                return BadRequest("Не предоставлено валидных ID продуктов.");
            }

            var allReviews = await _reviewService.GetAllAsync();
            var actualReviews = allReviews.Where(r => r.Status == Status.Actual && productIds.Contains(r.ProductId)).ToList();

            var result = productIds.Select(productId =>
            {
                var reviewsForProduct = actualReviews.Where(r => r.ProductId == productId).ToList();
                return new ProductRatingDtoWithId
                {
                    ProductId = productId,
                    Rating = reviewsForProduct.Any() ? Math.Round(reviewsForProduct.Average(r => r.Grade), 2) : 0,
                    ReviewCount = reviewsForProduct.Count
                };
            }).ToList();

            return Ok(result);

        }
    }
}
