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
        EvenementHandler evenementHandler = new EvenementHandler();
        return JsonSerializer.Serialize(evenementHandler.GetEvenementen());
    }

    //POST api/<Show>
    [HttpPost("add_show")]
    public async Task<IResult> Post(Show newShow)
    {
        bool returnShowBool = await ShowHandler.addGebruikerAsync(newShow);

        if (returnShowBool)
        {
            return Results.Ok("Success");
        }
        else
        {
            return Results.BadRequest();
        }
    }
}