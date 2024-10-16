
using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DomainLogic.Period.Retriever
{
    public interface IPeriodRetriever
    {
        /// <summary>
        /// This method will retrieve all periods
        /// </summary>
        /// <returns></returns>
        Task<List<Periods>> GetPeriodsAsync();
    }
}
