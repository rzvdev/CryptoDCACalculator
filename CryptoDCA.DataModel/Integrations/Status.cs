namespace CryptoDCA.DataModel.Integrations;

public sealed class Status
{
    public string Timestamp { get; set; }
    public int ErrorCode { get; set; }
    public string ErrorMessage { get; set; }
    public int Elapsed { get; set; }
    public int CreditCount { get; set; }
    public string Notice { get; set; }
    public string Version { get; set; }
}
