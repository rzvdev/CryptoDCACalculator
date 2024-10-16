using CryptoDCA.DataModel.Context;
namespace CryptoDCA.DataAccess.Currency.Retriever;

public class CurrencyRetrieverDao : ICurrencyRetrieverDao
{
    private readonly AppDbContext _dbContext;

    public CurrencyRetrieverDao(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<List<Currencies>> GetCurrencies(bool onlyCrypto = false)
    {
        return await _dbContext.GetCurrencies(onlyCrypto);

    }
}
