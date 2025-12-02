using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Review.Domain.Models;
using Review.Domain.Services;

namespace ReviewsWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ReviewController : ControllerBase
    {

        private readonly ILogger<ReviewController> _logger;
        private readonly IReviewService _reviewService;

        public ReviewController(ILogger<ReviewController> logger, IReviewService reviewService)
        {
            _logger = logger;
            _reviewService = reviewService;
        }

        /// <summary>
        /// Получает все отзывы (до 100 записей в текущей инициализации).
        /// </summary>
        /// <returns>Список всех отзывов.</returns>
        [HttpGet("GetAllReviewsAsync")]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> GetAllReviewsAsync()
        {
            var reviews = await _reviewService.GetAllReviewsAsync();
            return Ok(reviews);
        }

        /// <summary>
        /// Получение отзывов по Id продукта
        /// </summary>
        /// <returns>Список отзывов с Id продукта.</returns>
        [HttpGet("GetReviewsByProductId")]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> GetFeedbacksByProductIdAsync(int productId)
        {
           var reviews = await _reviewService.GetReviewsByProductIdAsync(productId);
           return Ok(reviews);
        }

        /// <summary>
        /// Получение конкретного отзыва по уникальному Id
        /// </summary>
        /// <returns>Возвращает конкретный отзыв по Id</returns>
        [HttpGet("GetReview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Review.Domain.Models.Review>> GetReviewAsync(int reviewId)
        {
            var review = await _reviewService.GetReviewByIdAsync(reviewId);
                        
            if(review == null)
            {
                _logger.LogWarning($"Отзыв с ID={reviewId} не найден");
                return NotFound();
            }
            return Ok(review);
        }

        /// <summary>
        /// Удаляет отзыв по id отзыва
        /// </summary>
        /// <returns>204 (успешно) или 404 (не найден).</returns>
        [HttpDelete("DeleteReview")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteReviewAsync(int reviewId)
        {
           
            var result = await _reviewService.TryToDeleteReviewAsync(reviewId);
            if(!result)
            {
                _logger.LogWarning($"Попытка удаления несуществующего отзыва с ID={reviewId}");
                return NotFound();
            }

            _logger.LogInformation($"Отзыв с с ID={reviewId} успешно удалён");
            return NoContent();
        }
    }
}