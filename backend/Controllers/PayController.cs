using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/[controller]")]

[ApiController]
public class PayController : ControllerBase
{
    private DBContext _context;
    public PayController(DBContext context){
        this._context = context;
    }

    //POST api/<PayController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
        Console.WriteLine(value);
    }

    // GET: api/
    [HttpGet("getSessionId")]
    public async Task<string> getSessionId()
    {
        string session = SessionIdCreator.HashString();
        _context.sessionIds.Add(new SessionId(){Session=session});
        await _context.SaveChangesAsync();
        return session;
    }
}
