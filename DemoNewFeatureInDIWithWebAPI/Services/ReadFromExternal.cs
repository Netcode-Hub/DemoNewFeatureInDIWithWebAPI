namespace DemoNewFeatureInDIWithWebAPI.Services
{
    public class ReadFromExternal(HttpClient httpClient) : IRead
    {
        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
        {
            await Task.Delay(4000);
            var weatherData = await httpClient
                  .GetFromJsonAsync<IEnumerable<WeatherForecast>>("https://localhost:7198/weatherforecast");
            return weatherData!;
        }
    }
}
