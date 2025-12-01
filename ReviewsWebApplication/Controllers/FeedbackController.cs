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
    public class FeedbackController : ControllerBase
    {

        private readonly ILogger<FeedbackController> _logger;
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(ILogger<FeedbackController> logger, IFeedbackService feedbackService)
        {
            _logger = logger;
            _feedbackService = feedbackService;
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
                        
            if(feedback == null)
            {
                _logger.LogWarning($"Отзыв с ID={id} не найден");
                return NotFound();
            }
            return Ok(feedback);
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
        [HttpPost("AddFeedback")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Feedback>> AddFeedbackAsync([FromBody] AddFeedbackRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _feedbackService.AddFeedbackAsync(request);
            
            _logger.LogInformation($"Отзыв с ID продукта={request.ProductId} добавлен");
            return Created($"/Feedback/GetFeedback/{result.Id}", result);
        }
    }
}