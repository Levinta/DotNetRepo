using AdsProGroup.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsProGroup.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; private set; }

        public UnitOfWork(AdsProGroupDbContext context)
        {
            Context = context;
        }
    }
}
