using Leaderboard.Data;
using Leaderboard.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Leaderboard.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class LeaderboardController : ControllerBase
    {
        private readonly AppDbContext _context;
        public LeaderboardController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("submit")]
        public async Task<IActionResult> SubmitScore([FromBody] LeaderboardEntry entry)
        {
            if (entry == null || string.IsNullOrEmpty(entry.Username) || entry.Score < 0)
            {
                return BadRequest("Invalid leaderboard entry.");
            }
            _context.LeaderboardEntries.Add(entry);
            await _context.SaveChangesAsync();
            return Ok("Score submitted successfully.");
        }

        [HttpGet("scores")]
        public IActionResult GetTopScores()
        {
            var topScores = _context.LeaderboardEntries
                .OrderByDescending(e => e.Score)
                .ThenByDescending(e => e.DateAchieved)
                .Take(10)
                .ToList();

            if (topScores.Count == 0)
            {
                return NotFound("No scores found.");
            }
            return Ok(topScores);
        }

    }
}
