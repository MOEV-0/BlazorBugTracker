using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorBugTracker.Data;    // <-- Make sure this matches your namespace
using BlazorBugTracker.Models; // <-- Update if needed

namespace BlazorBugTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BugsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BugsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/bugs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bug>>> GetBugs()
        {
            return await _context.Bugs.ToListAsync();
        }

        // POST: api/bugs
        [HttpPost]
        public async Task<ActionResult<Bug>> PostBug(Bug bug)
        {
            _context.Bugs.Add(bug);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBugs), new { id = bug.Id }, bug);
        }
    }
}
