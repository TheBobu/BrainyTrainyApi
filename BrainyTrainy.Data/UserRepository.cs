using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Interfaces;
using System.Linq;

namespace BrainyTrainy.Data
{
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        public UserRepository(BrainyTrainyContext brainyTrainyContext) : base(brainyTrainyContext)
        {
        }

        public User GetUserByEmail(string email)
        {
            return DbContext.Set<User>().FirstOrDefault(x => x.Email == email);
        }
    }
}