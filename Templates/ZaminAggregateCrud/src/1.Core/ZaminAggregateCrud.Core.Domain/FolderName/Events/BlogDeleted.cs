using Zamin.Core.Domain.Events;

namespace ZaminAggregateCrud.Core.Domain.FolderName.Events;

public sealed record BlogDeleted(Guid BusinessId) : IDomainEvent;