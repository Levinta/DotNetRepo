using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AdsProGroup.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        
        IEnumerable<TEntity> Get();
        
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        
        TEntity GetByID(object id);
        
        void Add(TEntity entity);
        
        void Delete(TEntity entity);
        
        void Update(TEntity entity);
        void SaveChanges();
    }
}
