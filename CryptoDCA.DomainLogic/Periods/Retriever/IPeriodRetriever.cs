namespace CryptoDCA.DomainLogic.Periods.Retriever
{
    public interface IPeriodRetriever
    {
        /// <summary>
        /// This method will retrieve all periods
        /// </summary>
        /// <returns></returns>
        Task<List<Periods>> GetPeriodsAsync();
    }
}
