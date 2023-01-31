using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Identity;

namespace api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DonerenController : ControllerBase
{
    private DBContext _context;
    private readonly UserManager<Gebruiker> _userManager;
    private readonly SignInManager<Gebruiker> _signInManager;

    private List<string> roles = new List<string>(){"Default","Medewerker","Admin","Artiest","Donateur"};

    public DonerenController(DBContext context, UserManager<Gebruiker> userManager, SignInManager<Gebruiker> signInManager){
        _context = context;
        _userManager = userManager;
        _signInManager = signInManager;
    }


    // GET: api/
    [HttpPost("getSession")]
    public async Task<string> getSessionId(string Email, string bedrag)
    {
        string sessionId = SessionIdCreator.HashString(10);
        _context.sessionIds.Add(new SessionId(){Session=sessionId,expiration=DateTime.Now.AddMinutes(10),Data=bedrag,email=Email});
        await _context.SaveChangesAsync();
        Console.WriteLine("email: " + Email);
        Console.WriteLine("bedrag: " + bedrag);
        Console.WriteLine("sessionId: " + sessionId);
        return sessionId;
    }

    //POST api/<PayController>
    [HttpPost]
    public async Task<IActionResult> Post(string session, [FromForm] string token)
    {
        SessionId sessionId = _context.sessionIds.First(s => s.Session.Equals(session));

        using StringContent jsonContent = new(
        JsonSerializer.Serialize(new
        {
            Doel = 74,
            Hoeveelheid = sessionId.Data,
            Tekst = "Donatie aan SIM"
        }),
        Encoding.UTF8,
        "application/json");

        HttpClient client = new HttpClient();

        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

        var response = await client.PostAsync("https://ikdoneer.azurewebsites.net/api/donatie", jsonContent);

        var responseString = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseString);

        Gebruiker gebruiker = _context.gebruikers.First(g => g.Email.Equals(sessionId.email));

        if(responseString.Contains("Succes!"))
            gebruiker.TotaleDonatie += int.Parse(sessionId.Data);

        if(gebruiker.TotaleDonatie >= 5)
            await _userManager.AddToRoleAsync(gebruiker,"Donateur");
        

        await _context.SaveChangesAsync();
        return Redirect("http://localhost:3000/Doneren?");
    }
}