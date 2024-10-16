using System.Net.Http.Headers;
using System.Text.Json;
using CryptoDCA.DataModel.Integrations;
using Newtonsoft.Json;

namespace CryptoDCA.Integration.Coinmarketcap;

public sealed class CoinMarketCapService : ICoinMarketCapService
{
    private readonly HttpClient _httpClient;
    private readonly CryptoDCA.DataModel.Integrations.CoinMarketCapSettingsDto _settings;

    public CoinMarketCapService(HttpClient httpClient, CryptoDCA.DataModel.Integrations.CoinMarketCapSettingsDto settings)
    {
        _httpClient = httpClient;
        _settings = settings;
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_settings.Token, _settings.ApiKey);
        _httpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", "bff28ba3-f6d2-4b7a-acb3-ee914ddbeacf");
    }

    public async Task<decimal> GetCryptoPriceAtDateAsync(string crypto, DateTime date)
    {
        // Formatăm data într-un format acceptat de API
        string formattedDate = date.ToString("yyyy-MM-dd");

        // Construim URL-ul pentru cererea către CoinMarketCap
        string url = $"{_settings.URL.CryptocurrencyPriceAtDate}{crypto}&time_start={formattedDate}T00:00:00&time_end={formattedDate}T23:59:59";

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        var deserealizedResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);


        // Extragem prețul din răspuns
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
            // Construim URL-ul pentru cererea către CoinMarketCap pentru prețul actual
            string url = $"{_settings.URL.CryptocurrencyCurrentPrice}{crypto}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var deserealizedResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);


        // Extragem prețul din răspuns
        if (deserealizedResponse?.Data != null)
        {
            // Obținem criptomoneda (de exemplu, "ETH")
            var cryptocurrency = deserealizedResponse.Data.FirstOrDefault().Value;

            return cryptocurrency.Qoute.Usd.Price;
        }

        throw new Exception($"Current price not found for {crypto}");
    }
    }
