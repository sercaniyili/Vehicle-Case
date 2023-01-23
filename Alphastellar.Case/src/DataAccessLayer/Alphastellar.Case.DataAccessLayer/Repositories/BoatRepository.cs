using Alphastellar.Case.CoreLayer.Entities;
using Alphastellar.Case.CoreLayer.Interfaces.Repositories;
using Alphastellar.Case.DataAccessLayer.Context;

namespace Alphastellar.Case.DataAccessLayer.Repositories
{
    public class BoatRepository : BaseRepository<Boat>, IBoatRepository
    {
        public BoatRepository(AppDbContext appDbContext) : base(appDbContext) { }
    }
}
