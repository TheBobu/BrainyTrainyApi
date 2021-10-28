using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BrainyTrainy.Data
{
    public class GameHistoryRepository : BaseRepository<GameHistory, int>, IGameHistoryRepository
    {
        public GameHistoryRepository(BrainyTrainyContext dbContext) : base(dbContext)
        {
        }

        public List<GameHistory> GetGameHistories(int userId)
        {
            return DbContext.Set<GameHistory>().Where(x => x.UserId == userId).ToList();
        }
    }
}
