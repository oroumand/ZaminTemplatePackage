using Zamin.Core.Domain.Events;

namespace ZaminAggregateCrud.Core.Domain.FolderName.Events;

public sealed record BlogCreated(Guid BusinessId) : IDomainEvent;