using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShowController : ControllerBase
{
    private readonly ILogger<ShowController> _logger;

    public ShowController(ILogger<ShowController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{showNaam}")]
    public String GetEvenementen(string showNaam)
    {
        if(showNaam.Equals("0")){
        return JsonSerializer.Serialize(ShowHandler.GetShows());
        }else{
        return JsonSerializer.Serialize(ShowHandler.GetShowByName(showNaam));
        }
    }

    [HttpPost ("ShowToevoegen")]
    public void PostEvenement([FromBody] Show show)
    {
        ShowHandler.AddShow(show);
    }

    [HttpGet("getLastShowID")]
    public int GetLastEvenementID(){
        return ShowHandler.GetLastEvenementID();
    }
}