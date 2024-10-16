using CryptoDCA.DataAccess.Period.Retriever;
using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DomainLogic.Period.Retriever
{
    public sealed class PeriodRetriever : IPeriodRetriever
    {
        private readonly IPeriodRetrieverDao _periodRetrieverDao;

        public PeriodRetriever(IPeriodRetrieverDao periodRetrieverDao)
        {
            _periodRetrieverDao = periodRetrieverDao;
        }

        public async Task<List<Periods>> GetPeriodsAsync()
        {
            return await _periodRetrieverDao.GetPeriodsAsync();
        }
    }
}
