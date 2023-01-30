using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ZaalController : ControllerBase{
    private readonly DBContext _context;

    public ZaalController(DBContext context){
        _context = context;
    }

    // GET: api/Zaal
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Zaal>>> Getzalen(){
        if (_context.zalen == null){
            return NotFound();
        }
        return await _context.zalen.ToListAsync();
    }

    // GET: api/Zaal/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Zaal>> GetZaal(int id){
        if (_context.zalen == null){
            return NotFound();
        }
        var zaal = await _context.zalen.FindAsync(id);

        if (zaal == null){
            return NotFound();
        }
        return zaal;
    }

    // GET: api/Zaal/Show/1
    [HttpGet("Show/{id}")]
    public async Task<ActionResult<Zaal>> GetZaalShow(int id){
        if (_context.zalen == null){
            return NotFound();
        }

        var show = await _context.shows.FindAsync(id);
        if (show == null){
            return NotFound();
        }

        var zaal = await _context.zalen.FindAsync(show.Zaal);
        if (zaal == null){
            return NotFound();
        }
        return zaal;
    }

    // PUT: api/Zaal/5
    [HttpPut("{id}")]
    [Authorize(Roles ="Admin")]
    public async Task<IActionResult> PutZaal(int id, Zaal zaal){
        if (id != zaal.Zaalnr){
            return BadRequest();
        }
        _context.Entry(zaal).State = EntityState.Modified;

        try{
            await _context.SaveChangesAsync();
        }catch (DbUpdateConcurrencyException){
            if (!ZaalExists(id)){
                return NotFound();
            }else{
                throw;
            }
        }
        return NoContent();
    }

    // POST: api/Zaal
    [HttpPost]
    [Authorize(Roles ="Admin")]
    public async Task<ActionResult<Zaal>> PostZaal(Zaal zaal){
        if (_context.zalen == null){
            return Problem("Entity set 'DBContext.zalen' is null.");
        }
        _context.zalen.Add(zaal);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetZaal", new { id = zaal.Zaalnr }, zaal);
    }

    // DELETE: api/Zaal/5
    [HttpDelete("{id}")]
    [Authorize(Roles ="Admin")]
    public async Task<IActionResult> DeleteZaal(int id){
        if (_context.zalen == null){
            return NotFound();
        }
        var zaal = await _context.zalen.FindAsync(id);
        if (zaal == null){
            return NotFound();
        }

        _context.zalen.Remove(zaal);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    private bool ZaalExists(int id){
        return (_context.zalen?.Any(e => e.Zaalnr == id)).GetValueOrDefault();
    }
}
