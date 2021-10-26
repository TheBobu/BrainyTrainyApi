using BrainyTrainy.Dtos.User;

namespace BrainyTrainy.BusinessLogic.Interfaces
{
    public interface IUserBusinessLogic
    {
        AccountDto AuthenticateUser(LoginDto login);
        bool Register(UserDto userDto);
        UserDto GetUserInfo(int id);
    }
}