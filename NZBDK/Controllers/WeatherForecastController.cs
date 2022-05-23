using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZBDK.Data;
using NZBDK.Models;

namespace NZBDK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly NzbdkDBContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, NzbdkDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Sygnature? Get()
        {
            return _context.Sygnatures.FirstOrDefault();
        }
    }
}