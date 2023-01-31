using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReviewController : ControllerBase{
    private readonly DBContext _context;

    public ReviewController(DBContext context){
        _context = context;
    }

    // GET: api/Review
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Review>>> GetReview(){
        if (_context.Review == null){
            return NotFound();
        }
        return await _context.Review.ToListAsync();
    }

    // GET: api/Review/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Review>> GetReview(int id){
        if (_context.Review == null){
            return NotFound();
        }
        var review = await _context.Review.FindAsync(id);

        if (review == null){
            return NotFound();
        }
        return review;
    }

    // PUT: api/Review/5
    [HttpPut("{id}")]
    [Authorize(Roles ="Admin, Medewerker")]
    public async Task<IActionResult> PutReview(int id, Review review){
        if (id != review.reviewId){
            return BadRequest();
        }
        _context.Entry(review).State = EntityState.Modified;

        try{
            await _context.SaveChangesAsync();
        }catch (DbUpdateConcurrencyException){
            if (!ReviewExists(id)){
                return NotFound();
            }else{
                throw;
            }
        }
        return NoContent();
    }

    // POST: api/Review
    [HttpPost]
    [Authorize(Roles ="Admin, Medewerker")]
    public async Task<ActionResult<Review>> PostReview(Review review){
        if (_context.Review == null){
            return Problem("Entity set 'DBContext.Review'  is null.");
        }
        _context.Review.Add(review);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetReview", new { id = review.reviewId }, review);
    }

    // DELETE: api/Review/5
    [HttpDelete("{id}")]
    [Authorize(Roles ="Admin, Medewerker")]
    public async Task<IActionResult> DeleteReview(int id){
        if (_context.Review == null){
            return NotFound();
        }
        var review = await _context.Review.FindAsync(id);

        if (review == null){
            return NotFound();
        }
        _context.Review.Remove(review);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    private bool ReviewExists(int id){
        return (_context.Review?.Any(e => e.reviewId == id)).GetValueOrDefault();
    }
}

