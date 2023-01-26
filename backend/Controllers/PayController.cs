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
    public async Task<IActionResult> Post([FromForm] bool succes, [FromForm] string reference)
    {
        if(!succes || !_context.sessionIds.Contains(new SessionId(){Session=reference}))
            return Redirect("http://localhost:3000/ticket?succes=False");
        _context.sessionIds.Remove(new SessionId(){Session=reference});
        await _context.SaveChangesAsync();
        return Redirect("http://localhost:3000/ticket?succes=" + succes);
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