using Microsoft.AspNetCore.Mvc;

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
    public List<Evenement> GetEvenementen()
    {
        EvenementHadler evenementHadler = new EvenementHadler();
        return evenementHadler.GetEvenementen();
    }
}