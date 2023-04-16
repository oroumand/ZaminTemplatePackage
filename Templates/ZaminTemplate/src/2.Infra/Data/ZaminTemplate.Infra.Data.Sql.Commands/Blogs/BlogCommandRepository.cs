using Zamin.Infra.Data.Sql.Commands;
using ZaminTemplate.Core.Contracts.Blogs.Commands;
using ZaminTemplate.Core.Domain.Blogs.Entities;
using ZaminTemplate.Infra.Data.Sql.Commands.Common;

namespace ZaminTemplate.Infra.Data.Sql.Commands.Blogs;

public class BlogCommandRepository
    : BaseCommandRepository<Blog, ZaminTemplateCommandDbContext>, IBlogCommandRepository
{
    public BlogCommandRepository(ZaminTemplateCommandDbContext dbContext) : base(dbContext)
    {
    }
}
