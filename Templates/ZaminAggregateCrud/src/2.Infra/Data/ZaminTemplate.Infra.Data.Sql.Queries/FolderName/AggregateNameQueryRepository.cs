using Microsoft.EntityFrameworkCore;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Infra.Data.Sql.Queries;
using ZaminTemplate.Core.Contracts.FolderName.Queries;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetById;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetPagedFilter;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetSelectList;
using ZaminTemplate.Infra.Data.Sql.Queries.Common;
using ZaminTemplate.Infra.Data.Sql.Queries.FolderName.Entities;

namespace ZaminTemplate.Infra.Data.Sql.Queries.FolderName;

public class AggregateNameQueryRepository : BaseQueryRepository<DbContextNameQueryDbContext>, IAggregateNameQueryRepository
{
    public AggregateNameQueryRepository(DbContextNameQueryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<AggregateNameQr?> ExecuteAsync(GetAggregateNameByIdQuery query)
    {
        return await _dbContext.Set<AggregateName>()
            .Where(AggregateName => AggregateName.Id == query.Id)
            .Select(AggregateName => (AggregateNameQr)AggregateName)
            .FirstOrDefaultAsync();
    }

    public async Task<List<AggregateNameSelectItemQr>> ExecuteAsync(GetAggregateNameSelectListQuery query)
    {
        return await _dbContext.Set<AggregateName>().Select(AggregateName => (AggregateNameSelectItemQr)AggregateName).ToListAsync();
    }

    public async Task<PagedData<AggregateNameListItemQr>> ExecuteAsync(GetAggregateNamePagedFilterQuery query)
    {
        var filter = _dbContext.Set<AggregateName>().AsQueryable();

        return await filter.ToPagedData(query, AggregateName => (AggregateNameListItemQr)AggregateName);
    }
}