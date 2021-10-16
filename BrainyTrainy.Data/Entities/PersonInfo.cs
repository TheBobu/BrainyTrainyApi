using System.ComponentModel.DataAnnotations;

namespace BrainyTrainy.Data.Entities
{
    public class PersonInfo
    {
        public string Address { get; set; }
        public int Age { get; set; }

        [Required]
        public string ContactPersonName { get; set; }

        [Required]
        public string ContactPersonNumber { get; set; }

        [Required]
        public string FullName { get; set; }

        public int PersonInfoId { get; set; }
    }
}