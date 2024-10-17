using CryptoDCA.DataAccess.Currency.Retriever;
using CryptoDCA.DataModel.Context;
using Microsoft.Extensions.Caching.Memory;


namespace CryptoDCA.DomainLogic.Currency.Retriever;

public class CurrencyRetriever : ICurrencyRetriever
{
    private readonly IMemoryCache _cache;
    private readonly ICurrencyRetrieverDao _currencyRetrieverDao;

    public CurrencyRetriever(ICurrencyRetrieverDao currencyRetrieverDao,
                             IMemoryCache cache)
    {
        _currencyRetrieverDao = currencyRetrieverDao;
        _cache = cache;
    }


    public async Task<List<Currencies>> GetCryptoCurrencies()
    {
        // Try to get the data from the cache
        if (!_cache.TryGetValue(nameof(List<Currencies>), out List<Currencies> currencies))
        {
            // Data is not in the cache, so retrieve it
            currencies = await _currencyRetrieverDao.GetCurrencies(onlyCrypto: true);

            // Save data in cache
            _cache.Set(nameof(List<Currencies>), currencies);

            return currencies;
        }
        return currencies;
    }

    public async Task<List<Currencies>> GetCurrencies()
    {
        return await _currencyRetrieverDao.GetCurrencies();
    }
}
