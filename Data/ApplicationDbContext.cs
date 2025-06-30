using Microsoft.EntityFrameworkCore;
using BlazorBugTracker.Models;

namespace BlazorBugTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Bug> Bugs { get; set; }
    }
}
