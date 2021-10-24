namespace BrainyTrainy.Dtos.User
{
    public class UserDto
    {
        public PersonInfoDto Info { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
    }
}