#nullable disable
using Microsoft.EntityFrameworkCore;

namespace LotteryAnalysisApp.Data
{
    public class LotteryContext : DbContext
    {
        public DbSet<LotteryDraw> LotteryDraws { get; set; }

        public LotteryContext(DbContextOptions<LotteryContext> options) : base(options)
        {
        }
    }
}
#nullable enable