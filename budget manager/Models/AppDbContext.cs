using Microsoft.EntityFrameworkCore;

namespace BudgetManager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
   public DbSet<Expenses> Expenses { get; set; }

    }
}