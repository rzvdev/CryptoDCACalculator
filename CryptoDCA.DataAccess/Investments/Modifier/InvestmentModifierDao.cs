

using CryptoDCA.DataModel.Context;
using CryptoDCA.DataModel.DTOs;

namespace CryptoDCA.DataAccess.Investments.Modifier
{
    public class InvestmentModifierDao : IInvestmentModifierDao
    {
        private readonly AppDbContext _dbContext;

        public InvestmentModifierDao(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<InvestmentSaveResultDto> SaveInvestmentsAsync(List<Investment> investments)
        {
            // Add the investment entities to the DbContext
            investments.ForEach(investment => _dbContext.Set<Investment>().Add(investment));

            // Save changes to the database
            await _dbContext.SaveChangesAsync();

            // Map the saved investment entity back to the DTO
            var savedInvestmentDto = new InvestmentSaveResultDto
            {
                // Set the properties of the DTO based on the saved entity
                // (if needed)
            };

            return savedInvestmentDto;
        }
    }
}
