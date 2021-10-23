namespace BrainyTrainy.Domain
{
    public interface IUnitOfWork
    {
        IGameRepository GameRepository { get; }

        void Save();

        void Dispose();
    }
}