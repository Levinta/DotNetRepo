using AdsProGroup.BusinessServices;
using AdsProGroup.Data;
using AdsProGroup.Data.Entities;
using AdsProGroup.Data.Repository;
using AdsProGroup.Interfaces;
using Autofac;

namespace AdsProGroup.DI
{
    public class ContainerProvider
    {

        public static IContainer BuildContainer(ContainerBuilder builder)
        {
            //register Database types
            builder.RegisterType<AdsProGroupDbContext>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<Repository<Customer>>().As<IRepository<Customer>>().InstancePerRequest();

            //regiser services
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerRequest();
            //build container

            return builder.Build();
        }
    }
    
}
