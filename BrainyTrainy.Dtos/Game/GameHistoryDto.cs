using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyTrainy.Dtos.Game
{
    public class GameHistoryDto
    {
        public DateTime AddedDate { get; set; }

        public int GameHistoryId { get; set; }
        public int GameId { get; set; }
        public GameDto Game { get; set; }
        public int Score { get; set; }

        public TimeSpan TimeCompleted { get; set; }

        public int UserId { get; set; }
    }
}
