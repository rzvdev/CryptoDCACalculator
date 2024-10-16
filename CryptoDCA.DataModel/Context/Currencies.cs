using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoDCA.DataModel.Context;


[Table("GOT_CURRENCY")]
public sealed class Currencies
{
    [Column("GOT_CURRENCY_ID")]
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("GOT_CURRENCY_NAME")]
    [Required]
    public string Name { get; set; }

    [Column("GOT_CURRENCY_SYMBOL")]
    [Required]
    public string Symbol { get; set; }

    [Column("GOT_CURRENCY_ISACTIVE")]
    [DefaultValue(true)]
    public bool IsActive { get; set; }

    [Column("GOT_CURRENCY_TYPE_ID")]
    [Required]
    public int TypeId { get; set; }

    [ForeignKey("TypeId")] 
    public CurrencyTypes Type { get; set; }  

}
