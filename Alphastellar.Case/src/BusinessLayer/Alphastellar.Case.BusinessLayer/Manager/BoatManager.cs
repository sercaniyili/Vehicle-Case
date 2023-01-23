using Alphastellar.Case.CoreLayer.DTOs.Boat;
using Alphastellar.Case.CoreLayer.Entities;
using Alphastellar.Case.CoreLayer.Interfaces.Repositories;
using Alphastellar.Case.CoreLayer.Interfaces.Services;
using AutoMapper;

namespace Alphastellar.Case.BusinessLayer.Manager
{
    public class BoatManager : IBoatService
    {

        private readonly IBoatRepository _boatRepository;
        private readonly IMapper _mapper;

        public BoatManager(IBoatRepository boatRepository, IMapper mapper) => (_boatRepository, _mapper) = (boatRepository, mapper);

        public async Task<IEnumerable<GetBoatsDto>> GetBoatsByColorAsync(string color)
        {
            var boats = await _boatRepository.GetByColorAsync(color);
            var mappedBoats = _mapper.Map<IEnumerable<GetBoatsDto>>(boats);
            return mappedBoats;
        }

        public async Task<IEnumerable<GetBoatsDto>> GetAllBoatsAsync()
        {
            var boats = await _boatRepository.GetAllAsync();
            var mappedBoats = boats.Select(_mapper.Map<Boat, GetBoatsDto>);
            return mappedBoats;
        }


    }
}
