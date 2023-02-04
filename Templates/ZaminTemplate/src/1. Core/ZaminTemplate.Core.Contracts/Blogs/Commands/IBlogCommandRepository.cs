using Zamin.Core.Contracts.Data.Commands;
using ZaminTemplate.Core.Domain.Blogs.Entities;

namespace ZaminTemplate.Core.Contracts.Blogs.Commands;

public interface IBlogCommandRepository : ICommandRepository<Blog>
{
}
