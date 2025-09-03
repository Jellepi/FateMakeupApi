using Microsoft.EntityFrameworkCore;

namespace FateMakeupApi.Data
{
    public class MakeupDBContext(DbContextOptions<MakeupDBContext> options) : DbContext(options)
    {
        public DbSet<Makeup> Makeups => Set<Makeup>();
    }
}
