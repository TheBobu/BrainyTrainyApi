using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Interfaces;
using System.Linq;

namespace BrainyTrainy.Data
{
    public class PersonInfoRepository : BaseRepository<PersonInfo, int>, IPersonInfoRepository
    {
        public PersonInfoRepository(BrainyTrainyContext brainyTrainyContext) : base(brainyTrainyContext)
        {
        }
    }
}