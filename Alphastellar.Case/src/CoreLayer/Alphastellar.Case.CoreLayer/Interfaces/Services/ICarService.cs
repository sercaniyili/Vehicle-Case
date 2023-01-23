using Alphastellar.Case.CoreLayer.DTOs.Car;

namespace Alphastellar.Case.CoreLayer.Interfaces.Services
{
    public interface ICarService
    {
        Task<IEnumerable<GetCarsDto>> GetAllCarsAsync();
        Task<AddCarDto> AddAsync(AddCarDto model);
        Task<bool> DeleteAsync(int id);
        Task<UpdateCarHeadlightsDto> TurnHeadLights(int id, bool onOff);
        Task<IEnumerable<GetCarsDto>> GetCarsByColorAsync(string color);
    }
}
