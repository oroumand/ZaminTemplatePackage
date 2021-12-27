using ZaminTemplate.Core.Domain.Blogs.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace ZaminTemplate.Core.Contracts.Blogs.CommandRepositories
{
    public interface IBlogCommandRepository:ICommandRepository<Blog>
    {
    }
}
