using Microsoft.EntityFrameworkCore;
using KhumaloCraft.Entity;

namespace KhumaloCraft.DataLayer
{
    public class CraftDbContext : DbContext
    {
        public CraftDbContext(DbContextOptions options) :base(options) { }

        public DbSet<CraftDetailsEntity> CraftDetails { get; set; } 
    }
}
