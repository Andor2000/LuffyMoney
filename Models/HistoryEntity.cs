namespace LuffyMoney.Models
{
    public class HistoryEntity
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор игрока.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        /// Игрок.
        /// </summary>
        public PlayerEntity Player { get; set; }

        /// <summary>
        /// Дата.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Признак покупки золота.
        /// </summary>
        public bool IsBuyGold {  get; set; }

        /// <summary>
        /// Количество.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Получено ЧМ.
        /// </summary>
        public int GetChM { get; set; }
    }
}
