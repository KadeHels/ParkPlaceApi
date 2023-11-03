namespace ParkPlaceApi.Services
{
    public interface IWeatherForcastService
    {
        public IList<WeatherForecast> GetWeatherForcast();
    }
}
