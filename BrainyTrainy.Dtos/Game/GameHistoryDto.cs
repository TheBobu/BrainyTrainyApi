using System;

namespace BrainyTrainy.Dtos.Game
{
    public class GameHistoryDto
    {
        public DateTime AddedDate { get; set; }
        public int GameHistoryId { get; set; }
        public int GameId { get; set; }
        public GameDto Game { get; set; }
        public int Score { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int UserId { get; set; }
    }
}