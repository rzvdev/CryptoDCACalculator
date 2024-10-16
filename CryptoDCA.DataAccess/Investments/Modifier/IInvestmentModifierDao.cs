using CryptoDCA.DataModel.Context;

namespace CryptoDCA.DataAccess.Investments.Modifier;

public interface IInvestmentModifierDao
{
    /// <summary>
    /// Save investments to the database
    /// </summary>
    Task SaveInvestmentsAsync(List<Investment> investment);
}
