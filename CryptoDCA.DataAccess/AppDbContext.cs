using CryptoDCA.DataModel.Context;
using Microsoft.EntityFrameworkCore;

namespace CryptoDCA.DataAccess
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Investment> Investments { get; set; }

    }
}
