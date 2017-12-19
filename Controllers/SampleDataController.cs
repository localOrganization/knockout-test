using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;

namespace knockout.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private const string forcast10day = "http://api.wunderground.com/api/14bbd739ef370568/forecast10day/q/OR/Sisters.json";

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet("[action]")]
        public TenDayForecast GetTenDayForecast()
        {
            string json = string.Empty;
            using (WebClient client = new WebClient())
            {
               json = client.DownloadString(new Uri(forcast10day));
            }

            var forecast = JsonConvert.DeserializeObject<TenDayForecast>(json);

            return forecast;
        }

        
    }
}
