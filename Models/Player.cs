namespace LuffyMoney.Models
{
    /// <summary>
    /// Игрок.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Nick { get; set; } = string.Empty;

        /// <summary>
        /// Куплено золото.
        /// </summary>
        public int BuyGold { get; set; }

        /// <summary>
        /// Потрачено чм.
        /// </summary>
        public int SpentChM { get; set; }

        /// <summary>
        /// Доступно чм.
        /// </summary>
        public int AvailableChm { get; set; }
    }
}
