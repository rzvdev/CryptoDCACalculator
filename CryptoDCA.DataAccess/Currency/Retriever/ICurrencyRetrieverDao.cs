using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DataAccess.Currency.Retriever;

public interface ICurrencyRetrieverDao
{
    /// <summary>
    /// This method retrieves all currencies
    /// </summary>
    /// <returns></returns>
    Task<List<Currencies>> GetCurrencies(bool onlyCrypto = false);
}
