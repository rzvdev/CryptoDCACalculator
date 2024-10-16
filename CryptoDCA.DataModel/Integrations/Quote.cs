using Newtonsoft.Json;

namespace CryptoDCA.DataModel.Integrations;

public class Quote
{
    public string Timestamp { get; set; }

    [JsonProperty("quote")]
    public QuoteData QuoteData { get; set; }
}
