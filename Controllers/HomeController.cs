using Leaderboard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Leaderboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var topScores = await _context.LeaderboardEntries
                .OrderByDescending(e => e.Score)
                .Take(10)
                .ToListAsync();

            return View(topScores);
        }
    }
}
