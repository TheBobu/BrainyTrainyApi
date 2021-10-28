using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyTrainy.Data
{
    public class GameHistoryRepository : BaseRepository<GameHistory, int>, IGameHistoryRepository
    {
        public GameHistoryRepository(BrainyTrainyContext dbContext) : base(dbContext)
        {
        }
    }
}
