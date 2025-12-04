using Review.Domain.Models;

namespace Review.Domain.Services
{
    public interface IReviewService
    {
        /// <summary>
        /// Получение всех отзывов по продукту
        /// </summary>
        /// <returns>Список отзывов.</returns>
        Task<List<Models.Review>> GetAllAsync();

        /// <summary>
        /// Получение отзывов по Id продукта
        /// </summary>
        /// <param name="productId">Id продукта</param>
        /// <returns>Список отзывов с Id продукта.</returns>
        Task<List<Models.Review>> GetByProductIdAsync(int productId);

        /// <summary>
        /// Получение отзывов по Id отзыва
        /// </summary>
        /// <param name="reviewId">Id отзыва</param>
        /// <returns>Список отзывов по Id отзыва</returns>
        Task<Models.Review?> GetByIdAsync(int reviewId);

        /// <summary>
        /// Удаление отзыва
        /// </summary>
        /// <param name="reviewId">Id отзыва</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(int reviewId, string deletedBy = "system", string? reason = null);

    }
}
