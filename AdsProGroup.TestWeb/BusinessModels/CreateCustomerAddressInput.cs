using System.ComponentModel.DataAnnotations;

namespace AdsProGroup.BusinessModels
{
    public class CreateCustomerAddressInput
    {
        public string Type { get; set; }
        public CreateCustomerStreetInput Street { get; set; }
        [Required]
        [MaxLength(5)]
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
