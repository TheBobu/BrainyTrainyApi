using BrainyTrainy.Dtos.User;

namespace BrainyTrainy.BusinessLogic.Interfaces
{
    public interface IUserBusinessLogic
    {
        AccountDto AuthenticateUser(LoginDto login);
    }
}