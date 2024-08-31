using Microsoft.AspNetCore.Mvc;
using TodoApi.Services;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/v1/weather-forcast")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching",
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private IWeatherForcastService _iWeatherForcastService;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IWeatherForcastService iWeatherForcastService
    )
    {
        _logger = logger;
        this._iWeatherForcastService = iWeatherForcastService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return _iWeatherForcastService.displayWeatherForcast();
    }

    [Route("buddy")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<String> PostBuddyAdd([FromBody] String body)
    {
        return CreatedAtAction(nameof(PostBuddyAdd), new { id = "1020" }, body);
    }

    [HttpPut("{id}")]
    public ActionResult PutTodoItem(long id)
    {
        return NoContent();
    }
}
