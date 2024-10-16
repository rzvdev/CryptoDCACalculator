using CryptoDCA.DataAccess.Investments.Retriever;
using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DomainLogic.Investments.Retriever;

public sealed class InvestmentRetriever : IInvestmentRetriever
{
    private readonly IInvestmentRetrieverDao _investmentRetrieverDao;

    public InvestmentRetriever(IInvestmentRetrieverDao investmentRetrieverDao)
    {
        _investmentRetrieverDao = investmentRetrieverDao;
    }

    public async Task<List<Investment>> GetInvestmentsAsync()
    {
        return await _investmentRetrieverDao.GetInvestmentsAsync();
    }
}
