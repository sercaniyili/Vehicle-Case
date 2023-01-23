using Alphastellar.Case.CoreLayer.DTOs.Boat;
using Alphastellar.Case.CoreLayer.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Alphastellar.Case.WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {

        private readonly IBoatService boatManager;
        public BoatController(IBoatService boatService) => (boatManager) = (boatService);

        /// <summary>
        /// Rengi girilen tekneleri döndürür, renk boş bırakıldığında bütün tekneleri döndürür.
        /// </summary>
        /// <param name="color">renk</param>
        /// <returns>tekneler</returns>
        [HttpGet]
        public async Task<IActionResult> GetBoatsByColor([FromQuery] string? color)
        {
            IEnumerable<GetBoatsDto> boats;

            if (color == null)
            {
                boats = await boatManager.GetAllBoatsAsync();
            }
            else
            {
                if (this.IsColorInvalid(color))
                    return BadRequest();
                boats = await boatManager.GetBoatsByColorAsync(color);
            }
            return this.BuildListResult(boats);
        }

    }
}
