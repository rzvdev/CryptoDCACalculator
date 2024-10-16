
using System.Text.Json.Serialization;

namespace CryptoDCA.DataModel.Integrations;

public sealed class QuoteData
{
    [JsonPropertyName("USD")]
    public Usd Usd { get; set; }
}
