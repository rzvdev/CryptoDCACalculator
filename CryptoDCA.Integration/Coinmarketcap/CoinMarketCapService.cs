using CryptoDCA.DataModel.Integrations;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace CryptoDCA.Integration.Coinmarketcap;

public sealed class CoinMarketCapService : ICoinMarketCapService
{
    private readonly HttpClient _httpClient;
    private readonly CoinMarketCapSettingsDto _settings;

    public CoinMarketCapService(HttpClient httpClient, CoinMarketCapSettingsDto settings)
    {
        _httpClient = httpClient;
        _settings = settings;
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_settings.Token, _settings.ApiKey);
        _httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", _settings.ApiKey);
    }

    public async Task<decimal> GetCryptoPriceAtDateAsync(string crypto, DateTime date)
    {
        // format the date to be in the format that CoinMarketCap expects
        string formattedDate = date.ToString("yyyy-MM-dd");

        // make the url for the request to CoinMarketCap for the price at a specific date
        string url = $"{_settings.URL.CryptocurrencyPriceAtDate}{crypto}&time_start={formattedDate}T00:00:00&time_end={formattedDate}T23:59:59";

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        var deserealizedResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);


        // extract the price from response
        var cryptocurrency = deserealizedResponse?.Data?.FirstOrDefault().Value;
        decimal? price = cryptocurrency?.Quotes switch
        {
            var quotes when quotes != null && quotes.Count > 0 => quotes[0].QuoteData.Usd.Price,
            var quotes when quotes != null && quotes.FirstOrDefault()?.QuoteData.Usd != null => quotes.First().QuoteData.Usd.Price,
            _ => null
        };

        return price ?? throw new Exception($"Price data not found for {crypto} on {date.ToShortDateString()}");
    }

    public async Task<decimal> GetCurrentCryptoPrice(string crypto)
    {
        // make the url for the request to CoinMarketCap for the current price
        string url = $"{_settings.URL.CryptocurrencyCurrentPrice}{crypto}";

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        var deserealizedResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);


        //  extract the price from response
        if (deserealizedResponse?.Data != null)
        {
            var cryptocurrency = deserealizedResponse.Data.FirstOrDefault().Value;

            return cryptocurrency.Qoute.Usd.Price;
        }

        throw new Exception($"Current price not found for {crypto}");
    }
}
