using Zamin.Core.Contracts.Data.Commands;
using ZaminTemplate.Core.Domain.FolderName.Entities;

namespace ZaminTemplate.Core.Contracts.FolderName.Commands;

public interface IAggregateNameCommandRepository : ICommandRepository<AggregateName, int>
{
}