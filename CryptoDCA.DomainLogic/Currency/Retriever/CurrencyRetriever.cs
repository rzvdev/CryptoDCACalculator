using CryptoDCA.DataAccess.Currency.Retriever;
using CryptoDCA.DataModel.Context;


namespace CryptoDCA.DomainLogic.Currency.Retriever;

public class CurrencyRetriever : ICurrencyRetriever
{
    private readonly ICurrencyRetrieverDao _currencyRetrieverDao;

    public CurrencyRetriever(ICurrencyRetrieverDao currencyRetrieverDao)
    {
        _currencyRetrieverDao = currencyRetrieverDao;
    }


    public async Task<List<Currencies>> GetCryptoCurrencies()
    {
        return await _currencyRetrieverDao.GetCurrencies(onlyCrypto: true);
    }

    public async Task<List<Currencies>> GetCurrencies()
    {
        return await _currencyRetrieverDao.GetCurrencies();
    }
}
