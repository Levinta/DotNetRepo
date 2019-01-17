using System.Collections.Generic;
namespace AdsProGroup.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public string Notes { get; set; }
    }
}
