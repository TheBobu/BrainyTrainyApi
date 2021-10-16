using System.ComponentModel.DataAnnotations;
using System.Security;

namespace BrainyTrainy.Data.Entities
{
    public class User
    {
        [Required]
        public string Email { get; set; }

        public PersonInfo Info { get; set; }

        [Required]
        public SecureString Password { get; set; }

        public int UserId { get; set; }
    }
}