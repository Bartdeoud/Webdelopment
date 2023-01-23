using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GebruikerController : ControllerBase
{
    public static DBContext _context = new DBContext();

    [HttpGet] // GET: api/Gebruiker
    public async Task<ActionResult<IEnumerable<Gebruiker>>> getShows()
    {
        if (_context.shows == null)
          {
              return NotFound();
          }
            return await _context.gebruikers.ToListAsync();
    }

    [HttpGet("{id}")] // GET: api/Gebruiker/5
    public async Task<ActionResult<Gebruiker>> GetShowUsingId(int id)
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
    
    [HttpPost] // POST: api/Gebruiker
    public async Task<ActionResult<Gebruiker>> PostShow(Gebruiker gebruiker)
    {
        if (_context.gebruikers == null)
        {
            return Problem("Entity set 'DBcontext.shows'  is null.");
        }
        _context.gebruikers.Add(gebruiker);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetShow", new { id = gebruiker.UserID }, gebruiker);
    }

    //PUT api/<Gebruiker/id
    [HttpPut ("{id}")]
    public async Task<IResult> Put(Gebruiker updateGebruiker)
    {
        bool updateGebruikerBool = await GebruikerHandler.updateGebruikerAsync(updateGebruiker);

        if (updateGebruikerBool)
        {
            return Results.Ok("Success");
        }
        else
        {
            return Results.BadRequest();
        }
    } 

    //DELETE api/<Gebruiker/id
    [HttpDelete("delete_gebruiker_with_id/{id}")]
    public async Task<IResult> Delete(int id)
    {
        bool deleteGebruikerBool = await GebruikerHandler.deleteGebruikerAsync(id);

        if (deleteGebruikerBool)
        {
            return Results.Ok("Success");
        }
        else
        {
            return Results.BadRequest();
        }
    }
}
