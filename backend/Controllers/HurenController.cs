using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/[controller]")]

[ApiController]
public class HurenController : ControllerBase
{
    private DBContext _context;
    public HurenController(DBContext context){
        this._context = context;
    }

    // GET: api/Huren
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Huren>>> getReserveringen()
    {
        if (_context.reserveringen == null)
        {
            return Problem(statusCode:404);
        }
        return _context.reserveringen.ToList();

    }

    //POST api/Huren
    [HttpPost]
    public async Task<ActionResult<Huren>> PostReservering(Huren reservering)
    {
            if (_context.reserveringen == null)
            {
                return Problem(statusCode:400);
            }
            _context.reserveringen.Add(reservering);
            await _context.SaveChangesAsync();
            return NoContent();
    }
    //PUT api/<PayController>/id
    [HttpPut("{id}")]
    public void PutHuren(int id, [FromBody] string value)
    {
    }
}
