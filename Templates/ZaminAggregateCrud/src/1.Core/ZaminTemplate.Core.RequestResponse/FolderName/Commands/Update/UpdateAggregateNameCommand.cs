using Zamin.Core.RequestResponse.Commands;
using ZaminTemplate.Core.Domain.FolderName.Parameters;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Update;

public sealed class UpdateAggregateNameCommand : ICommand
{
    public int Id { get; set; }

    public AggregateNameUpdateParameter ToParameter() => new();
}