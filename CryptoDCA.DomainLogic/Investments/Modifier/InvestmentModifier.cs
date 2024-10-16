using CryptoDCA.DataAccess.Investments.Modifier;
using CryptoDCA.DataModel.Context;
using CryptoDCA.DataModel.DTOs;
using System.Linq;

namespace CryptoDCA.DomainLogic.Investments.Modifier;

public sealed class InvestmentModifier : IInvestmentModifier
{
    private readonly IInvestmentModifierDao _investmentModifierDao;

    public InvestmentModifier(IInvestmentModifierDao investmentModifierDao)
    {
        _investmentModifierDao = investmentModifierDao;
    }

    public async Task<InvestmentSaveResultDto> AddInvestmentsAsync(List<DCAResultDto> investmentDataDto)
    {
        var investments = investmentDataDto.Select(x => new Investment()
                                                    {
                                                        InvestedAmount = x.InvestedAmount,
                                                        InvestmentDate = x.Date,
                                                        CryptoValue = x.CryptoAmount,
                                                        Cryptocurrency = x.CryptoCurrency,
                                                        ROI = x.ROI,
                                                        CurrentValue = x.ValueToday
                                                    })
                                            .ToList();

        await _investmentModifierDao.SaveInvestmentsAsync(investments);

        return new InvestmentSaveResultDto(); 
    }
}
