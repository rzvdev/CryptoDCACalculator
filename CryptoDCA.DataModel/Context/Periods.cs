using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CryptoDCA.DataModel.Context
{
    [Table("GOT_INVEST_PERIOD")]
    public sealed class Periods
    {
        [Column("GOT_INVEST_PERIOD_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("GOT_INVEST_PERIOD_PROGID")]
        [Required]
        public string ProgId { get; set; }

        [Column("GOT_INVEST_PERIOD_NAME")]
        [Required]
        public string Name { get; set; }

        [Column("GOT_INVEST_PERIOD_DAYS")]
        [Required]
        public int Days { get; set; }

        [Column("GOT_INVEST_PERIOD_DESCRIPTION")]
        [Required]
        public string Description { get; set; }

        [Column("GOT_INVEST_PERIOD_ISACTIVE")]
        [Required]
        public bool IsActive { get; set; }

    }
}
