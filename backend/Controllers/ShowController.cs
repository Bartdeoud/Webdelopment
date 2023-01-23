using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShowController : ControllerBase
{
    public static DBContext _context = new DBContext();

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Show>>> getShows()
    {
        if (_context.shows == null)
          {
              return NotFound();
          }
            return await _context.shows.ToListAsync();
    }

    [HttpGet("usingId{id}")]

    public async Task<ActionResult<Show>> GetShowUsingId(int id)
    {
        if (_context.shows == null)
        {
            return NotFound();
        }
        var show = await _context.shows.FindAsync(id);

        if (show == null)
        {
            return NotFound();
        }

        return show;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Show>> GetShowUsingName(String name)
    {
        if (_context.shows == null)
        {
            return NotFound();
        }
        var show = await _context.shows.FindAsync(name);
        if (show == null)
        {
            return NotFound();
        }
        return show;
    }

    [HttpPost]
    public async Task<ActionResult<Show>> PostShow(Show show)
    {
        if (_context.shows == null)
        {
            return Problem("Entity set 'DBcontext.shows'  is null.");
        }
        _context.shows.Add(show);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetShow", new { id = show.Shownr }, show);
    }
}