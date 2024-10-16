using CryptoDCA.DataModel.Context;
using Microsoft.EntityFrameworkCore;

namespace CryptoDCA.DataAccess.Period.Retriever;

public sealed class PeriodRetrieverDao : IPeriodRetrieverDao
{
    private readonly AppDbContext _appDbContext;

    public PeriodRetrieverDao(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<Periods>> GetPeriodsAsync()
    {
        return await _appDbContext.Periods.ToListAsync();
    }
}
