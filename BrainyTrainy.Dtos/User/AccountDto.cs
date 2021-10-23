namespace BrainyTrainy.Dtos.User
{
    public class AccountDto
    {
        public UserDto User { get; set; }
        public string AuthorizationToken { get; set; }
    }
}