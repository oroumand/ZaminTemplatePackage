using Zamin.Infra.Data.Sql.Commands;
using ZaminTemplate.Core.Contracts.FolderName.Commands;
using ZaminTemplate.Core.Domain.FolderName.Entities;
using ZaminTemplate.Infra.Data.Sql.Commands.Common;

namespace ZaminTemplate.Infra.Data.Sql.Commands.FolderName;

public sealed class AggregateNameCommandRepository
    : BaseCommandRepository<AggregateName, DbContextNameCommandDbContext, int>, IAggregateNameCommandRepository
{
    public AggregateNameCommandRepository(DbContextNameCommandDbContext dbContext) : base(dbContext)
    {
    }
}