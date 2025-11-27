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
        /// <returns>Список отзывов.</returns>
        [HttpGet("GetAllReviewsAsync")]
        public async Task<ActionResult<List<Feedback>>> GetAllReviewsAsync()
        {
            try
            {
                var result = await _reviewService.GetAllReviewsAsync();
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }

        /// <summary>
        /// Получение отзывов по Id продукта
        /// </summary>
        /// <returns>Список отзывов с Id продукта.</returns>
        [HttpGet("GetFeedbacksByProductId")]
        public async Task<ActionResult<List<Feedback>>> GetFeedbacksByProductIdAsync(int productId)
        {
            try
            {
                var result = await _reviewService.GetFeedbacksByProductIdAsync(productId);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }

        /// <summary>
        /// Получение отзывов по Id отзыва
        /// </summary>
        /// <returns>Список отзывов по Id отзыва</returns>
        [HttpGet("GetReview")]
        public async Task<ActionResult<List<Feedback>>> GetReviewAsync(int feedbackId)
        {
            try
            {
                var result = await _reviewService.GetReviewAsync(feedbackId);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }

        /// <summary>
        /// Удаляет отзыв по id
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpDelete("DeleteReview")]
        public async Task<ActionResult<List<Feedback>>> DeleteReviewAsync(int id)
        {
            try
            {
                var result = await _reviewService.TryToDeleteReviewAsync(id);
                if(result)
                    return Ok();
                return BadRequest(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }
    }
}