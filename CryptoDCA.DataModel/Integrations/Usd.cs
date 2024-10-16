namespace CryptoDCA.DataModel.Integrations;

public sealed class Usd
{
    public decimal Price { get; set; }
    public decimal Volume24h { get; set; }
    public decimal MarketCap { get; set; }
    public decimal CirculatingSupply { get; set; }
    public decimal TotalSupply { get; set; }
}
