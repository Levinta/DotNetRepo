using AdsProGroup.BusinessModels;
using AdsProGroup.Data.Entities;
using AdsProGroup.Data.Repository;
using AdsProGroup.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace AdsProGroup.BusinessServices
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;
        public CustomerService(IRepository<Customer> customRespository)
        {
            _customerRepository = customRespository;
        }

        public async Task CreateCustomer(CreateCustomerInput input)
        {
            //insert data from the input
            var addressEntitiesList = new List<Address>();
            foreach (var item in input.Addresses)
            {
                addressEntitiesList.Add(new Address
                {
                    Type = item.Type,
                    City = item.City,
                    PostalCode = item.PostalCode,
                    Street= new Street
                    {
                        Street1=item.Street.Street1,
                        Street2=item.Street.Street2
                    }
                });
            }
            var customerEntity = new Customer
            {
                Name = input.Name,
                Surname = input.Surname,
                Middlename = input.Middlename,
                Addresses = addressEntitiesList
            };
            _customerRepository.Add(customerEntity);
            _customerRepository.SaveChanges();
            //await void tasks
            await Task.CompletedTask.ConfigureAwait(false);
        }

        public Task DeleteCustomer(int input)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AllCustomersOutput>> GetAllCustomers()
        {
            var entities = _customerRepository.Get().ToList();
            var result = new List<AllCustomersOutput>();
            if (entities != null && entities.Any())
            {
                foreach (var item in entities)
                {
                    result.Add(new AllCustomersOutput
                    {
                        Name = item.Name,
                        Surname = item.Surname
                        //map everything else here
                    });
                }
            }

            return await Task.FromResult(result).ConfigureAwait(false);
        }

        public async Task<IEnumerable<CustomerSearchResultOutput>> SearchCustomers()
        {
            Collection<CustomerSearchResultOutput> result = new Collection<CustomerSearchResultOutput>();
            result.Add(new CustomerSearchResultOutput
            {
                Name = "Elvis",
                Surname = "Presley"
            });
            result.Add(new CustomerSearchResultOutput
            {
                Name = "Iron",
                Surname = "Maiden"
            });
            return await Task.FromResult(result);
        }

        public Task UpdateCustomer(UpdateCustomerInput input)
        {
            throw new NotImplementedException();
        }
    }
}
