using BrainyTrainy.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BrainyTrainy.Data.Entities
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