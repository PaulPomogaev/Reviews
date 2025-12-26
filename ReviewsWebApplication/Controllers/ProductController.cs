using Microsoft.AspNetCore.Mvc;
using Review.Domain.Models;
using Review.Domain.Models.Dto;
using Review.Domain.Services;

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
            var productIds = idStrings.Select(s => s.Trim()).Where(s => int.TryParse(s, out _)).Select(int.Parse).Where(id => id > 0).Distinct().ToList();

            
            if (productIds.Count == 0)
            {
                return BadRequest("Не предоставлено валидных ID продуктов.");
            }

            var result = await _reviewService.GetProductRatingsByProductIdsAsync(productIds);

            return Ok(result);

        }
    }
}
