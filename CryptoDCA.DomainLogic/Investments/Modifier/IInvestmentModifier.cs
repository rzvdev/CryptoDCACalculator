using CryptoDCA.DataModel.DTOs;

namespace CryptoDCA.DomainLogic.Investments.Modifier;

public interface IInvestmentModifier
{
    /// <summary>
    /// Add investments to the database
    /// </summary>
    Task AddInvestmentsAsync(List<DCAResultDto> investmentDataDto);
}
