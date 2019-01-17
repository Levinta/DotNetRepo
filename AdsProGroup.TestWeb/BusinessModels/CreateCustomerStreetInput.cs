using System.Collections.Generic;

namespace AdsProGroup.BusinessModels
{
    public class CreateCustomerStreetInput
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public virtual ICollection<CreateCustomerAddressInput> Addresses { get; set; }
    }
}
