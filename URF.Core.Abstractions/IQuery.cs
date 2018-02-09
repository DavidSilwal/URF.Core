﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace URF.Core.Abstractions
{
    public interface IQuery<TEntity> where TEntity : class
    {
        IQuery<TEntity> Where(Expression<Func<TEntity, bool>> filter);
        IQuery<TEntity> Include(Expression<Func<TEntity, object>> include);
        IQuery<TEntity> OrderBy(Expression<Func<TEntity, object>> orderBy);
        IQuery<TEntity> OrderByDescending(Expression<Func<TEntity, object>> orderByDescending);
        Task<IEnumerable<TEntity>> SelectAsync(CancellationToken cancellationToken = default);
        IQuery<TEntity> Skip(int skip);
        IQuery<TEntity> Take(int take);
        IQuery<TEntity> ThenBy(Expression<Func<TEntity, object>> thenBy);
        IQuery<TEntity> ThenByDescending(Expression<Func<TEntity, object>> thenByDescending);
        Task<int> CountAsync(CancellationToken cancellationToken = default);
    }
}