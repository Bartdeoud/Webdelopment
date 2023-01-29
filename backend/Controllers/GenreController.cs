using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly DBContext _context;

        public GenreController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Genre
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> Getgenres()
        {
          if (_context.genres == null)
          {
              return NotFound();
          }
            return await _context.genres.ToListAsync();
        }

        // GET: api/Genre/Show/1
        [HttpGet("Show/{id}")]
        public async Task<ActionResult<Genre>> GetGenreShow(int id)
        {
            if (_context.genres == null){
                return NotFound();
            }

            var show = await _context.shows.FindAsync(id);
            if (show == null){
                return NotFound();
            }

            var genre = await _context.genres.FindAsync(show.Genre);
            if (genre == null){
                return NotFound();
            }
            
            return genre;
            
        }

        // GET: api/Genre/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> GetGenre(int id)
        {
          if (_context.genres == null)
          {
              return NotFound();
          }
            var genre = await _context.genres.FindAsync(id);

            if (genre == null)
            {
                return NotFound();
            }

            return genre;
        }

        // PUT: api/Genre/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles ="Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenre(int id, Genre genre)
        {
            if (id != genre.GenreID)
            {
                return BadRequest();
            }

            _context.Entry(genre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenreExists(id))
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

        // POST: api/Genre
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult<Genre>> PostGenre(Genre genre)
        {
          if (_context.genres == null)
          {
              return Problem("Entity set 'DBContext.genres'  is null.");
          }
            _context.genres.Add(genre);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGenre", new { id = genre.GenreID }, genre);
        }

        // DELETE: api/Genre/5
        [HttpDelete("{id}")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            if (_context.genres == null)
            {
                return NotFound();
            }
            var genre = await _context.genres.FindAsync(id);
            if (genre == null)
            {
                return NotFound();
            }

            _context.genres.Remove(genre);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GenreExists(int id)
        {
            return (_context.genres?.Any(e => e.GenreID == id)).GetValueOrDefault();
        }
    }
}
