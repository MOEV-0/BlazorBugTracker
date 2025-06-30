using Microsoft.EntityFrameworkCore;
using BlazorBugTracker.Data;
using BlazorBugTracker.Models;

namespace BlazorBugTracker.Services
{
    public class BugService : IBugService
    {
        private readonly ApplicationDbContext _context;

        public BugService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Bug>> GetBugsAsync()
        {
            return await _context.Bugs.OrderByDescending(b => b.CreatedAt).ToListAsync();
        }
    }
}
