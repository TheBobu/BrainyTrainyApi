namespace BrainyTrainy.Domain
{
    public interface IUnitOfWork
    {
        IGameRepository GameRepository { get; }
        IUserRepository UserRepository { get; }

        void Save();

        void Dispose();
    }
}