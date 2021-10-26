using System.Linq;
using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Interfaces;

namespace BrainyTrainy.Data
{
    public class GameProgressRepository : BaseRepository<GameProgress, int>, IGameProgressRepository
    {
        public GameProgressRepository(BrainyTrainyContext brainyTrainyContext) : base(brainyTrainyContext)
        {

        }
}
