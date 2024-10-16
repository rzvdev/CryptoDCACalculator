using CryptoDCA.DataModel.DTOs;
using CryptoDCA.DataAccess.Crypto.Retriever;
using CryptoDCA.DataAccess.Investments.Modifier;
using CryptoDCA.DomainLogic.Investments.Modifier;

namespace CryptoDCA.DomainLogic.Services
{

    public sealed class CryptoService : ICryptoService
    {
        private readonly ICryptoRetrieverDao _cryptoRetrieverDao;
        private readonly IInvestmentModifier _investmentModifier;

        public CryptoService(ICryptoRetrieverDao cryptoRetrieverDao,
                             IInvestmentModifier investmentModifier)
        {
            _cryptoRetrieverDao = cryptoRetrieverDao;
        }

        public async Task<List<DCAResultDto>> CalculateDCA(InvestmentData investmentData)
        {
            List<DCAResultDto> results = new();

            // the logic for calculation DCA goes here
            DateTime currentDate = DateTime.Now;

            for (var date = investmentData.StartDate; date <= currentDate; date = date.AddMonths(1))
            {
                decimal investedAmount = investmentData.MonthlyInvestment;

                // get the price of the selected crypto at the current date
                decimal cryptoPrice = await _cryptoRetrieverDao.GetCryptoPriceAtDateAsync(investmentData.SelectedCrypto, date);
                decimal cryptoAmount = investedAmount / cryptoPrice;

                // here we calculate the current value of the investment and ROI
                decimal currentCryptoPrice = await _cryptoRetrieverDao.GetCurrentCryptoPrice(investmentData.SelectedCrypto);
                decimal currentValue = cryptoAmount * currentCryptoPrice;
                decimal roi = (currentValue - investedAmount) / investedAmount * 100; // ROI in percentage

                results.Add(new DCAResultDto(date, investmentData.SelectedCrypto ,investedAmount, cryptoAmount, currentValue, roi));
            }


            // save the investment data
            await _investmentModifier.AddInvestmentsAsync(results);

            return results;
        }
    }
}


