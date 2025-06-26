using System.ComponentModel.DataAnnotations;

namespace Leaderboard.Models
{
    public class LeaderboardEntry
    {
        public int Id { get; set; }
        [Required]
        public string? Username { get; set; }
        [Range(0, int.MaxValue)]
        public int Score { get; set; }
        [Display(Name = "Date Achieved")]
        public DateTime DateAchieved { get; set; } = DateTime.UtcNow;
    }
}
