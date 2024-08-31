namespace TodoApi.Services.Impl;

public class WeatherForcastServiceImpl : IWeatherForcastService
{
    private Dictionary<int, string> mp = new Dictionary<int, string>();

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

    public Dictionary<int, string> getMap()
    {
        return mp;
    }
}
