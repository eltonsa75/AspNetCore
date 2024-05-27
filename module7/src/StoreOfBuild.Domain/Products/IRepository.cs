using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOfBuild.Domain.Products
{
    public interface IRepository<TEntity>
    {
        TEntity GetEntity(int id);

        void Save(TEntity entity);
    }
}