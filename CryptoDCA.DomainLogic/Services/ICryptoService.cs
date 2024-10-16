using CryptoDCA.DataModel.DTOs;

namespace CryptoDCA.DomainLogic.Services;

public interface ICryptoService
{
    /// <summary>
    /// This method will calculate the DCA for the given investment data
    /// </summary>
    Task<List<DCAResultDto>> CalculateDCA(InvestmentData investmentDataDto);
}
