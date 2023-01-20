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

    [HttpGet(Name = "Evenementen")]
    public String GetEvenementen()
    {
        EvenementHadler evenementHadler = new EvenementHadler();
        return JsonSerializer.Serialize(evenementHadler.GetEvenementen());
    }
}