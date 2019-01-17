using System.Data.Entity;

namespace AdsProGroup.Data.Repository
{
    public interface IUnitOfWork
    {
        DbContext Context { get; }
        
    }
}
