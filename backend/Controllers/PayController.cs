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

        SessionId sessionId = _context.sessionIds.First(s => s.Session.Equals(reference));
        MailService.sendMail(sessionId.email ?? "");
        _context.sessionIds.Remove(sessionId);
        await _context.SaveChangesAsync();
        return Redirect("http://localhost:3000/ticket?succes=" + succes);
    }

    // GET: api/
    [HttpGet("getSessionId")]
    public async Task<string> getSessionId(string email)
    {
        string session = SessionIdCreator.HashString();
        _context.sessionIds.Add(new SessionId(){Session=session, email=email});
        await _context.SaveChangesAsync();
        return session;
    }
}