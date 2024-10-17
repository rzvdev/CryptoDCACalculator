using CryptoDCA.DataModel.Context;
using CryptoDCA.DataModel.DTOs.Currency;

namespace CryptoDCA.DataAccess.Currency.Retriever;

public interface ICurrencyRetrieverDao
{
    /// <summary>
    /// This method retrieves all currencies
    /// </summary>
    /// <returns></returns>
    Task<List<Currencies>> GetCurrencies(GetCurrenciesFilterDto dto);
}
