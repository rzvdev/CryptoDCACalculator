namespace CryptoDCA.DataModel.Integrations;
public class QuoteDetails
{
    public decimal Price { get; set; }
    public decimal Volume_24h { get; set; }
    public decimal Market_Cap { get; set; }
    public decimal Circulating_Supply { get; set; }
    public decimal Total_Supply { get; set; }
    public DateTime Timestamp { get; set; }
}
