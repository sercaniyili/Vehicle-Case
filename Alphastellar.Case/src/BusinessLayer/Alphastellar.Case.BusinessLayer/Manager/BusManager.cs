using Alphastellar.Case.CoreLayer.DTOs.Bus;
using Alphastellar.Case.CoreLayer.Entities;
using Alphastellar.Case.CoreLayer.Interfaces.Repositories;
using Alphastellar.Case.CoreLayer.Interfaces.Services;
using AutoMapper;

namespace Alphastellar.Case.BusinessLayer.Manager
{
    public class BusManager : IBusService
    {

        private readonly IBusRepository _busRepository;
        private readonly IMapper _mapper;

        public BusManager(IBusRepository busRepository, IMapper mapper) => (_busRepository, _mapper) = (busRepository, mapper);


        public async Task<IEnumerable<GetBusesDto>> GetBusesByColorAsync(string color)
        {
            var buses = await _busRepository.GetByColorAsync(color);
            var mappedBuses = _mapper.Map<IEnumerable<GetBusesDto>>(buses);
            return mappedBuses;
        }

        public async Task<IEnumerable<GetBusesDto>> GetAllBusesAsync()
        {
            var buses = await _busRepository.GetAllAsync();
            var mappedBuses = buses.Select(_mapper.Map<Bus, GetBusesDto>);
            return mappedBuses;
        }

    }
}
