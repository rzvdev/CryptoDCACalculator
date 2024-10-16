using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DataAccess.Investments.Retriever;

public interface IInvestmentRetrieverDao
{
    /// <summary>
    /// This method retrieves all investments
    /// </summary>
    /// <returns></returns>
    Task<List<Investment>> GetInvestmentsAsync();
}
