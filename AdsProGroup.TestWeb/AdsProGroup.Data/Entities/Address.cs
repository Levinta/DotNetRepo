namespace AdsProGroup.Data.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Street Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
