using CryptoDCA.DataModel.Context;
using CryptoDCA.DataModel.DTOs.Currency;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CryptoDCA.DataAccess
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Investment> Investments { get; set; }
        public DbSet<Currencies> Currencies { get; set; }
        public DbSet<Periods> Periods { get; set; }



        public async Task<List<Currencies>> GetCurrencies(GetCurrenciesFilterDto dto)
        {
            // Create SQL parameters
            var onlyCryptoParam = new SqlParameter("@onlyCrypto", dto.OnlyCrypto);

            var result = await Currencies.FromSqlRaw("EXEC Currency_GetAll @onlyCrypto", onlyCryptoParam).ToListAsync();
            return result;                                                                                                  
        }
    }
}
