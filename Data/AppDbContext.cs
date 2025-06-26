using Leaderboard.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Leaderboard.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaderboardEntry> LeaderboardEntries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LeaderboardEntry>().HasData(
                new LeaderboardEntry { Id = 1, Username = "ShadowStrike", Score = 9800, DateAchieved = new DateTime(2025, 6, 20) },
                new LeaderboardEntry { Id = 2, Username = "PixelNinja", Score = 8700, DateAchieved = new DateTime(2025, 6, 21) },
                new LeaderboardEntry { Id = 3, Username = "CodeCrusader", Score = 9200, DateAchieved = new DateTime(2025, 6, 22) },
                new LeaderboardEntry { Id = 4, Username = "NullPointer", Score = 8600, DateAchieved = new DateTime(2025, 6, 18) },
                new LeaderboardEntry { Id = 5, Username = "StackBlazer", Score = 8900, DateAchieved = new DateTime(2025, 6, 19) }
            );
        }

    }
}
