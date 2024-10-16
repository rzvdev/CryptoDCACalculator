using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoDCA.DataModel.Context;

[Table("GOT_CURRENCY_TYPE")]
public sealed class CurrencyTypes
{
    [Column("GOT_CURRENCY_TYPE_ID")]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("GOT_CURRENCY_TYPE_NAME")]
    [Required]
    public string Name { get; set; }

    [Column("GOT_CURRENCY_TYPE_PROGID")]
    [Required]
    public string ProgId { get; set; }

    [Column("GOT_CURRENCY_TYPE_DESCRIPTION")]
    public string Description { get; set; }

    [Column("GOT_CURRENCY_TYPE_ISACTIVE")]
    [DefaultValue(true)]
    public bool IsActive { get; set; }
}
