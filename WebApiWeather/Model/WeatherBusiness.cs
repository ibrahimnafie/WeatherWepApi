using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWeather.Model
{
    public class WeatherBusiness
    {
        private static readonly string[] Summaries = new[]
          {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public static WeatherForecast GetDayWeather(int dayorder)
        {
            var rng = new Random();
            var oneday = new WeatherForecast
            {
                Date = DateTime.Now.AddDays(dayorder),
                Summary = Summaries[rng.Next(Summaries.Length)],
                TemperatureC = rng.Next(-20, 55),
            };
            return oneday;
        }
    }
}
