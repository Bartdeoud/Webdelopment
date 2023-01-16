using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger; 

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public String Get()
    {
        DBConnect dBConnect = new DBConnect();
        dBConnect.open_connection();
        return "Gelukt!!";
    }

    [HttpGet(Name = "GetEvenementen")]
    public List<EvenementHadler> GetEvenementen()
    {
        return EvenementHadler.GetEvenementen();
    }
}