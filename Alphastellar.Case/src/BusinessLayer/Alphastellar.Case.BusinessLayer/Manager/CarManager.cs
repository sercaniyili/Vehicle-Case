using Alphastellar.Case.CoreLayer.DTOs.Car;
using Alphastellar.Case.CoreLayer.Entities;
using Alphastellar.Case.CoreLayer.Interfaces.Repositories;
using Alphastellar.Case.CoreLayer.Interfaces.Services;
using AutoMapper;

namespace Alphastellar.Case.BusinessLayer.Manager
{
    public class CarManager : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarManager(ICarRepository carRepository, IMapper mapper) => (_carRepository, _mapper) = (carRepository, mapper);


        public async Task<AddCarDto> AddAsync(AddCarDto model)
        {
            var car = _mapper.Map<Car>(model);
            car.Color = car.Color.ToLower();
            var mappedCar = await _carRepository.AddAsync(car);
            var result = _mapper.Map<AddCarDto>(mappedCar);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _carRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<GetCarsDto>> GetAllCarsAsync()
        {
            var cars = await _carRepository.GetAllAsync();
            var mappedCars = cars.Select(_mapper.Map<Car, GetCarsDto>);
            return mappedCars;
        }

        public async Task<IEnumerable<GetCarsDto>> GetCarsByColorAsync(string color)
        {
            var cars = await _carRepository.GetByColorAsync(color);
            var mappedCars = _mapper.Map<IEnumerable<GetCarsDto>>(cars);
            return mappedCars;
        }

        public async Task<UpdateCarHeadlightsDto> TurnHeadLights(int id, bool onOff)
        {
            var car = await _carRepository.GetDefault(x => x.Id == id);
            car.Headlights = onOff;
            _carRepository.Update(car);
            var mappedCar = _mapper.Map<UpdateCarHeadlightsDto>(car);
            return mappedCar;
        }
    }
}
