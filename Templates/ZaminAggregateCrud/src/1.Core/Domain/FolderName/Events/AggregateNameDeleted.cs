using Zamin.Core.Domain.Events;

namespace ZaminTemplate.Core.Domain.FolderName.Events;

public sealed record AggregateNameDeleted(Guid BusinessId) : IDomainEvent;