using lab1.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private Calculate calculate = new Calculate(0);

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet(Name = "GetWeatherForecast2")]
        public IEnumerable<WeatherForecast> Get2()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet(Name = "GetCalculate")]
        public int GetCalculate()
        {
           
            return calculate.GetValue();
        }

        //make post to set value
        [HttpPost(Name = "PostCalculate")]
        public int PostCalculateSetValue(int value)
        {

            calculate.SetValue(value);

            return calculate.GetValue();
        }

        [HttpPost(Name = "PostCalculateAdd")]
        public int PostCalculateAdd(int value)
        {
            

            calculate.SetValue(calculate.Add(value));

            return calculate.GetValue();
        }


        [HttpPost(Name = "PostCalculateSubtract")]
        public int PostCalculateSubtract(int value)
        {
          

            calculate.SetValue(calculate.Subtract(value));

            return calculate.GetValue();
        }

        [HttpGet(Name = "GetList")]
        public List<int> GetList()
        {
            var calculateInstanse1 = new Calculate(6);
            var calculateInstanse2 = new Calculate(3);

            return new List<int>() { calculateInstanse1.GetValue(), calculateInstanse2.GetValue() };
        }
    }
}