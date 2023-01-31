using Microsoft.AspNetCore.Mvc;

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
    public IActionResult Post([FromForm] string token)
    {
        Console.WriteLine(token);
        return Redirect("http://localhost:3000/Doneren??token=" + token);
    }
}