namespace CryptoDCA.Integration.Coinmarketcap;

public interface ICoinMarketCapService
{
    Task<decimal> GetCryptoPriceAtDateAsync(string crypto, DateTime date);
    Task<decimal> GetCurrentCryptoPrice(string crypto);


}
