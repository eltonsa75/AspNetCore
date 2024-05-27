using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOfBuild.Domain
{
    public interface IRepository<TEntity>
    {
            TEntity GetById(int id);

            void Save(TEntity entity);
    }
} 