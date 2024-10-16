using CryptoDCA.DataModel.Context;
using Microsoft.EntityFrameworkCore;

namespace CryptoDCA.DataAccess.Investments.Retriever;

public sealed class InvestmentRetrieverDao : IInvestmentRetrieverDao
{
    private readonly AppDbContext _dbContext;

    public InvestmentRetrieverDao(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Investment>> GetInvestmentsAsync()
    {
        return await _dbContext.Investments.ToListAsync();
    }
}
