namespace CryptoDCA.DataModel.Integrations;

public sealed class ApiResponse
{
    public Status Status { get; set; }
    public Dictionary<string, Cryptocurrency> Data { get; set; }
}
