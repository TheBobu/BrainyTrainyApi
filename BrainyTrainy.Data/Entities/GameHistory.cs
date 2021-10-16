using System;
using System.ComponentModel.DataAnnotations;

namespace BrainyTrainy.Data.Entities
{
    public class GameHistory
    {
        [Required]
        public DateTime AddedDate { get; set; }

        public Game Game { get; set; }
        public int GameHistoryId { get; set; }

        [Required]
        public int GameId { get; set; }

        [Required]
        public int Score { get; set; }

        public TimeSpan TimeCompleted { get; set; }
        public User User { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}