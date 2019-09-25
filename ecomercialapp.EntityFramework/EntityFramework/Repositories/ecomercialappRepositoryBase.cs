using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ecomercialapp.EntityFramework.Repositories
{
    public abstract class ecomercialappRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ecomercialappDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ecomercialappRepositoryBase(IDbContextProvider<ecomercialappDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ecomercialappRepositoryBase<TEntity> : ecomercialappRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ecomercialappRepositoryBase(IDbContextProvider<ecomercialappDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
