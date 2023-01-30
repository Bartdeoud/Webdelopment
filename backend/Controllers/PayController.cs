using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

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
        try{
        var sessionIds = _context.sessionIds;
        foreach (var session in sessionIds)
        { 
            if(DateTime.Compare(session.expiration, DateTime.Now) < 0)
            _context.sessionIds.Remove(session);
        }

        SessionId sessionId = _context.sessionIds.First(s => s.Session.Equals(reference));

        if(succes)MailService.sendMail(sessionId.email ?? "",sessionId.ticketData ?? "");

        _context.sessionIds.Remove(sessionId);
        await _context.SaveChangesAsync();
        } catch{ succes = false; }
        return Redirect("http://localhost:3000/ticket?succes=" + succes);
    }

    // GET: api/
    [HttpGet("getSessionId")]
    public async Task<string> getSessionId(string email, string ticketData)
    {
        string session = SessionIdCreator.HashString();
        _context.sessionIds.Add(new SessionId(){Session=session, expiration=DateTime.Now.AddMinutes(5), email=email,ticketData=ticketData});
        await _context.SaveChangesAsync();
        return session;
    }
}