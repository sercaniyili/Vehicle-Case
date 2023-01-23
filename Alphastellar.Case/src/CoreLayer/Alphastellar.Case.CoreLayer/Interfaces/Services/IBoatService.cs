using Alphastellar.Case.CoreLayer.DTOs.Boat;

namespace Alphastellar.Case.CoreLayer.Interfaces.Services
{
    public interface IBoatService
    {
        Task<IEnumerable<GetBoatsDto>> GetBoatsByColorAsync(string color);
        Task<IEnumerable<GetBoatsDto>> GetAllBoatsAsync();
    }
}
