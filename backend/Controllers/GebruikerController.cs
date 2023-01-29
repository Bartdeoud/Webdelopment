using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GebruikerController : ControllerBase
{
    private DBContext _context;
    public GebruikerController(DBContext context){
        this._context = context;
    }

    // GET: api/Gebruiker
    [HttpGet] 
    public async Task<ActionResult<IEnumerable<Gebruiker>>> getGebruiker()
    {
        if (_context.shows == null)
          {
              return NotFound();
          }
            return await _context.gebruikers.ToListAsync();
    }

    // GET: api/Gebruiker/5
    [HttpGet("{id}")] 
    public async Task<ActionResult<Gebruiker>> GetGebruikerUsingId(int id)
    {
        if (_context.gebruikers == null)
        {
            return NotFound();
        }
        var gebruiker = await _context.gebruikers.FindAsync(id);

        if (gebruiker == null)
        {
            return NotFound();
        }
        return gebruiker;
    }
    
    // POST: api/Gebruiker
    [HttpPost] 
    public async Task<ActionResult<Gebruiker>> PostGebruiker(Gebruiker gebruiker)
    {
        if (_context.gebruikers == null)
        {
            return Problem("Entity set 'DBcontext.gebruikers'  is null.");
        }
        _context.gebruikers.Add(gebruiker);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetGebruiker", new { id = gebruiker.UserID }, gebruiker);
    }

    //PUT api/Gebruiker/5
    [HttpPut ("{id}")]
    public async Task<IActionResult> PutGebruiker(int id, Gebruiker gebruiker)
    {
        if (_context.gebruikers == null)
        {
            return Problem("Entity set 'DBcontext.gebruikers'  is null.");
        }
        if (id != gebruiker.UserID)
        {
            return BadRequest();
        }
        _context.Entry(gebruiker).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    } 

    private bool GebruikerExists(int id){
        return _context.gebruikers.Any(e => e.UserID == id);
    }

    // DELETE: api/Gebruiker/5
    [HttpDelete("{id}")] 
    public async Task<ActionResult<Show>> DeleteGebruiker(int id)
    {
        if (_context.gebruikers == null)
        {
            return Problem("Entity set 'DBcontext.gebruikers'  is null.");
        }
        var gebruiker = await _context.gebruikers.FindAsync(id);
        if (gebruiker == null)
        {
            return NotFound();
        }
        _context.gebruikers.Remove(gebruiker);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
