﻿namespace CryptoDCA.DataAccess.Crypto.Retriever;

public interface ICryptoRetrieverDao
{
    /// <summary>
    /// This method retrieves the price of a crypto at a specific date
    /// </summary>
    Task<decimal> GetCryptoPriceAtDateAsync(string crypto, DateTime date);

    /// <summary>
    /// This method retrieves the current price of a crypto
    /// </summary>
    Task<decimal> GetCurrentCryptoPrice(string crypto);


}
