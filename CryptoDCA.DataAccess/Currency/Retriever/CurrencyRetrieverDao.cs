using CryptoDCA.DataModel.Context;
using CryptoDCA.DataModel.DTOs.Currency;
namespace CryptoDCA.DataAccess.Currency.Retriever;

public class CurrencyRetrieverDao : ICurrencyRetrieverDao
{
    private readonly AppDbContext _dbContext;

    public CurrencyRetrieverDao(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<List<Currencies>> GetCurrencies(GetCurrenciesFilterDto dto)
    {
        return await _dbContext.GetCurrencies(dto);

    }
}
