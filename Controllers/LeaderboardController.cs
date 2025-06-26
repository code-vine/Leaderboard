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

            foreach (var claim in User.Claims)
            {
                Console.WriteLine($"{claim.Type}: {claim.Value}");
            }
            if (entry == null || string.IsNullOrEmpty(entry.Username) || entry.Score < 0)
            {
                return BadRequest("Invalid leaderboard entry.");
            }
            _context.LeaderboardEntries.Add(entry);
            await _context.SaveChangesAsync();
            return Ok("Score submitted successfully.");
        }

        [HttpGet("ping")]
        public IActionResult Ping() => Ok("pong");

    }
}
