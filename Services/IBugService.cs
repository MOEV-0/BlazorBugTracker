using BlazorBugTracker.Models;

namespace BlazorBugTracker.Services
{
    public interface IBugService
    {
        Task<List<Bug>> GetBugsAsync();
    }
}
