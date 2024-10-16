using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DomainLogic.Investments.Retriever;

public interface IInvestmentRetriever
{
    /// <summary>
    /// This method will retrieve all investments
    /// </summary>
    /// <returns></returns>
    Task<List<Investment>> GetInvestmentsAsync();
}
