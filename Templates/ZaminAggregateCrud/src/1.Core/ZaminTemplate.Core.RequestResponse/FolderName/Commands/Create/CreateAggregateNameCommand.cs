using Zamin.Core.RequestResponse.Commands;
using ZaminTemplate.Core.Domain.FolderName.Parameters;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Create;

public sealed class CreateAggregateNameCommand : ICommand<int>
{
    public Guid BusinessId { get; set; }

    public AggregateNameCreateParameter ToParameter() => new(BusinessId);
}