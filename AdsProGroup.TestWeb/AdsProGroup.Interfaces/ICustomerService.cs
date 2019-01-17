using AdsProGroup.BusinessModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdsProGroup.Interfaces
{
    public interface ICustomerService
    {
        Task CreateCustomer(CreateCustomerInput input);
        Task DeleteCustomer(int input);
        Task UpdateCustomer(UpdateCustomerInput input);
        Task<IEnumerable<CustomerSearchResultOutput>> SearchCustomers();

        Task<IEnumerable<AllCustomersOutput>> GetAllCustomers();
    }
}
