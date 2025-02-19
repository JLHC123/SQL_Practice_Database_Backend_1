namespace SQLBackEndPracticeDatabase1.DTO
{
    public class CustomerAddressDTO
    {
        public int CustomerAddresssId { get; set; }
        public int CustomerId { get; set; } 
        public required string Street1 { get; set; }
        public required string Street2 { get; set; }
        public required string City { get; set; }
        public required string States { get; set; }
        public required string Zip { get; set; }
    }
}
