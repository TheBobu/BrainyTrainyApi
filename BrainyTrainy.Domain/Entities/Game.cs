using BrainyTrainy.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BrainyTrainy.Domain.Entities
{
    public class Game
    {
        [Required]
        public GameType Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}