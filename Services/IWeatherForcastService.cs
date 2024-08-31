namespace TodoApi.Services;

public interface IWeatherForcastService
{
    public IEnumerable<WeatherForecast> displayWeatherForcast();

    public Dictionary<int, string> getMap();
}
