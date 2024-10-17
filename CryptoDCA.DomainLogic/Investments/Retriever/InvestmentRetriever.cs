using CryptoDCA.DataAccess.Investments.Retriever;
using CryptoDCA.DataModel.Context;
using Microsoft.Extensions.Caching.Memory;

namespace CryptoDCA.DomainLogic.Investments.Retriever;

public sealed class InvestmentRetriever : IInvestmentRetriever
{
    private readonly IInvestmentRetrieverDao _investmentRetrieverDao;
    private readonly IMemoryCache _cache;

    public InvestmentRetriever(IInvestmentRetrieverDao investmentRetrieverDao,
                               IMemoryCache cache)
    {
        _investmentRetrieverDao = investmentRetrieverDao;
        _cache = cache;
    }

    public async Task<List<Investment>> GetInvestmentsAsync()
    {
        // Try to get the data from the cache
        if (!_cache.TryGetValue(nameof(List<Investment>), out List<Investment> investments))
        {
            // Data is not in the cache, so retrieve it
            investments = await _investmentRetrieverDao.GetInvestmentsAsync();

            // Save data in cache
            _cache.Set(nameof(List<Investment>), investments);

            return investments;
        }
        return investments;
    }
}
