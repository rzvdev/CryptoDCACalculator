
using CryptoDCA.Integration.Coinmarketcap;
using Microsoft.EntityFrameworkCore;

namespace CryptoDCA.DataAccess.Crypto.Retriever;

public sealed class CryptoRetrieverDao : ICryptoRetrieverDao
{
    private readonly CoinMarketCapService _coinMarketCapService;

    public CryptoRetrieverDao(CoinMarketCapService coinMarketCapService)
    {
        _coinMarketCapService = coinMarketCapService;
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
