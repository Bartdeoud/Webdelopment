using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class EvenementController : ControllerBase
{

    private readonly ILogger<EvenementController> _logger;

    public EvenementController(ILogger<EvenementController> logger)
    {
        _logger = logger;
    }



    [HttpGet(Name = "Evenement/{evenementNaam}")]
    public String GetEvenementen(string evenementNaam)
    {
        return JsonSerializer.Serialize(ShowHandler.GetShowByName(evenementNaam));
    }
}