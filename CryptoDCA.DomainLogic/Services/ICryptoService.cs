using CryptoDCA.DataModel.DTOs;

namespace CryptoDCA.DomainLogic.Services;

public interface ICryptoService
{
    /// <summary>
    /// This method will calculateDCA
    /// </summary>
    Task<List<DCAResultDto>> CalculateDCA(InvestmentData investmentDataDto);
}
