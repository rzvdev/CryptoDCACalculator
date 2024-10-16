namespace CryptoDCA.DataModel.DTOs;

public sealed record DCAResultDto
{
    public DateTime Date { get; set; }
    public decimal InvestedAmount { get; set; }
    public decimal CryptoAmount { get; set; }
    public string CryptoCurrency { get; set; }
    public decimal ValueToday { get; set; }
    public decimal ROI { get; set; }

    public DCAResultDto(DateTime date, string cryptoCurrency, decimal investedAmount, decimal cryptoAmount, decimal valueToday, decimal roi)
    {
        Date = date;
        InvestedAmount = investedAmount;
        CryptoAmount = cryptoAmount;
        CryptoCurrency = cryptoCurrency;
        ValueToday = valueToday;
        ROI = roi;
    }
}