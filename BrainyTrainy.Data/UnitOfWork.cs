using BrainyTrainy.Domain;

namespace BrainyTrainy.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BrainyTrainyContext brainyTrainyContext;
        private IGameRepository gameRepository;
        public IGameRepository GameRepository => gameRepository ??= new GameRepository(brainyTrainyContext);

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