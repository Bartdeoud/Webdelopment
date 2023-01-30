using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShowController : ControllerBase{
    private DBContext _context;
    public ShowController(DBContext context){
        this._context = context;
    }

    // GET: api/Show
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Show>>> getShows(){
        if (_context.shows == null){
            return NotFound();
        }
        return await _context.shows.ToListAsync();
    }

    // GET: api/Show/5
    [HttpGet("usingId{id}")]
    public async Task<ActionResult<Show>> GetShowUsingId(int id){
        if (_context.shows == null){
            return NotFound();
        }
        var show = await _context.shows.FindAsync(id);

        if (show == null){
            return NotFound();
        }
        return show;
    }

    // POST: api/Show
    [HttpPost]
    [Authorize(Roles ="Admin, Medewerker")]
    public async Task<ActionResult<Show>> PostShow(Show show){
        if (_context.shows == null){
            return Problem("Entity set 'DBcontext.shows'  is null.");
        }
        _context.shows.Add(show);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetShow", new { id = show.Shownr }, show);
    }

    // DELETE: api/Show/5
    [HttpDelete("{id}")] 
    [Authorize(Roles ="Admin, Medewerker")]
    public async Task<ActionResult<Show>> DeleteShow(int id){
        if (_context.shows == null){
            return Problem("Entity set 'DBcontext.shows'  is null.");
        }
        var show = await _context.shows.FindAsync(id);
        
        if (show == null){
            return NotFound();
        }
        _context.shows.Remove(show);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // PUT: api/Show/5
    [HttpPut("{id}")]
    [Authorize(Roles ="Admin, Medewerker")]
    public async Task<IActionResult> PutShow(int id, Show show){
        if (id != show.Shownr){
            return BadRequest();
        }
        _context.Entry(show).State = EntityState.Modified;
        
        try{
            await _context.SaveChangesAsync();
        }catch (DbUpdateConcurrencyException){
            if (!ShowExists(id)){
                return NotFound();
            }else{
                throw;
            }
        }
        return NoContent();
    }

    private bool ShowExists(int id){
        if (_context.shows == null){
            return false;
        }else{
            return true;
        }
    }
}