namespace TodoApi.Services;

public interface IWeatherForcastService
{
    public IEnumerable<WeatherForecast> displayWeatherForcast();
}
