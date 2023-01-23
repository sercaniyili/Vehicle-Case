using Alphastellar.Case.CoreLayer.Entities.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Alphastellar.Case.WebApı.Controllers
{

    public static class ControllerExtension
    {
        public static IActionResult BuildListResult<T>(this ControllerBase controllerBase, IEnumerable<T> list)
        {
            if (list.Count() > 0)
                return controllerBase.Ok(list);
            else
                return controllerBase.NotFound(list);
        }

        public static bool IsColorInvalid(this ControllerBase controllerBase, string color)
        {
            var colors = Enum.GetNames(typeof(Colors)).Select(x => x.ToLower());

            return !colors.Contains(color.ToLower());
        }
    }
}
