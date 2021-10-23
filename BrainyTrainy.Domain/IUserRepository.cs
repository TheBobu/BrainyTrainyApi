using BrainyTrainy.Domain.Entities;

namespace BrainyTrainy.Domain
{
    public interface IUserRepository : IBaseRepository<User, int>
    {
        User GetUserByEmail(string email);
    }
}