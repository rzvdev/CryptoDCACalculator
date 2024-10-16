using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DomainLogic.Currency.Retriever;

public interface ICurrencyRetriever
{
    /// <summary>
    /// That method will retrieve all currencies 
    /// </summary>
    /// <returns></returns>
    Task<List<Currencies>> GetCurrencies();

    /// <summary>
    /// That metod will retrieve all crypto currencies
    /// </summary>
    Task<List<Currencies>> GetCryptoCurrencies();
}
