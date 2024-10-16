using CryptoDCA.DataModel.Context;
using CryptoDCA.DataModel.DTOs;

namespace CryptoDCA.DataAccess.Investments.Modifier;

public interface IInvestmentModifierDao
{  
   Task<InvestmentSaveResultDto> SaveInvestmentsAsync(List<Investment> investment);
}
