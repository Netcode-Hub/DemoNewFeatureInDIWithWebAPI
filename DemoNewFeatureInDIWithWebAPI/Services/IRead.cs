namespace DemoNewFeatureInDIWithWebAPI.Services
{
    public interface IRead
    {
        Task<IEnumerable<WeatherForecast>> GetForecastAsync();
    }
}
