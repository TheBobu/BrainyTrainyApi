using BrainyTrainy.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BrainyTrainy.Domain.Entities
{
    public class Game
    {
        public int GameId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public GameType Type { get; set; }
    }
}