using Alphastellar.Case.CoreLayer.DTOs.Car;
using Alphastellar.Case.CoreLayer.Entities;
using Alphastellar.Case.CoreLayer.Entities.Enums;
using Alphastellar.Case.CoreLayer.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Alphastellar.Case.WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService carManager;

        public CarController(ICarService carService) => (carManager) = (carService);

        /// <summary>
        /// Rengi girilen arabaları döndürür, renk boş bırakıldığında bütün arabaları döndürür.
        /// </summary>
        /// <param name="color">renk</param>
        /// <returns>arabalar</returns>
        [HttpGet]
        public async Task<IActionResult> GetCarsByColor([FromQuery] string? color)
        {
            IEnumerable<GetCarsDto> cars;

            if (color == null)
            {
                cars = await carManager.GetAllCarsAsync();
            }
            else
            {
                if (this.IsColorInvalid(color))
                    return BadRequest();
                cars = await carManager.GetCarsByColorAsync(color);
            }

            return this.BuildListResult(cars);
        }

        /// <summary>
        /// Araba ekler.
        /// </summary>
        /// <param name="model">araba</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddCar([FromBody] AddCarDto model)
        {
            var colors = Enum.GetNames(typeof(Colors)).Select(x => x.ToLower());

            if (!colors.Contains(model.Color.ToLower()))
                return BadRequest();

            var car = await carManager.AddAsync(model);
            return Ok();
        }

        /// <summary>
        /// Id'si girilen arabayı siler, id hatalıysa 404 döner.
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteCar([FromQuery] int id)
        {
            var success = await carManager.DeleteAsync(id);
            if (success)
                return Ok();
            else
                return NotFound();
        }

        /// <summary>
        /// Id'si girilen arabanın ışıkları açıp kapatır, id hatalıysa 404 döner.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="light">ışık</param>
        /// <returns>araba</returns>
        [HttpPost("{id}")]
        public async Task<IActionResult> TurnHeadLights([FromRoute] int id, [FromBody] Car.Light light)
        {

            var car = await carManager.TurnHeadLights(id, light.onOff);

            if (car != null)
                return Ok(car);
            else
                return NotFound();
        }

    }
}
