using System;
using System.ComponentModel.DataAnnotations;

namespace BrainyTrainy.Data.Entities
{
    public class GameProgress
    {
        [Required]
        public int AverageScore { get; set; }

        public TimeSpan AverageTime { get; set; }
        public Game Game { get; set; }

        [Required]
        public int GameId { get; set; }

        public int GameProgressId { get; set; }
        public User User { get; set; }

        [Required]
        public int UserId { get; set; }

        public DateTime Week { get; set; }
    }
}