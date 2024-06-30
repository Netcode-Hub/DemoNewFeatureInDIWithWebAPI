using DemoNewFeatureInDIWithWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace DemoNewFeatureInDIWithWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastOption1Controller(
        [FromKeyedServices("LocalRead")] IRead readLocal,
        [FromKeyedServices("ExternalRead")] IRead readExternal) : ControllerBase
    {

        [HttpGet("Local")]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> Local()
        {
            return Ok(await readLocal.GetForecastAsync());
        }

        [HttpGet("External")]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> External()
        {
            return Ok(await readExternal.GetForecastAsync());
        }
    }
}

