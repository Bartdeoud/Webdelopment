using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeeftijdsGroepController : ControllerBase
    {
        private readonly DBContext _context;

        public LeeftijdsGroepController(DBContext context)
        {
            _context = context;
        }

        // GET: api/LeeftijdsGroep
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Leeftijdsgroep>>> Getleeftijdsgroepen()
        {
          if (_context.leeftijdsgroepen == null)
          {
              return NotFound();
          }
            return await _context.leeftijdsgroepen.ToListAsync();
        }

        // GET: api/LeeftijdsGroep/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Leeftijdsgroep>> GetLeeftijdsgroep(int id)
        {
          if (_context.leeftijdsgroepen == null)
          {
              return NotFound();
          }
            var leeftijdsgroep = await _context.leeftijdsgroepen.FindAsync(id);

            if (leeftijdsgroep == null)
            {
                return NotFound();
            }

            return leeftijdsgroep;
        }

        // GET: api/LeeftijdsGroep/Show/1
        [HttpGet("Show/{id}")]
        public async Task<ActionResult<Leeftijdsgroep>> GetLeeftijdsgroepShow(int id)
        {
            if (_context.leeftijdsgroepen == null){
                return NotFound();
            }

            var show = await _context.shows.FindAsync(id);
            if (show == null){
                return NotFound();
            }

            var leeftijdsgroep = await _context.leeftijdsgroepen.FindAsync(show.Leeftijdsgroep);
            if (leeftijdsgroep == null){
                return NotFound();
            }

            return leeftijdsgroep;
        }


        // PUT: api/LeeftijdsGroep/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLeeftijdsgroep(int id, Leeftijdsgroep leeftijdsgroep)
        {
            if (id != leeftijdsgroep.LeeftijdsgroepID)
            {
                return BadRequest();
            }

            _context.Entry(leeftijdsgroep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeeftijdsgroepExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LeeftijdsGroep
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Leeftijdsgroep>> PostLeeftijdsgroep(Leeftijdsgroep leeftijdsgroep)
        {
          if (_context.leeftijdsgroepen == null)
          {
              return Problem("Entity set 'DBContext.leeftijdsgroepen'  is null.");
          }
            _context.leeftijdsgroepen.Add(leeftijdsgroep);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLeeftijdsgroep", new { id = leeftijdsgroep.LeeftijdsgroepID }, leeftijdsgroep);
        }

        // DELETE: api/LeeftijdsGroep/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeeftijdsgroep(int id)
        {
            if (_context.leeftijdsgroepen == null)
            {
                return NotFound();
            }
            var leeftijdsgroep = await _context.leeftijdsgroepen.FindAsync(id);
            if (leeftijdsgroep == null)
            {
                return NotFound();
            }

            _context.leeftijdsgroepen.Remove(leeftijdsgroep);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LeeftijdsgroepExists(int id)
        {
            return (_context.leeftijdsgroepen?.Any(e => e.LeeftijdsgroepID == id)).GetValueOrDefault();
        }
    }
}
