using BrainyTrainy.Domain.Interfaces;

namespace BrainyTrainy.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IGameRepository GameRepository { get; }
        IUserRepository UserRepository { get; }
        IPersonInfoRepository PersonInfoRepository { get; }
        IGameProgressRepository GameProgressRepository { get; }
        IGameHistoryRepository GameHistoryRepository { get; }
        void Save();

        void Dispose();
    }
}