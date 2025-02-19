using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLBackEndPracticeDatabase1.Models
{
    [Table("customers")]
    public partial class Customer
    {
        [Key][Column("CustomerId")] public int CustomerId { get; set; }
        [Column("First Name")] public required string CustomerFirstName { get; set; }
        [Column("Last Name")] public required string CustomerLastName { get; set; }
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
