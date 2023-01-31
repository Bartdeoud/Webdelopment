using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DonerenController : ControllerBase
{
    private DBContext _context;
    public DonerenController(DBContext context){
        this._context = context;
    }

    //POST api/<PayController>
    [HttpPost]
    public async Task<IActionResult> Post(string bedrag , [FromForm] string token)
    {

        Console.WriteLine(bedrag);

        using StringContent jsonContent = new(
        JsonSerializer.Serialize(new
        {
            Doel = 74,
            Hoeveelheid = bedrag,
            Tekst = "Donatie aan SIM"
        }),
        Encoding.UTF8,
        "application/json");

        HttpClient client = new HttpClient();

        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

        var response = await client.PostAsync("https://ikdoneer.azurewebsites.net/api/donatie", jsonContent);

        var responseString = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseString);

        return Redirect("http://localhost:3000/Doneren?");
    }
}

public class values{
    public string? header{get;set;}
    public string? value{get;set;}

    public values(string header, string value){
        this.header = header;
        this.value = value;
    }
}