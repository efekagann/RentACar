using Application.Services.Repositories;
using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Persistence.Contexts;
using System.Linq.Expressions;

namespace Persistence.Repositories;

public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
{
    public BrandRepository(BaseDbContext context) : base(context)
    {
    }

    public Task<Brand> AddAsync(Brand entity)
    {
        throw new NotImplementedException();
    }

    public Task<Brand> DeleteAsync(Brand entity)
    {
        throw new NotImplementedException();
    }

    public Task<Brand?> GetAsync(Expression<Func<Brand, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IPaginate<Brand>> GetListAsync(Expression<Func<Brand, bool>>? predicate = null, Func<IQueryable<Brand>, IOrderedQueryable<Brand>>? orderBy = null, Func<IQueryable<Brand>, IIncludableQueryable<Brand, object>>? include = null, int index = 0, int size = 10, bool enableTracking = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IPaginate<Brand>> GetListByDynamicAsync(Dynamic dynamic, Func<IQueryable<Brand>, IIncludableQueryable<Brand, object>>? include = null, int index = 0, int size = 10, bool enableTracking = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Brand> UpdateAsync(Brand entity)
    {
        throw new NotImplementedException();
    }

    IQueryable<Brand> IQuery<Brand>.Query()
    {
        throw new NotImplementedException();
    }
}
