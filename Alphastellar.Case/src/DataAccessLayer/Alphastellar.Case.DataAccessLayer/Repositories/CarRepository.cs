using Alphastellar.Case.CoreLayer.Entities;
using Alphastellar.Case.CoreLayer.Interfaces.Repositories;
using Alphastellar.Case.DataAccessLayer.Context;

namespace Alphastellar.Case.DataAccessLayer.Repositories
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(AppDbContext appDbContext) : base(appDbContext) { }

    }
}
