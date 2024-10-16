using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoDCA.DataModel.Context
{

    [Table("BOT_INVESTMENT")]
    public sealed class Investment
    {
        [Column("BOT_INVESTMENT_ID")]
        [Key] // This attribute specifies that this property is the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This makes it auto-increment
        public int Id { get; set; }

        [Column("BOT_INVESTMENT_CRYPTOCURRENCY")]
        public string Cryptocurrency { get; set; }

        [Column("BOT_INVESTMENT_INVESTEDAMOUNT")]
        public decimal InvestedAmount { get; set; }

        [Column("BOT_INVESTMENT_CRYPTOCURRENCYAMOUNT")]
        public decimal CryptoValue { get; set; }

        [Column("BOT_INVESTMENT_DATE")]
        public DateTime InvestmentDate { get; set; }

        [Column("BOT_INVESTMENT_CURRENTVALUE")]
        public decimal CurrentValue { get; set; }

        [Column("BOT_INVESTMENT_ROI")]
        public decimal ROI { get; set; }
    }
}
