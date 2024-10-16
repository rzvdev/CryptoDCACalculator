using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DataAccess.Period.Retriever;

public interface IPeriodRetrieverDao
{
    /// <summary>
    /// This method will retrieve all periods
    /// </summary>
    /// <returns></returns>
    Task<List<Periods>> GetPeriodsAsync();
}
