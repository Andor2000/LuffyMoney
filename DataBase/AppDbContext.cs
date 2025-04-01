using LuffyMoney.Models;
using Microsoft.EntityFrameworkCore;

namespace LuffyMoney.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<PlayerEntity> Players { get; set; }
        public DbSet<HistoryEntity> Histories { get; set; }
        public DbSet<SettingEntity> Settings{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // База данных лежит рядом с .exe
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.sqlite");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
