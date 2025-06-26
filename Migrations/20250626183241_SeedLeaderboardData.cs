using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leaderboard.Migrations
{
    /// <inheritdoc />
    public partial class SeedLeaderboardData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeaderboardEntries",
                columns: new[] { "Id", "DateAchieved", "Score", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9800, "ShadowStrike" },
                    { 2, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8700, "PixelNinja" },
                    { 3, new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9200, "CodeCrusader" },
                    { 4, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8600, "NullPointer" },
                    { 5, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8900, "StackBlazer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaderboardEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaderboardEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaderboardEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LeaderboardEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LeaderboardEntries",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
