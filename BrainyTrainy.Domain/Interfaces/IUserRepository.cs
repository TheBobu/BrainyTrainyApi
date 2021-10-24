using BrainyTrainy.Domain.Entities;

namespace BrainyTrainy.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User, int>
    {
        User GetUserByEmail(string email);
    }
}