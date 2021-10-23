using System.ComponentModel.DataAnnotations;

namespace BrainyTrainy.Domain.Entities
{
    public class User
    {
        [Required]
        public string Email { get; set; }

        public PersonInfo Info { get; set; }

        [Required]
        public string Password { get; set; }

        public int UserId { get; set; }
    }
}