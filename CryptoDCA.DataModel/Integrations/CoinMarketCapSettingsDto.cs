namespace CryptoDCA.DataModel.Integrations;

public sealed class CoinMarketCapSettingsDto
{
    public string Token { get; set; }
    public string ApiKey { get; set; }
    public CoinMarketCapUrls URL { get; set; }
}
