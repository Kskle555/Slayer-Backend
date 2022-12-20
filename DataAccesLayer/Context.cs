
using Microsoft.EntityFrameworkCore;

namespace Fansub.DataAccesLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-01QE6IC;database=FansubAPI; integrated security=true; TrustServerCertificate=True");
        }
        public DbSet<Anime> Animes { get; set; }

    }
}
