namespace Review.Domain.Models
{
    /// <summary>
    /// Отзыв
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Id отзыва
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id продукта
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Id пользователя, оставившего отзыв
        /// </summary>
        public int UserId { get; set; }

                
        /// <summary>
        /// Дата и время удаления отзыва
        /// </summary>
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Кем удалён отзыв
        /// </summary>
        public string? DeletedBy { get; set; }

        /// <summary>
        /// Причина удаления отзыва
        /// </summary>
        public string? DeleteReason { get; set; }

        /// <summary>
        /// Текст отзыва
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Оценка (количество звезд)
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDate { get; set; }
                
        /// <summary>
        /// Статус
        /// </summary>
        public Status Status { get; set; } = Status.Actual;

    }
}

