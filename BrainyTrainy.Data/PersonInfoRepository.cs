using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Interfaces;

namespace BrainyTrainy.Data
{
    public class PersonInfoRepository : BaseRepository<PersonInfo, int>, IPersonInfoRepository
    {
        public PersonInfoRepository(BrainyTrainyContext brainyTrainyContext) : base(brainyTrainyContext)
        {
        }
    }
}