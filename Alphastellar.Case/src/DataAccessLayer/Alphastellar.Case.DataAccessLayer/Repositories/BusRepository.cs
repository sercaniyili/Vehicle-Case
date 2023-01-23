using Alphastellar.Case.CoreLayer.Entities;
using Alphastellar.Case.CoreLayer.Interfaces.Repositories;
using Alphastellar.Case.DataAccessLayer.Context;

namespace Alphastellar.Case.DataAccessLayer.Repositories
{
    public class BusRepository : BaseRepository<Bus>, IBusRepository
    {
        public BusRepository(AppDbContext appDbContext) : base(appDbContext) { }
    }
}
