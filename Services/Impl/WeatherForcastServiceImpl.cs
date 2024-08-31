namespace TodoApi.Services.Impl;

public class WeatherForcastServiceImpl : IWeatherForcastService
{
    public IEnumerable<WeatherForecast> displayWeatherForcast()
    {
        return Enumerable
            .Range(1, 5)
            .Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary =
                    "" //Summaries[Random.Shared.Next(Summaries.Length)],
                ,
            })
            .ToArray();
    }
}
