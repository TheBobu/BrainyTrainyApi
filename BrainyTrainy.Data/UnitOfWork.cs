using BrainyTrainy.Domain;
using BrainyTrainy.Domain.Interfaces;

namespace BrainyTrainy.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BrainyTrainyContext brainyTrainyContext;
        private IGameRepository gameRepository;
        private IUserRepository userRepository;
        private IPersonInfoRepository personInfoRepository;
        public IGameRepository GameRepository => gameRepository ??= new GameRepository(brainyTrainyContext);
        public IUserRepository UserRepository => userRepository ??= new UserRepository(brainyTrainyContext);
        public IPersonInfoRepository PersonInfoRepository => personInfoRepository ??= new PersonInfoRepository(brainyTrainyContext);

        public UnitOfWork(BrainyTrainyContext brainyTrainyContext)
        {
            this.brainyTrainyContext = brainyTrainyContext;
        }

        public void Save()
        {
            brainyTrainyContext.SaveChanges();
        }

        public void Dispose()
        {
            brainyTrainyContext.Dispose();
        }
    }
}