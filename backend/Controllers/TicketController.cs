using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketController : ControllerBase{
    private readonly DBContext _context;

    public TicketController(DBContext context){
        _context = context;
    }

    // GET: api/Ticket
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ticket>>> Gettickets(){
        if (_context.tickets == null){
            return NotFound();
        }
        return await _context.tickets.ToListAsync();
    }

    // GET: api/Ticket/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Ticket>> GetTicket(int id){
        if (_context.tickets == null){
            return NotFound();
        }
        var ticket = await _context.tickets.FindAsync(id);

        if (ticket == null){
            return NotFound();
        }
        return ticket;
    }

    // PUT: api/Ticket/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTicket(int id, Ticket ticket){
        if (id != ticket.TicketID){
            return BadRequest();
        }
        _context.Entry(ticket).State = EntityState.Modified;

        try{
            await _context.SaveChangesAsync();
        }catch (DbUpdateConcurrencyException){
            if (!TicketExists(id)){
                return NotFound();
            }else{
                throw;
            }
        }
        return NoContent();
    }

    // POST: api/Ticket
    [HttpPost]
    public async Task<ActionResult<Ticket>> PostTicket(Ticket ticket){
        if (_context.tickets == null){
            return Problem("Entity set 'DBContext.tickets'  is null.");
        }
        _context.tickets.Add(ticket);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetTicket", new { id = ticket.TicketID }, ticket);
    }

    // DELETE: api/Ticket/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTicket(int id){
        if (_context.tickets == null){
            return NotFound();
        }
        var ticket = await _context.tickets.FindAsync(id);

        if (ticket == null){
            return NotFound();
        }
        _context.tickets.Remove(ticket);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    private bool TicketExists(int id){
        return (_context.tickets?.Any(e => e.TicketID == id)).GetValueOrDefault();
    }
}

