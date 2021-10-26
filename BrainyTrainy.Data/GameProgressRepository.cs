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
        public GameProgress GetGameProgressById(int id)
        {
            return DbContext.Set<GameProgress>().FirstOrDefault(x => x.GameId == id);
        }

        IGameProgressRepository IGameProgressRepository.GetGameProgressById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
