using System;

namespace BrainyTrainy.Dtos.Game
{
    public class GameProgressDto
    {
        public int AverageScore { get; set; }
        public string Game { get; set; }
        public int GameProgressId { get; set; }
        public DateTime Week { get; set; }
    }
}
