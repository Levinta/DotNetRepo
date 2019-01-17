using System.Data.Entity;

namespace AdsProGroup.Data.Entities
{
    public class AdsProGroupDbContext : DbContext
    {
        public AdsProGroupDbContext() : base("DefaultConnection")
        {

        }

        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Email> Emails { get; set; }
        public IDbSet<Phone> Phones { get; set; }
        public IDbSet<Street> Streets { get; set; }
    }
}
