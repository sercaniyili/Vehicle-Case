using Alphastellar.Case.CoreLayer.DTOs.Bus;

namespace Alphastellar.Case.CoreLayer.Interfaces.Services
{
    public interface IBusService
    {
        Task<IEnumerable<GetBusesDto>> GetBusesByColorAsync(string color);
        Task<IEnumerable<GetBusesDto>> GetAllBusesAsync();
    }
}
