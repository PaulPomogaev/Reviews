using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Review.Domain.Models;
using Review.Domain.Services;
using ReviewsWebApplication.Dto;

namespace ReviewsWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
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
        [HttpGet]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> GetAllAsync()
        {
            var reviews = await _reviewService.GetAllAsync();
            return Ok(reviews);
        }

        /// <summary>
        /// Получение отзывов по Id продукта
        /// </summary>
        /// <returns>Список отзывов с Id продукта.</returns>
        [HttpGet("filter")]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> GetByProductIdAsync([FromQuery] int? productId = null)
        {
            if (!productId.HasValue)
            {
                return BadRequest("Не указан productId");
            }

            var reviews = await _reviewService.GetByProductIdAsync(productId.Value);
           return Ok(reviews);
        }

        /// <summary>
        /// Получение конкретного отзыва по уникальному Id
        /// </summary>
        /// <returns>Возвращает конкретный отзыв по Id</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Review.Domain.Models.Review>> GetByIdAsync(int id)
        {
            var review = await _reviewService.GetByIdAsync(id);
                        
            if(review == null)
            {
                _logger.LogWarning($"Отзыв с ID={id} не найден");
                return NotFound();
            }
            return Ok(review);
        }

        /// <summary>
        /// Удаляет отзыв по id отзыва (soft-delete)
        /// </summary>
        /// <returns>204 (успешно) или 404 (не найден).</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteAsync(int id, string deletedBy = "system", string? reason = null)
        {
           
            var result = await _reviewService.DeleteAsync(id, deletedBy, reason);
            if(!result)
            {
                _logger.LogWarning($"Попытка удаления несуществующего отзыва с ID={id}");
                return NotFound();
            }

            _logger.LogInformation($"Отзыв с с ID={id} успешно удалён");
            return NoContent();
        }

        /// <summary>
        /// Добавляет отзыв клиента
        /// </summary>
        /// <returns>201 (успешно) или 400 (не найден).</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Review.Domain.Models.Review>> AddAsync([FromBody] AddReviewRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var review = await _reviewService.AddAsync(request);

            _logger.LogInformation($"Отзыв с ID продукта={review.ProductId} добавлен");
            return Created($"/api/Review/{review.Id}", review);
        }
    }
}