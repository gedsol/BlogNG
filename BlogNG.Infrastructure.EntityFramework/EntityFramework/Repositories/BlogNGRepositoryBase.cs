using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace BlogNG.EntityFramework.Repositories
{
    public abstract class BlogNGRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BlogNGDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class BlogNGRepositoryBase<TEntity> : BlogNGRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
