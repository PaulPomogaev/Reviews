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

        private bool _isDeleted = false;
        private Status _status = Status.Actual;

        /// <summary>
        /// Состояние отзыва (удалён-не удалён)
        /// </summary>
        /// <remarks>
        /// Автоматически синхронизируется со свойством <see cref="Status"/>.
        /// При установке <c>IsDeleted = true</c> → <c>Status = Status.Deleted</c>.
        /// При установке <c>IsDeleted = false</c> → <c>Status = Status.Actual</c>.
        /// </remarks>
        public bool IsDeleted 
        { 
            get => _isDeleted; 
            set
            {
                _isDeleted = value;
                _status = value ? Status.Deleted : Status.Actual;
            }
        }

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
        /// Id рейтинга
        /// </summary>
        public int RatingId { get; set; }

        /// <summary>
        /// Рейтинг
        /// </summary>
        public Rating? Rating { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        /// <remarks>
        /// Автоматически синхронизируется со свойством <see cref="IsDeleted"/>.
        /// При установке <c>Status = Status.Deleted</c> → <c>IsDeleted = true</c>.
        /// При установке <c>Status = Status.Actual</c> → <c>IsDeleted = false</c>.
        /// </remarks>
        public Status Status
        {
            get => _status;
            set
            {
                _status = value;
                _isDeleted = value == Status.Deleted;
            }
        }
    }
}

