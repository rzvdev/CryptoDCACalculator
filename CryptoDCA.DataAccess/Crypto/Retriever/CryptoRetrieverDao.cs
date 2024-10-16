
using CryptoDCA.DataModel.Context;
using CryptoDCA.DataModel.Integrations;
using CryptoDCA.Integration.Coinmarketcap;

namespace CryptoDCA.DataAccess.Crypto.Retriever;

public sealed class CryptoRetrieverDao : ICryptoRetrieverDao
{
    private readonly CoinMarketCapService _coinMarketCapService;
    private readonly AppDbContext _dbContext;

    public CryptoRetrieverDao(CoinMarketCapService coinMarketCapService, 
                              AppDbContext dbContext)
    {
        _coinMarketCapService = coinMarketCapService;
        _dbContext = dbContext;
    }

    public async Task<List<Currencies>> GetCryptoCurrencies()
    {
        return new List<Currencies>();
    }

    public async Task<decimal> GetCryptoPriceAtDateAsync(string crypto, DateTime date)
    {
        return await _coinMarketCapService.GetCryptoPriceAtDateAsync(crypto, date);
    }

    public async Task<decimal> GetCurrentCryptoPrice(string crypto)
    {
        return await _coinMarketCapService.GetCurrentCryptoPrice(crypto);
    }

}
