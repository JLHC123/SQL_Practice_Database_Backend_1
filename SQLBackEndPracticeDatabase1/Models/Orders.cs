using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLBackEndPracticeDatabase1.Models
{
    [Table("orders")]
    public partial class Order
    {
        [Key][Column("OrderId")] public int OrderId { get; set; }
        [ForeignKey("CustomerId")] public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
