using CryptoDCA.DataModel.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CryptoDCA.DataAccess
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Investment> Investments { get; set; }
        public DbSet<Currencies> Currencies { get; set; }



        public async Task<List<Currencies>> GetCryptoCurrencies()
        {
            return await Currencies.FromSqlRaw("EXEC CryptoCurrency_GetAll").ToListAsync();
        }
    }
}
