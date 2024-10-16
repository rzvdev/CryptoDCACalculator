using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DataAccess.Investments.Modifier;

public class InvestmentModifierDao : IInvestmentModifierDao
{
    private readonly AppDbContext _dbContext;

    public InvestmentModifierDao(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveInvestmentsAsync(List<Investment> investments)
    {
        // Add the investment entities to the DbContext
        investments.ForEach(investment => _dbContext.Set<Investment>().Add(investment));

        // Save changes to the database
        await _dbContext.SaveChangesAsync();
    }
}
