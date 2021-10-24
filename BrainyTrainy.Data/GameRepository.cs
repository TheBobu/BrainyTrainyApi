using BrainyTrainy.Domain;
using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Interfaces;

namespace BrainyTrainy.Data
{
    public class GameRepository : BaseRepository<Game, int>, IGameRepository
    {
        public GameRepository(BrainyTrainyContext brainyTrainyContext) : base(brainyTrainyContext)
        {
        }
    }
}