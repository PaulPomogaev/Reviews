using Review.Domain.Models;

namespace Review.Domain.Services
{
    public interface IReviewService
    {
        /// <summary>
        /// Получение всех отзывов по продукту
        /// </summary>
        /// <returns>Список отзывов.</returns>
        Task<List<Models.Review>> GetAllReviewsAsync();

        /// <summary>
        /// Получение отзывов по Id продукта
        /// </summary>
        /// <param name="productId">Id продукта</param>
        /// <returns>Список отзывов с Id продукта.</returns>
        Task<List<Models.Review>> GetReviewsByProductIdAsync(int productId);

        /// <summary>
        /// Получение отзывов по Id отзыва
        /// </summary>
        /// <param name="reviewId">Id отзыва</param>
        /// <returns>Список отзывов по Id отзыва</returns>
        Task<Models.Review?> GetReviewByIdAsync(int reviewId);

        /// <summary>
        /// Удаление отзыва
        /// </summary>
        /// <param name="reviewId">Id отзыва</param>
        /// <returns></returns>
        Task<bool> TryToDeleteReviewAsync(int reviewId, string deletedBy = "system", string? reason = null);
    }
}
