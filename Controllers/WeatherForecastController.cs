using Disclone.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Disclone.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    private WeatherContext context;


    public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherContext myContext)
    {
        _logger = logger;
        context = myContext;
    }

    [HttpGet]
    [Route("")]
    public IEnumerable<WeatherForecast> Get()
    {
        // var wf = new WeatherForecast
        // {
        //     Summary = "my summarys"
        // };
        // context.WeatherForecasts.Add(wf);
        // context.SaveChanges();

        return context.WeatherForecasts;
    }
}