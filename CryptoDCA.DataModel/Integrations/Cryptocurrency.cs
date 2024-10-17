using Newtonsoft.Json;

namespace CryptoDCA.DataModel.Integrations;

public class Cryptocurrency
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public bool IsActive { get; set; }
    public List<Quote> Quotes { get; set; } 
    public decimal CirculatingSupply { get; set; } 
    public decimal TotalSupply { get; set; }

    [JsonProperty("quote")]
    public QuoteData Qoute { get; set; } 
}
