using Zamin.Core.Domain.Events;

namespace ZaminTemplate.Core.Domain.FolderName.Events;

public sealed record AggregateNameUpdated(Guid BusinessId) : IDomainEvent;