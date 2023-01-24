using Alphastellar.Case.CoreLayer.DTOs.Bus;
using Alphastellar.Case.CoreLayer.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Alphastellar.Case.WebApı.Controllers
{
    [Route("api/buses")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService busManager;
        public BusController(IBusService busService) => (busManager) = (busService);


        /// <summary>
        /// Rengi girilen otobüsleri döndürür, renk boş bırakıldığında bütün otobüs döndürür.
        /// </summary>
        /// <param name="color">renk</param>
        /// <returns>otobüs</returns>
        [HttpGet]
        public async Task<IActionResult> GetBusessByColor([FromQuery] string? color)
        {
            IEnumerable<GetBusesDto> buses;

            if (color == null)
            {
                buses = await busManager.GetAllBusesAsync();
            }
            else
            {
                if (this.IsColorInvalid(color))
                    return BadRequest();
                buses = await busManager.GetBusesByColorAsync(color);
            }

            return this.BuildListResult(buses);
        }
    }
}
