using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdsProGroup.BusinessModels
{
    public class CreateCustomerInput
    {
        [Required(ErrorMessage = "Please enter customer's name")]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public List<CreateCustomerAddressInput> Addresses { get; set; }
    }
}
