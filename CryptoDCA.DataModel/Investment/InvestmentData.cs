using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DataModel.DTOs;

public sealed record InvestmentData {
    public string SelectedCrypto { get; set; } = "BTC";
    public DateTime StartDate { get; set; }  = DateTime.Now.Subtract(TimeSpan.FromDays(150));
    public decimal InvestmentValue { get; set; } = 1;
    public Periods InvestmentPeriod { get; set; }
}
