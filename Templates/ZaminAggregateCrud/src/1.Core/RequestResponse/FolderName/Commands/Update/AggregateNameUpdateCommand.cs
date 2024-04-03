using Zamin.Core.RequestResponse.Commands;
using ZaminTemplate.Core.Domain.FolderName.Parameters;

namespace ZaminTemplate.Core.RequestResponse.FolderName.Commands.Update;

public sealed class AggregateNameUpdateCommand : ICommand
{
    public int Id { get; set; }

    public AggregateNameUpdateParameter ToParameter() => new();
}