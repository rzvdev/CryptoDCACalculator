using CryptoDCA.DataAccess.Period.Retriever;
using CryptoDCA.DataModel.Context;
using Microsoft.Extensions.Caching.Memory;

namespace CryptoDCA.DomainLogic.Period.Retriever
{
    public sealed class PeriodRetriever : IPeriodRetriever
    {
        private readonly IPeriodRetrieverDao _periodRetrieverDao;
        private readonly IMemoryCache _cache;

        public PeriodRetriever(IPeriodRetrieverDao periodRetrieverDao,
                               IMemoryCache cache)
        {
            _periodRetrieverDao = periodRetrieverDao;
            _cache = cache;
        }

        public async Task<List<Periods>> GetPeriodsAsync()
        {
            // Try to get the data from the cache
            if (!_cache.TryGetValue(nameof(List<Periods>), out List<Periods> periods))
            {
                // Data is not in the cache, so retrieve it
                periods = await _periodRetrieverDao.GetPeriodsAsync();

                // Save data in cache
                _cache.Set(nameof(List<Periods>), periods);

                return periods;
            }
            return periods;
        }
    }
}
