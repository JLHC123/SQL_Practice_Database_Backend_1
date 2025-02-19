using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLBackEndPracticeDatabase1.Models
{
    [Table("customeraddresses")]
    public partial class CustomerAddress
    {
        [Key][Column("CustomerAddressId")] public int CustomerAddressId { get; set; }
        [ForeignKey("CustomerId")][Column("CustomerId")] public int CustomerId { get; set; }
        [Column("Street1")] public required string Street1 { get; set; }
        [Column("Street2")] public required string Street2 { get; set; }
        [Column("City")] public required string City { get; set; }
        [Column("States")] public required string States { get; set; }
        [Column("Zip")] public required string Zip { get; set; }
    }
}
