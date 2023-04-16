using Zamin.Infra.Data.Sql.Commands;
using ZaminAggregateCrud.Core.Contracts.FolderName.Commands;
using ZaminAggregateCrud.Core.Domain.FolderName.Entities;
using ZaminAggregateCrud.Infra.Data.Sql.Commands.Common;

namespace ZaminAggregateCrud.Infra.Data.Sql.Commands.FolderName;

public sealed class BlogCommandRepository
    : BaseCommandRepository<Blog, ZaminAggregateCrudCommandDbContext>, IBlogCommandRepository
{
    public BlogCommandRepository(ZaminAggregateCrudCommandDbContext dbContext) : base(dbContext)
    {
    }
}
