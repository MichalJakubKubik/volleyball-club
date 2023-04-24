using Microsoft.EntityFrameworkCore;
using MyApplication.Entities;

namespace MyApplication
{
    public class PendingMigrations
    {
        private readonly ClubDbContext _dbContext;

        public PendingMigrations(ClubDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void ActualMigrations()
        {
            var pendingMigrations = _dbContext.Database.GetPendingMigrations();
            if (pendingMigrations != null && pendingMigrations.Any())
            {
                _dbContext.Database.Migrate();
            }
        }
    }
}
