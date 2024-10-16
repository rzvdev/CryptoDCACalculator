using CryptoDCA.DataModel.DTOs;

namespace CryptoDCA.DomainLogic.Investments.Modifier;

public interface IInvestmentModifier
{
    Task<InvestmentSaveResultDto> AddInvestmentsAsync(List<DCAResultDto> investmentDataDto);
}
