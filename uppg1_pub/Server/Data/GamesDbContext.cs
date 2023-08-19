using Microsoft.EntityFrameworkCore;
using uppg1_pub.Server.Data.Models;

namespace uppg1_pub.Server.Data
{
    public class GamesDbContext : DbContext
    {
        public GamesDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<GamesModel> GamesTable { get; set; }
        public DbSet<GenreModel> GenreTable { get; set; }

    }
}
