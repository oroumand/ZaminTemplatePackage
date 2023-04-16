using Zamin.Core.Contracts.Data.Commands;
using ZaminAggregateCrud.Core.Domain.FolderName.Entities;

namespace ZaminAggregateCrud.Core.Contracts.FolderName.Commands;

public interface IBlogCommandRepository : ICommandRepository<Blog>
{
}
