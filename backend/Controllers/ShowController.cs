using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EvenementController : ControllerBase
{

    private readonly ILogger<EvenementController> _logger;

    public EvenementController(ILogger<EvenementController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Evenement/{evenementNaam}")]
    public string GetEvenementen(string evenementNaam)
    {
        if(evenementNaam.Equals("0")){
        return JsonSerializer.Serialize(ShowHandler.GetEvenementen());
        }
        return JsonSerializer.Serialize(ShowHandler.GetShowByName(evenementNaam));
    }
}