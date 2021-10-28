using BrainyTrainy.Domain.Entities;
using System.Collections.Generic;

namespace BrainyTrainy.Domain.Interfaces
{
    public interface IGameHistoryRepository:IBaseRepository<GameHistory, int>
    {
        List<GameHistory> GetGameHistories(int userId);
    }
}
