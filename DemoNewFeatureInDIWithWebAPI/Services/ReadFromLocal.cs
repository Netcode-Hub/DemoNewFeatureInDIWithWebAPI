namespace DemoNewFeatureInDIWithWebAPI.Services
{
    public class ReadFromLocal : IRead
    {
        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            string[] Summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];
            return Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
