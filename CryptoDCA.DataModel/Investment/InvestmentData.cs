namespace CryptoDCA.DataModel.DTOs;

public sealed record InvestmentData {
    public string SelectedCrypto { get; set; } = "BTC";
    public DateTime StartDate { get; set; }  = DateTime.Now.Subtract(TimeSpan.FromDays(2));
    public decimal MonthlyInvestment { get; set; } = 1;
}
